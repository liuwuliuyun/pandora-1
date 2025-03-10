using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.ContainerApps.v2022_11_01_preview.Diagnostics;


internal class WorkloadProfileModel
{
    [JsonPropertyName("maximumCount")]
    public int? MaximumCount { get; set; }

    [JsonPropertyName("minimumCount")]
    public int? MinimumCount { get; set; }

    [JsonPropertyName("name")]
    [Required]
    public string Name { get; set; }

    [JsonPropertyName("workloadProfileType")]
    [Required]
    public string WorkloadProfileType { get; set; }
}
