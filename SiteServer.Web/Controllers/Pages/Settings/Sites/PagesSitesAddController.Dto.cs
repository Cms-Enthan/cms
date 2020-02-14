﻿using System.Collections.Generic;
using SiteServer.CMS.Context.Enumerations;
using SiteServer.CMS.Core;
using SiteServer.CMS.Dto;

namespace SiteServer.API.Controllers.Pages.Settings.Sites
{
    public partial class PagesSitesAddController
    {
        public class GetResult
        {
            public List<SiteTemplateInfo> SiteTemplates { get; set; }
            public bool RootExists { get; set; }
            public List<Cascade<int>> Sites { get; set; }
            public List<string> TableNameList { get; set; }
            public string Guid { get; set; }
        }

        public class SubmitRequest
        {
            public string Guid { get; set; }
            public string CreateType { get; set; }
            public string CreateTemplateId { get; set; }
            public string SiteName { get; set; }
            public bool Root { get; set; }
            public int ParentId { get; set; }
            public string SiteDir { get; set; }
            public ETableRule TableRule { get; set; }
            public string TableChoose { get; set; }
            public string TableHandWrite { get; set; }
            public bool IsImportContents { get; set; }
            public bool IsImportTableStyles { get; set; }
        }

        public class ProcessRequest
        {
            public string Guid { get; set; }
        }
    }
}