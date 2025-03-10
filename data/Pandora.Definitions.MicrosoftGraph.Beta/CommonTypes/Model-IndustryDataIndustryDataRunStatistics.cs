// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


namespace Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;

internal class IndustryDataIndustryDataRunStatisticsModel
{
    [JsonPropertyName("activityStatistics")]
    public List<IndustryDataActivityStatisticsModel>? ActivityStatistics { get; set; }

    [JsonPropertyName("inboundTotals")]
    public AggregatedInboundStatisticsModel? InboundTotals { get; set; }

    [JsonPropertyName("@odata.type")]
    public string? ODataType { get; set; }

    [JsonPropertyName("runId")]
    public string? RunId { get; set; }

    [JsonPropertyName("status")]
    public IndustryDataRunStatusConstant? Status { get; set; }
}
