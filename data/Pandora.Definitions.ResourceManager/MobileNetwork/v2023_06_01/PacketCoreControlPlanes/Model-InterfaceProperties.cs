using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.MobileNetwork.v2023_06_01.PacketCoreControlPlanes;


internal class InterfacePropertiesModel
{
    [JsonPropertyName("ipv4Address")]
    public string? IPv4Address { get; set; }

    [JsonPropertyName("ipv4Gateway")]
    public string? IPv4Gateway { get; set; }

    [JsonPropertyName("ipv4Subnet")]
    public string? IPv4Subnet { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
