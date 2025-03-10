// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


namespace Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;

internal class FilterOperatorSchemaModel
{
    [JsonPropertyName("arity")]
    public ScopeOperatorTypeConstant? Arity { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("multivaluedComparisonType")]
    public ScopeOperatorMultiValuedComparisonTypeConstant? MultivaluedComparisonType { get; set; }

    [JsonPropertyName("@odata.type")]
    public string? ODataType { get; set; }

    [JsonPropertyName("supportedAttributeTypes")]
    public List<AttributeTypeConstant>? SupportedAttributeTypes { get; set; }
}
