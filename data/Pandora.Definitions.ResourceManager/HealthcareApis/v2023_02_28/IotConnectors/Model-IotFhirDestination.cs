using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.HealthcareApis.v2023_02_28.IotConnectors;


internal class IotFhirDestinationModel
{
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("location")]
    public CustomTypes.Location? Location { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("properties")]
    [Required]
    public IotFhirDestinationPropertiesModel Properties { get; set; }

    [JsonPropertyName("systemData")]
    public CustomTypes.SystemData? SystemData { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
