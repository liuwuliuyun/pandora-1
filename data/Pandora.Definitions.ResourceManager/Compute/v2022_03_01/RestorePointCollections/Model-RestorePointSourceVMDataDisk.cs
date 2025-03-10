using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Compute.v2022_03_01.RestorePointCollections;


internal class RestorePointSourceVMDataDiskModel
{
    [JsonPropertyName("caching")]
    public CachingTypesConstant? Caching { get; set; }

    [JsonPropertyName("diskRestorePoint")]
    public ApiEntityReferenceModel? DiskRestorePoint { get; set; }

    [JsonPropertyName("diskSizeGB")]
    public int? DiskSizeGB { get; set; }

    [JsonPropertyName("lun")]
    public int? Lun { get; set; }

    [JsonPropertyName("managedDisk")]
    public ManagedDiskParametersModel? ManagedDisk { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
