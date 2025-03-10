// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


namespace Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;

internal class RunModel
{
    [JsonPropertyName("completedDateTime")]
    public DateTime? CompletedDateTime { get; set; }

    [JsonPropertyName("failedTasksCount")]
    public int? FailedTasksCount { get; set; }

    [JsonPropertyName("failedUsersCount")]
    public int? FailedUsersCount { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("lastUpdatedDateTime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [JsonPropertyName("@odata.type")]
    public string? ODataType { get; set; }

    [JsonPropertyName("processingStatus")]
    public LifecycleWorkflowProcessingStatusConstant? ProcessingStatus { get; set; }

    [JsonPropertyName("scheduledDateTime")]
    public DateTime? ScheduledDateTime { get; set; }

    [JsonPropertyName("startedDateTime")]
    public DateTime? StartedDateTime { get; set; }

    [JsonPropertyName("successfulUsersCount")]
    public int? SuccessfulUsersCount { get; set; }

    [JsonPropertyName("taskProcessingResults")]
    public List<TaskProcessingResultModel>? TaskProcessingResults { get; set; }

    [JsonPropertyName("totalTasksCount")]
    public int? TotalTasksCount { get; set; }

    [JsonPropertyName("totalUnprocessedTasksCount")]
    public int? TotalUnprocessedTasksCount { get; set; }

    [JsonPropertyName("totalUsersCount")]
    public int? TotalUsersCount { get; set; }

    [JsonPropertyName("userProcessingResults")]
    public List<UserProcessingResultModel>? UserProcessingResults { get; set; }

    [JsonPropertyName("workflowExecutionType")]
    public WorkflowExecutionTypeConstant? WorkflowExecutionType { get; set; }
}
