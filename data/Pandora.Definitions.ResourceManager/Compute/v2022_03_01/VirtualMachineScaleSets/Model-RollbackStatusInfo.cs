using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Compute.v2022_03_01.VirtualMachineScaleSets;


internal class RollbackStatusInfoModel
{
    [JsonPropertyName("failedRolledbackInstanceCount")]
    public int? FailedRolledbackInstanceCount { get; set; }

    [JsonPropertyName("rollbackError")]
    public ApiErrorModel? RollbackError { get; set; }

    [JsonPropertyName("successfullyRolledbackInstanceCount")]
    public int? SuccessfullyRolledbackInstanceCount { get; set; }
}
