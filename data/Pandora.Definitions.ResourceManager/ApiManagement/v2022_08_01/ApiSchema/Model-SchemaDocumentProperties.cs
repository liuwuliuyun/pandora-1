using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.ApiManagement.v2022_08_01.ApiSchema;


internal class SchemaDocumentPropertiesModel
{
    [JsonPropertyName("components")]
    public object? Components { get; set; }

    [JsonPropertyName("definitions")]
    public object? Definitions { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
