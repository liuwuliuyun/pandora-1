using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Storage.v2023_01_01.EncryptionScopes;

internal class Definition : ResourceDefinition
{
    public string Name => "EncryptionScopes";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new GetOperation(),
        new ListOperation(),
        new PatchOperation(),
        new PutOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {
        typeof(EncryptionScopeSourceConstant),
        typeof(EncryptionScopeStateConstant),
        typeof(ListEncryptionScopesIncludeConstant),
    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(EncryptionScopeModel),
        typeof(EncryptionScopeKeyVaultPropertiesModel),
        typeof(EncryptionScopePropertiesModel),
    };
}
