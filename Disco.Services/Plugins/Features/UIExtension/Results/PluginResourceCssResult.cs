﻿using Disco.Services.Web.Bundles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Disco.Services.Plugins.Features.UIExtension.Results
{
    public class PluginResourceCssResult : UIExtensionResult
    {
        private string _resource;
        private string _resourceUrl;

        public PluginResourceCssResult(PluginFeatureManifest Source, string Resource)
            : base(Source)
        {
            this._resource = Resource;
            this._resourceUrl = Source.PluginManifest.WebResourceUrl(Resource);

            var deferredBundles = HttpContext.Current.Items[BundleTable.UIExtensionCssKey] as List<string>;
            if (deferredBundles == null)
            {
                deferredBundles = new List<string>();
                HttpContext.Current.Items[BundleTable.UIExtensionCssKey] = deferredBundles;
            }
            if (!deferredBundles.Contains(this._resourceUrl))
                deferredBundles.Add(this._resourceUrl);
        }

        public override void ExecuteResult<T>(System.Web.Mvc.WebViewPage<T> page)
        {
            // Nothing Done
        }
    }
}
