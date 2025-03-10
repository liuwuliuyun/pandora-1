using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.PostgreSql.v2023_03_01_preview.Servers;


internal class AuthConfigModel
{
    [JsonPropertyName("activeDirectoryAuth")]
    public ActiveDirectoryAuthEnumConstant? ActiveDirectoryAuth { get; set; }

    [JsonPropertyName("passwordAuth")]
    public PasswordAuthEnumConstant? PasswordAuth { get; set; }

    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}
