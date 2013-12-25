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

namespace Disco.Web.Views.User.UserParts
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
    
    #line 2 "..\..\Views\User\UserParts\_Authorization.cshtml"
    using Disco.Services.Authorization.Roles;
    
    #line default
    #line hidden
    using Disco.Services.Web;
    using Disco.Web;
    using Disco.Web.Extensions;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/User/UserParts/_Authorization.cshtml")]
    public partial class Authorization : Disco.Services.Web.WebViewPage<Disco.Web.Models.User.ShowModel>
    {
        public Authorization()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\User\UserParts\_Authorization.cshtml"
  
    Authorization.Require(Claims.User.ShowAuthorization);

    var isDiscoAdmin = Authorization.Has(Claims.DiscoAdminAccount);

    Html.BundleDeferred("~/Style/Fancytree");
    Html.BundleDeferred("~/ClientScripts/Modules/jQuery-Fancytree");

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" id=\"UserDetailTab-Authorization\"");

WriteLiteral(" class=\"UserPart\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" id=\"UserDetailTab-AuthorizationContainer\"");

WriteLiteral(" class=\"clearfix\"");

WriteLiteral(">\r\n\r\n");

            
            #line 14 "..\..\Views\User\UserParts\_Authorization.cshtml"
        
            
            #line default
            #line hidden
            
            #line 14 "..\..\Views\User\UserParts\_Authorization.cshtml"
         if (Model.ClaimNavigator != null)
        {

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" id=\"UserDetailTab-Authorization_ClaimsTree_Container\"");

WriteLiteral(">\r\n                <h3>Effective Permissions</h3>\r\n                <div");

WriteLiteral(" id=\"UserDetailTab-Authorization_ClaimsTree\"");

WriteLiteral(">\r\n                </div>\r\n                <script>\r\n                    (functio" +
"n(){\r\n                        var claimNodes = ");

            
            #line 22 "..\..\Views\User\UserParts\_Authorization.cshtml"
                                     Write(new HtmlString(Newtonsoft.Json.JsonConvert.SerializeObject(Model.ClaimNavigatorFancyTreeNodes)));

            
            #line default
            #line hidden
WriteLiteral(@";

                        $(function(){
                            var tree = $('#UserDetailTab-Authorization_ClaimsTree').fancytree({
                                source: claimNodes,
                                checkbox: false,
                                selectMode: 3,
                                keyboard: false
                            });
                        });
                    })();
                </script>
                <span");

WriteLiteral(" class=\"smallMessage\"");

WriteLiteral(">Calculated from authorization roles</span>\r\n            </div>\r\n");

            
            #line 36 "..\..\Views\User\UserParts\_Authorization.cshtml"
        }
        else
        {

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" id=\"UserDetailTab-Authorization_NoAccess\"");

WriteLiteral(">\r\n                <h3>User Not Authorized</h3>\r\n                <p>The user (<sp" +
"an");

WriteLiteral(" class=\"code\"");

WriteLiteral(">");

            
            #line 41 "..\..\Views\User\UserParts\_Authorization.cshtml"
                                            Write(Model.User.Id);

            
            #line default
            #line hidden
WriteLiteral("</span>) is not authorized to access any authenticated components.</p>\r\n");

            
            #line 42 "..\..\Views\User\UserParts\_Authorization.cshtml"
                
            
            #line default
            #line hidden
            
            #line 42 "..\..\Views\User\UserParts\_Authorization.cshtml"
                 if (isDiscoAdmin)
                {
                    
            
            #line default
            #line hidden
            
            #line 44 "..\..\Views\User\UserParts\_Authorization.cshtml"
               Write(Html.ActionLinkButton("Configure Authorization Roles", MVC.Config.AuthorizationRole.Index(null), null, "small"));

            
            #line default
            #line hidden
            
            #line 44 "..\..\Views\User\UserParts\_Authorization.cshtml"
                                                                                                                                    
                }

            
            #line default
            #line hidden
WriteLiteral("            </div>\r\n");

            
            #line 47 "..\..\Views\User\UserParts\_Authorization.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" id=\"UserDetailTab-Authorization_Membership\"");

