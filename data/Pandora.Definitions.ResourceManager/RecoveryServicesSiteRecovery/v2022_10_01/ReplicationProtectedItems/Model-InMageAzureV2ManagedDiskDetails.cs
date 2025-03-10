using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.RecoveryServicesSiteRecovery.v2022_10_01.ReplicationProtectedItems;


internal class InMageAzureV2ManagedDiskDetailsModel
{
    [JsonPropertyName("diskEncryptionSetId")]
    public string? DiskEncryptionSetId { get; set; }

    [JsonPropertyName("diskId")]
    public string? DiskId { get; set; }

    [JsonPropertyName("replicaDiskType")]
    public string? ReplicaDiskType { get; set; }

    [JsonPropertyName("seedManagedDiskId")]
    public string? SeedManagedDiskId { get; set; }

    [JsonPropertyName("targetDiskName")]
    public string? TargetDiskName { get; set; }
}
