using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Consumption.v2022_09_01.PriceSheet;


internal class SavingsPlanModel
{
    [JsonPropertyName("effectivePrice")]
    public float? EffectivePrice { get; set; }

    [JsonPropertyName("marketPrice")]
    public float? MarketPrice { get; set; }

    [JsonPropertyName("term")]
    public string? Term { get; set; }
}
