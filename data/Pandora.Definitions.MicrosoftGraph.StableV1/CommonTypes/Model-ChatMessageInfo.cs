// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


namespace Pandora.Definitions.MicrosoftGraph.StableV1.CommonTypes;

internal class ChatMessageInfoModel
{
    [JsonPropertyName("body")]
    public ItemBodyModel? Body { get; set; }

    [JsonPropertyName("createdDateTime")]
    public DateTime? CreatedDateTime { get; set; }

    [JsonPropertyName("eventDetail")]
    public EventMessageDetailModel? EventDetail { get; set; }

    [JsonPropertyName("from")]
    public ChatMessageFromIdentitySetModel? From { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("isDeleted")]
    public bool? IsDeleted { get; set; }

    [JsonPropertyName("messageType")]
    public ChatMessageTypeConstant? MessageType { get; set; }

    [JsonPropertyName("@odata.type")]
    public string? ODataType { get; set; }
}
