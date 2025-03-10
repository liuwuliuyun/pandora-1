// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


namespace Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;

internal class ManagedTenantAlertModel
{
    [JsonPropertyName("alertData")]
    public AlertDataModel? AlertData { get; set; }

    [JsonPropertyName("alertDataReferenceStrings")]
    public List<AlertDataReferenceStringModel>? AlertDataReferenceStrings { get; set; }

    [JsonPropertyName("alertLogs")]
    public List<ManagedTenantAlertLogModel>? AlertLogs { get; set; }

    [JsonPropertyName("alertRule")]
    public ManagedTenantAlertRuleModel? AlertRule { get; set; }

    [JsonPropertyName("alertRuleDisplayName")]
    public string? AlertRuleDisplayName { get; set; }

    [JsonPropertyName("apiNotifications")]
    public List<ManagedTenantApiNotificationModel>? ApiNotifications { get; set; }

    [JsonPropertyName("assignedToUserId")]
    public string? AssignedToUserId { get; set; }

    [JsonPropertyName("correlationCount")]
    public int? CorrelationCount { get; set; }

    [JsonPropertyName("correlationId")]
    public string? CorrelationId { get; set; }

    [JsonPropertyName("createdByUserId")]
    public string? CreatedByUserId { get; set; }

    [JsonPropertyName("createdDateTime")]
    public DateTime? CreatedDateTime { get; set; }

    [JsonPropertyName("emailNotifications")]
    public List<ManagedTenantEmailNotificationModel>? EmailNotifications { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("lastActionByUserId")]
    public string? LastActionByUserId { get; set; }

    [JsonPropertyName("lastActionDateTime")]
    public DateTime? LastActionDateTime { get; set; }

    [JsonPropertyName("message")]
    public string? Message { get; set; }

    [JsonPropertyName("@odata.type")]
    public string? ODataType { get; set; }

    [JsonPropertyName("severity")]
    public AlertSeverityConstant? Severity { get; set; }

    [JsonPropertyName("status")]
    public AlertStatusConstant? Status { get; set; }

    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    [JsonPropertyName("title")]
    public string? Title { get; set; }
}
