﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
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
    using Disco.BI.Extensions;
    using Disco.Models.Repository;
    using Disco.Web;
    using Disco.Web.Extensions;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.5.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Job/Create.cshtml")]
    public class Create : System.Web.Mvc.WebViewPage<Disco.Web.Models.Job.CreateModel>
    {
        public Create()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\Job\Create.cshtml"
  
    Layout = "~/Views/Shared/_DialogLayout.cshtml";
    ViewBag.Title = Html.ToBreadcrumb("Jobs", MVC.Job.Index(), "Create");

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" id=\"createJob_Container\"");

WriteLiteral(">\r\n");

            
            #line 7 "..\..\Views\Job\Create.cshtml"
    
            
            #line default
            #line hidden
            
            #line 7 "..\..\Views\Job\Create.cshtml"
     using (Html.BeginForm(MVC.Job.Create(), FormMethod.Post))
    {
        
            
            #line default
            #line hidden
            
            #line 9 "..\..\Views\Job\Create.cshtml"
   Write(Html.HiddenFor(m => m.DeviceSerialNumber));

            
            #line default
            #line hidden
            
            #line 9 "..\..\Views\Job\Create.cshtml"
                                                  
        
            
            #line default
            #line hidden
            
            #line 10 "..\..\Views\Job\Create.cshtml"
   Write(Html.HiddenFor(m => m.UserId));

            
            #line default
            #line hidden
            
            #line 10 "..\..\Views\Job\Create.cshtml"
                                      
        
            
            #line default
            #line hidden
            
            #line 11 "..\..\Views\Job\Create.cshtml"
   Write(Html.HiddenFor(m => m.QuickLogDestinationUrl));

            
            #line default
            #line hidden
            
            #line 11 "..\..\Views\Job\Create.cshtml"
                                                      
    
        
            
            #line default
            #line hidden
            
            #line 13 "..\..\Views\Job\Create.cshtml"
   Write(Html.Partial(MVC.Job.Views._CreateSubject, Model));

            
            #line default
            #line hidden
            
            #line 13 "..\..\Views\Job\Create.cshtml"
                                                          
        
            
            #line default
            #line hidden
            
            #line 14 "..\..\Views\Job\Create.cshtml"
   Write(Html.ValidationSummary(true));

            
            #line default
            #line hidden
            
            #line 14 "..\..\Views\Job\Create.cshtml"
                                     
        

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"createJob_Component\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" id=\"createJob_Type\"");

WriteLiteral(">\r\n                <h3>Type</h3>\r\n");

WriteLiteral("                ");

            
            #line 19 "..\..\Views\Job\Create.cshtml"
           Write(Html.ValidationMessageFor(m => m.Type));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 20 "..\..\Views\Job\Create.cshtml"
           Write(CommonHelpers.RadioButtonList("Type", Model.JobTypes.ToSelectListItems(Model.Type), 3));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 21 "..\..\Views\Job\Create.cshtml"
           Write(Html.ValidationMessageFor(m => m.SubTypes));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n            <div");

WriteLiteral(" id=\"createJob_SubTypes\"");

WriteLiteral(">\r\n");

            
            #line 24 "..\..\Views\Job\Create.cshtml"
                
            
            #line default
            #line hidden
            
            #line 24 "..\..\Views\Job\Create.cshtml"
                 foreach (var jt in Model.JobTypes)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <div");

WriteAttribute("id", Tuple.Create(" id=\"", 1037), Tuple.Create("\"", 1068)
, Tuple.Create(Tuple.Create("", 1042), Tuple.Create("createJob_SubType_", 1042), true)
            
            #line 26 "..\..\Views\Job\Create.cshtml"
, Tuple.Create(Tuple.Create("", 1060), Tuple.Create<System.Object, System.Int32>(jt.Id
            
            #line default
            #line hidden
, 1060), false)
);

WriteLiteral(" class=\"createJob_SubType\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"createJob_SubTypes\"");

WriteLiteral(">\r\n");

WriteLiteral("                            ");

            
            #line 28 "..\..\Views\Job\Create.cshtml"
                       Write(CommonHelpers.CheckBoxList("SubTypes", Model.JobSubTypes.Where(jst => jst.JobTypeId == jt.Id).ToList().ToSelectListItems(Model.SubTypes), 3));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </div>\r\n                    </div>   \r\n");

            
            #line 31 "..\..\Views\Job\Create.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </div>\r\n        </div>\r\n");

