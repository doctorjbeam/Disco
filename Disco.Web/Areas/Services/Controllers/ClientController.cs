﻿using Disco.BI.Extensions;
using Disco.Data.Repository;
using Disco.Models.ClientServices;
using Disco.Services.Authorization;
using Newtonsoft.Json;
using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace Disco.Web.Areas.Services.Controllers
{
    [OutputCache(Duration = 0)]
    public partial class ClientController : Controller
    {
        [DiscoAuthorize(Claims.Config.Enrolment.DownloadBootstrapper)]
        public virtual ActionResult Bootstrapper()
        {
            return File(Links.ClientBin.Disco_ClientBootstrapper_exe, "application/x-msdownload", "Disco.ClientBootstrapper.exe");
        }

        public virtual ActionResult PreparationClient()
        {
            return File(Links.ClientBin.PreparationClient_zip, "application/x-msdownload", "PreparationClient.zip");
        }

        public virtual ActionResult Unauthenticated(string feature)
        {
            if (string.IsNullOrEmpty(feature))
            {
                return Json(null);
            }
            switch (feature.ToLower())
            {
                case "enrol":
                    {
                        JavaScriptSerializer serializer = new JavaScriptSerializer();
                        Enrol enrolRequest = serializer.Deserialize<Enrol>(base.Request.InputStream.StreamToString());
                        EnrolResponse enrolResponse = enrolRequest.BuildResponse();
                        return Json(enrolResponse);
                    }
                case "macenrol":
                    {
                        var Binder = ModelBinders.Binders.GetBinder(typeof(MacEnrol));
                        var BinderContext = new ModelBindingContext()
                        {
                            ModelMetadata = ModelMetadataProviders.Current.GetMetadataForType(null, typeof(MacEnrol)),
                            ValueProvider = ValueProvider
                        };
                        MacEnrol enrolRequest = (MacEnrol)Binder.BindModel(ControllerContext, BinderContext);

                        MacEnrolResponse enrolResponse = enrolRequest.BuildResponse();

                        return Json(enrolResponse, JsonRequestBehavior.AllowGet);
                    }
                case "macsecureenrol":
                    {
                        using (var database = new DiscoDataContext())
                        {
                            var host = HttpContext.Request.UserHostAddress;
                            MacSecureEnrolResponse enrolResponse = BI.DeviceBI.DeviceEnrol.MacSecureEnrol(database, host);
                            database.SaveChanges();
                            return Json(enrolResponse, JsonRequestBehavior.AllowGet);
                        }
                    }
                case "register":
                    {
                        Register registerRequest = new Register();
                        this.UpdateModel(registerRequest);
                        RegisterResponse registerResponse = registerRequest.BuildResponse();
                        return Json(registerResponse);
                    }
            }
            throw new MissingMethodException(string.Format("Unknown Feature: {0}", feature));
        }

        [Authorize]
        public virtual ActionResult Authenticated(string feature)
        {
            if (string.IsNullOrEmpty(feature))
            {
                WhoAmIResponse whoAmIResponse = new WhoAmI().BuildResponse();
                return Json(whoAmIResponse, JsonRequestBehavior.AllowGet);
            }
            switch (feature.ToLower())
            {
                case "whoami":
                    {
                        WhoAmIResponse whoAmIResponse = new WhoAmI().BuildResponse();
                        return Json(whoAmIResponse, JsonRequestBehavior.AllowGet);
                    }
                case "enrol":
                    {
                        JavaScriptSerializer serializer = new JavaScriptSerializer();
                        Enrol enrolRequest = serializer.Deserialize<Enrol>(base.Request.InputStream.StreamToString());
                        EnrolResponse enrolResponse = enrolRequest.BuildResponse();
                        return Json(enrolResponse);
                    }
                case "register":
                    {
                        Register registerRequest = new Register();
                        this.UpdateModel(registerRequest);
                        RegisterResponse registerResponse = registerRequest.BuildResponse();
                        return Json(registerResponse);
                    }
            }
            throw new MissingMethodException(string.Format("Unknown Feature: {0}", feature));
        }

        public virtual ActionResult ClientError(string SessionId, string DeviceIdentifier, string JsonException)
        {

            string clientVersion = Request.UserAgent;
            string clientIP = Request.UserHostAddress;
            string errorMessage;

            try
            {
                var ex = JsonConvert.DeserializeObject<Exception>(JsonException);
                errorMessage = ex.Message;
            }
            catch (Exception)
            {
                try
                {
                    dynamic ex = JsonConvert.DeserializeObject(JsonException);
                    errorMessage = ex.Message;
                }
                catch (Exception)
                {
                    errorMessage = "Unable to determine the error message; Export log for more information";
                }
            }

            if (string.IsNullOrEmpty(SessionId))
                Disco.BI.DeviceBI.EnrolmentLog.LogClientError(clientIP, DeviceIdentifier, clientVersion, errorMessage, JsonException);
            else
                Disco.BI.DeviceBI.EnrolmentLog.LogSessionClientError(SessionId, clientIP, DeviceIdentifier, clientVersion, errorMessage, JsonException);

            return Content("Error Message Logged");
        }

    }
}
