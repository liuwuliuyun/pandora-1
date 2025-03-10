using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.PostgreSql.v2023_03_01_preview.FlexibleServerCapabilities;


internal class ServerSkuCapabilityModel
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    [JsonPropertyName("status")]
    public CapabilityStatusConstant? Status { get; set; }

    [JsonPropertyName("supportedHaMode")]
    public List<HaModeConstant>? SupportedHaMode { get; set; }

    [JsonPropertyName("supportedIops")]
    public int? SupportedIops { get; set; }

    [JsonPropertyName("supportedMemoryPerVcoreMb")]
    public int? SupportedMemoryPerVcoreMb { get; set; }

    [JsonPropertyName("supportedZones")]
    public List<string>? SupportedZones { get; set; }

    [JsonPropertyName("vCores")]
    public int? VCores { get; set; }
}