WriteLiteral("        <div");

WriteLiteral(" id=\"createJob_DeviceHeldContainer\"");

WriteLiteral(" class=\"createJob_Component\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 35 "..\..\Views\Job\Create.cshtml"
       Write(Html.ValidationMessageFor(m => m.DeviceHeld));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 36 "..\..\Views\Job\Create.cshtml"
       Write(Html.HiddenFor(m => m.DeviceHeld));

            
            #line default
            #line hidden
WriteLiteral("\r\n            <table>\r\n                <tr>\r\n                    <td>\r\n          " +
"              <h3>Device Held</h3>\r\n                    </td>\r\n                 " +
"   <td>\r\n                        <input");

WriteLiteral(" id=\"createJob_DeviceHeld\"");

WriteLiteral(" name=\"_DeviceHeld\"");

WriteLiteral(" type=\"radio\"");

WriteLiteral(" value=\"true\"");

WriteLiteral(" /><label");

WriteLiteral(" for=\"createJob_DeviceHeld\"");

WriteLiteral(">Held</label>\r\n                    </td>\r\n                    <td>\r\n             " +
"           <input");

WriteLiteral(" id=\"createJob_DeviceNotHeld\"");

WriteLiteral(" name=\"_DeviceHeld\"");

WriteLiteral(" type=\"radio\"");

WriteLiteral(" value=\"false\"");

WriteLiteral(" /><label");

WriteLiteral(" for=\"createJob_DeviceNotHeld\"");

WriteLiteral(">Not Held</label>\r\n                    </td>\r\n                </tr>\r\n            " +
"</table>\r\n        </div>\r\n");

WriteLiteral("        <div");

WriteLiteral(" id=\"createJob_CommentsContainer\"");

WriteLiteral(" class=\"createJob_Component\"");

WriteLiteral(">\r\n            <table>\r\n                <tr>\r\n                    <td>\r\n         " +
"               <h3>Comments</h3>\r\n                    </td>\r\n                   " +
" <td>\r\n");

WriteLiteral("                        ");

            
            #line 58 "..\..\Views\Job\Create.cshtml"
                   Write(Html.EditorFor(m => m.Comments));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n            </table>\r\n       " +
" </div>\r\n");

WriteLiteral("        <div");

WriteLiteral(" id=\"createJob_QuickLogContainer\"");

WriteLiteral(" class=\"createJob_Component\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" id=\"createJob_QuickLogAutoCloseContainer\"");

WriteLiteral(">\r\n                <h3>Quick Log</h3>\r\n                <input");

WriteLiteral(" id=\"createJob_QuickLog\"");

WriteLiteral(" name=\"QuickLog\"");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" value=\"true\"");

WriteLiteral(" /><label");

WriteLiteral(" for=\"createJob_QuickLog\"");

WriteLiteral(">Automatically close this job</label>\r\n            </div>\r\n            <div");

WriteLiteral(" id=\"createJob_QuickLogTaskTimeContainer\"");

WriteLiteral(">\r\n                <h3>Task Time</h3>\r\n");

WriteLiteral("                ");

            
            #line 70 "..\..\Views\Job\Create.cshtml"
           Write(Html.ValidationMessageFor(m => m.QuickLogTaskTimeMinutes));

            
            #line default
            #line hidden
WriteLiteral("\r\n                <input");

WriteLiteral(" type=\"radio\"");

WriteLiteral(" id=\"createJob_TaskTime10\"");

WriteLiteral(" name=\"QuickLogTaskTimeMinutes\"");

WriteLiteral(" value=\"10\"");

WriteLiteral(" /><label");

WriteLiteral(" for=\"createJob_TaskTime10\"");

WriteLiteral("> 10 Minutes</label>\r\n                <input");

WriteLiteral(" type=\"radio\"");

WriteLiteral(" id=\"createJob_TaskTime30\"");

WriteLiteral(" name=\"QuickLogTaskTimeMinutes\"");

WriteLiteral(" value=\"30\"");

WriteLiteral(" /><label");

WriteLiteral(" for=\"createJob_TaskTime30\"");

WriteLiteral("> 30 Minutes</label>\r\n                <input");

WriteLiteral(" type=\"radio\"");

WriteLiteral(" id=\"createJob_TaskTime60\"");

WriteLiteral(" name=\"QuickLogTaskTimeMinutes\"");

WriteLiteral(" value=\"60\"");

WriteLiteral(" /><label");

WriteLiteral(" for=\"createJob_TaskTime60\"");

