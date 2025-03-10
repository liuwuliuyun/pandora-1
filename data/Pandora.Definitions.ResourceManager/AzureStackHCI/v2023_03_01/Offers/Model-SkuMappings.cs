using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.AzureStackHCI.v2023_03_01.Offers;


internal class SkuMappingsModel
{
    [JsonPropertyName("catalogPlanId")]
    public string? CatalogPlanId { get; set; }

    [JsonPropertyName("marketplaceSkuId")]
    public string? MarketplaceSkuId { get; set; }

    [JsonPropertyName("marketplaceSkuVersions")]
    public List<string>? MarketplaceSkuVersions { get; set; }
}
