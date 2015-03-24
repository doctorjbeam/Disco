﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Disco.Models.Repository;
using Disco.Data.Repository;
using System.IO;
using Disco.Models.BI.DocumentTemplates;
using Disco.Services.Interop.ActiveDirectory;

namespace Disco.BI.Extensions
{
    public static class UserExtensions
    {
        public static UserAttachment CreateAttachment(this User User, DiscoDataContext Database, User CreatorUser, string Filename, string MimeType, string Comments, Stream Content, DocumentTemplate DocumentTemplate = null, byte[] PdfThumbnail = null)
        {
            if (string.IsNullOrEmpty(MimeType) || MimeType.Equals("unknown/unknown", StringComparison.OrdinalIgnoreCase))
                MimeType = Interop.MimeTypes.ResolveMimeType(Filename);

            UserAttachment ua = new UserAttachment()
            {
                UserId = User.UserId,
                TechUserId = CreatorUser.UserId,
                Filename = Filename,
                MimeType = MimeType,
                Timestamp = DateTime.Now,
                Comments = Comments
            };

            if (DocumentTemplate != null)
                ua.DocumentTemplateId = DocumentTemplate.Id;

            Database.UserAttachments.Add(ua);
            Database.SaveChanges();

            ua.SaveAttachment(Database, Content);
            Content.Position = 0;
            if (PdfThumbnail == null)
                ua.GenerateThumbnail(Database, Content);
            else
                ua.SaveThumbnailAttachment(Database, PdfThumbnail);

            return ua;
        }

        public static List<DocumentTemplate> AvailableDocumentTemplates(this User u, DiscoDataContext Database, User User, DateTime TimeStamp)
        {
            var dts = Database.DocumentTemplates.Include("JobSubTypes")
               .Where(dt => dt.Scope == DocumentTemplate.DocumentTemplateScopes.User)
               .ToArray()
               .Where(dt => dt.FilterExpressionMatches(u, Database, User, TimeStamp, DocumentState.DefaultState())).ToList();

            return dts;
        }

        public static List<DeviceUserAssignment> CurrentDeviceUserAssignments(this User u)
        {
            return u.DeviceUserAssignments.Where(dua => !dua.UnassignedDate.HasValue).ToList();
        }
        public static ADUserAccount ActiveDirectoryAccount(this User User, params string[] AdditionalProperties)
        {
            return ActiveDirectory.RetrieveADUserAccount(User.UserId, AdditionalProperties);
        }

        public static bool CanCreateJob(this User u)
        {
            if (!JobActionExtensions.CanCreate())
                return false;

            return true;
        }
    }
}
