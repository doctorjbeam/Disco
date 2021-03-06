// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments
#pragma warning disable 1591
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;
namespace Disco.Web.Areas.Config.Controllers
{
    public partial class DocumentTemplateController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public DocumentTemplateController() { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected DocumentTemplateController(Dummy d) { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoute(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(Task<ActionResult> taskResult)
        {
            return RedirectToAction(taskResult.Result);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoutePermanent(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(Task<ActionResult> taskResult)
        {
            return RedirectToActionPermanent(taskResult.Result);
        }

        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult Index()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Index);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult ExpressionBrowser()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ExpressionBrowser);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public DocumentTemplateController Actions { get { return MVC.Config.DocumentTemplate; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "Config";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "DocumentTemplate";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "DocumentTemplate";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string Index = "Index";
            public readonly string ImportStatus = "ImportStatus";
            public readonly string UndetectedPages = "UndetectedPages";
            public readonly string Create = "Create";
            public readonly string ExpressionBrowser = "ExpressionBrowser";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string Index = "Index";
            public const string ImportStatus = "ImportStatus";
            public const string UndetectedPages = "UndetectedPages";
            public const string Create = "Create";
            public const string ExpressionBrowser = "ExpressionBrowser";
        }


        static readonly ActionParamsClass_Index s_params_Index = new ActionParamsClass_Index();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Index IndexParams { get { return s_params_Index; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Index
        {
            public readonly string id = "id";
        }
        static readonly ActionParamsClass_Create s_params_Create = new ActionParamsClass_Create();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Create CreateParams { get { return s_params_Create; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Create
        {
            public readonly string model = "model";
        }
        static readonly ActionParamsClass_ExpressionBrowser s_params_ExpressionBrowser = new ActionParamsClass_ExpressionBrowser();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_ExpressionBrowser ExpressionBrowserParams { get { return s_params_ExpressionBrowser; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_ExpressionBrowser
        {
            public readonly string type = "type";
            public readonly string StaticDeclaredMembersOnly = "StaticDeclaredMembersOnly";
        }
        static readonly ViewsClass s_views = new ViewsClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ViewsClass Views { get { return s_views; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ViewsClass
        {
            static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
            public _ViewNamesClass ViewNames { get { return s_ViewNames; } }
            public class _ViewNamesClass
            {
                public readonly string _ExpressionsTable = "_ExpressionsTable";
                public readonly string Create = "Create";
                public readonly string ExpressionBrowser = "ExpressionBrowser";
                public readonly string ImportStatus = "ImportStatus";
                public readonly string Index = "Index";
                public readonly string Show = "Show";
                public readonly string UndetectedPages = "UndetectedPages";
            }
            public readonly string _ExpressionsTable = "~/Areas/Config/Views/DocumentTemplate/_ExpressionsTable.cshtml";
            public readonly string Create = "~/Areas/Config/Views/DocumentTemplate/Create.cshtml";
            public readonly string ExpressionBrowser = "~/Areas/Config/Views/DocumentTemplate/ExpressionBrowser.cshtml";
            public readonly string ImportStatus = "~/Areas/Config/Views/DocumentTemplate/ImportStatus.cshtml";
            public readonly string Index = "~/Areas/Config/Views/DocumentTemplate/Index.cshtml";
            public readonly string Show = "~/Areas/Config/Views/DocumentTemplate/Show.cshtml";
            public readonly string UndetectedPages = "~/Areas/Config/Views/DocumentTemplate/UndetectedPages.cshtml";
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public partial class T4MVC_DocumentTemplateController : Disco.Web.Areas.Config.Controllers.DocumentTemplateController
    {
        public T4MVC_DocumentTemplateController() : base(Dummy.Instance) { }

        [NonAction]
        partial void IndexOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string id);

        [NonAction]
        public override System.Web.Mvc.ActionResult Index(string id)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Index);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            IndexOverride(callInfo, id);
            return callInfo;
        }

        [NonAction]
        partial void ImportStatusOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult ImportStatus()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ImportStatus);
            ImportStatusOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void UndetectedPagesOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult UndetectedPages()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.UndetectedPages);
            UndetectedPagesOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void CreateOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult Create()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Create);
            CreateOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void CreateOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, Disco.Web.Areas.Config.Models.DocumentTemplate.CreateModel model);

        [NonAction]
        public override System.Web.Mvc.ActionResult Create(Disco.Web.Areas.Config.Models.DocumentTemplate.CreateModel model)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Create);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "model", model);
            CreateOverride(callInfo, model);
            return callInfo;
        }

        [NonAction]
        partial void ExpressionBrowserOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string type, bool StaticDeclaredMembersOnly);

        [NonAction]
        public override System.Web.Mvc.ActionResult ExpressionBrowser(string type, bool StaticDeclaredMembersOnly)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ExpressionBrowser);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "type", type);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "StaticDeclaredMembersOnly", StaticDeclaredMembersOnly);
            ExpressionBrowserOverride(callInfo, type, StaticDeclaredMembersOnly);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591
