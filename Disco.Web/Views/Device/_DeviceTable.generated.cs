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

namespace Disco.Web.Views.Device
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Device/_DeviceTable.cshtml")]
    public partial class DeviceTable : Disco.Services.Web.WebViewPage<IEnumerable<Disco.Models.Services.Searching.DeviceSearchResultItem>>
    {
        public DeviceTable()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\Device\_DeviceTable.cshtml"
  
    var canShowDevices = Authorization.Has(Claims.Device.Show);
    var canShowUsers = Authorization.Has(Claims.User.Show);

    Html.BundleDeferred("~/ClientScripts/Modules/Disco-DataTableHelpers");

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"genericData deviceTable\"");

WriteLiteral(">\r\n");

            
            #line 9 "..\..\Views\Device\_DeviceTable.cshtml"
    
            
            #line default
            #line hidden
            
            #line 9 "..\..\Views\Device\_DeviceTable.cshtml"
     if (Model != null && Model.Count() > 0)
    { 

            
            #line default
            #line hidden
WriteLiteral("        <table");

WriteLiteral(" class=\"genericData deviceTable\"");

WriteLiteral(@">
            <thead>
                <tr>
                    <th>Serial#
                    </th>
                    <th>Asset#
                    </th>
                    <th>Name
                    </th>
                    <th>Model
                    </th>
                    <th>Profile
                    </th>
                    <th>Batch
                    </th>
                    <th>Assigned User
                    </th>
                    <th>Jobs
                    </th>
                </tr>
            </thead>
            <tbody>
");

            
            #line 33 "..\..\Views\Device\_DeviceTable.cshtml"
                
            
            #line default
            #line hidden
            
            #line 33 "..\..\Views\Device\_DeviceTable.cshtml"
                 foreach (var item in Model)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <tr");

WriteAttribute("class", Tuple.Create(" class=\"", 1101), Tuple.Create("\"", 1178)
            
            #line 35 "..\..\Views\Device\_DeviceTable.cshtml"
, Tuple.Create(Tuple.Create("", 1109), Tuple.Create<System.Object, System.Int32>(item.DecommissionedDate.HasValue ? "decommissioned" : string.Empty
            
            #line default
            #line hidden
, 1109), false)
);

WriteLiteral(">\r\n                        <td>\r\n");

            
            #line 37 "..\..\Views\Device\_DeviceTable.cshtml"
                            
            
            #line default
            #line hidden
            
            #line 37 "..\..\Views\Device\_DeviceTable.cshtml"
                             if (canShowDevices)
                            {
            
            #line default
            #line hidden
            
            #line 38 "..\..\Views\Device\_DeviceTable.cshtml"
                        Write(Html.ActionLink(item.Id, MVC.Device.Show(item.Id)));

            
            #line default
            #line hidden
            
            #line 38 "..\..\Views\Device\_DeviceTable.cshtml"
                                                                                }
                            else
                            {
            
            #line default
            #line hidden
            
            #line 40 "..\..\Views\Device\_DeviceTable.cshtml"
                        Write(item.Id);

            
            #line default
            #line hidden
            
            #line 40 "..\..\Views\Device\_DeviceTable.cshtml"
                                     }

            
            #line default
            #line hidden
WriteLiteral("                        </td>\r\n                        <td>\r\n");

WriteLiteral("                            ");

            
            #line 43 "..\..\Views\Device\_DeviceTable.cshtml"
                       Write(item.AssetNumber);

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 44 "..\..\Views\Device\_DeviceTable.cshtml"
                            
            
            #line default
            #line hidden
            
            #line 44 "..\..\Views\Device\_DeviceTable.cshtml"
                             if (item.DecommissionedDate.HasValue)
                            {
            
            #line default
            #line hidden
WriteLiteral(" <span");

WriteLiteral(" class=\"smallMessage\"");

WriteLiteral(">(Decommissioned\r\n");

WriteLiteral("                            ");

            
            #line 46 "..\..\Views\Device\_DeviceTable.cshtml"
                       Write(CommonHelpers.FriendlyDate(item.DecommissionedDate.Value));

            
            #line default
            #line hidden
WriteLiteral(")</span> ");

            
            #line 46 "..\..\Views\Device\_DeviceTable.cshtml"
                                                                                               }

            
            #line default
            #line hidden
WriteLiteral("                        </td>\r\n                        <td>\r\n");

            
            #line 49 "..\..\Views\Device\_DeviceTable.cshtml"
                            
            
            #line default
            #line hidden
            
            #line 49 "..\..\Views\Device\_DeviceTable.cshtml"
                             if (string.IsNullOrWhiteSpace(item.ComputerName))
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <span");

WriteLiteral(" class=\"smallMessage\"");

WriteLiteral(">Unknown</span>\r\n");

            
            #line 52 "..\..\Views\Device\_DeviceTable.cshtml"
                            }
                            else
                            { 
                                
            
            #line default
            #line hidden
            
            #line 55 "..\..\Views\Device\_DeviceTable.cshtml"
                           Write(item.ComputerName);

            
            #line default
            #line hidden
            
            #line 55 "..\..\Views\Device\_DeviceTable.cshtml"
                                                  
                            }

            
            #line default
            #line hidden
WriteLiteral("                        </td>\r\n                        <td>\r\n");

            
            #line 59 "..\..\Views\Device\_DeviceTable.cshtml"
                            
            
            #line default
            #line hidden
            
            #line 59 "..\..\Views\Device\_DeviceTable.cshtml"
                             if (item.DeviceModelDescription != null)
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <span>");

            
            #line 61 "..\..\Views\Device\_DeviceTable.cshtml"
                                 Write(item.DeviceModelDescription);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n");

            
            #line 62 "..\..\Views\Device\_DeviceTable.cshtml"
                            }
                            else
                            { 

            
            #line default
            #line hidden
WriteLiteral("                                <span");

WriteLiteral(" class=\"smallMessage\"");

WriteLiteral(">Unknown</span>                    \r\n");

            
            #line 66 "..\..\Views\Device\_DeviceTable.cshtml"
                            }

            
            #line default
            #line hidden
