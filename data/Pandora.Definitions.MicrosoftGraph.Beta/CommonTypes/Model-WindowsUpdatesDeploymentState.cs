// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


namespace Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;

internal class WindowsUpdatesDeploymentStateModel
{
    [JsonPropertyName("effectiveValue")]
    public DeploymentStateValueConstant? EffectiveValue { get; set; }

    [JsonPropertyName("@odata.type")]
    public string? ODataType { get; set; }

    [JsonPropertyName("reasons")]
    public List<DeploymentStateReasonModel>? Reasons { get; set; }

    [JsonPropertyName("requestedValue")]
    public RequestedDeploymentStateValueConstant? RequestedValue { get; set; }
}