WriteLiteral(">\r\n");

            
            #line 49 "..\..\Views\User\UserParts\_Authorization.cshtml"
            
            
            #line default
            #line hidden
            
            #line 49 "..\..\Views\User\UserParts\_Authorization.cshtml"
             if (Model.ClaimNavigator != null)
            {

            
            #line default
            #line hidden
WriteLiteral("                <h3>Associated Roles</h3>\r\n");

WriteLiteral("                <ul");

WriteLiteral(" id=\"UserDetailTab-Authorization_Membership_Roles\"");

WriteLiteral(">\r\n");

            
            #line 53 "..\..\Views\User\UserParts\_Authorization.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 53 "..\..\Views\User\UserParts\_Authorization.cshtml"
                     foreach (var roleToken in Model.AuthorizationToken.RoleTokens.Cast<RoleToken>())
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <li>");

            
            #line 55 "..\..\Views\User\UserParts\_Authorization.cshtml"
                             if (roleToken.Role.Id < 0)
                            {

            
            #line default
            #line hidden
WriteLiteral("                            ");

            
            #line 57 "..\..\Views\User\UserParts\_Authorization.cshtml"
                             Write(roleToken.Role.Name);

            
            #line default
            #line hidden
WriteLiteral(" <span");

WriteLiteral(" class=\"code\"");

WriteLiteral(">[SYSTEM ROLE]</span>");

WriteLiteral("\r\n");

            
            #line 58 "..\..\Views\User\UserParts\_Authorization.cshtml"
                            }
                            else
                            {
                                if (isDiscoAdmin)
                                {
                            
            
            #line default
            #line hidden
            
            #line 63 "..\..\Views\User\UserParts\_Authorization.cshtml"
                       Write(Html.ActionLink(roleToken.Role.Name, MVC.Config.AuthorizationRole.Index(roleToken.Role.Id)));

            
            #line default
            #line hidden
            
            #line 63 "..\..\Views\User\UserParts\_Authorization.cshtml"
                                                                                                                        
                                }
                                else
                                {
                            
            
            #line default
            #line hidden
            
            #line 67 "..\..\Views\User\UserParts\_Authorization.cshtml"
                       Write(roleToken.Role.Name);

            
            #line default
            #line hidden
            
            #line 67 "..\..\Views\User\UserParts\_Authorization.cshtml"
                                                
                                }
                            }

            
            #line default
            #line hidden
WriteLiteral("                        </li>\r\n");

            
            #line 71 "..\..\Views\User\UserParts\_Authorization.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                </ul>\r\n");

            
            #line 73 "..\..\Views\User\UserParts\_Authorization.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" id=\"UserDetailTab-Authorization_Membership_Groups_Container\"");

WriteLiteral(">\r\n                <h4>Associated Active Directory Security Groups</h4>\r\n");

            
            #line 76 "..\..\Views\User\UserParts\_Authorization.cshtml"
                
            
            #line default
            #line hidden
            
            #line 76 "..\..\Views\User\UserParts\_Authorization.cshtml"
                 if (Model.AuthorizationToken != null)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <ul");

WriteLiteral(" id=\"UserDetailTab-Authorization_Membership_Groups\"");

WriteLiteral(">\r\n");

            
            #line 79 "..\..\Views\User\UserParts\_Authorization.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 79 "..\..\Views\User\UserParts\_Authorization.cshtml"
                         foreach (var group in Model.AuthorizationToken.GroupMembership)
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <li>");

            
            #line 81 "..\..\Views\User\UserParts\_Authorization.cshtml"
                           Write(group);

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n");

            
            #line 82 "..\..\Views\User\UserParts\_Authorization.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </ul>\r\n");

WriteLiteral("                    <span");

WriteLiteral(" class=\"smallMessage\"");

WriteLiteral(">[Note: Includes inherited groups]</span>\r\n");

            
            #line 85 "..\..\Views\User\UserParts\_Authorization.cshtml"
                }
                else
                {

            
            #line default
            #line hidden
WriteLiteral("                    <h5>&lt;None&gt;</h5>\r\n");

WriteLiteral("                    <span");

WriteLiteral(" class=\"smallMessage\"");

WriteLiteral(">[Note: Not found in Active Directory]</span>    \r\n");

            
            #line 90 "..\..\Views\User\UserParts\_Authorization.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </div>\r\n        </div>\r\n\r\n\r\n    </div>\r\n    <script>\r\n        $(\'#Use" +
"rDetailTabItems\').append(\'<li><a href=\"#UserDetailTab-Authorization\">Authorizati" +
"on</a></li>\');\r\n    </script>\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591
