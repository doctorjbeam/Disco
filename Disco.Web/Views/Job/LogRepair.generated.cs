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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Job/LogRepair.cshtml")]
    public partial class LogRepair : Disco.Services.Web.WebViewPage<Disco.Web.Models.Job.LogRepairModel>
    {
        public LogRepair()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\Job\LogRepair.cshtml"
  
    Authorization.Require(Claims.Job.Actions.LogRepair);

    ViewBag.Title = Html.ToBreadcrumb("Jobs", MVC.Job.Index(), string.Format("Job: {0}", Model.Job.Id), MVC.Job.Show(Model.Job.Id), "Log Repair");

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 7 "..\..\Views\Job\LogRepair.cshtml"
 using (Html.BeginForm(MVC.Job.LogRepair(), FormMethod.Post))
{
    
            
            #line default
            #line hidden
            
            #line 9 "..\..\Views\Job\LogRepair.cshtml"
Write(Html.ValidationSummary(true));

            
            #line default
            #line hidden
            
            #line 9 "..\..\Views\Job\LogRepair.cshtml"
                                 
    
            
            #line default
            #line hidden
            
            #line 10 "..\..\Views\Job\LogRepair.cshtml"
Write(Html.HiddenFor(m => m.JobId));

            
            #line default
            #line hidden
            
            #line 10 "..\..\Views\Job\LogRepair.cshtml"
                                 
    
            
            #line default
            #line hidden
            
            #line 11 "..\..\Views\Job\LogRepair.cshtml"
Write(Html.ValidationMessageFor(m => m.JobId));

            
            #line default
            #line hidden
            
            #line 11 "..\..\Views\Job\LogRepair.cshtml"
                                            

            
            #line default
            #line hidden
WriteLiteral("    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" name=\"SubmissionAction\"");

WriteAttribute("value", Tuple.Create(" value=\"", 489), Tuple.Create("\"", 546)
            
            #line 12 "..\..\Views\Job\LogRepair.cshtml"
, Tuple.Create(Tuple.Create("", 497), Tuple.Create<System.Object, System.Int32>(Model.IsManualProvider ? "Manual" : "Disclose"
            
            #line default
            #line hidden
, 497), false)
);

WriteLiteral(" />\r\n");

WriteLiteral("    <div");

WriteLiteral(" id=\"repairJobForm\"");

WriteLiteral(" class=\"form\"");

WriteLiteral(" style=\"width: 650px\"");

WriteLiteral(">\r\n        <table>\r\n            <tr>\r\n                <th>Internal Job Id:\r\n     " +
"           </th>\r\n                <td>\r\n");

WriteLiteral("                    ");

            
            #line 19 "..\..\Views\Job\LogRepair.cshtml"
               Write(Model.JobId);

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <th" +
">Device Serial Number:\r\n                </th>\r\n                <td>\r\n");

WriteLiteral("                    ");

            
            #line 26 "..\..\Views\Job\LogRepair.cshtml"
               Write(Model.Job.Device.SerialNumber);

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <th" +
">Device Model:\r\n                </th>\r\n                <td>\r\n");

WriteLiteral("                    ");

            
            #line 33 "..\..\Views\Job\LogRepair.cshtml"
               Write(Model.Job.Device.DeviceModel.Manufacturer);

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 33 "..\..\Views\Job\LogRepair.cshtml"
                                                          Write(Model.Job.Device.DeviceModel.Model);

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <th" +
">Technician:\r\n                </th>\r\n                <td>\r\n");

WriteLiteral("                    ");

            
            #line 40 "..\..\Views\Job\LogRepair.cshtml"
               Write(Model.TechUser.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <div");

WriteLiteral(" class=\"smallMessage\"");

WriteLiteral(">\r\n                        Email Address: ");

            
            #line 42 "..\..\Views\Job\LogRepair.cshtml"
                                  Write(Model.TechUser.EmailAddress);

            
            #line default
            #line hidden
WriteLiteral("<br />\r\n                        Phone Number: ");

            
            #line 43 "..\..\Views\Job\LogRepair.cshtml"
                                 Write(Model.TechUser.PhoneNumber);

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                </td>\r\n            </tr>\r\n         " +
"   <tr>\r\n                <th");

