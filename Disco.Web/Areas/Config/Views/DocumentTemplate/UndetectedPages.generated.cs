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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Config/Views/DocumentTemplate/UndetectedPages.cshtml")]
    public partial class UndetectedPages : Disco.Services.Web.WebViewPage<Disco.Web.Areas.Config.Models.DocumentTemplate.UndetectedPagesModel>
    {
        public UndetectedPages()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Areas\Config\Views\DocumentTemplate\UndetectedPages.cshtml"
  
    Authorization.Require(Claims.Config.DocumentTemplate.UndetectedPages);

    ViewBag.Title = Html.ToBreadcrumb("Configuration", MVC.Config.Config.Index(), "Document Templates", MVC.Config.DocumentTemplate.Index(), "Undetected Pages");
    Html.BundleDeferred("~/ClientScripts/Modules/Knockout");
    Html.BundleDeferred("~/ClientScripts/Modules/jQuery-SignalR");

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" id=\"undetectedPagesContainer\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" id=\"noUndetectedPages\"");

WriteLiteral(" data-bind=\"visible: noUndetectedPages\"");

WriteLiteral(">\r\n        <h3>No Undetected Pages</h3>\r\n    </div>\r\n    <ul");

WriteLiteral(" id=\"undetectedPages\"");

WriteLiteral(" class=\"clearfix\"");

WriteLiteral(" data-bind=\"visible: !noUndetectedPages(), foreach: { data: undetectedPages }\"");

WriteLiteral(">\r\n        <li");

WriteLiteral(" class=\"undetectedPage\"");

WriteLiteral(" data-bind=\"style: { backgroundImage: thumbnailUrl }, click: select\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"pageDetails\"");

WriteLiteral(" data-bind=\"text: timestampFuzzy, attr: { title: timestamp }\"");

WriteLiteral(">\r\n            </div>\r\n        </li>\r\n    </ul>\r\n</div>\r\n<div");

WriteLiteral(" id=\"undetectedPageDialog\"");

WriteLiteral(" data-bind=\"with: selectedUndetectedPage\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"pagePreview\"");

WriteLiteral(" data-bind=\"style: { backgroundImage: previewUrl }\"");

WriteLiteral(">\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"actions\"");

WriteLiteral(">\r\n        <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" class=\"button\"");

WriteLiteral(" target=\"_blank\"");

WriteLiteral(" data-bind=\"attr: { href: sourceUrl }\"");

WriteLiteral(">Download</a>\r\n        <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" class=\"button\"");

WriteLiteral(" id=\"dialogDeleteButton\"");

WriteLiteral(" data-bind=\"click: deletePage\"");

WriteLiteral(">Delete</a>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"actions\"");

WriteLiteral(">\r\n        Type: ");

            
            #line 28 "..\..\Areas\Config\Views\DocumentTemplate\UndetectedPages.cshtml"
         Write(Html.DropDownList("dialogDocumentTemplateId", Model.DocumentTemplatesSelectListItems, new Dictionary<string, object> { { "data-bind", "value: dialogTemplateId" } }));

            
            #line default
            #line hidden
WriteLiteral("\r\n        Data:\r\n        <input");

WriteLiteral(" id=\"dialogDataId\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(" data-bind=\"value: dialogDataId, autocomplete: { source: dialogDataIdService, min" +
"Length: 3, position: { my: \'left bottom\', at: \'left top\' } }\"");

WriteLiteral(" />\r\n        <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" class=\"button\"");

WriteLiteral(" id=\"dialogAssignButton\"");

WriteLiteral(" data-bind=\"click: assignPage\"");

WriteLiteral(">Assign</a>\r\n    </div>\r\n</div>\r\n<div");

WriteLiteral(" id=\"dialogRemove\"");

WriteLiteral(" title=\"Delete this Page?\"");

WriteLiteral(">\r\n    <p>\r\n        <i");

WriteLiteral(" class=\"fa fa-exclamation-triangle fa-lg warning\"");

