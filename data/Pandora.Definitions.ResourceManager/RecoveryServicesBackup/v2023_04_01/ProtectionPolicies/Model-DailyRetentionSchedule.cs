using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.RecoveryServicesBackup.v2023_04_01.ProtectionPolicies;


internal class DailyRetentionScheduleModel
{
    [JsonPropertyName("retentionDuration")]
    public RetentionDurationModel? RetentionDuration { get; set; }

    [JsonPropertyName("retentionTimes")]
    public List<DateTime>? RetentionTimes { get; set; }
}
