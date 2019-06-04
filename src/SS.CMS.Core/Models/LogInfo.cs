﻿using System;
using SS.CMS.Plugin;
using SS.CMS.Plugin.Data;

namespace SS.CMS.Core.Models
{
    [Table("siteserver_Log")]
    public class LogInfo : Entity, ILogInfo
    {
        public const string AdminLogin = "后台管理员登录";

        [TableColumn]
        public string UserName { get; set; }

        [TableColumn]
        public string IpAddress { get; set; }

        [TableColumn]
        public DateTime? AddDate { get; set; }

        [TableColumn]
        public string Action { get; set; }

        [TableColumn]
        public string Summary { get; set; }
    }
}