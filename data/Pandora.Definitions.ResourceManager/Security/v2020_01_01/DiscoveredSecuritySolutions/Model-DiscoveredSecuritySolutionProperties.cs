using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Security.v2020_01_01.DiscoveredSecuritySolutions;


internal class DiscoveredSecuritySolutionPropertiesModel
{
    [JsonPropertyName("offer")]
    [Required]
    public string Offer { get; set; }

    [JsonPropertyName("publisher")]
    [Required]
    public string Publisher { get; set; }

    [JsonPropertyName("securityFamily")]
    [Required]
    public SecurityFamilyConstant SecurityFamily { get; set; }

    [JsonPropertyName("sku")]
    [Required]
    public string Sku { get; set; }
}