WriteLiteral("></i>\r\n        Are you sure?\r\n    </p>\r\n</div>\r\n<script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(@">
    ko.bindingHandlers.autocomplete = {
        update: function (element, valueAccessor, allBindingsAccessor, viewModel) {
            var autocompleteOptions = ko.utils.unwrapObservable(valueAccessor());
            if (autocompleteOptions.source)
                autocompleteOptions.source = ko.utils.unwrapObservable(autocompleteOptions.source);
            $element = $(element);
            if (!$element.is('.ui-autocomplete-input')) {
                autocompleteOptions.select = function (e, ui) {
                    allBindingsAccessor().value(ui.item.value);
                    return false;
                }
                $element.autocomplete(autocompleteOptions);
            } else {
                // Update Source Option Only
                if (autocompleteOptions.source)
                    $element.autocomplete('option', 'source', autocompleteOptions.source);
            }
        }
    };
</script>
<script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n    $(function () {\r\n\r\n        var vm;\r\n        var urlUndetectedPageThumbnail" +
" = \'");

            
            #line 65 "..\..\Areas\Config\Views\DocumentTemplate\UndetectedPages.cshtml"
                                      Write(new HtmlString(Url.Action(MVC.API.DocumentTemplate.ImporterUndetectedFile(null, false, true))));

            
            #line default
            #line hidden
WriteLiteral("\';\r\n        var urlUndetectedPagePreview = \'");

            
            #line 66 "..\..\Areas\Config\Views\DocumentTemplate\UndetectedPages.cshtml"
                                    Write(new HtmlString(Url.Action(MVC.API.DocumentTemplate.ImporterUndetectedFile(null, false, false))));

            
            #line default
            #line hidden
WriteLiteral("\';\r\n        var urlUndetectedPageSource = \'");

            
            #line 67 "..\..\Areas\Config\Views\DocumentTemplate\UndetectedPages.cshtml"
                                   Write(new HtmlString(Url.Action(MVC.API.DocumentTemplate.ImporterUndetectedFile(null, true, false))));

            
            #line default
            #line hidden
WriteLiteral("\';\r\n        var urlDataIdLookupService = \'");

            
            #line 68 "..\..\Areas\Config\Views\DocumentTemplate\UndetectedPages.cshtml"
                                  Write(Url.Action(MVC.API.DocumentTemplate.ImporterUndetectedDataIdLookup()));

            
            #line default
            #line hidden
WriteLiteral("/\';\r\n        var urlImporterUndetectedAssign = \'");

            
            #line 69 "..\..\Areas\Config\Views\DocumentTemplate\UndetectedPages.cshtml"
                                       Write(Url.Action(MVC.API.DocumentTemplate.ImporterUndetectedAssign()));

            
            #line default
            #line hidden
WriteLiteral("/\';\r\n        var urlImporterUndetectedDelete = \'");

            
            #line 70 "..\..\Areas\Config\Views\DocumentTemplate\UndetectedPages.cshtml"
                                       Write(Url.Action(MVC.API.DocumentTemplate.ImporterUndetectedDelete()));

            
            #line default
            #line hidden
WriteLiteral("/\';\r\n        var $undetectedPageDialog = $(\'#undetectedPageDialog\').dialog({\r\n   " +
"         modal: true,\r\n            width: 800,\r\n            resizable: false,\r\n " +
"           autoOpen: false\r\n        });\r\n\r\n        function resizeUndetectedPage" +
"Dialog() {\r\n            var dialogHeight = Math.min($(window).height() - 120, 80" +
"5);\r\n            $undetectedPageDialog.height(dialogHeight);\r\n            $undet" +
"ectedPageDialog.find(\'.pagePreview\').height(dialogHeight - 105);\r\n        }\r\n   " +
"     resizeUndetectedPageDialog();\r\n\r\n        $(window).resize(resizeUndetectedP" +
"ageDialog);\r\n\r\n        $dialogRemove = $(\'#dialogRemove\').dialog({\r\n            " +
"resizable: false,\r\n            height: 140,\r\n            modal: true,\r\n         " +
"   autoOpen: false\r\n        });\r\n\r\n        function pageViewModel() {\r\n         " +
"   var self = this;\r\n\r\n            self.selectedUndetectedPage = ko.observable(n" +
"ull);\r\n            self.undetectedPages = ko.observableArray();\r\n            sel" +
"f.noUndetectedPages = ko.computed(function () { return self.undetectedPages().le" +
"ngth == 0 });\r\n            self.selectNextPage = function () {\r\n                " +
"var oldSelected = self.selectedUndetectedPage();\r\n                var oldSelecte" +
"dIndex = vm.undetectedPages.indexOf(oldSelected);\r\n\r\n                if (vm.unde" +
"tectedPages().length > 1) {\r\n                    if (oldSelectedIndex + 1 <= vm." +
"undetectedPages().length - 1)\r\n                        vm.selectedUndetectedPage" +
"(vm.undetectedPages()[oldSelectedIndex + 1]);\r\n                    else\r\n       " +
"                 vm.selectedUndetectedPage(vm.undetectedPages()[oldSelectedIndex" +
" - 1]);\r\n                } else {\r\n                    $undetectedPageDialog.dia" +
"log(\'close\');\r\n                    vm.selectedUndetectedPage(null);\r\n           " +
"     }\r\n            }\r\n        }\r\n\r\n        function undetectedPageViewModel(id," +
" timestamp, timestampFuzzy) {\r\n            var self = this;\r\n\r\n            self." +
"id = id;\r\n            self.timestamp = timestamp;\r\n            self.timestampFuz" +
"zy = timestampFuzzy;\r\n            self.thumbnailUrl = \"url(\" + urlUndetectedPage" +
"Thumbnail + \"&id=\" + id + \")\";\r\n            self.previewUrl = \"url(\" + urlUndete" +
"ctedPagePreview + \"&id=\" + id + \")\";\r\n            self.sourceUrl = urlUndetected" +
"PageSource + \"&id=\" + id;\r\n            self.select = function (e, d) {\r\n        " +
"        vm.selectedUndetectedPage(self);\r\n                $undetectedPageDialog." +
"dialog(\'open\');\r\n            }\r\n\r\n            // Dialog Properties\r\n            " +
"self.dialogTemplateId = ko.observable(null);\r\n            self.dialogDataId = ko" +
".observable(null);\r\n            self.dialogDataIdService = ko.computed(function " +
"() {\r\n                return urlDataIdLookupService + self.dialogTemplateId();\r\n" +
"            });\r\n            self.deletePage = function () {\r\n                $u" +
"ndetectedPageDialog.dialog(\'option\', \'disabled\', true);\r\n\r\n                $dial" +
"ogRemove.dialog(\'option\', \'buttons\', {\r\n                    \"Remove\": function (" +
") {\r\n                        $dialogRemove.dialog(\"close\");\r\n                   " +
"     var data = { id: self.id };\r\n                        $.ajax({\r\n            " +
"                url: urlImporterUndetectedDelete,\r\n                            d" +
"ataType: \'json\',\r\n                            data: data,\r\n                     " +
"       type: \'POST\',\r\n                            success: function (d) {\r\n     " +
"                           if (d == \'OK\') {\r\n                                   " +
" vm.selectNextPage();\r\n                                    vm.undetectedPages.re" +
"move(self);\r\n                                } else {\r\n                         " +
"           alert(\'Unable to delete page: \' + d);\r\n                              " +
"  }\r\n                                $undetectedPageDialog.dialog(\'option\', \'dis" +
"abled\', false);\r\n                            },\r\n                            err" +
"or: function (jqXHR, textStatus, errorThrown) {\r\n                               " +
" alert(\'Unable to delete page: \' + errorThrown);\r\n                              " +
"  $undetectedPageDialog.dialog(\'option\', \'disabled\', false);\r\n                  " +
"          }\r\n                        });\r\n                    },\r\n              " +
"      \"Cancel\": function () {\r\n                        $dialogRemove.dialog(\"clo" +
"se\");\r\n                        $undetectedPageDialog.dialog(\'option\', \'disabled\'" +
", false);\r\n                    }\r\n                });\r\n\r\n                $dialog" +
"Remove.dialog(\'open\');\r\n\r\n                return false;\r\n            }\r\n        " +
"    self.assignPage = function () {\r\n                var dtId = self.dialogTempl" +
"ateId();\r\n                var dId = self.dialogDataId();\r\n                if (!d" +
"tId || !dId) {\r\n                    alert(\'Please specify a valid Document Type " +
"and Data Id\');\r\n                } else {\r\n                    $undetectedPageDia" +
"log.dialog(\'option\', \'disabled\', true);\r\n\r\n                    var data = { id: " +
"self.id, DocumentTemplateId: dtId, DataId: dId };\r\n\r\n                    $.ajax(" +
"{\r\n                        url: urlImporterUndetectedAssign,\r\n                  " +
"      dataType: \'json\',\r\n                        data: data,\r\n                  " +
"      type: \'POST\',\r\n                        success: function (d) {\r\n          " +
"                  if (d == \'OK\') {\r\n                                vm.selectNex" +
"tPage();\r\n                                vm.undetectedPages.remove(self);\r\n    " +
"                        } else {\r\n                                alert(\'Unable " +
"to assign page: \' + d);\r\n                            }\r\n                        " +
"    $undetectedPageDialog.dialog(\'option\', \'disabled\', false);\r\n                " +
"        },\r\n                        error: function (jqXHR, textStatus, errorThr" +
"own) {\r\n                            alert(\'Unable to assign page: \' + errorThrow" +
"n);\r\n                            $undetectedPageDialog.dialog(\'option\', \'disable" +
"d\', false);\r\n                        }\r\n                    });\r\n\r\n             " +
"   }\r\n                return false;\r\n            };\r\n        }\r\n\r\n        functi" +
"on init() {\r\n            vm = new pageViewModel();\r\n\r\n            $.ajax({\r\n    " +
"            url: \'");

            
            #line 212 "..\..\Areas\Config\Views\DocumentTemplate\UndetectedPages.cshtml"
                  Write(Url.Action(MVC.API.DocumentTemplate.ImporterUndetectedFiles()));

            
            #line default
            #line hidden
WriteLiteral(@"',
                dataType: 'json',
                type: 'POST',
                success: init_loadedContent,
                error: function (jqXHR, textStatus, errorThrown) {
                    alert('Unable to load content: ' + errorThrown);
                }
            });
        }
        function init_loadedContent(content) {
            if (content.length > 0) {
                for (var i = 0; i < content.length; i++) {
                    var c = content[i];
                    var up = new undetectedPageViewModel(c.Id, c.Timestamp, c.TimestampFuzzy);
                    vm.undetectedPages.push(up);
                }
            }

            ko.applyBindings(vm);
            init_loadedOpen();
        }
        function init_loadedOpen() {
            var fileId = window.location.hash;
            if (fileId) {
                fileId = fileId.substr(1);
                for (var i = 0; i < vm.undetectedPages().length; i++) {
                    var up = vm.undetectedPages()[i];
                    if (up.id == fileId) {
                        up.select();
                        return;
                    }
                }
            }
        }
        init();

    });
</script>
");

        }
    }
}
#pragma warning restore 1591
