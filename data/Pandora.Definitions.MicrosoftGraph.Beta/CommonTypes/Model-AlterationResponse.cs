// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


namespace Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;

internal class AlterationResponseModel
{
    [JsonPropertyName("@odata.type")]
    public string? ODataType { get; set; }

    [JsonPropertyName("originalQueryString")]
    public string? OriginalQueryString { get; set; }

    [JsonPropertyName("queryAlteration")]
    public SearchAlterationModel? QueryAlteration { get; set; }

    [JsonPropertyName("queryAlterationType")]
    public SearchAlterationTypeConstant? QueryAlterationType { get; set; }
}
