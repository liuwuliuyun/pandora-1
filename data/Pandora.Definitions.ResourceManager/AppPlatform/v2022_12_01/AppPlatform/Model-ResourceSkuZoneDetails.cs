using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.AppPlatform.v2022_12_01.AppPlatform;


internal class ResourceSkuZoneDetailsModel
{
    [JsonPropertyName("capabilities")]
    public List<ResourceSkuCapabilitiesModel>? Capabilities { get; set; }

    [JsonPropertyName("name")]
    public List<string>? Name { get; set; }
}
