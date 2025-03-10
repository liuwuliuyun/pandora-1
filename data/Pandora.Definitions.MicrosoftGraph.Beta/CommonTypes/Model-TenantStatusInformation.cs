// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


namespace Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;

internal class TenantStatusInformationModel
{
    [JsonPropertyName("delegatedPrivilegeStatus")]
    public DelegatedPrivilegeStatusConstant? DelegatedPrivilegeStatus { get; set; }

    [JsonPropertyName("lastDelegatedPrivilegeRefreshDateTime")]
    public DateTime? LastDelegatedPrivilegeRefreshDateTime { get; set; }

    [JsonPropertyName("@odata.type")]
    public string? ODataType { get; set; }

    [JsonPropertyName("offboardedByUserId")]
    public string? OffboardedByUserId { get; set; }

    [JsonPropertyName("offboardedDateTime")]
    public DateTime? OffboardedDateTime { get; set; }

    [JsonPropertyName("onboardedByUserId")]
    public string? OnboardedByUserId { get; set; }

    [JsonPropertyName("onboardedDateTime")]
    public DateTime? OnboardedDateTime { get; set; }

    [JsonPropertyName("onboardingStatus")]
    public TenantOnboardingStatusConstant? OnboardingStatus { get; set; }

    [JsonPropertyName("tenantOnboardingEligibilityReason")]
    public TenantOnboardingEligibilityReasonConstant? TenantOnboardingEligibilityReason { get; set; }

    [JsonPropertyName("workloadStatuses")]
    public List<WorkloadStatusModel>? WorkloadStatuses { get; set; }
}
