using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.RecoveryServices.v2022_08_01.Vaults;


internal class VaultPropertiesEncryptionModel
{
    [JsonPropertyName("infrastructureEncryption")]
    public InfrastructureEncryptionStateConstant? InfrastructureEncryption { get; set; }

    [JsonPropertyName("kekIdentity")]
    public CmkKekIdentityModel? KekIdentity { get; set; }

    [JsonPropertyName("keyVaultProperties")]
    public CmkKeyVaultPropertiesModel? KeyVaultProperties { get; set; }
}