WriteLiteral("> 1 Hour</label>\r\n                <input");

WriteLiteral(" type=\"radio\"");

WriteLiteral(" id=\"createJob_TaskTime120\"");

WriteLiteral(" name=\"QuickLogTaskTimeMinutes\"");

WriteLiteral(" value=\"120\"");

WriteLiteral(" /><label");

WriteLiteral(" for=\"createJob_TaskTime120\"");

WriteLiteral("> 2 Hours</label>\r\n                <input");

WriteLiteral(" type=\"radio\"");

WriteLiteral(" id=\"createJob_TaskTimeOther\"");

WriteLiteral(" name=\"QuickLogTaskTimeMinutes\"");

WriteLiteral(" value=\"\"");

WriteLiteral(" /><label");

WriteLiteral(" for=\"createJob_TaskTimeOther\"");

WriteLiteral("> Other</label>\r\n                <span");

WriteLiteral(" id=\"createJob_TaskTimeOtherMinutesContainer\"");

WriteLiteral(">\r\n                    <input");

WriteLiteral(" type=\"number\"");

WriteLiteral(" id=\"createJob_TaskTimeOtherMinutes\"");

WriteLiteral(" name=\"QuickLogTaskTimeMinutesOther\"");

WriteLiteral(" value=\"\"");

WriteLiteral(" disabled=\"disabled\"");

WriteLiteral(" />\r\n                    Minutes\r\n                </span>\r\n            </div>\r\n  " +
"      </div>\r\n");

            
            #line 82 "..\..\Views\Job\Create.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n        $(function () {\r\n            var discoDialogMethods;\r\n            var " +
