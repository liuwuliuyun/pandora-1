using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Insights.v2021_05_01_preview.AutoScaleSettings;


internal class ScaleRuleMetricDimensionModel
{
    [JsonPropertyName("DimensionName")]
    [Required]
    public string DimensionName { get; set; }

    [JsonPropertyName("Operator")]
    [Required]
    public ScaleRuleMetricDimensionOperationTypeConstant Operator { get; set; }

    [JsonPropertyName("Values")]
    [Required]
    public List<string> Values { get; set; }
}
