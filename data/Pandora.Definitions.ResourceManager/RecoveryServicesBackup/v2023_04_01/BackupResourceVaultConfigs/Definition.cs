using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.RecoveryServicesBackup.v2023_04_01.BackupResourceVaultConfigs;

internal class Definition : ResourceDefinition
{
    public string Name => "BackupResourceVaultConfigs";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new GetOperation(),
        new PutOperation(),
        new UpdateOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {
        typeof(EnhancedSecurityStateConstant),
        typeof(SoftDeleteFeatureStateConstant),
        typeof(StorageTypeConstant),
        typeof(StorageTypeStateConstant),
    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(BackupResourceVaultConfigModel),
        typeof(BackupResourceVaultConfigResourceModel),
    };
}
