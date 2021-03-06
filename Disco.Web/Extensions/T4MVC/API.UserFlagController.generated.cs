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
    public partial class UserFlagController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public UserFlagController() { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected UserFlagController(Dummy d) { }

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
        public virtual System.Web.Mvc.ActionResult UpdateName()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.UpdateName);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult UpdateDescription()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.UpdateDescription);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult UpdateIcon()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.UpdateIcon);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult UpdateIconColour()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.UpdateIconColour);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult UpdateIconAndColour()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.UpdateIconAndColour);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult UpdateAssignedUsersLinkedGroup()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.UpdateAssignedUsersLinkedGroup);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult UpdateAssignedUserDevicesLinkedGroup()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.UpdateAssignedUserDevicesLinkedGroup);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult Delete()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Delete);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult BulkAssignUsers()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.BulkAssignUsers);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult AssignedUsers()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.AssignedUsers);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public UserFlagController Actions { get { return MVC.API.UserFlag; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "API";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "UserFlag";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "UserFlag";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string Update = "Update";
            public readonly string UpdateName = "UpdateName";
            public readonly string UpdateDescription = "UpdateDescription";
            public readonly string UpdateIcon = "UpdateIcon";
            public readonly string UpdateIconColour = "UpdateIconColour";
            public readonly string UpdateIconAndColour = "UpdateIconAndColour";
            public readonly string UpdateAssignedUsersLinkedGroup = "UpdateAssignedUsersLinkedGroup";
            public readonly string UpdateAssignedUserDevicesLinkedGroup = "UpdateAssignedUserDevicesLinkedGroup";
            public readonly string Delete = "Delete";
            public readonly string BulkAssignUsers = "BulkAssignUsers";
            public readonly string AssignedUsers = "AssignedUsers";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string Update = "Update";
            public const string UpdateName = "UpdateName";
            public const string UpdateDescription = "UpdateDescription";
            public const string UpdateIcon = "UpdateIcon";
            public const string UpdateIconColour = "UpdateIconColour";
            public const string UpdateIconAndColour = "UpdateIconAndColour";
            public const string UpdateAssignedUsersLinkedGroup = "UpdateAssignedUsersLinkedGroup";
            public const string UpdateAssignedUserDevicesLinkedGroup = "UpdateAssignedUserDevicesLinkedGroup";
            public const string Delete = "Delete";
            public const string BulkAssignUsers = "BulkAssignUsers";
            public const string AssignedUsers = "AssignedUsers";
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
        static readonly ActionParamsClass_UpdateName s_params_UpdateName = new ActionParamsClass_UpdateName();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_UpdateName UpdateNameParams { get { return s_params_UpdateName; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_UpdateName
        {
            public readonly string id = "id";
            public readonly string FlagName = "FlagName";
            public readonly string redirect = "redirect";
        }
        static readonly ActionParamsClass_UpdateDescription s_params_UpdateDescription = new ActionParamsClass_UpdateDescription();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_UpdateDescription UpdateDescriptionParams { get { return s_params_UpdateDescription; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_UpdateDescription
        {
            public readonly string id = "id";
            public readonly string Description = "Description";
            public readonly string redirect = "redirect";
        }
        static readonly ActionParamsClass_UpdateIcon s_params_UpdateIcon = new ActionParamsClass_UpdateIcon();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_UpdateIcon UpdateIconParams { get { return s_params_UpdateIcon; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_UpdateIcon
        {
            public readonly string id = "id";
            public readonly string Icon = "Icon";
            public readonly string redirect = "redirect";
        }
        static readonly ActionParamsClass_UpdateIconColour s_params_UpdateIconColour = new ActionParamsClass_UpdateIconColour();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_UpdateIconColour UpdateIconColourParams { get { return s_params_UpdateIconColour; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_UpdateIconColour
        {
            public readonly string id = "id";
            public readonly string IconColour = "IconColour";
            public readonly string redirect = "redirect";
        }
        static readonly ActionParamsClass_UpdateIconAndColour s_params_UpdateIconAndColour = new ActionParamsClass_UpdateIconAndColour();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_UpdateIconAndColour UpdateIconAndColourParams { get { return s_params_UpdateIconAndColour; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_UpdateIconAndColour
        {
            public readonly string id = "id";
            public readonly string Icon = "Icon";
            public readonly string IconColour = "IconColour";
            public readonly string redirect = "redirect";
        }
        static readonly ActionParamsClass_UpdateAssignedUsersLinkedGroup s_params_UpdateAssignedUsersLinkedGroup = new ActionParamsClass_UpdateAssignedUsersLinkedGroup();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_UpdateAssignedUsersLinkedGroup UpdateAssignedUsersLinkedGroupParams { get { return s_params_UpdateAssignedUsersLinkedGroup; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_UpdateAssignedUsersLinkedGroup
        {
            public readonly string id = "id";
            public readonly string GroupId = "GroupId";
            public readonly string redirect = "redirect";
        }
        static readonly ActionParamsClass_UpdateAssignedUserDevicesLinkedGroup s_params_UpdateAssignedUserDevicesLinkedGroup = new ActionParamsClass_UpdateAssignedUserDevicesLinkedGroup();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_UpdateAssignedUserDevicesLinkedGroup UpdateAssignedUserDevicesLinkedGroupParams { get { return s_params_UpdateAssignedUserDevicesLinkedGroup; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_UpdateAssignedUserDevicesLinkedGroup
        {
            public readonly string id = "id";
            public readonly string GroupId = "GroupId";
            public readonly string redirect = "redirect";
        }
        static readonly ActionParamsClass_Delete s_params_Delete = new ActionParamsClass_Delete();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Delete DeleteParams { get { return s_params_Delete; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Delete
        {
            public readonly string id = "id";
            public readonly string redirect = "redirect";
        }
        static readonly ActionParamsClass_BulkAssignUsers s_params_BulkAssignUsers = new ActionParamsClass_BulkAssignUsers();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_BulkAssignUsers BulkAssignUsersParams { get { return s_params_BulkAssignUsers; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_BulkAssignUsers
        {
            public readonly string id = "id";
            public readonly string Override = "Override";
            public readonly string UserIds = "UserIds";
            public readonly string Comments = "Comments";
        }
        static readonly ActionParamsClass_AssignedUsers s_params_AssignedUsers = new ActionParamsClass_AssignedUsers();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_AssignedUsers AssignedUsersParams { get { return s_params_AssignedUsers; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_AssignedUsers
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
    public partial class T4MVC_UserFlagController : Disco.Web.Areas.API.Controllers.UserFlagController
    {
        public T4MVC_UserFlagController() : base(Dummy.Instance) { }

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
        partial void UpdateNameOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int id, string FlagName, bool? redirect);

        [NonAction]
        public override System.Web.Mvc.ActionResult UpdateName(int id, string FlagName, bool? redirect)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.UpdateName);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "FlagName", FlagName);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "redirect", redirect);
            UpdateNameOverride(callInfo, id, FlagName, redirect);
            return callInfo;
        }

        [NonAction]
        partial void UpdateDescriptionOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int id, string Description, bool? redirect);

        [NonAction]
        public override System.Web.Mvc.ActionResult UpdateDescription(int id, string Description, bool? redirect)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.UpdateDescription);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "Description", Description);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "redirect", redirect);
            UpdateDescriptionOverride(callInfo, id, Description, redirect);
            return callInfo;
        }

        [NonAction]
        partial void UpdateIconOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int id, string Icon, bool? redirect);

        [NonAction]
        public override System.Web.Mvc.ActionResult UpdateIcon(int id, string Icon, bool? redirect)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.UpdateIcon);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "Icon", Icon);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "redirect", redirect);
            UpdateIconOverride(callInfo, id, Icon, redirect);
            return callInfo;
        }

        [NonAction]
        partial void UpdateIconColourOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int id, string IconColour, bool? redirect);

        [NonAction]
        public override System.Web.Mvc.ActionResult UpdateIconColour(int id, string IconColour, bool? redirect)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.UpdateIconColour);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "IconColour", IconColour);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "redirect", redirect);
            UpdateIconColourOverride(callInfo, id, IconColour, redirect);
            return callInfo;
        }

        [NonAction]
        partial void UpdateIconAndColourOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int id, string Icon, string IconColour, bool redirect);

        [NonAction]
        public override System.Web.Mvc.ActionResult UpdateIconAndColour(int id, string Icon, string IconColour, bool redirect)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.UpdateIconAndColour);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "Icon", Icon);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "IconColour", IconColour);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "redirect", redirect);
            UpdateIconAndColourOverride(callInfo, id, Icon, IconColour, redirect);
            return callInfo;
        }

        [NonAction]
        partial void UpdateAssignedUsersLinkedGroupOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int id, string GroupId, bool redirect);

        [NonAction]
        public override System.Web.Mvc.ActionResult UpdateAssignedUsersLinkedGroup(int id, string GroupId, bool redirect)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.UpdateAssignedUsersLinkedGroup);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "GroupId", GroupId);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "redirect", redirect);
            UpdateAssignedUsersLinkedGroupOverride(callInfo, id, GroupId, redirect);
            return callInfo;
        }

        [NonAction]
        partial void UpdateAssignedUserDevicesLinkedGroupOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int id, string GroupId, bool redirect);

        [NonAction]
        public override System.Web.Mvc.ActionResult UpdateAssignedUserDevicesLinkedGroup(int id, string GroupId, bool redirect)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.UpdateAssignedUserDevicesLinkedGroup);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "GroupId", GroupId);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "redirect", redirect);
            UpdateAssignedUserDevicesLinkedGroupOverride(callInfo, id, GroupId, redirect);
            return callInfo;
        }

        [NonAction]
        partial void DeleteOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int id, bool? redirect);

        [NonAction]
        public override System.Web.Mvc.ActionResult Delete(int id, bool? redirect)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Delete);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "redirect", redirect);
            DeleteOverride(callInfo, id, redirect);
            return callInfo;
        }

        [NonAction]
        partial void BulkAssignUsersOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int id, bool Override, string UserIds, string Comments);

        [NonAction]
        public override System.Web.Mvc.ActionResult BulkAssignUsers(int id, bool Override, string UserIds, string Comments)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.BulkAssignUsers);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "Override", Override);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "UserIds", UserIds);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "Comments", Comments);
            BulkAssignUsersOverride(callInfo, id, Override, UserIds, Comments);
            return callInfo;
        }

        [NonAction]
        partial void AssignedUsersOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int id);

        [NonAction]
        public override System.Web.Mvc.ActionResult AssignedUsers(int id)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.AssignedUsers);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            AssignedUsersOverride(callInfo, id);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591
