using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.MachineLearningServices.v2023_04_01_preview.Schedule;


internal abstract class DataVersionBaseModel
{
    [JsonPropertyName("autoDeleteSetting")]
    public AutoDeleteSettingModel? AutoDeleteSetting { get; set; }

    [JsonPropertyName("dataType")]
    [ProvidesTypeHint]
    [Required]
    public DataTypeConstant DataType { get; set; }

    [JsonPropertyName("dataUri")]
    [Required]
    public string DataUri { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("intellectualProperty")]
    public IntellectualPropertyModel? IntellectualProperty { get; set; }

    [JsonPropertyName("isAnonymous")]
    public bool? IsAnonymous { get; set; }

    [JsonPropertyName("isArchived")]
    public bool? IsArchived { get; set; }

    [JsonPropertyName("properties")]
    public Dictionary<string, string>? Properties { get; set; }

    [JsonPropertyName("stage")]
    public string? Stage { get; set; }

    [JsonPropertyName("tags")]
    public CustomTypes.Tags? Tags { get; set; }
}
