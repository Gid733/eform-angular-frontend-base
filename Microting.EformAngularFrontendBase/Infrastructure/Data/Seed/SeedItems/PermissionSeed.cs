﻿/*
The MIT License (MIT)

Copyright (c) 2007 - 2021 Microting A/S

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/

namespace Microting.EformAngularFrontendBase.Infrastructure.Data.Seed.SeedItems
{
    using Const;
    using Entities.Permissions;
    using Microsoft.EntityFrameworkCore;

    public static class PermissionSeed
    {
        public static ModelBuilder AddPermissions(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Permission>().HasData(
                new Permission()
                {
                    Id = AuthConsts.DbIds.Permissions.WorkersClaims.Read,
                    ClaimName = AuthConsts.EformClaims.WorkersClaims.Read,
                    PermissionName = "Read",
                    PermissionTypeId = AuthConsts.DbIds.PermissionTypes.Workers
                },
                new Permission()
                {
                    Id = AuthConsts.DbIds.Permissions.WorkersClaims.Create,
                    ClaimName = AuthConsts.EformClaims.WorkersClaims.Create,
                    PermissionName = "Create",
                    PermissionTypeId = AuthConsts.DbIds.PermissionTypes.Workers
                },
                new Permission()
                {
                    Id = AuthConsts.DbIds.Permissions.WorkersClaims.Delete,
                    ClaimName = AuthConsts.EformClaims.WorkersClaims.Delete,
                    PermissionName = "Delete",
                    PermissionTypeId = AuthConsts.DbIds.PermissionTypes.Workers
                },
                new Permission()
                {
                    Id = AuthConsts.DbIds.Permissions.WorkersClaims.Update,
                    ClaimName = AuthConsts.EformClaims.WorkersClaims.Update,
                    PermissionName = "Update",
                    PermissionTypeId = AuthConsts.DbIds.PermissionTypes.Workers
                },
                new Permission()
                {
                    Id = AuthConsts.DbIds.Permissions.SitesClaims.Read,
                    ClaimName = AuthConsts.EformClaims.SitesClaims.Read,
                    PermissionName = "Read",
                    PermissionTypeId = AuthConsts.DbIds.PermissionTypes.Sites
                },
                new Permission()
                {
                    Id = AuthConsts.DbIds.Permissions.SitesClaims.Delete,
                    ClaimName = AuthConsts.EformClaims.SitesClaims.Delete,
                    PermissionName = "Delete",
                    PermissionTypeId = AuthConsts.DbIds.PermissionTypes.Sites
                },
                new Permission()
                {
                    Id = AuthConsts.DbIds.Permissions.SitesClaims.Update,
                    ClaimName = AuthConsts.EformClaims.SitesClaims.Update,
                    PermissionName = "Update",
                    PermissionTypeId = AuthConsts.DbIds.PermissionTypes.Sites
                },
                new Permission()
                {
                    Id = AuthConsts.DbIds.Permissions.EntitySearchClaims.Read,
                    ClaimName = AuthConsts.EformClaims.EntitySearchClaims.Read,
                    PermissionName = "Read",
                    PermissionTypeId = AuthConsts.DbIds.PermissionTypes.EntitySearch
                },
                new Permission()
                {
                    Id = AuthConsts.DbIds.Permissions.EntitySearchClaims.Create,
                    ClaimName = AuthConsts.EformClaims.EntitySearchClaims.Create,
                    PermissionName = "Create",
                    PermissionTypeId = AuthConsts.DbIds.PermissionTypes.EntitySearch
                },
                new Permission()
                {
                    Id = AuthConsts.DbIds.Permissions.EntitySearchClaims.Delete,
                    ClaimName = AuthConsts.EformClaims.EntitySearchClaims.Delete,
                    PermissionName = "Delete",
                    PermissionTypeId = AuthConsts.DbIds.PermissionTypes.EntitySearch
                },
                new Permission()
                {
                    Id = AuthConsts.DbIds.Permissions.EntitySearchClaims.Update,
                    ClaimName = AuthConsts.EformClaims.EntitySearchClaims.Update,
                    PermissionName = "Update",
                    PermissionTypeId = AuthConsts.DbIds.PermissionTypes.EntitySearch
                },
                new Permission()
                {
                    Id = AuthConsts.DbIds.Permissions.EntitySelectClaims.Read,
                    ClaimName = AuthConsts.EformClaims.EntitySelectClaims.Read,
                    PermissionName = "Read",
                    PermissionTypeId = AuthConsts.DbIds.PermissionTypes.EntitySelect
                },
                new Permission()
                {
                    Id = AuthConsts.DbIds.Permissions.EntitySelectClaims.Create,
                    ClaimName = AuthConsts.EformClaims.EntitySelectClaims.Create,
                    PermissionName = "Create",
                    PermissionTypeId = AuthConsts.DbIds.PermissionTypes.EntitySelect
                },
                new Permission()
                {
                    Id = AuthConsts.DbIds.Permissions.EntitySelectClaims.Delete,
                    ClaimName = AuthConsts.EformClaims.EntitySelectClaims.Delete,
                    PermissionName = "Delete",
                    PermissionTypeId = AuthConsts.DbIds.PermissionTypes.EntitySelect
                },
                new Permission()
                {
                    Id = AuthConsts.DbIds.Permissions.EntitySelectClaims.Update,
                    ClaimName = AuthConsts.EformClaims.EntitySelectClaims.Update,
                    PermissionName = "Update",
                    PermissionTypeId = AuthConsts.DbIds.PermissionTypes.EntitySelect
                },
                // User management
                new Permission()
                {
                    Id = AuthConsts.DbIds.Permissions.UserManagementClaims.Read,
                    ClaimName = AuthConsts.EformClaims.UserManagementClaims.Read,
                    PermissionName = "Read",
                    PermissionTypeId = AuthConsts.DbIds.PermissionTypes.UserManagement
                },
                new Permission()
                {
                    Id = AuthConsts.DbIds.Permissions.UserManagementClaims.Create,
                    ClaimName = AuthConsts.EformClaims.UserManagementClaims.Create,
                    PermissionName = "Create",
                    PermissionTypeId = AuthConsts.DbIds.PermissionTypes.UserManagement
                },
                new Permission()
                {
                    Id = AuthConsts.DbIds.Permissions.UserManagementClaims.Delete,
                    ClaimName = AuthConsts.EformClaims.UserManagementClaims.Delete,
                    PermissionName = "Delete",
                    PermissionTypeId = AuthConsts.DbIds.PermissionTypes.UserManagement
                },
                new Permission()
                {
                    Id = AuthConsts.DbIds.Permissions.UserManagementClaims.Update,
                    ClaimName = AuthConsts.EformClaims.UserManagementClaims.Update,
                    PermissionName = "Update",
                    PermissionTypeId = AuthConsts.DbIds.PermissionTypes.UserManagement
                },
                // Units
                new Permission()
                {
                    Id = AuthConsts.DbIds.Permissions.Units.Read,
                    ClaimName = AuthConsts.EformClaims.UnitsClaims.Read,
                    PermissionName = "Read",
                    PermissionTypeId = AuthConsts.DbIds.PermissionTypes.Units
                },
                new Permission()
                {
                    Id = AuthConsts.DbIds.Permissions.Units.Update,
                    ClaimName = AuthConsts.EformClaims.UnitsClaims.Update,
                    PermissionName = "Update",
                    PermissionTypeId = AuthConsts.DbIds.PermissionTypes.Units
                },
                // Device users
                new Permission()
                {
                    Id = AuthConsts.DbIds.Permissions.DeviceUsers.Read,
                    ClaimName = AuthConsts.EformClaims.DeviceUsersClaims.Read,
                    PermissionName = "Read",
                    PermissionTypeId = AuthConsts.DbIds.PermissionTypes.DeviceUsers
                },
                new Permission()
                {
                    Id = AuthConsts.DbIds.Permissions.DeviceUsers.Create,
                    ClaimName = AuthConsts.EformClaims.DeviceUsersClaims.Create,
                    PermissionName = "Create",
                    PermissionTypeId = AuthConsts.DbIds.PermissionTypes.DeviceUsers
                },
                new Permission()
                {
                    Id = AuthConsts.DbIds.Permissions.DeviceUsers.Delete,
                    ClaimName = AuthConsts.EformClaims.DeviceUsersClaims.Delete,
                    PermissionName = "Delete",
                    PermissionTypeId = AuthConsts.DbIds.PermissionTypes.DeviceUsers
                },
                new Permission()
                {
                    Id = AuthConsts.DbIds.Permissions.DeviceUsers.Update,
                    ClaimName = AuthConsts.EformClaims.DeviceUsersClaims.Update,
                    PermissionName = "Update",
                    PermissionTypeId = AuthConsts.DbIds.PermissionTypes.DeviceUsers
                },
                // Eforms
                new Permission()
                {
                    Id = AuthConsts.DbIds.Permissions.Eforms.Create,
                    ClaimName = AuthConsts.EformClaims.EformsClaims.Create,
                    PermissionName = "Create",
                    PermissionTypeId = AuthConsts.DbIds.PermissionTypes.Eforms
                },
                new Permission()
                {
                    Id = AuthConsts.DbIds.Permissions.Eforms.Delete,
                    ClaimName = AuthConsts.EformClaims.EformsClaims.Delete,
                    PermissionName = "Delete",
                    PermissionTypeId = AuthConsts.DbIds.PermissionTypes.Eforms
                },
                new Permission()
                {
                    Id = AuthConsts.DbIds.Permissions.Eforms.Read,
                    ClaimName = AuthConsts.EformClaims.EformsClaims.Read,
                    PermissionName = "Read",
                    PermissionTypeId = AuthConsts.DbIds.PermissionTypes.Eforms
                },
                new Permission()
                {
                    Id = AuthConsts.DbIds.Permissions.Eforms.UpdateColumns,
                    ClaimName = AuthConsts.EformClaims.EformsClaims.UpdateColumns,
                    PermissionName = "Update columns",
                    PermissionTypeId = AuthConsts.DbIds.PermissionTypes.Eforms
                },
                new Permission()
                {
                    Id = AuthConsts.DbIds.Permissions.Eforms.DownloadXml,
                    ClaimName = AuthConsts.EformClaims.EformsClaims.DownloadXml,
                    PermissionName = "Download XML",
                    PermissionTypeId = AuthConsts.DbIds.PermissionTypes.Eforms
                },
                new Permission()
                {
                    Id = AuthConsts.DbIds.Permissions.Eforms.UploadZip,
                    ClaimName = AuthConsts.EformClaims.EformsClaims.UploadZip,
                    PermissionName = "Upload ZIP",
                    PermissionTypeId = AuthConsts.DbIds.PermissionTypes.Eforms
                },
                new Permission()
                {
                    Id = AuthConsts.DbIds.Permissions.Cases.CasesRead,
                    ClaimName = AuthConsts.EformClaims.CasesClaims.CasesRead,
                    PermissionName = "Cases read",
                    PermissionTypeId = AuthConsts.DbIds.PermissionTypes.Cases
                },
                new Permission()
                {
                    Id = AuthConsts.DbIds.Permissions.Cases.CaseRead,
                    ClaimName = AuthConsts.EformClaims.CasesClaims.CaseRead,
                    PermissionName = "Case read",
                    PermissionTypeId = AuthConsts.DbIds.PermissionTypes.Cases
                },
                new Permission()
                {
                    Id = AuthConsts.DbIds.Permissions.Cases.CaseUpdate,
                    ClaimName = AuthConsts.EformClaims.CasesClaims.CaseUpdate,
                    PermissionName = "Case update",
                    PermissionTypeId = AuthConsts.DbIds.PermissionTypes.Cases
                },
                new Permission()
                {
                    Id = AuthConsts.DbIds.Permissions.Cases.CaseDelete,
                    ClaimName = AuthConsts.EformClaims.CasesClaims.CaseDelete,
                    PermissionName = "Case delete",
                    PermissionTypeId = AuthConsts.DbIds.PermissionTypes.Cases
                },
                new Permission()
                {
                    Id = AuthConsts.DbIds.Permissions.Cases.CaseGetPdf,
                    ClaimName = AuthConsts.EformClaims.CasesClaims.CaseGetPdf,
                    PermissionName = "Get PDF",
                    PermissionTypeId = AuthConsts.DbIds.PermissionTypes.Cases
                },
                new Permission()
                {
                    Id = AuthConsts.DbIds.Permissions.Cases.CaseGetDocx,
                    ClaimName = AuthConsts.EformClaims.CasesClaims.CaseGetDocx,
                    PermissionName = "Get DOCX",
                    PermissionTypeId = AuthConsts.DbIds.PermissionTypes.Cases
                },
                new Permission()
                {
                    Id = AuthConsts.DbIds.Permissions.Cases.CaseGetPptx,
                    ClaimName = AuthConsts.EformClaims.CasesClaims.CaseGetPptx,
                    PermissionName = "Get PPTX",
                    PermissionTypeId = AuthConsts.DbIds.PermissionTypes.Cases
                },
                new Permission()
                {
                    Id = AuthConsts.DbIds.Permissions.Eforms.PairingRead,
                    ClaimName = AuthConsts.EformClaims.EformsClaims.PairingRead,
                    PermissionName = "Pairing read",
                    PermissionTypeId = AuthConsts.DbIds.PermissionTypes.Eforms
                },
                new Permission()
                {
                    Id = AuthConsts.DbIds.Permissions.Eforms.PairingUpdate,
                    ClaimName = AuthConsts.EformClaims.EformsClaims.PairingUpdate,
                    PermissionName = "Pairing update",
                    PermissionTypeId = AuthConsts.DbIds.PermissionTypes.Eforms
                },
                new Permission()
                {
                    Id = AuthConsts.DbIds.Permissions.Eforms.ReadTags,
                    ClaimName = AuthConsts.EformClaims.EformsClaims.ReadTags,
                    PermissionName = "Read tags",
                    PermissionTypeId = AuthConsts.DbIds.PermissionTypes.Eforms
                },
                new Permission()
                {
                    Id = AuthConsts.DbIds.Permissions.Eforms.UpdateTags,
                    ClaimName = AuthConsts.EformClaims.EformsClaims.UpdateTags,
                    PermissionName = "Update tags",
                    PermissionTypeId = AuthConsts.DbIds.PermissionTypes.Eforms
                },
                new Permission()
                {
                    Id = AuthConsts.DbIds.Permissions.Eforms.GetCsv,
                    ClaimName = AuthConsts.EformClaims.EformsClaims.GetCsv,
                    PermissionName = "Get CSV",
                    PermissionTypeId = AuthConsts.DbIds.PermissionTypes.Eforms
                },
                new Permission()
                {
                    Id = AuthConsts.DbIds.Permissions.Eforms.ReadJasperReport,
                    ClaimName = AuthConsts.EformClaims.EformsClaims.ReadJasperReport,
                    PermissionName = "Read Jasper Report",
                    PermissionTypeId = AuthConsts.DbIds.PermissionTypes.Eforms
                },
                new Permission()
                {
                    Id = AuthConsts.DbIds.Permissions.Eforms.UpdateJasperReport,
                    ClaimName = AuthConsts.EformClaims.EformsClaims.UpdateJasperReport,
                    PermissionName = "Update Jasper Report",
                    PermissionTypeId = AuthConsts.DbIds.PermissionTypes.Eforms
                },
                new Permission()
                {
                    Id = AuthConsts.DbIds.Permissions.Eforms.ExportEformExcel,
                    ClaimName = AuthConsts.EformClaims.EformsClaims.ExportEformExcel,
                    PermissionName = "Export eForm excel",
                    PermissionTypeId = AuthConsts.DbIds.PermissionTypes.Eforms
                },
                new Permission()
                {
                    Id = AuthConsts.DbIds.Permissions.EmailRecipients.Create,
                    ClaimName = AuthConsts.EformClaims.EmailRecipientsClaims.Create,
                    PermissionName = "Create e-mail recipients",
                    PermissionTypeId = AuthConsts.DbIds.PermissionTypes.EmailRecipients
                },
                new Permission()
                {
                    Id = AuthConsts.DbIds.Permissions.EmailRecipients.Delete,
                    ClaimName = AuthConsts.EformClaims.EmailRecipientsClaims.Delete,
                    PermissionName = "Delete e-mail recipients",
                    PermissionTypeId = AuthConsts.DbIds.PermissionTypes.EmailRecipients
                },
                new Permission()
                {
                    Id = AuthConsts.DbIds.Permissions.EmailRecipients.Read,
                    ClaimName = AuthConsts.EformClaims.EmailRecipientsClaims.Read,
                    PermissionName = "Read e-mail recipients",
                    PermissionTypeId = AuthConsts.DbIds.PermissionTypes.EmailRecipients
                },
                new Permission()
                {
                    Id = AuthConsts.DbIds.Permissions.Eforms.AllowManagingEformTags,
                    ClaimName = AuthConsts.EformClaims.EformsClaims.AllowManagingEformTags,
                    PermissionName = "Allow managing eform tags",
                    PermissionTypeId = AuthConsts.DbIds.PermissionTypes.Eforms
                }
            );
            return modelBuilder;
        }
    }
}