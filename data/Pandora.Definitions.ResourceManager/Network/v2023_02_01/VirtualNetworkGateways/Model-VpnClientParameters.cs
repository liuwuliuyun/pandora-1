using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Network.v2023_02_01.VirtualNetworkGateways;


internal class VpnClientParametersModel
{
    [JsonPropertyName("authenticationMethod")]
    public AuthenticationMethodConstant? AuthenticationMethod { get; set; }

    [JsonPropertyName("clientRootCertificates")]
    public List<string>? ClientRootCertificates { get; set; }

    [JsonPropertyName("processorArchitecture")]
    public ProcessorArchitectureConstant? ProcessorArchitecture { get; set; }

    [JsonPropertyName("radiusServerAuthCertificate")]
    public string? RadiusServerAuthCertificate { get; set; }
}