WriteLiteral(" style=\"width: 150px\"");

WriteLiteral(">Repair Address:\r\n                </th>\r\n                <td>\r\n");

WriteLiteral("                    ");

            
            #line 51 "..\..\Views\Job\LogRepair.cshtml"
               Write(Html.DropDownListFor(model => model.OrganisationAddressId, Model.OrganisationAddresses.ToSelectListItems(Model.OrganisationAddressId, (Model.OrganisationAddress == null))));

            
            #line default
            #line hidden
WriteLiteral("<br />\r\n");

WriteLiteral("                    ");

            
            #line 52 "..\..\Views\Job\LogRepair.cshtml"
               Write(Html.ValidationMessageFor(m => m.OrganisationAddressId));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <div");

WriteLiteral(" id=\"organisationAddressDetails\"");

WriteLiteral(">\r\n");

            
            #line 54 "..\..\Views\Job\LogRepair.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 54 "..\..\Views\Job\LogRepair.cshtml"
                          
    var oa = Model.OrganisationAddress;
    if (oa != null)
    {

            
            #line default
            #line hidden
WriteLiteral("                            <span>");

            
            #line 58 "..\..\Views\Job\LogRepair.cshtml"
                             Write(oa.Address);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n");

WriteLiteral("                            <br />\r\n");

WriteLiteral("                            <span>");

            
            #line 60 "..\..\Views\Job\LogRepair.cshtml"
                             Write(oa.Suburb);

            
            #line default
            #line hidden
WriteLiteral(", ");

            
            #line 60 "..\..\Views\Job\LogRepair.cshtml"
                                         Write(oa.Postcode);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n");

WriteLiteral("                            <br />\r\n");

WriteLiteral("                            <span>");

            
            #line 62 "..\..\Views\Job\LogRepair.cshtml"
                             Write(oa.State);

            
            #line default
            #line hidden
WriteLiteral(", ");

            
            #line 62 "..\..\Views\Job\LogRepair.cshtml"
                                        Write(oa.Country);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n");

            
            #line 63 "..\..\Views\Job\LogRepair.cshtml"
    }
                        
            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                </td>\r\n            </tr>\r\n         " +
"   <tr>\r\n                <th>Repair Provider:\r\n                </th>\r\n          " +
"      <td>\r\n");

WriteLiteral("                    ");

            
            #line 72 "..\..\Views\Job\LogRepair.cshtml"
               Write(Html.DropDownListFor(model => model.RepairProviderId, Model.RepairProviders.ToSelectListItems(Model.RepairProviderId, AdditionalItems: new Dictionary<string, string>() { { "MANUAL", "<Manually Submitted Request>" } })));

            
            #line default
            #line hidden
WriteLiteral("<br />\r\n");

WriteLiteral("                    ");

            
            #line 73 "..\..\Views\Job\LogRepair.cshtml"
               Write(Html.ValidationMessageFor(m => m.RepairProviderId));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 74 "..\..\Views\Job\LogRepair.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 74 "..\..\Views\Job\LogRepair.cshtml"
                     if (Model.RepairProviders.Count == 0 && Authorization.Has(Claims.Config.Plugin.Install))
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <div");

WriteLiteral(" class=\"info-box\"");

WriteLiteral(">\r\n                            <p");

WriteLiteral(" class=\"fa-p\"");

WriteLiteral(">\r\n                                <i");

WriteLiteral(" class=\"fa fa-info-circle\"");

WriteLiteral("></i>View the <a");

WriteAttribute("href", Tuple.Create(" href=\"", 3297), Tuple.Create("\"", 3347)
            
            #line 78 "..\..\Views\Job\LogRepair.cshtml"
    , Tuple.Create(Tuple.Create("", 3304), Tuple.Create<System.Object, System.Int32>(Url.Action(MVC.Config.Plugins.Install())
            
            #line default
            #line hidden
, 3304), false)
);

