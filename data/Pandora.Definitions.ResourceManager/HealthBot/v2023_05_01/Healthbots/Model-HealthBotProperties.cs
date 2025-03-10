using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.HealthBot.v2023_05_01.Healthbots;


internal class HealthBotPropertiesModel
{
    [JsonPropertyName("botManagementPortalLink")]
    public string? BotManagementPortalLink { get; set; }

    [JsonPropertyName("keyVaultProperties")]
    public KeyVaultPropertiesModel? KeyVaultProperties { get; set; }

    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }
}
