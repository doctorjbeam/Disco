﻿using Disco.Services.Logging;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.DirectoryServices;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Disco.Services.Interop.ActiveDirectory
{
    public class ADDomain
    {
        private const int DomainMaintanceIntervalMinutes = 15;
        private const int SearchExceptionRetryMax = 4;

        private ActiveDirectoryContext context;
        private ConcurrentStack<ADDomainController> domainControllers;

        private int domainControllerRoundRobin = -1;
        private object domainMaintainLock = new object();
        private DateTime domainMaintenanceNext;

        public Domain Domain { get; private set; }
        public IEnumerable<ADDomainController> DomainControllers
        {
            get
            {
                return domainControllers.ToArray();
            }
        }

        public string Name { get; private set; }
        public string NetBiosName { get; private set; }
        public string DistinguishedName { get; private set; }
        public string ConfigurationNamingContext { get; private set; }
        public SecurityIdentifier SecurityIdentifier { get; private set; }

        public List<string> SearchContainers { get; private set; }

        public ADDomain(ActiveDirectoryContext Context, Domain Domain)
        {
            this.context = Context;

            this.Domain = Domain;
            this.SearchContainers = null;
            this.domainControllers = null;
            this.domainMaintenanceNext = DateTime.Now.AddMinutes(DomainMaintanceIntervalMinutes);

            this.Initialize();
        }

        private void Initialize()
        {
            this.Name = Domain.Name;

            var dc = Domain.FindDomainController();

            string ldapPath = string.Format("LDAP://{0}/", dc.Name);

            using (var adRootDSE = new DirectoryEntry(ldapPath + "RootDSE"))
            {
                this.DistinguishedName = adRootDSE.Properties["defaultNamingContext"][0].ToString();
                this.ConfigurationNamingContext = adRootDSE.Properties["configurationNamingContext"][0].ToString();
            }

            using (var adDomainRoot = new DirectoryEntry(ldapPath + this.DistinguishedName))
            {
                this.SecurityIdentifier = new SecurityIdentifier((byte[])(adDomainRoot.Properties["objectSid"][0]), 0);
            }

            using (var configSearchRoot = new DirectoryEntry(ldapPath + "CN=Partitions," + this.ConfigurationNamingContext))
            {
                var configSearchFilter = string.Format("(&(objectcategory=Crossref)(dnsRoot={0})(netBIOSName=*))", this.Name);

                using (var configSearcher = new DirectorySearcher(configSearchRoot, configSearchFilter, new string[] { "NetBIOSName" }, System.DirectoryServices.SearchScope.OneLevel))
                {
                    SearchResult configResult = configSearcher.FindOne();
                    if (configResult != null)
                        this.NetBiosName = configResult.Properties["NetBIOSName"][0].ToString();
                    else
                        this.NetBiosName = null;
                }
            }
        }

        #region Domain Controllers

        public IEnumerable<ADDomainController> GetAllReachableDomainControllers()
        {
            return this.Domain.FindAllDomainControllers().WhereReachable().Select(dc => new ADDomainController(this.context, dc, this, dc.SiteName == this.context.Site.Name, false));
        }

        public IEnumerable<ADDomainController> GetReachableSiteDomainControllers()
        {
            return this.DomainControllers.Where(dc => dc.IsSiteServer && dc.DomainController.IsReachable());
        }

        public ADDomainController GetAvailableDomainController(bool RequireWritable = false)
        {
            if (this.domainMaintenanceNext < DateTime.Now)
                MaintainDomainControllers();

            IEnumerable<ADDomainController> availableServers;

            // Try Site Servers first
            availableServers = AvailableDomainControllers(RequireSiteServer: true, RequireWritable: RequireWritable);

            if (!availableServers.Any())
            {
                // No Site Servers available - try all
                availableServers = AvailableDomainControllers(RequireSiteServer: false, RequireWritable: RequireWritable);

                if (!availableServers.Any())
                {
                    lock (domainMaintainLock)
                    {
                        availableServers = AvailableDomainControllers(RequireSiteServer: false, RequireWritable: RequireWritable);

                        if (!availableServers.Any())
                            return DiscoverAvailableDomainController(RequireWritable);
                    }
                }
            }

            switch (availableServers.Count())
            {
                case 1:
                    // 1 Available DC
                    return availableServers.First();
                default:
                    // Multiple DCs Available - Round Robin
                    int drr = Interlocked.Increment(ref domainControllerRoundRobin);
                    int dcrrValue = drr % availableServers.Count();

                    if (drr > availableServers.Count())
                        domainControllerRoundRobin = -1;

                    return availableServers.ElementAt(dcrrValue);
            }
        }
        private IEnumerable<ADDomainController> AvailableDomainControllers(bool RequireSiteServer, bool RequireWritable)
        {
            IEnumerable<ADDomainController> query = this.DomainControllers.Where(dc => dc.IsAvailable);
            if (RequireSiteServer)
                query = query.Where(dc => dc.IsSiteServer);
            if (RequireWritable)
                query = query.Where(dc => dc.IsWritable);

            return query;
        }
        private ADDomainController DiscoverAvailableDomainController(bool RequireWritable)
        {
            LocatorOptions locatorOptions;
            if (RequireWritable)
                locatorOptions = LocatorOptions.ForceRediscovery | LocatorOptions.WriteableRequired;
            else
                locatorOptions = LocatorOptions.ForceRediscovery;

            var dc = this.Domain.FindDomainController(locatorOptions);

            var dcName = dc.Name;

            var existingDC = this.DomainControllers.FirstOrDefault(edc => edc.Name == dcName);

            if (existingDC != null)
            {
                // DC already in scope

                // Native API indicates writable
                if (RequireWritable)
                    existingDC.IsWritable = true;

                // Native API indicates it is available
                existingDC.IsAvailable = true;

                return existingDC;
            }
            else
            {
                // New DC discovered

                var adDC = new ADDomainController(this.context, dc, this, dc.SiteName == this.context.Site.Name, RequireWritable);

                // Add DC to Available Servers
                this.domainControllers.Push(adDC);

                return adDC;
            }
        }

        private void MaintainDomainControllers()
        {
            lock (domainMaintainLock)
            {
                var servers = this.domainControllers.ToList();

                var nonSiteServersPresent = servers.Any(s => !s.IsSiteServer);

                if (nonSiteServersPresent)
                {
                    var siteServersAvailable = servers.Any(s => s.IsSiteServer && s.IsAvailable);
                    var nonSiteServersUnavailable = servers.Any(s => !s.IsSiteServer && !s.IsAvailable);

                    if (siteServersAvailable)
                    {
                        // Remove non-site servers
                        UpdateDomainControllers(servers.Where(s => s.IsSiteServer));
                    }
                    else if (nonSiteServersUnavailable)
                    {
                        // Remove unavailable non-site servers
                        UpdateDomainControllers(servers.Where(s => s.IsSiteServer || s.IsAvailable));
                    }
                }
                this.domainMaintenanceNext = DateTime.Now.AddMinutes(DomainMaintanceIntervalMinutes);
            }
        }

        internal void UpdateDomainControllers(IEnumerable<ADDomainController> DomainControllers)
        {
            this.domainControllers = new ConcurrentStack<ADDomainController>(DomainControllers);
        }

        #endregion

        public ADDirectoryEntry RetrieveDirectoryEntry(string DistinguishedName, string[] LoadProperties = null)
        {
            if (string.IsNullOrWhiteSpace(DistinguishedName))
                throw new ArgumentNullException("DistinguishedName");

            if (!DistinguishedName.EndsWith(this.DistinguishedName, StringComparison.OrdinalIgnoreCase))
                throw new ArgumentException(string.Format("The Distinguished Name ({0}) isn't a member of this domain [{1}]", DistinguishedName, this.Name), "DistinguishedName");

            var dc = GetAvailableDomainController();

            return dc.RetrieveDirectoryEntry(DistinguishedName, LoadProperties);
        }

        #region Searching

        public IEnumerable<ADSearchResult> SearchEntireDomain(string LdapFilter, string[] LoadProperties, int? ResultLimit = null)
        {
            return SearchInternal(this.DistinguishedName, LdapFilter, LoadProperties, ResultLimit);
        }

        public IEnumerable<ADSearchResult> SearchScope(string LdapFilter, string[] LoadProperties, int? ResultLimit = null)
        {
            var searchScope = this.SearchContainers;

            // No scope set, search entire domain
            if (searchScope == null)
                return SearchEntireDomain(LdapFilter, LoadProperties, ResultLimit);

            switch (searchScope.Count)
            {
                case 0: // Ignore domain                    
                    return Enumerable.Empty<ADSearchResult>();

                case 1: // Single-search
                    return SearchInternal(searchScope[0], LdapFilter, LoadProperties, ResultLimit);

                default: // Multi-search - Parallelize

                    var queryTasks = searchScope.Select(scope =>
                        Task<IEnumerable<ADSearchResult>>.Factory.StartNew(() =>
                            SearchInternal(scope, LdapFilter, LoadProperties, ResultLimit))).ToArray();

                    // Block
                    Task.WaitAll(queryTasks);

                    var results = queryTasks.SelectMany(t => t.Result);
                    if (ResultLimit.HasValue)
                        results = results.Take(ResultLimit.Value);
                    return results;
            }
        }

        internal IEnumerable<ADSearchResult> SearchInternal(string SearchRoot, string LdapFilter, string[] LoadProperties, int? ResultLimit)
        {
            if (string.IsNullOrEmpty(SearchRoot))
                throw new ArgumentNullException("SearchRoot");
            if (string.IsNullOrEmpty(LdapFilter))
                throw new ArgumentNullException("LdapFilter");
            if (ResultLimit.HasValue && ResultLimit.Value < 1)
                throw new ArgumentOutOfRangeException("ResultLimit", "The ResultLimit must be 1 or greater");

            // Search with recovery
            var exceptionCount = 0;
            Queue<Exception> exceptions = null;
            do
            {
                var domainController = GetAvailableDomainController();

                try
                {
                    return domainController.SearchInternal(SearchRoot, LdapFilter, LoadProperties, ResultLimit);
                }
                catch (Exception ex)
                {
                    if (exceptions == null)
                        exceptions = new Queue<Exception>(SearchExceptionRetryMax);

                    exceptions.Enqueue(ex);
                    exceptionCount++;

                    // Set offline for DomainControllerUnavailableMinutes
                    domainController.IsAvailable = false;
                    SystemLog.LogWarning(string.Format("A domain controller [{0}] is offline. It will be retried after {1}. Error: {2} [{3}]", domainController.Name, domainController.AvailableWhen.Value.ToShortTimeString(), ex.Message, ex.GetType().Name));
                }
            } while (exceptionCount < SearchExceptionRetryMax);

            throw new AggregateException(
                new Exception[] { new Exception(string.Format("Unable to perform Active Directory Search after {0} attempts", exceptionCount)) }
                .Concat(exceptions));
        }

        #endregion

        internal void UpdateSearchContainers(List<string> Containers)
        {
            this.SearchContainers = Containers ?? new List<string>();
        }
        internal void UpdateSearchEntireDomain()
        {
            this.SearchContainers = null;
        }

        #region Helpers

        public string DefaultComputerContainer
        {
            get
            {
                return string.Format("CN=Computers,{0}", this.DistinguishedName);
            }
        }

        public string FriendlyDistinguishedNamePath(string DistinguishedName)
        {
            if (!DistinguishedName.EndsWith(this.DistinguishedName, StringComparison.OrdinalIgnoreCase))
                throw new ArgumentException(string.Format("The Distinguished Name [{0}] doesn't exist within this domain [{1}]", DistinguishedName, this.DistinguishedName));

            StringBuilder name = new StringBuilder();

            name.Append('[').Append(this.NetBiosName).Append(']');

            var subDN = DistinguishedName.Substring(0, DistinguishedName.Length - this.DistinguishedName.Length);
            var subDNComponents = subDN.Split(',');

            subDNComponents
                .Where(c => !string.IsNullOrWhiteSpace(c))
                .Reverse()
                .Select(c => c.Substring(c.IndexOf('=') + 1))
                .ToList()
                .ForEach(c => name.Append(" > ").Append(c));

            return name.ToString();
        }

        #endregion

        public override string ToString()
        {
            return string.Format("{0} [{1}]", this.Name, this.NetBiosName);
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is ADDomain))
                return false;
            else
                return this.DistinguishedName == ((ADDomain)obj).DistinguishedName;
        }
        public override int GetHashCode()
        {
            return System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(this.DistinguishedName);
        }
    }
}