WriteLiteral("                        </td>\r\n                        <td>\r\n");

WriteLiteral("                            ");

            
            #line 69 "..\..\Views\Device\_DeviceTable.cshtml"
                       Write(item.DeviceProfileDescription);

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n");

            
            #line 72 "..\..\Views\Device\_DeviceTable.cshtml"
                            
            
            #line default
            #line hidden
            
            #line 72 "..\..\Views\Device\_DeviceTable.cshtml"
                             if (item.DeviceBatchName != null)
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <span>");

            
            #line 74 "..\..\Views\Device\_DeviceTable.cshtml"
                                 Write(item.DeviceBatchName);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n");

            
            #line 75 "..\..\Views\Device\_DeviceTable.cshtml"
                            }
                            else
                            { 

            
            #line default
            #line hidden
WriteLiteral("                                <span");

WriteLiteral(" class=\"smallMessage\"");

WriteLiteral(">N/A</span>                    \r\n");

            
            #line 79 "..\..\Views\Device\_DeviceTable.cshtml"
                            }

            
            #line default
            #line hidden
WriteLiteral("                        </td>\r\n                        <td>\r\n");

            
            #line 82 "..\..\Views\Device\_DeviceTable.cshtml"
                            
            
            #line default
            #line hidden
            
            #line 82 "..\..\Views\Device\_DeviceTable.cshtml"
                             if (string.IsNullOrEmpty(item.AssignedUserId))
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <span");

WriteLiteral(" class=\"smallMessage\"");

WriteLiteral(">N/A</span>                 \r\n");

            
            #line 85 "..\..\Views\Device\_DeviceTable.cshtml"
                            }
                            else
                            { 

            
            #line default
            #line hidden
WriteLiteral("                                <span>");

            
            #line 88 "..\..\Views\Device\_DeviceTable.cshtml"
                                       if (canShowUsers)
                                      {
                                    
            
            #line default
            #line hidden
            
            #line 90 "..\..\Views\Device\_DeviceTable.cshtml"
                               Write(Html.ActionLink(item.AssignedUserDescription, MVC.User.Show(item.AssignedUserId)));

            
            #line default
            #line hidden
            
            #line 90 "..\..\Views\Device\_DeviceTable.cshtml"
                                                                                                                      
                                      }
                                      else
                                      {
                                    
            
            #line default
            #line hidden
            
            #line 94 "..\..\Views\Device\_DeviceTable.cshtml"
                               Write(item.AssignedUserDescription);

            
            #line default
            #line hidden
            
            #line 94 "..\..\Views\Device\_DeviceTable.cshtml"
                                                                 
                                      }

            
            #line default
            #line hidden
WriteLiteral("                                </span>\r\n");

            
            #line 97 "..\..\Views\Device\_DeviceTable.cshtml"
                            }

            
            #line default
            #line hidden
WriteLiteral("                        </td>\r\n                        <td>\r\n");

WriteLiteral("                            ");

            
            #line 100 "..\..\Views\Device\_DeviceTable.cshtml"
                       Write(item.JobCount);

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");

            
            #line 103 "..\..\Views\Device\_DeviceTable.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </tbody>\r\n        </table>\r\n");

            
            #line 106 "..\..\Views\Device\_DeviceTable.cshtml"
    }
    else
    { 

            
            #line default
            #line hidden
WriteLiteral("        <span");

WriteLiteral(" class=\"smallMessage\"");

WriteLiteral(">No Devices Found</span>\r\n");

            
            #line 110 "..\..\Views\Device\_DeviceTable.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

        }
    }
}
#pragma warning restore 1591
