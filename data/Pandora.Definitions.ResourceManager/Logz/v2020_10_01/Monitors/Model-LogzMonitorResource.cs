using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Logz.v2020_10_01.Monitors;


internal class LogzMonitorResourceModel
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("identity")]
    public IdentityPropertiesModel? Identity { get; set; }

    [JsonPropertyName("location")]
    [Required]
    public CustomTypes.Location Location { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("properties")]
    public MonitorPropertiesModel? Properties { get; set; }

    [JsonPropertyName("systemData")]
    public CustomTypes.SystemData? SystemData { get; set; }

    [JsonPropertyName("tags")]
    public CustomTypes.Tags? Tags { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
