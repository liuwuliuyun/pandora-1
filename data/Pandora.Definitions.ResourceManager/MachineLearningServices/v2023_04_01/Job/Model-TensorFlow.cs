using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.MachineLearningServices.v2023_04_01.Job;

[ValueForType("TensorFlow")]
internal class TensorFlowModel : DistributionConfigurationModel
{
    [JsonPropertyName("parameterServerCount")]
    public int? ParameterServerCount { get; set; }

    [JsonPropertyName("workerCount")]
    public int? WorkerCount { get; set; }
}
