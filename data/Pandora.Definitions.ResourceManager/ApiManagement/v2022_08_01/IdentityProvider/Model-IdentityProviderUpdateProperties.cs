using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.ApiManagement.v2022_08_01.IdentityProvider;


internal class IdentityProviderUpdatePropertiesModel
{
    [MaxItems(32)]
    [JsonPropertyName("allowedTenants")]
    public List<string>? AllowedTenants { get; set; }

    [JsonPropertyName("authority")]
    public string? Authority { get; set; }

    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    [JsonPropertyName("clientLibrary")]
    public string? ClientLibrary { get; set; }

    [JsonPropertyName("clientSecret")]
    public string? ClientSecret { get; set; }

    [JsonPropertyName("passwordResetPolicyName")]
    public string? PasswordResetPolicyName { get; set; }

    [JsonPropertyName("profileEditingPolicyName")]
    public string? ProfileEditingPolicyName { get; set; }

    [JsonPropertyName("signinPolicyName")]
    public string? SigninPolicyName { get; set; }

    [JsonPropertyName("signinTenant")]
    public string? SigninTenant { get; set; }

    [JsonPropertyName("signupPolicyName")]
    public string? SignupPolicyName { get; set; }

    [JsonPropertyName("type")]
    public IdentityProviderTypeConstant? Type { get; set; }
}
