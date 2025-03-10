using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.KubernetesConfiguration.v2022_11_01.Flux;


internal class ServicePrincipalPatchDefinitionModel
{
    [JsonPropertyName("clientCertificate")]
    public string? ClientCertificate { get; set; }

    [JsonPropertyName("clientCertificatePassword")]
    public string? ClientCertificatePassword { get; set; }

    [JsonPropertyName("clientCertificateSendChain")]
    public bool? ClientCertificateSendChain { get; set; }

    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    [JsonPropertyName("clientSecret")]
    public string? ClientSecret { get; set; }

    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}
