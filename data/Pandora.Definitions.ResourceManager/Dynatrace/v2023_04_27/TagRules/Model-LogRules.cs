using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Dynatrace.v2023_04_27.TagRules;


internal class LogRulesModel
{
    [JsonPropertyName("filteringTags")]
    public List<FilteringTagModel>? FilteringTags { get; set; }

    [JsonPropertyName("sendAadLogs")]
    public SendAadLogsStatusConstant? SendAadLogs { get; set; }

    [JsonPropertyName("sendActivityLogs")]
    public SendActivityLogsStatusConstant? SendActivityLogs { get; set; }

    [JsonPropertyName("sendSubscriptionLogs")]
    public SendSubscriptionLogsStatusConstant? SendSubscriptionLogs { get; set; }
}
