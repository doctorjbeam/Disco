﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Disco.Data.Repository;
using Disco.Models.Repository;
using Disco.Models.UI.Config.DocumentTemplate;
using Disco.BI.DocumentTemplateBI.ManagedGroups;

namespace Disco.Web.Areas.Config.Models.DocumentTemplate
{
    public class ShowModel : ConfigDocumentTemplateShowModel
    {
        public Disco.Models.Repository.DocumentTemplate DocumentTemplate { get; set; }

        public int StoredInstanceCount { get; set; }

        public List<Disco.BI.Expressions.Expression> TemplateExpressions { get; set; }

        public List<Disco.Models.Repository.JobType> JobTypes { get; set; }

        public List<string> Scopes
        {
            get
            {
                return Disco.Models.Repository.DocumentTemplate.DocumentTemplateScopes.ToList();
            }
        }

        public DocumentTemplateDevicesManagedGroup DevicesLinkedGroup { get; set; }
        public DocumentTemplateUsersManagedGroup UsersLinkedGroup { get; set; }

        public void UpdateModel(DiscoDataContext Database)
        {

            switch (this.DocumentTemplate.Scope)
            {
                case Disco.Models.Repository.DocumentTemplate.DocumentTemplateScopes.Device:
                    this.StoredInstanceCount = Database.DeviceAttachments.Count(a => a.DocumentTemplateId == this.DocumentTemplate.Id);
                    break;
                case Disco.Models.Repository.DocumentTemplate.DocumentTemplateScopes.Job:
                    this.StoredInstanceCount = Database.JobAttachments.Count(a => a.DocumentTemplateId == this.DocumentTemplate.Id);
                    break;
                case Disco.Models.Repository.DocumentTemplate.DocumentTemplateScopes.User:
                    this.StoredInstanceCount = Database.UserAttachments.Count(a => a.DocumentTemplateId == this.DocumentTemplate.Id);
                    break;
            }

            if (this.JobTypes == null)
                JobTypes = Database.JobTypes.Include("JobSubTypes").ToList();
        }
    }
}