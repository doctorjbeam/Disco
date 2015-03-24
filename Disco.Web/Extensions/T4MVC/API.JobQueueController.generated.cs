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
    public partial class JobQueueController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public JobQueueController() { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected JobQueueController(Dummy d) { }

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
        public virtual System.Web.Mvc.ActionResult UpdatePriority()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.UpdatePriority);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult UpdateDefaultSLAExpiry()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.UpdateDefaultSLAExpiry);
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
        public virtual System.Web.Mvc.ActionResult UpdateSubjects()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.UpdateSubjects);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult UpdateJobSubTypes()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.UpdateJobSubTypes);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult Delete()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Delete);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public JobQueueController Actions { get { return MVC.API.JobQueue; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "API";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "JobQueue";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "JobQueue";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string Update = "Update";
            public readonly string UpdateName = "UpdateName";
            public readonly string UpdateDescription = "UpdateDescription";
            public readonly string UpdatePriority = "UpdatePriority";
            public readonly string UpdateDefaultSLAExpiry = "UpdateDefaultSLAExpiry";
            public readonly string UpdateIcon = "UpdateIcon";
            public readonly string UpdateIconColour = "UpdateIconColour";
            public readonly string UpdateIconAndColour = "UpdateIconAndColour";
            public readonly string UpdateSubjects = "UpdateSubjects";
            public readonly string UpdateJobSubTypes = "UpdateJobSubTypes";
            public readonly string Delete = "Delete";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string Update = "Update";
            public const string UpdateName = "UpdateName";
            public const string UpdateDescription = "UpdateDescription";
            public const string UpdatePriority = "UpdatePriority";
            public const string UpdateDefaultSLAExpiry = "UpdateDefaultSLAExpiry";
            public const string UpdateIcon = "UpdateIcon";
            public const string UpdateIconColour = "UpdateIconColour";
            public const string UpdateIconAndColour = "UpdateIconAndColour";
            public const string UpdateSubjects = "UpdateSubjects";
            public const string UpdateJobSubTypes = "UpdateJobSubTypes";
            public const string Delete = "Delete";
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
            public readonly string QueueName = "QueueName";
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
        static readonly ActionParamsClass_UpdatePriority s_params_UpdatePriority = new ActionParamsClass_UpdatePriority();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_UpdatePriority UpdatePriorityParams { get { return s_params_UpdatePriority; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_UpdatePriority
        {
            public readonly string id = "id";
            public readonly string Priority = "Priority";
            public readonly string redirect = "redirect";
        }
        static readonly ActionParamsClass_UpdateDefaultSLAExpiry s_params_UpdateDefaultSLAExpiry = new ActionParamsClass_UpdateDefaultSLAExpiry();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_UpdateDefaultSLAExpiry UpdateDefaultSLAExpiryParams { get { return s_params_UpdateDefaultSLAExpiry; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_UpdateDefaultSLAExpiry
        {
            public readonly string id = "id";
            public readonly string DefaultSLAExpiry = "DefaultSLAExpiry";
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
        static readonly ActionParamsClass_UpdateSubjects s_params_UpdateSubjects = new ActionParamsClass_UpdateSubjects();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_UpdateSubjects UpdateSubjectsParams { get { return s_params_UpdateSubjects; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_UpdateSubjects
        {
            public readonly string id = "id";
            public readonly string Subjects = "Subjects";
            public readonly string redirect = "redirect";
        }
        static readonly ActionParamsClass_UpdateJobSubTypes s_params_UpdateJobSubTypes = new ActionParamsClass_UpdateJobSubTypes();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_UpdateJobSubTypes UpdateJobSubTypesParams { get { return s_params_UpdateJobSubTypes; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_UpdateJobSubTypes
        {
            public readonly string id = "id";
            public readonly string JobSubTypes = "JobSubTypes";
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
    public partial class T4MVC_JobQueueController : Disco.Web.Areas.API.Controllers.JobQueueController
    {
        public T4MVC_JobQueueController() : base(Dummy.Instance) { }

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
        partial void UpdateNameOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int id, string QueueName, bool? redirect);

        [NonAction]
        public override System.Web.Mvc.ActionResult UpdateName(int id, string QueueName, bool? redirect)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.UpdateName);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "QueueName", QueueName);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "redirect", redirect);
            UpdateNameOverride(callInfo, id, QueueName, redirect);
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
        partial void UpdatePriorityOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int id, string Priority, bool? redirect);

        [NonAction]
        public override System.Web.Mvc.ActionResult UpdatePriority(int id, string Priority, bool? redirect)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.UpdatePriority);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "Priority", Priority);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "redirect", redirect);
            UpdatePriorityOverride(callInfo, id, Priority, redirect);
            return callInfo;
        }

        [NonAction]
        partial void UpdateDefaultSLAExpiryOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int id, string DefaultSLAExpiry, bool? redirect);

        [NonAction]
        public override System.Web.Mvc.ActionResult UpdateDefaultSLAExpiry(int id, string DefaultSLAExpiry, bool? redirect)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.UpdateDefaultSLAExpiry);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "DefaultSLAExpiry", DefaultSLAExpiry);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "redirect", redirect);
            UpdateDefaultSLAExpiryOverride(callInfo, id, DefaultSLAExpiry, redirect);
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
        partial void UpdateSubjectsOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int id, string[] Subjects, bool redirect);

        [NonAction]
        public override System.Web.Mvc.ActionResult UpdateSubjects(int id, string[] Subjects, bool redirect)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.UpdateSubjects);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "Subjects", Subjects);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "redirect", redirect);
            UpdateSubjectsOverride(callInfo, id, Subjects, redirect);
            return callInfo;
        }

        [NonAction]
        partial void UpdateJobSubTypesOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int id, System.Collections.Generic.List<string> JobSubTypes, bool redirect);

        [NonAction]
        public override System.Web.Mvc.ActionResult UpdateJobSubTypes(int id, System.Collections.Generic.List<string> JobSubTypes, bool redirect)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.UpdateJobSubTypes);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "JobSubTypes", JobSubTypes);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "redirect", redirect);
            UpdateJobSubTypesOverride(callInfo, id, JobSubTypes, redirect);
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

    }
}

#endregion T4MVC
#pragma warning restore 1591
