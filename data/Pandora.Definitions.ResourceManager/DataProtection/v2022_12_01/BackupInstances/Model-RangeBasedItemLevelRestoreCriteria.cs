using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.DataProtection.v2022_12_01.BackupInstances;

[ValueForType("RangeBasedItemLevelRestoreCriteria")]
internal class RangeBasedItemLevelRestoreCriteriaModel : ItemLevelRestoreCriteriaModel
{
    [JsonPropertyName("maxMatchingValue")]
    public string? MaxMatchingValue { get; set; }

    [JsonPropertyName("minMatchingValue")]
    public string? MinMatchingValue { get; set; }
}
