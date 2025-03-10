using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.KubernetesConfiguration.v2023_05_01.FluxConfigurationOperationStatus;


internal class ErrorAdditionalInfoModel
{
    [JsonPropertyName("info")]
    public object? Info { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
