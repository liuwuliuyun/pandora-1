using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Kusto.v2023_05_02.DataConnections;

[ValueForType("EventGrid")]
internal class EventGridDataConnectionModel : DataConnectionModel
{
    [JsonPropertyName("properties")]
    public EventGridConnectionPropertiesModel? Properties { get; set; }
}