"init = true;\r\n            //#region Parent Dialog\r\n            if (window.parent" +
" && window.parent.document) {\r\n                $(\'#QuickLogDestinationUrl\').val(" +
"window.parent.window.location.href);\r\n\r\n                var parentDialog = $(\'#c" +
"reateJobDialog\', window.parent.document);\r\n                if (parentDialog.leng" +
"th > 0) {\r\n                    discoDialogMethods = parentDialog[0].discoDialogM" +
"ethods;\r\n                    var buttons = {\r\n                        \"Create Jo" +
"b\": function () {\r\n                            createJobForm.submit()\r\n         " +
"               },\r\n                        Cancel: function () {\r\n              " +
"              discoDialogMethods.close();\r\n                        }\r\n          " +
"          }\r\n\r\n                    discoDialogMethods.setButtons(buttons);\r\n    " +
"            }\r\n            }\r\n            //#endregion\r\n\r\n\r\n            var crea" +
"teJobForm = $(\'form\');\r\n            var validator = createJobForm.data(\'validato" +
"r\');\r\n            var unobtrusiveValidation = createJobForm.data(\'unobtrusiveVal" +
"idation\');\r\n\r\n            // Validate all Fields\r\n            validator.settings" +
".ignore = \'\';\r\n\r\n            //#region Job Type/SubTypes\r\n            var $jobTy" +
"peContainer = $(\'#createJob_Type\');\r\n            var $typeValidationMessage = $(" +
"\'[data-valmsg-for=\"Type\"]\', $jobTypeContainer)\r\n            var $subTypesValidat" +
"ionMessage = $(\'[data-valmsg-for=\"SubTypes\"]\', $jobTypeContainer)\r\n            v" +
"ar $jobTypes = $jobTypeContainer.find(\'input[type=\"radio\"]\').change(jobTypeChang" +
"e);\r\n            $(\'#createJob_SubTypes\').find(\'input[type=\"checkbox\"]\').change(" +
"jobSubTypeHighlight).each(jobSubTypeHighlight);\r\n            jobTypeChange();\r\n " +
"           function jobSubTypeHighlight() {\r\n                var $this = $(this)" +
";\r\n                if ($this.is(\':checked\'))\r\n                    $this.closest(" +
"\'li\').addClass(\'highlight\');\r\n                else\r\n                    $this.cl" +
"osest(\'li\').removeClass(\'highlight\');\r\n            }\r\n            function jobTy" +
"peChange() {\r\n                var $checkedItem = $jobTypes.filter(\':checked\');\r\n" +
"\r\n                $jobTypes.closest(\'li\').removeClass(\'highlight\');\r\n\r\n         " +
"       $checkedItem.closest(\'li\').addClass(\'highlight\');\r\n\r\n                if (" +
"init) {\r\n                    var jobType = $checkedItem.val();\r\n                " +
"    $(\'#createJob_SubType_\' + jobType).show();\r\n                } else {\r\n      " +
"              $(\'#createJob_SubTypes\').find(\'.createJob_SubType:visible\').slideU" +
"p();\r\n                    var jobType = $checkedItem.val();\r\n                   " +
" $(\'#createJob_SubType_\' + jobType).slideDown();\r\n                }\r\n           " +
" }\r\n\r\n\r\n            var additionalValidation = function (form) {\r\n              " +
"  var isValid = true;\r\n\r\n                // Validate Type\r\n                var t" +
"ypeValue = $jobTypes.filter(\':checked\').val();\r\n                if (typeValue) {" +
"\r\n                    $typeValidationMessage.removeClass(\'field-validation-error" +
"\').addClass(\'field-validation-valid\');\r\n                    // Validate SubTypes" +
"\r\n                    if ($(\'#createJob_SubType_\' + typeValue).find(\'input:check" +
"ed\').length > 0) {\r\n                        $subTypesValidationMessage.removeCla" +
"ss(\'field-validation-error\').addClass(\'field-validation-valid\');\r\n              " +
"      } else {\r\n                        $subTypesValidationMessage.text(\'At leas" +
"t one Job Sub Type is required\').removeClass(\'field-validation-valid\').addClass(" +
"\'field-validation-error\');\r\n                        isValid = false;\r\n          " +
"          }\r\n                } else {\r\n                    $typeValidationMessag" +
"e.text(\'A Job Type is required\').removeClass(\'field-validation-valid\').addClass(" +
"\'field-validation-error\');\r\n                    isValid = false;\r\n              " +
"  }\r\n\r\n                // Validate QuickLog Task Time\r\n                if ($quic" +
"kLog.is(\':checked\')) {\r\n                    var selectedTime = $quickLogTaskTime" +
"s.filter(\':checked\');\r\n                    if (selectedTime.length > 0) {\r\n     " +
"                   if (selectedTime.val() === \'\') {\r\n                           " +
" // Handle \'Other\'\r\n                            var otherTime = parseInt($quickL" +
"ogTaskTimeOtherMinutes.val());\r\n                            if (!otherTime || ot" +
"herTime <= 0) {\r\n                                $quickLogTaskTimeValidationMess" +
"age.text(\'A Task Time is required\').removeClass(\'field-validation-valid\').addCla" +
"ss(\'field-validation-error\');\r\n                                isValid = false;\r" +
"\n                            }\r\n                        } else {\r\n              " +
"              $quickLogTaskTimeValidationMessage.removeClass(\'field-validation-v" +
"alid\').addClass(\'field-validation-error\');\r\n                        }\r\n         " +
"           } else {\r\n                        $quickLogTaskTimeValidationMessage." +
"text(\'A Task Time is required\').removeClass(\'field-validation-valid\').addClass(\'" +
"field-validation-error\');\r\n                        isValid = false;\r\n           " +
"         }\r\n                } else {\r\n                    $quickLogTaskTimeValid" +
"ationMessage.removeClass(\'field-validation-valid\').addClass(\'field-validation-er" +
"ror\');\r\n                }\r\n\r\n                return isValid;\r\n            }\r\n\r\n " +
"           validator.settings.submitHandler = function (form) {\r\n               " +
" if (additionalValidation()) {\r\n                    discoDialogMethods.setButton" +
"s({});\r\n                    form.submit();\r\n                }\r\n            }\r\n  " +
"          //#endregion\r\n\r\n            //#region DeviceHeld\r\n            var $dev" +
"iceHeld = $(\'#DeviceHeld\');\r\n\r\n            if ($(\'#DeviceSerialNumber\').val()) {" +
"\r\n                switch ($deviceHeld.val()) {\r\n                    case \'True\':" +
"\r\n                        $(\'#createJob_DeviceHeld\').prop(\'checked\', true);\r\n   " +
"                     $(\'#createJob_DeviceNotHeld\').prop(\'checked\', false);\r\n    " +
"                    break;\r\n                    case \'False\':\r\n                 " +
"       $(\'#createJob_DeviceHeld\').prop(\'checked\', false);\r\n                     " +
"   $(\'#createJob_DeviceNotHeld\').prop(\'checked\', true);\r\n                       " +
" break;\r\n                    default:\r\n                        $(\'#createJob_Dev" +
"iceHeld\').prop(\'checked\', false);\r\n                        $(\'#createJob_DeviceN" +
"otHeld\').prop(\'checked\', false);\r\n                        break;\r\n              " +
"  }\r\n                $(\'#createJob_DeviceHeldContainer\').find(\'input[type=\"radio" +
"\"]\').change(function () {\r\n                    // Update Hidden Field with Boole" +
"an Value\r\n                    // Set DeviceHeld\r\n                    var deviceH" +
"eldValue = \'\';\r\n                    if ($(\'#createJob_DeviceHeld\').is(\':checked\'" +
"))\r\n                        deviceHeldValue = \'True\';\r\n                    if ($" +
"(\'#createJob_DeviceNotHeld\').is(\':checked\'))\r\n                        deviceHeld" +
"Value = \'False\';\r\n                    $deviceHeld.val(deviceHeldValue).change();" +
"\r\n                });\r\n            } else {\r\n                // No Device Associ" +
"ated\r\n                $deviceHeld.val(\'False\');\r\n                $(\'#createJob_D" +
"eviceHeldContainer\').hide();\r\n            }\r\n            //#endregion\r\n\r\n       " +
"     //#region QuickLog\r\n            var $quickLog = $(\'#createJob_QuickLog\');\r\n" +
"            var $quickLogContainer = $(\'#createJob_QuickLogContainer\');\r\n       " +
"     var $quickLogTaskTimeContainer = $(\'#createJob_QuickLogTaskTimeContainer\');" +
"\r\n            var $quickLogTaskTimes = $quickLogTaskTimeContainer.find(\'input[ty" +
"pe=\"radio\"]\');\r\n            var $quickLogTaskTimeOtherMinutes = $(\'#createJob_Ta" +
"skTimeOtherMinutes\');\r\n            var $quickLogTaskTimeValidationMessage = $qui" +
"ckLogTaskTimeContainer.find(\'[data-valmsg-for=\"QuickLogTaskTimeMinutes\"]\');\r\n\r\n " +
"           $deviceHeld.change(validateQuickLog);\r\n            $jobTypes.change(v" +
"alidateQuickLog);\r\n            validateQuickLog();\r\n\r\n            function valid" +
"ateQuickLog() {\r\n                var quickLogAllowed = false;\r\n\r\n               " +
" if ($deviceHeld.val() === \'True\') {\r\n                    quickLogAllowed = fals" +
"e;\r\n                } else {\r\n                    var selectedType = $jobTypes.f" +
"ilter(\':checked\').val();\r\n                    switch (selectedType) {\r\n         " +
"               case \'HMisc\':\r\n                        case \'SApp\':\r\n            " +
"            case \'SImg\':\r\n                        case \'SOS\':\r\n                 " +
"       case \'UMgmt\':\r\n                            quickLogAllowed = true;\r\n     " +
"                       break;\r\n                        default:\r\n               " +
"             quickLogAllowed = false;\r\n                            break;\r\n     " +
"               }\r\n                }\r\n\r\n                if (quickLogAllowed) {\r\n " +
"                   $quickLogContainer.slideDown();\r\n                } else {\r\n  " +
"                  if (init)\r\n                        $quickLogContainer.hide();\r" +
"\n                    else\r\n                        $quickLogContainer.slideUp();" +
"\r\n                    $quickLog.prop(\'checked\', false).change();\r\n              " +
"  }\r\n            }\r\n\r\n            $quickLog.change(function () {\r\n              " +
"  if ($(this).is(\':checked\')) {\r\n                    $quickLogTaskTimeContainer." +
"slideDown();\r\n                } else {\r\n                    $quickLogTaskTimeCon" +
"tainer.slideUp();\r\n                }\r\n            });\r\n\r\n            $quickLogTa" +
"skTimes.change(function () {\r\n                if ($quickLogTaskTimes.filter(\':ch" +
"ecked\').val() === \"\") {\r\n                    $(\'#createJob_TaskTimeOtherMinutesC" +
"ontainer\').show();\r\n                    $quickLogTaskTimeOtherMinutes.attr(\'disa" +
"bled\', null).focus().select();\r\n                } else {\r\n                    $(" +
"\'#createJob_TaskTimeOtherMinutesContainer\').hide();\r\n                    $quickL" +
"ogTaskTimeOtherMinutes.attr(\'disabled\', \'disabled\');\r\n                }\r\n       " +
"     });\r\n            //#endregion\r\n\r\n            init = false;\r\n        });\r\n  " +
"  </script>\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591
