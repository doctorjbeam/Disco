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
namespace Disco.Web.Areas.API.Controllers
{
    public partial class UserFlagAssignmentController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public UserFlagAssignmentController() { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected UserFlagAssignmentController(Dummy d) { }

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
        public virtual System.Web.Mvc.ActionResult Update()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Update);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult UpdateComments()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.UpdateComments);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult AddUser()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.AddUser);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult RemoveUser()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.RemoveUser);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public UserFlagAssignmentController Actions { get { return MVC.API.UserFlagAssignment; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "API";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "UserFlagAssignment";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "UserFlagAssignment";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string Update = "Update";
            public readonly string UpdateComments = "UpdateComments";
            public readonly string AddUser = "AddUser";
            public readonly string RemoveUser = "RemoveUser";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string Update = "Update";
            public const string UpdateComments = "UpdateComments";
            public const string AddUser = "AddUser";
            public const string RemoveUser = "RemoveUser";
        }


        static readonly ActionParamsClass_Update s_params_Update = new ActionParamsClass_Update();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Update UpdateParams { get { return s_params_Update; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Update
        {
            public readonly string id = "id";
            public readonly string key = "key";
            public readonly string value = "value";
            public readonly string redirect = "redirect";
        }
        static readonly ActionParamsClass_UpdateComments s_params_UpdateComments = new ActionParamsClass_UpdateComments();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_UpdateComments UpdateCommentsParams { get { return s_params_UpdateComments; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_UpdateComments
        {
            public readonly string id = "id";
            public readonly string Comments = "Comments";
            public readonly string redirect = "redirect";
        }
        static readonly ActionParamsClass_AddUser s_params_AddUser = new ActionParamsClass_AddUser();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_AddUser AddUserParams { get { return s_params_AddUser; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_AddUser
        {
            public readonly string id = "id";
            public readonly string UserId = "UserId";
            public readonly string Comments = "Comments";
        }
        static readonly ActionParamsClass_RemoveUser s_params_RemoveUser = new ActionParamsClass_RemoveUser();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_RemoveUser RemoveUserParams { get { return s_params_RemoveUser; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_RemoveUser
        {
            public readonly string id = "id";
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
            }
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public partial class T4MVC_UserFlagAssignmentController : Disco.Web.Areas.API.Controllers.UserFlagAssignmentController
    {
        public T4MVC_UserFlagAssignmentController() : base(Dummy.Instance) { }

        [NonAction]
        partial void UpdateOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int id, string key, string value, bool? redirect);

        [NonAction]
        public override System.Web.Mvc.ActionResult Update(int id, string key, string value, bool? redirect)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Update);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "key", key);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "value", value);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "redirect", redirect);
            UpdateOverride(callInfo, id, key, value, redirect);
            return callInfo;
        }

        [NonAction]
        partial void UpdateCommentsOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int id, string Comments, bool? redirect);

        [NonAction]
        public override System.Web.Mvc.ActionResult UpdateComments(int id, string Comments, bool? redirect)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.UpdateComments);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "Comments", Comments);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "redirect", redirect);
            UpdateCommentsOverride(callInfo, id, Comments, redirect);
            return callInfo;
        }

        [NonAction]
        partial void AddUserOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int id, string UserId, string Comments);

        [NonAction]
        public override System.Web.Mvc.ActionResult AddUser(int id, string UserId, string Comments)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.AddUser);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "UserId", UserId);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "Comments", Comments);
            AddUserOverride(callInfo, id, UserId, Comments);
            return callInfo;
        }

        [NonAction]
        partial void RemoveUserOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int id);

        [NonAction]
        public override System.Web.Mvc.ActionResult RemoveUser(int id)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.RemoveUser);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            RemoveUserOverride(callInfo, id);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591
