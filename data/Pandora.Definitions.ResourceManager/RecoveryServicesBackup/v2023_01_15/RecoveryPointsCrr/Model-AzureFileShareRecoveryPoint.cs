using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.RecoveryServicesBackup.v2023_01_15.RecoveryPointsCrr;

[ValueForType("AzureFileShareRecoveryPoint")]
internal class AzureFileShareRecoveryPointModel : RecoveryPointModel
{
    [JsonPropertyName("fileShareSnapshotUri")]
    public string? FileShareSnapshotUri { get; set; }

    [JsonPropertyName("recoveryPointProperties")]
    public RecoveryPointPropertiesModel? RecoveryPointProperties { get; set; }

    [JsonPropertyName("recoveryPointSizeInGB")]
    public int? RecoveryPointSizeInGB { get; set; }

    [DateFormat(DateFormatAttribute.DateFormat.RFC3339)]
    [JsonPropertyName("recoveryPointTime")]
    public DateTime? RecoveryPointTime { get; set; }

    [JsonPropertyName("recoveryPointType")]
    public string? RecoveryPointType { get; set; }
}
