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

namespace Disco.Web.Views.Job.JobParts
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Job/JobParts/NonWarrantyFinance.cshtml")]
    public partial class NonWarrantyFinance : Disco.Services.Web.WebViewPage<Disco.Web.Models.Job.ShowModel>
    {
        public NonWarrantyFinance()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\Job\JobParts\NonWarrantyFinance.cshtml"
  
    Html.BundleDeferred("~/ClientScripts/Modules/Disco-PropertyChangeHelpers");

    Authorization.Require(Claims.Job.ShowNonWarrantyFinance);

            
            #line default
            #line hidden
WriteLiteral("\r\n<table");

WriteLiteral(" id=\"jobNonWarrantyFinance\"");

WriteLiteral(">\r\n    <tr>\r\n        <th");

WriteLiteral(" style=\"width: 200px;\"");

WriteLiteral(">Accounting Charge Required\r\n        </th>\r\n        <td>\r\n");

WriteLiteral("            ");

            
            #line 12 "..\..\Views\Job\JobParts\NonWarrantyFinance.cshtml"
       Write(CommonHelpers.FriendlyDate(Model.Job.JobMetaNonWarranty.AccountingChargeRequiredDate, "Not Required", "Job_JobMetaNonWarranty_AccountingChargeRequiredDate"));

            
            #line default
            #line hidden
WriteLiteral("\r\n            <span");

WriteLiteral(" id=\"Job_JobMetaNonWarranty_AccountingChargeRequiredUser\"");

WriteLiteral(">");

            
            #line 13 "..\..\Views\Job\JobParts\NonWarrantyFinance.cshtml"
                                                                       Write(string.IsNullOrEmpty(Model.Job.JobMetaNonWarranty.AccountingChargeRequiredUserId) ? string.Empty : string.Format("by {0}", Model.Job.JobMetaNonWarranty.AccountingChargeRequiredUser.ToString()));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n");

WriteLiteral("            ");

            
            #line 14 "..\..\Views\Job\JobParts\NonWarrantyFinance.cshtml"
       Write(AjaxHelpers.AjaxLoader());

            
            #line default
            #line hidden
WriteLiteral("\r\n        </td>\r\n    </tr>\r\n    <tr>\r\n        <th");

WriteLiteral(" style=\"width: 200px;\"");

WriteLiteral(">Accounting Charge Added\r\n        </th>\r\n        <td>\r\n");

WriteLiteral("            ");

            
            #line 21 "..\..\Views\Job\JobParts\NonWarrantyFinance.cshtml"
       Write(CommonHelpers.FriendlyDate(Model.Job.JobMetaNonWarranty.AccountingChargeAddedDate, "Not Added", "Job_JobMetaNonWarranty_AccountingChargeAddedDate"));

            
            #line default
            #line hidden
WriteLiteral("\r\n            <span");

WriteLiteral(" id=\"Job_JobMetaNonWarranty_AccountingChargeAddedUser\"");

WriteLiteral(">");

            
            #line 22 "..\..\Views\Job\JobParts\NonWarrantyFinance.cshtml"
                                                                    Write(string.IsNullOrEmpty(Model.Job.JobMetaNonWarranty.AccountingChargeAddedUserId) ? string.Empty : string.Format("by {0}", Model.Job.JobMetaNonWarranty.AccountingChargeAddedUser.ToString()));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n");

WriteLiteral("            ");

            
            #line 23 "..\..\Views\Job\JobParts\NonWarrantyFinance.cshtml"
       Write(AjaxHelpers.AjaxLoader());

            
            #line default
            #line hidden
WriteLiteral("\r\n        </td>\r\n    </tr>\r\n    <tr>\r\n        <th");

WriteLiteral(" style=\"width: 200px;\"");

WriteLiteral(">Accounting Charge Paid\r\n        </th>\r\n        <td>\r\n");

WriteLiteral("            ");

            
            #line 30 "..\..\Views\Job\JobParts\NonWarrantyFinance.cshtml"
       Write(CommonHelpers.FriendlyDate(Model.Job.JobMetaNonWarranty.AccountingChargePaidDate, "Not Paid", "Job_JobMetaNonWarranty_AccountingChargePaidDate"));

            
            #line default
            #line hidden
WriteLiteral("\r\n            <span");

WriteLiteral(" id=\"Job_JobMetaNonWarranty_AccountingChargePaidUser\"");

WriteLiteral(">");

            
            #line 31 "..\..\Views\Job\JobParts\NonWarrantyFinance.cshtml"
                                                                   Write(string.IsNullOrEmpty(Model.Job.JobMetaNonWarranty.AccountingChargePaidUserId) ? string.Empty : string.Format("by {0}", Model.Job.JobMetaNonWarranty.AccountingChargePaidUser.ToString()));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n");

WriteLiteral("            ");

            
            #line 32 "..\..\Views\Job\JobParts\NonWarrantyFinance.cshtml"
       Write(AjaxHelpers.AjaxLoader());

            
            #line default
            #line hidden
WriteLiteral("\r\n        </td>\r\n    </tr>\r\n    <tr>\r\n        <th");

WriteLiteral(" style=\"width: 200px;\"");

WriteLiteral(">Purchase Order Raised\r\n        </th>\r\n        <td>\r\n");

WriteLiteral("            ");

            
            #line 39 "..\..\Views\Job\JobParts\NonWarrantyFinance.cshtml"
       Write(CommonHelpers.FriendlyDate(Model.Job.JobMetaNonWarranty.PurchaseOrderRaisedDate, "Not Raised", "Job_JobMetaNonWarranty_PurchaseOrderRaisedDate"));

            
            #line default
            #line hidden
WriteLiteral("\r\n            <span");

WriteLiteral(" id=\"Job_JobMetaNonWarranty_PurchaseOrderRaisedUser\"");

WriteLiteral(">");

            
            #line 40 "..\..\Views\Job\JobParts\NonWarrantyFinance.cshtml"
                                                                  Write(string.IsNullOrEmpty(Model.Job.JobMetaNonWarranty.PurchaseOrderRaisedUserId) ? string.Empty : string.Format("by {0}", Model.Job.JobMetaNonWarranty.PurchaseOrderRaisedUser.ToString()));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n");

WriteLiteral("            ");

            
            #line 41 "..\..\Views\Job\JobParts\NonWarrantyFinance.cshtml"
       Write(AjaxHelpers.AjaxLoader());

            
            #line default
            #line hidden
WriteLiteral("\r\n        </td>\r\n    </tr>\r\n    <tr>\r\n        <th>Purchase Order Reference\r\n     " +
"   </th>\r\n        <td>\r\n");

            
            #line 48 "..\..\Views\Job\JobParts\NonWarrantyFinance.cshtml"
            
            
            #line default
            #line hidden
            
            #line 48 "..\..\Views\Job\JobParts\NonWarrantyFinance.cshtml"
             if (Authorization.Has(Claims.Job.Properties.NonWarrantyProperties.PurchaseOrderReference))
            {
                
            
            #line default
            #line hidden
            
            #line 50 "..\..\Views\Job\JobParts\NonWarrantyFinance.cshtml"
           Write(Html.TextBoxFor(m => m.Job.JobMetaNonWarranty.PurchaseOrderReference));

            
            #line default
            #line hidden
            
            #line 50 "..\..\Views\Job\JobParts\NonWarrantyFinance.cshtml"
                                                                                      
                
            
            #line default
            #line hidden
            
            #line 51 "..\..\Views\Job\JobParts\NonWarrantyFinance.cshtml"
           Write(AjaxHelpers.AjaxSave());

            
            #line default
            #line hidden
            
            #line 51 "..\..\Views\Job\JobParts\NonWarrantyFinance.cshtml"
                                       
                
            
            #line default
            #line hidden
            
            #line 52 "..\..\Views\Job\JobParts\NonWarrantyFinance.cshtml"
           Write(AjaxHelpers.AjaxLoader());

            
            #line default
            #line hidden
            
            #line 52 "..\..\Views\Job\JobParts\NonWarrantyFinance.cshtml"
                                         

            
            #line default
            #line hidden
WriteLiteral("                <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(@">
                    $(function () {
                        var $purchaseOrderReference = $('#Job_JobMetaNonWarranty_PurchaseOrderReference');
                        var $ajaxSave = $purchaseOrderReference.next('.ajaxSave');
                        $purchaseOrderReference
                        .watermark('No Reference')
                        .focus(function () { $purchaseOrderReference.select() })
                        .keydown(function (e) {
                            $ajaxSave.show();
                            if (e.which == 13) {
                                $(this).blur();
                            }
                        }).blur(function () {
                            $ajaxSave.hide();
                        })
                        .change(function () {
                            $ajaxSave.hide();
                            $ajaxLoading = $ajaxSave.next('.ajaxLoading').show();
                            var data = { PurchaseOrderReference: $purchaseOrderReference.val() };
                            $.ajax({
                                url: '");

            
            #line 73 "..\..\Views\Job\JobParts\NonWarrantyFinance.cshtml"
                                 Write(Url.Action(MVC.API.Job.UpdateNonWarrantyPurchaseOrderReference(Model.Job.Id, null)));

            
            #line default
            #line hidden
WriteLiteral(@"',
                                dataType: 'json',
                                data: data,
                                success: function (d) {
                                    if (d == 'OK') {
                                        $ajaxLoading.hide().next('.ajaxOk').show().delay('fast').fadeOut('slow');
                                    } else {
                                        $ajaxLoading.hide();
                                        alert('Unable to update purchase order reference: ' + d);
                                    }
                                },
                                error: function (jqXHR, textStatus, errorThrown) {
                                    alert('Unable to update purchase order reference: ' + textStatus);
                                    $ajaxLoading.hide();
                                }
                            });
                        });
                    });
                </script>
");

            
            #line 92 "..\..\Views\Job\JobParts\NonWarrantyFinance.cshtml"
            }
            else
            {
                if (string.IsNullOrWhiteSpace(Model.Job.JobMetaNonWarranty.PurchaseOrderReference))
                {

            
            #line default
            #line hidden
WriteLiteral("                <span");

WriteLiteral(" class=\"smallMessage\"");

WriteLiteral(">&lt;Unknown/None&gt;</span>\r\n");

            
            #line 98 "..\..\Views\Job\JobParts\NonWarrantyFinance.cshtml"
                }
                else
                {
                
            
            #line default
            #line hidden
            
            #line 101 "..\..\Views\Job\JobParts\NonWarrantyFinance.cshtml"
           Write(Model.Job.JobMetaNonWarranty.PurchaseOrderReference);

            
            #line default
            #line hidden
            
            #line 101 "..\..\Views\Job\JobParts\NonWarrantyFinance.cshtml"
                                                                    
                }
            }

            
            #line default
            #line hidden
WriteLiteral("        </td>\r\n    </tr>\r\n    <tr>\r\n        <th");

WriteLiteral(" style=\"width: 200px;\"");

WriteLiteral(">Purchase Order Sent\r\n        </th>\r\n        <td>\r\n");

WriteLiteral("            ");

            
            #line 110 "..\..\Views\Job\JobParts\NonWarrantyFinance.cshtml"
       Write(CommonHelpers.FriendlyDate(Model.Job.JobMetaNonWarranty.PurchaseOrderSentDate, "Not Sent", "Job_JobMetaNonWarranty_PurchaseOrderSentDate"));

            
            #line default
            #line hidden
WriteLiteral("\r\n            <span");

WriteLiteral(" id=\"Job_JobMetaNonWarranty_PurchaseOrderSentUser\"");

WriteLiteral(">");

            
            #line 111 "..\..\Views\Job\JobParts\NonWarrantyFinance.cshtml"
                                                                Write(string.IsNullOrEmpty(Model.Job.JobMetaNonWarranty.PurchaseOrderSentUserId) ? string.Empty : string.Format("by {0}", Model.Job.JobMetaNonWarranty.PurchaseOrderSentUser.ToString()));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n");

WriteLiteral("            ");

            
            #line 112 "..\..\Views\Job\JobParts\NonWarrantyFinance.cshtml"
       Write(AjaxHelpers.AjaxLoader());

            
            #line default
            #line hidden
WriteLiteral("\r\n        </td>\r\n    </tr>\r\n    <tr>\r\n        <th");

WriteLiteral(" style=\"width: 200px;\"");

WriteLiteral(">Invoice Received\r\n        </th>\r\n        <td>\r\n");

WriteLiteral("            ");

            
            #line 119 "..\..\Views\Job\JobParts\NonWarrantyFinance.cshtml"
       Write(CommonHelpers.FriendlyDate(Model.Job.JobMetaNonWarranty.InvoiceReceivedDate, "Not Received", "Job_JobMetaNonWarranty_InvoiceReceivedDate"));

            
            #line default
            #line hidden
WriteLiteral("\r\n            <span");

WriteLiteral(" id=\"Job_JobMetaNonWarranty_InvoiceReceivedUser\"");

WriteLiteral(">");

            
            #line 120 "..\..\Views\Job\JobParts\NonWarrantyFinance.cshtml"
                                                              Write(string.IsNullOrEmpty(Model.Job.JobMetaNonWarranty.InvoiceReceivedUserId) ? string.Empty : string.Format("by {0}", Model.Job.JobMetaNonWarranty.InvoiceReceivedUser.ToString()));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n");

WriteLiteral("            ");

            
            #line 121 "..\..\Views\Job\JobParts\NonWarrantyFinance.cshtml"
       Write(AjaxHelpers.AjaxLoader());

            
            #line default
            #line hidden
WriteLiteral("\r\n        </td>\r\n    </tr>\r\n</table>\r\n<script>\r\n    $(function () {\r\n        var " +
"updateUrl = \'");

            
            #line 127 "..\..\Views\Job\JobParts\NonWarrantyFinance.cshtml"
                     Write(Url.Action(MVC.API.Job.Update(Model.Job.Id, null)));

            
            #line default
            #line hidden
WriteLiteral("\';\r\n        var jobOpenDate = \'");

            
            #line 128 "..\..\Views\Job\JobParts\NonWarrantyFinance.cshtml"
                       Write(Model.Job.OpenedDate.ToISO8601());

            
            #line default
            #line hidden
WriteLiteral("\';\r\n\r\n");

            
            #line 130 "..\..\Views\Job\JobParts\NonWarrantyFinance.cshtml"
        
            
            #line default
            #line hidden
            
            #line 130 "..\..\Views\Job\JobParts\NonWarrantyFinance.cshtml"
         if (Authorization.Has(Claims.Job.Properties.NonWarrantyProperties.AccountingChargeRequired))
        {
            
            #line default
            #line hidden
WriteLiteral(@"document.DiscoFunctions.DateDialogCreateUpdater(updateUrl, 'Accounting Charge Required', 'Job_JobMetaNonWarranty_AccountingChargeRequiredDate', 'Job_JobMetaNonWarranty_AccountingChargeRequiredUser', 'NonWarrantyAccountingChargeRequired', 'Not Required', jobOpenDate, false);");

            
            #line 131 "..\..\Views\Job\JobParts\NonWarrantyFinance.cshtml"
                                                                                                                                                                                                                                                                                                        }

            
            #line default
            #line hidden
WriteLiteral("        ");

            
            #line 132 "..\..\Views\Job\JobParts\NonWarrantyFinance.cshtml"
         if (Authorization.Has(Claims.Job.Properties.NonWarrantyProperties.AccountingChargeAdded))
        {
            
            #line default
            #line hidden
WriteLiteral(@"document.DiscoFunctions.DateDialogCreateUpdater(updateUrl, 'Accounting Charge Added', 'Job_JobMetaNonWarranty_AccountingChargeAddedDate', 'Job_JobMetaNonWarranty_AccountingChargeAddedUser', 'NonWarrantyAccountingChargeAdded', 'Not Added', jobOpenDate, false);");

            
            #line 133 "..\..\Views\Job\JobParts\NonWarrantyFinance.cshtml"
                                                                                                                                                                                                                                                                                         }

            
            #line default
            #line hidden
WriteLiteral("        ");

            
            #line 134 "..\..\Views\Job\JobParts\NonWarrantyFinance.cshtml"
         if (Authorization.Has(Claims.Job.Properties.NonWarrantyProperties.AccountingChargePaid))
        {
            
            #line default
            #line hidden
WriteLiteral("document.DiscoFunctions.DateDialogCreateUpdater(updateUrl, \'Accounting Charge Pai" +
"d\', \'Job_JobMetaNonWarranty_AccountingChargePaidDate\', \'Job_JobMetaNonWarranty_A" +
"ccountingChargePaidUser\', \'NonWarrantyAccountingChargePaid\', \'Not Paid\', jobOpen" +
"Date, false);");

            
            #line 135 "..\..\Views\Job\JobParts\NonWarrantyFinance.cshtml"
                                                                                                                                                                                                                                                                                    }

            
            #line default
            #line hidden
WriteLiteral("        ");

            
            #line 136 "..\..\Views\Job\JobParts\NonWarrantyFinance.cshtml"
         if (Authorization.Has(Claims.Job.Properties.NonWarrantyProperties.PurchaseOrderRaised))
        {
            
            #line default
            #line hidden
WriteLiteral("document.DiscoFunctions.DateDialogCreateUpdater(updateUrl, \'Purchase Order Raised" +
"\', \'Job_JobMetaNonWarranty_PurchaseOrderRaisedDate\', \'Job_JobMetaNonWarranty_Pur" +
"chaseOrderRaisedUser\', \'NonWarrantyPurchaseOrderRaised\', \'Not Raised\', jobOpenDa" +
"te, true);");

            
            #line 137 "..\..\Views\Job\JobParts\NonWarrantyFinance.cshtml"
                                                                                                                                                                                                                                                                                 }

            
            #line default
            #line hidden
WriteLiteral("        ");

            
            #line 138 "..\..\Views\Job\JobParts\NonWarrantyFinance.cshtml"
         if (Authorization.Has(Claims.Job.Properties.NonWarrantyProperties.PurchaseOrderSent))
        {
            
            #line default
            #line hidden
WriteLiteral("document.DiscoFunctions.DateDialogCreateUpdater(updateUrl, \'Purchase Order Sent\'," +
" \'Job_JobMetaNonWarranty_PurchaseOrderSentDate\', \'Job_JobMetaNonWarranty_Purchas" +
"eOrderSentUser\', \'NonWarrantyPurchaseOrderSent\', \'Not Sent\', jobOpenDate, true);" +
"");

            
            #line 139 "..\..\Views\Job\JobParts\NonWarrantyFinance.cshtml"
                                                                                                                                                                                                                                                                       }

            
            #line default
            #line hidden
WriteLiteral("        ");

            
            #line 140 "..\..\Views\Job\JobParts\NonWarrantyFinance.cshtml"
         if (Authorization.Has(Claims.Job.Properties.NonWarrantyProperties.InvoiceReceived))
        {
            
            #line default
            #line hidden
WriteLiteral("document.DiscoFunctions.DateDialogCreateUpdater(updateUrl, \'Invoice Received\', \'J" +
"ob_JobMetaNonWarranty_InvoiceReceivedDate\', \'Job_JobMetaNonWarranty_InvoiceRecei" +
"vedUser\', \'NonWarrantyInvoiceReceived\', \'Not Received\', jobOpenDate, true);");

            
            #line 141 "..\..\Views\Job\JobParts\NonWarrantyFinance.cshtml"
                                                                                                                                                                                                                                                                  }

            
            #line default
            #line hidden
WriteLiteral("    });\r\n</script>\r\n");

        }
    }
}
#pragma warning restore 1591
