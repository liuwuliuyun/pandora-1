using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Sql.v2022_11_01_preview.SubscriptionUsages;


internal class SubscriptionUsagePropertiesModel
{
    [JsonPropertyName("currentValue")]
    public float? CurrentValue { get; set; }

    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    [JsonPropertyName("limit")]
    public float? Limit { get; set; }

    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}
