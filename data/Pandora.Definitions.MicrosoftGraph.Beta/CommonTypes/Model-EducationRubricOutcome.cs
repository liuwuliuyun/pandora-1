// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


namespace Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;

internal class EducationRubricOutcomeModel
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("lastModifiedBy")]
    public IdentitySetModel? LastModifiedBy { get; set; }

    [JsonPropertyName("lastModifiedDateTime")]
    public DateTime? LastModifiedDateTime { get; set; }

    [JsonPropertyName("@odata.type")]
    public string? ODataType { get; set; }

    [JsonPropertyName("publishedRubricQualityFeedback")]
    public List<RubricQualityFeedbackModelModel>? PublishedRubricQualityFeedback { get; set; }

    [JsonPropertyName("publishedRubricQualitySelectedLevels")]
    public List<RubricQualitySelectedColumnModelModel>? PublishedRubricQualitySelectedLevels { get; set; }

    [JsonPropertyName("rubricQualityFeedback")]
    public List<RubricQualityFeedbackModelModel>? RubricQualityFeedback { get; set; }

    [JsonPropertyName("rubricQualitySelectedLevels")]
    public List<RubricQualitySelectedColumnModelModel>? RubricQualitySelectedLevels { get; set; }
}
