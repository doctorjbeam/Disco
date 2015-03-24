﻿using Disco.Models.Services.Devices.Exporting;
using Disco.Models.UI.Device;
using System.Collections.Generic;

namespace Disco.Web.Models.Device
{
    public class ExportModel : DeviceExportModel
    {
        public DeviceExportOptions Options { get; set; }

        public string ExportSessionId { get; set; }
        public DeviceExportResult ExportSessionResult { get; set; }

        public IEnumerable<KeyValuePair<int, string>> DeviceBatches { get; set; }
        public IEnumerable<KeyValuePair<int, string>> DeviceModels { get; set; }
        public IEnumerable<KeyValuePair<int, string>> DeviceProfiles { get; set; }
    }
}