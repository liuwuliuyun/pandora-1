using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.PostgreSql.v2022_03_08_preview.Servers;


internal class AuthConfigModel
{
    [JsonPropertyName("activeDirectoryAuthEnabled")]
    public bool? ActiveDirectoryAuthEnabled { get; set; }

    [JsonPropertyName("passwordAuthEnabled")]
    public bool? PasswordAuthEnabled { get; set; }

    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}