WriteLiteral(">Plugin Catalogue</a> to discover and install repair provider plugins.\r\n         " +
"                   </p>\r\n                        </div>\r\n");

            
            #line 81 "..\..\Views\Job\LogRepair.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                </td>\r\n            </tr>\r\n");

            
            #line 84 "..\..\Views\Job\LogRepair.cshtml"
            
            
            #line default
            #line hidden
            
            #line 84 "..\..\Views\Job\LogRepair.cshtml"
             if (Model.IsManualProvider)
            {

            
            #line default
            #line hidden
WriteLiteral("                <tr>\r\n                    <th>Provider Name:</th>\r\n              " +
"      <td>\r\n");

WriteLiteral("                        ");

            
            #line 89 "..\..\Views\Job\LogRepair.cshtml"
                   Write(Html.EditorFor(model => model.ManualProviderName));

            
            #line default
            #line hidden
WriteLiteral("<br />\r\n");

WriteLiteral("                        ");

            
            #line 90 "..\..\Views\Job\LogRepair.cshtml"
                   Write(Html.ValidationMessageFor(m => m.ManualProviderName));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");

WriteLiteral("                <tr>\r\n                    <th>Provider Job Reference:</th>\r\n     " +
"               <td>\r\n");

WriteLiteral("                        ");

            
            #line 96 "..\..\Views\Job\LogRepair.cshtml"
                   Write(Html.EditorFor(model => model.ManualProviderReference));

            
            #line default
            #line hidden
WriteLiteral("<br />\r\n");

WriteLiteral("                        ");

            
            #line 97 "..\..\Views\Job\LogRepair.cshtml"
                   Write(Html.ValidationMessageFor(m => m.ManualProviderReference));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");

            
            #line 100 "..\..\Views\Job\LogRepair.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </table>\r\n    </div>\r\n");

WriteLiteral("    <div");

WriteLiteral(" id=\"repairJobRepairDescription\"");

WriteLiteral(" class=\"form\"");

WriteLiteral(" style=\"width: 650px; margin-top: 15px;\"");

WriteLiteral(">\r\n        <h2>Repair Description</h2>\r\n        <table>\r\n            <tr>\r\n      " +
"          <td>\r\n");

WriteLiteral("                    ");

            
            #line 108 "..\..\Views\Job\LogRepair.cshtml"
               Write(Html.EditorFor(model => model.RepairDescription));

            
            #line default
            #line hidden
WriteLiteral("<br />\r\n");

WriteLiteral("                    ");

            
            #line 109 "..\..\Views\Job\LogRepair.cshtml"
               Write(Html.ValidationMessageFor(m => m.RepairDescription));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n            </tr>\r\n        </table>\r\n    </div>\r\n");

            
            #line 114 "..\..\Views\Job\LogRepair.cshtml"
            if (!Model.IsManualProvider && Authorization.Has(Claims.Job.ShowAttachments) && Model.Job.JobAttachments.Count > 0)
            {

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"form\"");

WriteLiteral(" style=\"width: 650px; margin-top: 15px;\"");

WriteLiteral(">\r\n        <h2>Send Attachments</h2>\r\n        <table>\r\n            <tr>\r\n        " +
"        <td>\r\n                    <div");

WriteLiteral(" id=\"publishJobAttachments\"");

WriteLiteral(">\r\n");

            
            #line 122 "..\..\Views\Job\LogRepair.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 122 "..\..\Views\Job\LogRepair.cshtml"
                         foreach (var ja in Model.Job.JobAttachments)
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 5175), Tuple.Create("\"", 5232)
            
            #line 124 "..\..\Views\Job\LogRepair.cshtml"
, Tuple.Create(Tuple.Create("", 5182), Tuple.Create<System.Object, System.Int32>(Url.Action(MVC.API.Job.AttachmentDownload(ja.Id))
            
            #line default
            #line hidden
, 5182), false)
);

WriteLiteral(" data-attachmentid=\"");

            
            #line 124 "..\..\Views\Job\LogRepair.cshtml"
                                                                                                       Write(ja.Id);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(" data-mimetype=\"");

            
            #line 124 "..\..\Views\Job\LogRepair.cshtml"
                                                                                                                              Write(ja.MimeType);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">\r\n                                <input");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" class=\"select\"");

