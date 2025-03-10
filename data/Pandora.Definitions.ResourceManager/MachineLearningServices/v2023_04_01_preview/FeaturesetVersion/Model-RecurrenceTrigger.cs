using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.MachineLearningServices.v2023_04_01_preview.FeaturesetVersion;

[ValueForType("Recurrence")]
internal class RecurrenceTriggerModel : TriggerBaseModel
{
    [JsonPropertyName("frequency")]
    [Required]
    public RecurrenceFrequencyConstant Frequency { get; set; }

    [JsonPropertyName("interval")]
    [Required]
    public int Interval { get; set; }

    [JsonPropertyName("schedule")]
    public RecurrenceScheduleModel? Schedule { get; set; }
}
