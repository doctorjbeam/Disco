﻿using System.Collections.Generic;

namespace Disco.Models.BI.Device
{
    public class ImportDeviceSession
    {
        public string ImportParseTaskId { get; set; }
        public string ImportFilename { get; set; }
        public List<ImportDevice> ImportDevices { get; set; }
    }
}