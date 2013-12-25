﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Disco.Web.Views.Job
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Disco;
    using Disco.BI.Extensions;
    using Disco.Models.Repository;
    using Disco.Services.Authorization;
    using Disco.Services.Web;
    using Disco.Web;
    using Disco.Web.Extensions;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Job/Show.cshtml")]
    public partial class Show : Disco.Services.Web.WebViewPage<Disco.Web.Models.Job.ShowModel>
    {
        public Show()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\Job\Show.cshtml"
  
    ViewBag.Title = Html.ToBreadcrumb("Jobs", MVC.Job.Index(), string.Format("Job: {0}", Model.Job.Id.ToString()));

    if (Authorization.Has(Claims.Job.Actions.AddAttachments))
    {
        Html.BundleDeferred("~/ClientScripts/Modules/Silverlight");
    }

    Html.BundleDeferred("~/ClientScripts/Modules/jQueryUI-TimePicker");

    Authorization.Require(Claims.Job.Show);

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" id=\"Job_Show\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" id=\"Job_Show_Status\"");

WriteLiteral(">\r\n");

            
            #line 16 "..\..\Views\Job\Show.cshtml"
        
            
            #line default
            #line hidden
            
            #line 16 "..\..\Views\Job\Show.cshtml"
           var jobStatusInfo = Model.Job.Status();
            
            #line default
            #line hidden
WriteLiteral("\r\n        <i");

WriteAttribute("class", Tuple.Create(" class=\"", 549), Tuple.Create("\"", 602)
, Tuple.Create(Tuple.Create("", 557), Tuple.Create("fa", 557), true)
, Tuple.Create(Tuple.Create(" ", 559), Tuple.Create("fa-square", 560), true)
, Tuple.Create(Tuple.Create(" ", 569), Tuple.Create("jobStatus", 570), true)
            
            #line 17 "..\..\Views\Job\Show.cshtml"
, Tuple.Create(Tuple.Create(" ", 579), Tuple.Create<System.Object, System.Int32>(jobStatusInfo.Item1
            
            #line default
            #line hidden
, 580), false)
);

WriteLiteral("></i>&nbsp;");

            
            #line 17 "..\..\Views\Job\Show.cshtml"
                                                                      Write(jobStatusInfo.Item2);

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 17 "..\..\Views\Job\Show.cshtml"
                                                                                                 if (Model.LongRunning.HasValue)
                                                                                       {
            
            #line default
            #line hidden
WriteLiteral("<span");

WriteLiteral(" class=\"smallMessage\"");

WriteLiteral(">(Long Running: ");

            
            #line 18 "..\..\Views\Job\Show.cshtml"
                                                                                                                             Write(Model.LongRunning.Value.Humanize(false));

            
            #line default
            #line hidden
WriteLiteral(")</span>");

            
            #line 18 "..\..\Views\Job\Show.cshtml"
                                                                                                                                                                                  }

            
            #line default
            #line hidden
WriteLiteral("        <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n            $(function () {\r\n                $(\'#Job_Show_Status\').appendTo(\'#" +
"layout_PageHeading\')\r\n            });\r\n        </script>\r\n    </div>\r\n");

WriteLiteral("    ");

            
            #line 25 "..\..\Views\Job\Show.cshtml"
Write(Html.Partial(MVC.Job.Views.JobParts._Subject, Model));

            
            #line default
            #line hidden
WriteLiteral("\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n        $(function () {\r\n            var $tabs = $(\'#jobDetailTabs\');\r\n       " +
"     if ($tabs.children().length > 1) {\r\n                $tabs.tabs({\r\n         " +
"           activate: function (event, ui) {\r\n                        window.setT" +
"imeout(function () {\r\n                            var $window = $(window);\r\n    " +
"                        var tabHeight = $tabs.height();\r\n                       " +
"     var tabOffset = $tabs.offset();\r\n                            var windowScro" +
"llTop = $window.scrollTop();\r\n                            var windowHeight = $wi" +
"ndow.height();\r\n\r\n                            var tabTopNotShown = windowScrollT" +
"op - tabOffset.top;\r\n                            if (tabTopNotShown > 0) {\r\n    " +
"                            $(\'html\').animate({ scrollTop: tabOffset.top }, 125)" +
";\r\n                            } else {\r\n                                var tab" +
"BottomNotShown = ((windowScrollTop + windowHeight) - (tabHeight + tabOffset.top)" +
") * -1;\r\n                                if (tabBottomNotShown > 0) {\r\n         " +
"                           if (tabHeight > windowHeight)\r\n                      " +
"                  $(\'html\').animate({ scrollTop: tabOffset.top }, 125);\r\n       " +
"                             else\r\n                                        $(\'ht" +
"ml\').animate({ scrollTop: windowScrollTop + tabBottomNotShown }, 125);\r\n        " +
"                        }\r\n                            }\r\n                      " +
"  }, 1);\r\n                    }\r\n                });\r\n            } else {\r\n    " +
"            $tabs.hide();\r\n            }\r\n        });\r\n    </script>\r\n    <div");

WriteLiteral(" id=\"jobDetailTabs\"");

WriteLiteral(">\r\n        <ul");

WriteLiteral(" id=\"jobDetailTabItems\"");

WriteLiteral(">\r\n");

            
            #line 61 "..\..\Views\Job\Show.cshtml"
            
            
            #line default
            #line hidden
            
            #line 61 "..\..\Views\Job\Show.cshtml"
             if (Authorization.HasAll(Claims.Job.ShowLogs, Claims.Job.ShowAttachments))
            {

            
            #line default
            #line hidden
WriteLiteral("                <li><a");

WriteLiteral(" href=\"#jobDetailTab-Resources\"");

WriteLiteral(">Log and Attachments</a></li>\r\n");

            
            #line 64 "..\..\Views\Job\Show.cshtml"
            }
            else if (Authorization.Has(Claims.Job.ShowLogs))
            {

            
            #line default
            #line hidden
WriteLiteral("                <li><a");

WriteLiteral(" href=\"#jobDetailTab-Resources\"");

WriteLiteral(">Log</a></li>\r\n");

            
            #line 68 "..\..\Views\Job\Show.cshtml"
            }
            else if (Authorization.Has(Claims.Job.ShowLogs))
            {

            
            #line default
            #line hidden
WriteLiteral("                <li><a");

WriteLiteral(" href=\"#jobDetailTab-Resources\"");

WriteLiteral(">Attachments</a></li>\r\n");

            
            #line 72 "..\..\Views\Job\Show.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </ul>\r\n");

            
            #line 74 "..\..\Views\Job\Show.cshtml"
        
            
            #line default
            #line hidden
            
            #line 74 "..\..\Views\Job\Show.cshtml"
         if (Authorization.HasAny(Claims.Job.ShowLogs, Claims.Job.ShowAttachments))
        {

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" id=\"jobDetailTab-Resources\"");

WriteLiteral(" class=\"jobPart\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 77 "..\..\Views\Job\Show.cshtml"
           Write(Html.Partial(MVC.Job.Views.JobParts.Resources, Model));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n");

            
            #line 79 "..\..\Views\Job\Show.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("        ");

            
            #line 80 "..\..\Views\Job\Show.cshtml"
   Write(Html.Partial(MVC.Job.Views.JobParts.JobMetaAdditions, Model));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591
