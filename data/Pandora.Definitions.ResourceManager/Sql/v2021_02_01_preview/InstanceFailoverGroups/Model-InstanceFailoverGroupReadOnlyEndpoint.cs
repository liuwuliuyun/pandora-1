using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Sql.v2021_02_01_preview.InstanceFailoverGroups;


internal class InstanceFailoverGroupReadOnlyEndpointModel
{
    [JsonPropertyName("failoverPolicy")]
    public ReadOnlyEndpointFailoverPolicyConstant? FailoverPolicy { get; set; }
}