WriteLiteral(" name=\"PublishAttachmentIds\"");

WriteAttribute("value", Tuple.Create(" value=\"", 5389), Tuple.Create("\"", 5403)
            
            #line 125 "..\..\Views\Job\LogRepair.cshtml"
                         , Tuple.Create(Tuple.Create("", 5397), Tuple.Create<System.Object, System.Int32>(ja.Id
            
            #line default
            #line hidden
, 5397), false)
);

WriteLiteral(" ");

            
            #line 125 "..\..\Views\Job\LogRepair.cshtml"
                                                                                                             Write(Model.PublishAttachmentIds.Contains(ja.Id) ? "checked" : null);

            
            #line default
            #line hidden
WriteLiteral(" />\r\n                                <span");

WriteLiteral(" class=\"icon\"");

WriteAttribute("title", Tuple.Create(" title=\"", 5524), Tuple.Create("\"", 5544)
            
            #line 126 "..\..\Views\Job\LogRepair.cshtml"
, Tuple.Create(Tuple.Create("", 5532), Tuple.Create<System.Object, System.Int32>(ja.Filename
            
            #line default
            #line hidden
, 5532), false)
);

WriteLiteral(">\r\n                                    <img");

WriteLiteral(" alt=\"Attachment Thumbnail\"");

WriteAttribute("src", Tuple.Create(" src=\"", 5615), Tuple.Create("\"", 5674)
            
            #line 127 "..\..\Views\Job\LogRepair.cshtml"
, Tuple.Create(Tuple.Create("", 5621), Tuple.Create<System.Object, System.Int32>(Url.Action(MVC.API.Job.AttachmentThumbnail(ja.Id))
            
            #line default
            #line hidden
, 5621), false)
);

WriteLiteral(" /></span>\r\n                                <span");

WriteLiteral(" class=\"comments\"");

WriteAttribute("title", Tuple.Create(" title=\"", 5741), Tuple.Create("\"", 5761)
            
            #line 128 "..\..\Views\Job\LogRepair.cshtml"
, Tuple.Create(Tuple.Create("", 5749), Tuple.Create<System.Object, System.Int32>(ja.Comments
            
            #line default
            #line hidden
, 5749), false)
);

WriteLiteral(">\r\n");

            
            #line 129 "..\..\Views\Job\LogRepair.cshtml"
                                    
            
            #line default
            #line hidden
            
            #line 129 "..\..\Views\Job\LogRepair.cshtml"
                                      if (!string.IsNullOrEmpty(ja.DocumentTemplateId))
                                      { 
            
            #line default
            #line hidden
            
            #line 130 "..\..\Views\Job\LogRepair.cshtml"
                                   Write(ja.DocumentTemplate.Description);

            
            #line default
            #line hidden
            
            #line 130 "..\..\Views\Job\LogRepair.cshtml"
                                                                        }
                                      else
                                      { 
            
            #line default
            #line hidden
            
            #line 132 "..\..\Views\Job\LogRepair.cshtml"
                                   Write(ja.Comments);

            
            #line default
            #line hidden
            
            #line 132 "..\..\Views\Job\LogRepair.cshtml"
                                                     }
            
            #line default
            #line hidden
WriteLiteral("\r\n                                </span><span");

WriteLiteral(" class=\"author\"");

WriteLiteral(">");

            
            #line 133 "..\..\Views\Job\LogRepair.cshtml"
                                                       Write(ja.TechUser.ToStringFriendly());

            
            #line default
            #line hidden
WriteLiteral("</span><span");

WriteLiteral(" class=\"timestamp\"");

WriteLiteral(" data-livestamp=\"");

            
            #line 133 "..\..\Views\Job\LogRepair.cshtml"
                                                                                                                                      Write(ja.Timestamp.ToUnixEpoc());

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteAttribute("title", Tuple.Create(" title=\"", 6197), Tuple.Create("\"", 6235)
            
            #line 133 "..\..\Views\Job\LogRepair.cshtml"
                                                                                               , Tuple.Create(Tuple.Create("", 6205), Tuple.Create<System.Object, System.Int32>(ja.Timestamp.ToFullDateTime()
            
            #line default
            #line hidden
, 6205), false)
);

