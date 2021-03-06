﻿using Disco.Data.Repository;
using Disco.Models.Repository;
using Disco.Models.Services.Devices.Importing;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Disco.Services.Devices.Importing.Fields
{
    internal class DeviceAssetNumberImportField : DeviceImportFieldBase
    {
        private string parsedValue;
        private string previousValue;

        public override DeviceImportFieldTypes FieldType { get { return DeviceImportFieldTypes.DeviceAssetNumber; } }

        public override object RawParsedValue { get { return parsedValue; } }
        public override string FriendlyValue { get { return parsedValue; } }
        public override string FriendlyPreviousValue { get { return previousValue; } }

        public override bool Parse(DiscoDataContext Database, IDeviceImportCache Cache, DeviceImportContext Context, int RecordIndex, string DeviceSerialNumber, Device ExistingDevice, Dictionary<DeviceImportFieldTypes, string> Values, string Value)
        {
            if (string.IsNullOrWhiteSpace(Value))
                parsedValue = null;
            else
            {
                parsedValue = Value.Trim();
                if (parsedValue.Length > 40)
                    return Error("Cannot be more than 40 characters");
            }

            if (ExistingDevice == null && parsedValue != null)
                return Success(EntityState.Added);
            else if (ExistingDevice != null && ExistingDevice.AssetNumber != parsedValue)
            {
                previousValue = ExistingDevice.AssetNumber;
                return Success(EntityState.Modified);
            }
            else
                return Success(EntityState.Unchanged);
        }

        public override bool Apply(DiscoDataContext Database, Device Device)
        {
            if (this.FieldAction == EntityState.Added ||
                this.FieldAction == EntityState.Modified)
            {
                Device.AssetNumber = this.parsedValue;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int? GuessHeader(DiscoDataContext Database, DeviceImportContext Context)
        {
            // 'asset' in column name
            var possibleColumns = Context.Header
                .Select((h, i) => Tuple.Create(h, i))
                .Where(h => h.Item1.Item2 == DeviceImportFieldTypes.IgnoreColumn && h.Item1.Item1.IndexOf("asset", System.StringComparison.OrdinalIgnoreCase) >= 0);

            return possibleColumns.Select(h => (int?)h.Item2).FirstOrDefault();
        }
    }
}
