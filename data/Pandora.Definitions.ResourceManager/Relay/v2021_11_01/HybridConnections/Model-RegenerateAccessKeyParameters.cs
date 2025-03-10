using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Relay.v2021_11_01.HybridConnections;


internal class RegenerateAccessKeyParametersModel
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("keyType")]
    [Required]
    public KeyTypeConstant KeyType { get; set; }
}
