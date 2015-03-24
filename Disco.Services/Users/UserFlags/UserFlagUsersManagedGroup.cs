﻿using Disco.Data.Repository;
using Disco.Data.Repository.Monitor;
using Disco.Models.Repository;
using Disco.Models.Services.Interop.ActiveDirectory;
using Disco.Services.Interop.ActiveDirectory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace Disco.Services.Users.UserFlags
{
    public class UserFlagUsersManagedGroup : ADManagedGroup
    {
        private const string KeyFormat = "UserFlag_{0}_Users";
        private const string DescriptionFormat = "User associated with the {0} Flag will be added to this Active Directory group.";
        private const string CategoryDescriptionFormat = "Assigned Users Linked Group";
        private const string GroupDescriptionFormat = "{0} [User Flag Users]";
        
        private IDisposable repositorySubscription;
        private int UserFlagId;
        private string UserFlagName;

        public override string Description { get { return string.Format(DescriptionFormat, UserFlagName); } }
        public override string CategoryDescription { get { return CategoryDescriptionFormat; } }
        public override string GroupDescription { get { return string.Format(GroupDescriptionFormat, UserFlagName); } }
        public override bool IncludeFilterBeginDate { get { return false; } }

        private UserFlagUsersManagedGroup(string Key, ADManagedGroupConfiguration Configuration, UserFlag UserFlag)
            : base(Key, Configuration)
        {
            this.UserFlagId = UserFlag.Id;
            this.UserFlagName = UserFlag.Name;
        }

        public override void Initialize()
        {
            // Subscribe to changes
            repositorySubscription = UserFlagService.UserFlagAssignmentRepositoryEvents.Value
                .Where(e =>
                    (((UserFlagAssignment)e.Entity).UserFlagId == UserFlagId))
                .Subscribe(ProcessRepositoryEvent);
        }

        public static string GetKey(UserFlag UserFlag)
        {
            return string.Format(KeyFormat, UserFlag.Id);
        }
        public static string GetDescription(UserFlag UserFlag)
        {
            return string.Format(DescriptionFormat, UserFlag.Name);
        }
        public static string GetCategoryDescription(UserFlag UserFlag)
        {
            return CategoryDescriptionFormat;
        }

        public static bool TryGetManagedGroup(UserFlag UserFlag, out UserFlagUsersManagedGroup ManagedGroup)
        {
            ADManagedGroup managedGroup;
            string key = GetKey(UserFlag);

            if (ActiveDirectory.Context.ManagedGroups.TryGetValue(key, out managedGroup))
            {
                ManagedGroup = (UserFlagUsersManagedGroup)managedGroup;
                return true;
            }
            else
            {
                ManagedGroup = null;
                return false;
            }
        }

        public static UserFlagUsersManagedGroup Initialize(UserFlag UserFlag)
        {
            if (UserFlag.Id > 0)
            {
                var key = GetKey(UserFlag);

                if (!string.IsNullOrEmpty(UserFlag.UsersLinkedGroup))
                {
                    var config = ADManagedGroup.ConfigurationFromJson(UserFlag.UsersLinkedGroup);

                    if (config != null && !string.IsNullOrWhiteSpace(config.GroupId))
                    {
                        var group = new UserFlagUsersManagedGroup(
                            key,
                            config,
                            UserFlag);

                        // Add to AD Context
                        ActiveDirectory.Context.ManagedGroups.AddOrUpdate(group);

                        return group;
                    }
                }

                // Remove from AD Context
                ActiveDirectory.Context.ManagedGroups.Remove(key);
            }

            return null;
        }

        public override IEnumerable<string> DetermineMembers(DiscoDataContext Database)
        {
            return Database.UserFlagAssignments
                .Where(a => a.UserFlagId == UserFlagId && !a.RemovedDate.HasValue)
                .Select(a => a.UserId);
        }

        private void ProcessRepositoryEvent(RepositoryMonitorEvent Event)
        {
            var userFlagAssignemnt = (UserFlagAssignment)Event.Entity;

            switch (Event.EventType)
            {
                case RepositoryMonitorEventType.Added:
                    if (!userFlagAssignemnt.RemovedDate.HasValue)
                        AddMember(userFlagAssignemnt.UserId);
                    break;
                case RepositoryMonitorEventType.Modified:
                    if (userFlagAssignemnt.RemovedDate.HasValue)
                        RemoveMember(userFlagAssignemnt.UserId);
                    else
                        AddMember(userFlagAssignemnt.UserId);
                    break;
                case RepositoryMonitorEventType.Deleted:
                    string userId = userFlagAssignemnt.UserId;
                    // Remove the user if no other (non-removed) assignments exist.
                    RemoveMember(userId, (database) =>
                    {
                        if (database.UserFlagAssignments.Any(a => a.UserFlagId == UserFlagId && a.UserId == userId && !a.RemovedDate.HasValue))
                            return null;
                        else
                            return new string[] { userId };
                    });
                    break;
            }
        }

        public override void Dispose()
        {
            if (repositorySubscription != null)
                repositorySubscription.Dispose();
        }
    }
}
