using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.RecoveryServicesSiteRecovery.v2023_04_01.ReplicationProtectedItems;

[ValueForType("A2A")]
internal class A2ARemoveDisksInputModel : RemoveDisksProviderSpecificInputModel
{
    [JsonPropertyName("vmDisksUris")]
    public List<string>? VMDisksUris { get; set; }

    [JsonPropertyName("vmManagedDisksIds")]
    public List<string>? VMManagedDisksIds { get; set; }
}
