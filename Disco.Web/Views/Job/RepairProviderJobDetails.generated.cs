﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
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
    using Disco.Services;
    using Disco.Services.Authorization;
    using Disco.Services.Web;
    using Disco.Web;
    using Disco.Web.Extensions;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Job/RepairProviderJobDetails.cshtml")]
    public partial class RepairProviderJobDetails : Disco.Services.Web.WebViewPage<Disco.Web.Models.Job.ProviderJobDetailsModel>
    {
        public RepairProviderJobDetails()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\Job\RepairProviderJobDetails.cshtml"
   Layout = null;

   Authorization.Require(Claims.Job.Properties.NonWarrantyProperties.RepairProviderDetails);
   
   if (Model.JobDetailsException != null)
   {

            
            #line default
            #line hidden
WriteLiteral("    <h3>\r\n        Error:</h3>\r\n");

WriteLiteral("    <div>\r\n        <strong>");

            
            #line 11 "..\..\Views\Job\RepairProviderJobDetails.cshtml"
           Write(Model.JobDetailsException.Message);

            
            #line default
            #line hidden
WriteLiteral("</strong>\r\n    </div>\r\n");

WriteLiteral("    <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" id=\"repairJobDetailsErrorShow\"");

WriteLiteral(" class=\"smallMessage\"");

WriteLiteral(">(show more)</a>\r\n");

WriteLiteral("    <div");

WriteLiteral(" id=\"repairJobDetailsErrorMore\"");

WriteLiteral(" style=\"display: none\"");

WriteLiteral(">\r\n        <br />\r\n        <strong>Error Type: </strong>");

            
            #line 16 "..\..\Views\Job\RepairProviderJobDetails.cshtml"
                                Write(Model.JobDetailsException.GetType().Name);

            
            #line default
            #line hidden
WriteLiteral("\r\n        <br />\r\n        <strong>Stack Trace:</strong>\r\n        <div");

WriteLiteral(" class=\"code\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 20 "..\..\Views\Job\RepairProviderJobDetails.cshtml"
       Write(Model.JobDetailsException.StackTrace.ToMultilineString());

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n");

            
            #line 22 "..\..\Views\Job\RepairProviderJobDetails.cshtml"
        
            
            #line default
            #line hidden
            
            #line 22 "..\..\Views\Job\RepairProviderJobDetails.cshtml"
         if (Model.JobDetailsException.InnerException != null)
        { 

            
            #line default
            #line hidden
WriteLiteral("            <hr />\r\n");

WriteLiteral("            <div>\r\n                <strong>Inner Exception:</strong> ");

            
            #line 26 "..\..\Views\Job\RepairProviderJobDetails.cshtml"
                                             Write(Model.JobDetailsException.InnerException.Message);

            
            #line default
            #line hidden
WriteLiteral("<br />\r\n                <strong>Error Type:</strong> ");

            
            #line 27 "..\..\Views\Job\RepairProviderJobDetails.cshtml"
                                        Write(Model.JobDetailsException.GetType().Name);

            
            #line default
            #line hidden
WriteLiteral("<br />\r\n                <strong>Stack Trace:</strong>\r\n                <div");

WriteLiteral(" class=\"code\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 30 "..\..\Views\Job\RepairProviderJobDetails.cshtml"
               Write(Model.JobDetailsException.InnerException.StackTrace);

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n            </div>\r\n");

            
            #line 33 "..\..\Views\Job\RepairProviderJobDetails.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("        <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(@">
            $(function () {
                $('#repairJobDetailsErrorShow').click(function () {
                    $(this).hide();
                    $('#repairJobDetailsErrorMore').slideDown();
                });
            });
        </script>
    </div>
");

            
            #line 43 "..\..\Views\Job\RepairProviderJobDetails.cshtml"
   }
   else
   {
       if (Model.JobDetailsSupported)
       {
    
            
            #line default
            #line hidden
            
            #line 48 "..\..\Views\Job\RepairProviderJobDetails.cshtml"
Write(Html.PartialCompiled(Model.ViewType, Model.ViewModel));

            
            #line default
            #line hidden
            
            #line 48 "..\..\Views\Job\RepairProviderJobDetails.cshtml"
                                                          
       }
       else
       { 

            
            #line default
            #line hidden
WriteLiteral("    <span");

WriteLiteral(" class=\"smallMessage\"");

WriteLiteral(">");

            
            #line 52 "..\..\Views\Job\RepairProviderJobDetails.cshtml"
                          Write(Model.JobDetailsNotSupportedMessage);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n");

            
            #line 53 "..\..\Views\Job\RepairProviderJobDetails.cshtml"
       }
   }

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
