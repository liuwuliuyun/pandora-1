// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


namespace Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;

internal class SubjectRightsRequestDetailModel
{
    [JsonPropertyName("excludedItemCount")]
    public long? ExcludedItemCount { get; set; }

    [JsonPropertyName("insightCounts")]
    public List<KeyValuePairModel>? InsightCounts { get; set; }

    [JsonPropertyName("itemCount")]
    public long? ItemCount { get; set; }

    [JsonPropertyName("itemNeedReview")]
    public long? ItemNeedReview { get; set; }

    [JsonPropertyName("@odata.type")]
    public string? ODataType { get; set; }

    [JsonPropertyName("productItemCounts")]
    public List<KeyValuePairModel>? ProductItemCounts { get; set; }

    [JsonPropertyName("signedOffItemCount")]
    public long? SignedOffItemCount { get; set; }

    [JsonPropertyName("totalItemSize")]
    public long? TotalItemSize { get; set; }
}
