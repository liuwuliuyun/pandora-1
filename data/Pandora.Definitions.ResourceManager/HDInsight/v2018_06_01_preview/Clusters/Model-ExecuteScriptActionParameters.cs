using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.HDInsight.v2018_06_01_preview.Clusters;


internal class ExecuteScriptActionParametersModel
{
    [JsonPropertyName("persistOnSuccess")]
    [Required]
    public bool PersistOnSuccess { get; set; }

    [JsonPropertyName("scriptActions")]
    public List<RuntimeScriptActionModel>? ScriptActions { get; set; }
}
