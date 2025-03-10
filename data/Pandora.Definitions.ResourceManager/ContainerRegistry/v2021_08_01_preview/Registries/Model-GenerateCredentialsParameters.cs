using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.ContainerRegistry.v2021_08_01_preview.Registries;


internal class GenerateCredentialsParametersModel
{
    [DateFormat(DateFormatAttribute.DateFormat.RFC3339)]
    [JsonPropertyName("expiry")]
    public DateTime? Expiry { get; set; }

    [JsonPropertyName("name")]
    public TokenPasswordNameConstant? Name { get; set; }

    [JsonPropertyName("tokenId")]
    public string? TokenId { get; set; }
}
