using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Network.v2023_02_01.ApplicationGatewayWafDynamicManifests;


internal class ApplicationGatewayFirewallManifestRuleSetModel
{
    [JsonPropertyName("ruleGroups")]
    [Required]
    public List<ApplicationGatewayFirewallRuleGroupModel> RuleGroups { get; set; }

    [JsonPropertyName("ruleSetType")]
    [Required]
    public string RuleSetType { get; set; }

    [JsonPropertyName("ruleSetVersion")]
    [Required]
    public string RuleSetVersion { get; set; }

    [JsonPropertyName("status")]
    public ApplicationGatewayRuleSetStatusOptionsConstant? Status { get; set; }

    [JsonPropertyName("tiers")]
    public List<ApplicationGatewayTierTypesConstant>? Tiers { get; set; }
}
