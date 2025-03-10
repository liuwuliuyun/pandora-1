using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Migrate.v2020_01_01.HyperVMachines;


internal class FeatureModel
{
    [JsonPropertyName("featureType")]
    public string? FeatureType { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    [JsonPropertyName("status")]
    public string? Status { get; set; }
}
