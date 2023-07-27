using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.DataDog.v2022_06_01.MonitoredResources;


internal class MonitoredResourceModel
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("reasonForLogsStatus")]
    public string? ReasonForLogsStatus { get; set; }

    [JsonPropertyName("reasonForMetricsStatus")]
    public string? ReasonForMetricsStatus { get; set; }

    [JsonPropertyName("sendingLogs")]
    public bool? SendingLogs { get; set; }

    [JsonPropertyName("sendingMetrics")]
    public bool? SendingMetrics { get; set; }
}
