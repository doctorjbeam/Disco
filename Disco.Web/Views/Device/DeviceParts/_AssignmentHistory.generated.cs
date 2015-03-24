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

namespace Disco.Web.Views.Device.DeviceParts
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Device/DeviceParts/_AssignmentHistory.cshtml")]
    public partial class AssignmentHistory : Disco.Services.Web.WebViewPage<Disco.Web.Models.Device.ShowModel>
    {
        public AssignmentHistory()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\Device\DeviceParts\_AssignmentHistory.cshtml"
  
    Authorization.Require(Claims.Device.ShowAssignmentHistory);

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" id=\"DeviceDetailTab-AssignmentHistory\"");

WriteLiteral(" class=\"DevicePart\"");

WriteLiteral(">\r\n");

            
            #line 6 "..\..\Views\Device\DeviceParts\_AssignmentHistory.cshtml"
    
            
            #line default
            #line hidden
            
            #line 6 "..\..\Views\Device\DeviceParts\_AssignmentHistory.cshtml"
     if (Model.Device.DeviceUserAssignments.Count > 0)
    { 

            
            #line default
            #line hidden
WriteLiteral("        <table");

WriteLiteral(" class=\"genericData\"");

WriteLiteral(">\r\n            <tr>\r\n                <th>User\r\n                </th>\r\n           " +
"     <th>Assigned\r\n                </th>\r\n                <th>Unassigned\r\n      " +
"          </th>\r\n            </tr>\r\n");

            
            #line 17 "..\..\Views\Device\DeviceParts\_AssignmentHistory.cshtml"
            
            
            #line default
            #line hidden
            
            #line 17 "..\..\Views\Device\DeviceParts\_AssignmentHistory.cshtml"
             foreach (var dua in Model.Device.DeviceUserAssignments.OrderByDescending(m => m.AssignedDate))
            {

            
            #line default
            #line hidden
WriteLiteral("                <tr>\r\n                    <td>\r\n");

            
            #line 21 "..\..\Views\Device\DeviceParts\_AssignmentHistory.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 21 "..\..\Views\Device\DeviceParts\_AssignmentHistory.cshtml"
                         if (Authorization.Has(Claims.User.Show))
                        {
                            
            
            #line default
            #line hidden
            
            #line 23 "..\..\Views\Device\DeviceParts\_AssignmentHistory.cshtml"
                       Write(Html.ActionLink(dua.AssignedUser.ToString(), MVC.User.Show(dua.AssignedUserId)));

            
            #line default
            #line hidden
            
            #line 23 "..\..\Views\Device\DeviceParts\_AssignmentHistory.cshtml"
                                                                                                            
                        }
                        else
                        {
                            
            
            #line default
            #line hidden
            
            #line 27 "..\..\Views\Device\DeviceParts\_AssignmentHistory.cshtml"
                       Write(dua.AssignedUser.ToString());

            
            #line default
            #line hidden
            
            #line 27 "..\..\Views\Device\DeviceParts\_AssignmentHistory.cshtml"
                                                        
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </td>\r\n                    <td>\r\n");

WriteLiteral("                        ");

            
            #line 31 "..\..\Views\Device\DeviceParts\_AssignmentHistory.cshtml"
                   Write(CommonHelpers.FriendlyDate(dua.AssignedDate));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n");

WriteLiteral("                        ");

            
            #line 34 "..\..\Views\Device\DeviceParts\_AssignmentHistory.cshtml"
                   Write(CommonHelpers.FriendlyDate(dua.UnassignedDate, "Current"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");

            
            #line 37 "..\..\Views\Device\DeviceParts\_AssignmentHistory.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </table>\r\n");

            
            #line 39 "..\..\Views\Device\DeviceParts\_AssignmentHistory.cshtml"
    }
    else
    { 

            
            #line default
            #line hidden
WriteLiteral("        <span");

WriteLiteral(" class=\"smallMessage\"");

WriteLiteral(">No Assignment History Available</span>\r\n");

            
            #line 43 "..\..\Views\Device\DeviceParts\_AssignmentHistory.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    <script>\r\n        $(\'#DeviceDetailTabItems\').append(\'<li><a href=\"#DeviceDeta" +
"ilTab-AssignmentHistory\">Assignment History [");

            
            #line 45 "..\..\Views\Device\DeviceParts\_AssignmentHistory.cshtml"
                                                                                                            Write(Model.Device.DeviceUserAssignments.Count);

            
            #line default
            #line hidden
WriteLiteral("]</a></li>\');\r\n    </script>\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591
