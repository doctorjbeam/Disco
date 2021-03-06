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

namespace Disco.Web.Areas.Config.Views.UserFlag
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Config/Views/UserFlag/Index.cshtml")]
    public partial class Index : Disco.Services.Web.WebViewPage<Disco.Web.Areas.Config.Models.UserFlag.IndexModel>
    {
        public Index()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Areas\Config\Views\UserFlag\Index.cshtml"
  
    Authorization.Require(Claims.Config.UserFlag.Show);
    ViewBag.Title = Html.ToBreadcrumb("Configuration", MVC.Config.Config.Index(), "User Flags");

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" id=\"Config_UserFlags_Index\"");

WriteLiteral(">\r\n");

            
            #line 7 "..\..\Areas\Config\Views\UserFlag\Index.cshtml"
    
            
            #line default
            #line hidden
            
            #line 7 "..\..\Areas\Config\Views\UserFlag\Index.cshtml"
     if (Model.UserFlags.Count == 0)
    {

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"form\"");

WriteLiteral(" style=\"width: 450px; padding: 100px 0;\"");

WriteLiteral(">\r\n            <h2>No user flags are configured</h2>\r\n        </div>  \r\n");

            
            #line 12 "..\..\Areas\Config\Views\UserFlag\Index.cshtml"
    }
    else
    {

            
            #line default
            #line hidden
WriteLiteral("        <table");

WriteLiteral(" class=\"tableData\"");

WriteLiteral(">\r\n            <tr>\r\n                <th>Name</th>\r\n                <th>Descripti" +
"on</th>\r\n                <th>Linked</th>\r\n            </tr>\r\n");

            
            #line 21 "..\..\Areas\Config\Views\UserFlag\Index.cshtml"
            
            
            #line default
            #line hidden
            
            #line 21 "..\..\Areas\Config\Views\UserFlag\Index.cshtml"
             foreach (var item in Model.UserFlags)
            {

            
            #line default
            #line hidden
WriteLiteral("                <tr>\r\n                    <td>\r\n                        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 776), Tuple.Create("\"", 830)
            
            #line 25 "..\..\Areas\Config\Views\UserFlag\Index.cshtml"
, Tuple.Create(Tuple.Create("", 783), Tuple.Create<System.Object, System.Int32>(Url.Action(MVC.Config.UserFlag.Index(item.Id))
            
            #line default
            #line hidden
, 783), false)
);

WriteLiteral(">\r\n                            <i");

WriteAttribute("class", Tuple.Create(" class=\"", 864), Tuple.Create("\"", 917)
, Tuple.Create(Tuple.Create("", 872), Tuple.Create("fa", 872), true)
, Tuple.Create(Tuple.Create(" ", 874), Tuple.Create("fa-", 875), true)
            
            #line 26 "..\..\Areas\Config\Views\UserFlag\Index.cshtml"
, Tuple.Create(Tuple.Create("", 878), Tuple.Create<System.Object, System.Int32>(item.Icon
            
            #line default
            #line hidden
, 878), false)
, Tuple.Create(Tuple.Create(" ", 890), Tuple.Create("fa-lg", 891), true)
, Tuple.Create(Tuple.Create(" ", 896), Tuple.Create("d-", 897), true)
            
            #line 26 "..\..\Areas\Config\Views\UserFlag\Index.cshtml"
, Tuple.Create(Tuple.Create("", 899), Tuple.Create<System.Object, System.Int32>(item.IconColour
            
            #line default
            #line hidden
, 899), false)
);

WriteLiteral("></i>\r\n");

WriteLiteral("                            ");

            
            #line 27 "..\..\Areas\Config\Views\UserFlag\Index.cshtml"
                       Write(item.Name);

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </a>\r\n                    </td>\r\n                    <t" +
"d>");

            
            #line 30 "..\..\Areas\Config\Views\UserFlag\Index.cshtml"
                         if (string.IsNullOrWhiteSpace(item.Description))
                        {

            
            #line default
            #line hidden
WriteLiteral("                        <span");

WriteLiteral(" class=\"smallMessage\"");

WriteLiteral(">&lt;none&gt;</span>\r\n");

            
            #line 33 "..\..\Areas\Config\Views\UserFlag\Index.cshtml"
                        }
                        else
                        {
                        
            
            #line default
            #line hidden
            
            #line 36 "..\..\Areas\Config\Views\UserFlag\Index.cshtml"
                   Write(item.Description.ToHtmlComment());

            
            #line default
            #line hidden
            
            #line 36 "..\..\Areas\Config\Views\UserFlag\Index.cshtml"
                                                         
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </td>\r\n                    <td>");

            
            #line 39 "..\..\Areas\Config\Views\UserFlag\Index.cshtml"
                         if (item.UserDevicesLinkedGroup != null || item.UsersLinkedGroup != null)
                        {

            
            #line default
            #line hidden
WriteLiteral("                        <i");

WriteLiteral(" class=\"fa fa-link fa-lg success\"");

WriteLiteral("></i>\r\n");

            
            #line 42 "..\..\Areas\Config\Views\UserFlag\Index.cshtml"
                        }
                        else
                        {

            
            #line default
            #line hidden
WriteLiteral("                        <i");

WriteLiteral(" class=\"fa fa-unlink fa-lg information\"");

WriteLiteral("></i>\r\n");

            
            #line 46 "..\..\Areas\Config\Views\UserFlag\Index.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </td>\r\n                </tr>\r\n");

            
            #line 49 "..\..\Areas\Config\Views\UserFlag\Index.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </table>\r\n");

            
            #line 51 "..\..\Areas\Config\Views\UserFlag\Index.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    ");

            
            #line 52 "..\..\Areas\Config\Views\UserFlag\Index.cshtml"
     if (Authorization.Has(Claims.Config.UserFlag.Create))
    {

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"actionBar\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 55 "..\..\Areas\Config\Views\UserFlag\Index.cshtml"
       Write(Html.ActionLinkButton("Create User Flag", MVC.Config.UserFlag.Create()));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n");

            
            #line 57 "..\..\Areas\Config\Views\UserFlag\Index.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</div>");

        }
    }
}
#pragma warning restore 1591