WriteLiteral(">");

            
            #line 133 "..\..\Views\Job\LogRepair.cshtml"
                                                                                                                                                                                                          Write(ja.Timestamp.ToFullDateTime());

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                            </a>   \r\n");

            
            #line 135 "..\..\Views\Job\LogRepair.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </div>\r\n                </td>\r\n            </tr>\r\n        </t" +
"able>\r\n    </div>\r\n");

            
            #line 141 "..\..\Views\Job\LogRepair.cshtml"
            }
            if (Model.RepairProvider != null && Model.RepairProviderSubmitJobBeginResult != null)
            { 

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" id=\"repairJobProviderProperties\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 145 "..\..\Views\Job\LogRepair.cshtml"
   Write(Html.PartialCompiled(Model.RepairProviderSubmitJobBeginResult.Item1, Model.RepairProviderSubmitJobBeginResult.Item2));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n");

            
            #line 147 "..\..\Views\Job\LogRepair.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"actionBar\"");

WriteLiteral(">\r\n");

            
            #line 149 "..\..\Views\Job\LogRepair.cshtml"
        
            
            #line default
            #line hidden
            
            #line 149 "..\..\Views\Job\LogRepair.cshtml"
         if (Model.IsManualProvider)
        {

            
            #line default
            #line hidden
WriteLiteral("            <input");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"button\"");

WriteLiteral(" value=\"Save Repair Request\"");

WriteLiteral(" />\r\n");

            
            #line 152 "..\..\Views\Job\LogRepair.cshtml"
        }
        else
        {

            
            #line default
            #line hidden
WriteLiteral("            <input");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"button\"");

WriteLiteral(" value=\"Preview Repair Request\"");

WriteLiteral(" />\r\n");

            
            #line 156 "..\..\Views\Job\LogRepair.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n");

            
            #line 158 "..\..\Views\Job\LogRepair.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("<script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n    $(function () {\r\n        var $providerId = $(\'#RepairProviderId\');\r\n      " +
"  var $addressId = $(\'#OrganisationAddressId\');\r\n\r\n        function updateDetail" +
"s() {\r\n            $(\'<form>\').attr({\r\n                action: $providerId.close" +
"st(\'form\').attr(\'action\'),\r\n                method: \'post\'\r\n            }).appen" +
"d(\r\n                $(\'<input>\').attr({ type: \'hidden\', name: \'SubmissionAction\'" +
", value: \'Update\' })\r\n            ).append(\r\n                $(\'<input>\').attr({" +
" type: \'hidden\', name: \'JobId\', value: $(\'#JobId\').val() })\r\n            ).appen" +
"d(\r\n                $(\'<input>\').attr({ type: \'hidden\', name: \'RepairProviderId\'" +
", value: $providerId.val() })\r\n            ).append(\r\n                $(\'<input>" +
"\').attr({ type: \'hidden\', name: \'OrganisationAddressId\', value: $addressId.val()" +
" })\r\n            ).append(\r\n                $(\'<input>\').attr({ type: \'hidden\', " +
"name: \'RepairDescription\', value: $(\'#RepairDescription\').val() })\r\n            " +
").append(\r\n                $(\'<input>\').attr({ type: \'hidden\', name: \'ManualProv" +
"iderName\', value: $(\'#ManualProviderName\').val() })\r\n            ).append(\r\n    " +
"            $(\'<input>\').attr({ type: \'hidden\', name: \'ManualProviderReference\'," +
" value: $(\'#ManualProviderReference\').val() })\r\n            ).appendTo(\'body\').s" +
"ubmit();\r\n        }\r\n\r\n        $providerId.change(updateDetails);\r\n        $addr" +
"essId.change(updateDetails);\r\n\r\n        var manualProvider = $(\'#ManualProviderN" +
"ame\');\r\n        if (manualProvider.length > 0 && !manualProvider.val()) {\r\n     " +
"       manualProvider.focus();\r\n        } else {\r\n            $(\'#RepairDescript" +
"ion\').focus();\r\n        }\r\n    });\r\n</script>\r\n");

        }
    }
}
#pragma warning restore 1591