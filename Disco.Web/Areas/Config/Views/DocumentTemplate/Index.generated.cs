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

namespace Disco.Web.Areas.Config.Views.DocumentTemplate
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Config/Views/DocumentTemplate/Index.cshtml")]
    public partial class Index : Disco.Services.Web.WebViewPage<Disco.Web.Areas.Config.Models.DocumentTemplate.IndexModel>
    {
        public Index()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Areas\Config\Views\DocumentTemplate\Index.cshtml"
  
    Authorization.Require(Claims.Config.DocumentTemplate.Show);

    ViewBag.Title = Html.ToBreadcrumb("Configuration", MVC.Config.Config.Index(), "Document Templates");

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 7 "..\..\Areas\Config\Views\DocumentTemplate\Index.cshtml"
 if (Model.DocumentTemplates.Count == 0)
{

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"form\"");

WriteLiteral(" style=\"width: 450px; padding: 100px 0;\"");

WriteLiteral(">\r\n        <h2>No document templates are configured</h2>\r\n    </div>  \r\n");

            
            #line 12 "..\..\Areas\Config\Views\DocumentTemplate\Index.cshtml"
}
else
{

            
            #line default
            #line hidden
WriteLiteral("    <table");

WriteLiteral(" class=\"tableData\"");

WriteLiteral(">\r\n        <tr>\r\n            <th>Id\r\n            </th>\r\n            <th>Descripti" +
"on\r\n            </th>\r\n            <th>Scope\r\n            </th>\r\n        </tr>\r\n" +
"");

            
            #line 24 "..\..\Areas\Config\Views\DocumentTemplate\Index.cshtml"
        
            
            #line default
            #line hidden
            
            #line 24 "..\..\Areas\Config\Views\DocumentTemplate\Index.cshtml"
         foreach (var item in Model.DocumentTemplates)
        {

            
            #line default
            #line hidden
WriteLiteral("            <tr>\r\n                <td>\r\n");

WriteLiteral("                    ");

            
            #line 28 "..\..\Areas\Config\Views\DocumentTemplate\Index.cshtml"
               Write(Html.ActionLink(item.Id.ToString(), MVC.Config.DocumentTemplate.Index(item.Id)));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n                <td>\r\n");

WriteLiteral("                    ");

            
            #line 31 "..\..\Areas\Config\Views\DocumentTemplate\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Description));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n                <td>\r\n");

WriteLiteral("                    ");

            
            #line 34 "..\..\Areas\Config\Views\DocumentTemplate\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Scope));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");

            
            #line 37 "..\..\Areas\Config\Views\DocumentTemplate\Index.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </table>\r\n");

            
            #line 39 "..\..\Areas\Config\Views\DocumentTemplate\Index.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("<div");

WriteLiteral(" class=\"actionBar\"");

WriteLiteral(">\r\n");

            
            #line 41 "..\..\Areas\Config\Views\DocumentTemplate\Index.cshtml"
    
            
            #line default
            #line hidden
            
            #line 41 "..\..\Areas\Config\Views\DocumentTemplate\Index.cshtml"
     if (Authorization.Has(Claims.Config.DocumentTemplate.UndetectedPages))
    {
        
            
            #line default
            #line hidden
            
            #line 43 "..\..\Areas\Config\Views\DocumentTemplate\Index.cshtml"
   Write(Html.ActionLinkButton("Undetected Pages", MVC.Config.DocumentTemplate.UndetectedPages()));

            
            #line default
            #line hidden
            
            #line 43 "..\..\Areas\Config\Views\DocumentTemplate\Index.cshtml"
                                                                                                 
    }

            
            #line default
            #line hidden
WriteLiteral("    ");

            
            #line 45 "..\..\Areas\Config\Views\DocumentTemplate\Index.cshtml"
     if (Authorization.Has(Claims.Config.DocumentTemplate.ShowStatus))
    {
        
            
            #line default
            #line hidden
            
            #line 47 "..\..\Areas\Config\Views\DocumentTemplate\Index.cshtml"
   Write(Html.ActionLinkButton("Import Status", MVC.Config.DocumentTemplate.ImportStatus()));

            
            #line default
            #line hidden
            
            #line 47 "..\..\Areas\Config\Views\DocumentTemplate\Index.cshtml"
                                                                                           
    }

            
            #line default
            #line hidden
WriteLiteral("    ");

            
            #line 49 "..\..\Areas\Config\Views\DocumentTemplate\Index.cshtml"
     if (Authorization.Has(Claims.Config.Show))
    {
        
            
            #line default
            #line hidden
            
            #line 51 "..\..\Areas\Config\Views\DocumentTemplate\Index.cshtml"
   Write(Html.ActionLinkButton("Expression Browser", MVC.Config.DocumentTemplate.ExpressionBrowser()));

            
            #line default
            #line hidden
            
            #line 51 "..\..\Areas\Config\Views\DocumentTemplate\Index.cshtml"
                                                                                                     
    }

            
            #line default
            #line hidden
WriteLiteral("    ");

            
            #line 53 "..\..\Areas\Config\Views\DocumentTemplate\Index.cshtml"
     if (Authorization.HasAll(Claims.Config.DocumentTemplate.Create, Claims.Config.DocumentTemplate.Configure))
    {
        
            
            #line default
            #line hidden
            
            #line 55 "..\..\Areas\Config\Views\DocumentTemplate\Index.cshtml"
   Write(Html.ActionLinkButton("Create Document Template", MVC.Config.DocumentTemplate.Create()));

            
            #line default
            #line hidden
            
            #line 55 "..\..\Areas\Config\Views\DocumentTemplate\Index.cshtml"
                                                                                                
    }

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

        }
    }
}
#pragma warning restore 1591
