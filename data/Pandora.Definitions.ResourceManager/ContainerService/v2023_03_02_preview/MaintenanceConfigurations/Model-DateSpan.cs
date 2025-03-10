using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.ContainerService.v2023_03_02_preview.MaintenanceConfigurations;


internal class DateSpanModel
{
    [JsonPropertyName("end")]
    [Required]
    public string End { get; set; }

    [JsonPropertyName("start")]
    [Required]
    public string Start { get; set; }
}
