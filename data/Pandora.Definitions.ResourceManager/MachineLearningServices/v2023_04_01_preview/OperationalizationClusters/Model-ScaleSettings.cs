using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.MachineLearningServices.v2023_04_01_preview.OperationalizationClusters;


internal class ScaleSettingsModel
{
    [JsonPropertyName("maxNodeCount")]
    [Required]
    public int MaxNodeCount { get; set; }

    [JsonPropertyName("minNodeCount")]
    public int? MinNodeCount { get; set; }

    [JsonPropertyName("nodeIdleTimeBeforeScaleDown")]
    public string? NodeIdleTimeBeforeScaleDown { get; set; }
}
