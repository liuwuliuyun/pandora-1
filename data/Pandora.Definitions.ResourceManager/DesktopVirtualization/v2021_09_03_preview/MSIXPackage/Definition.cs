using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.DesktopVirtualization.v2021_09_03_preview.MSIXPackage;

internal class Definition : ResourceDefinition
{
    public string Name => "MSIXPackage";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new CreateOrUpdateOperation(),
        new DeleteOperation(),
        new GetOperation(),
        new ListOperation(),
        new UpdateOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {

    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(MSIXPackageModel),
        typeof(MSIXPackagePatchModel),
        typeof(MSIXPackagePatchPropertiesModel),
        typeof(MSIXPackagePropertiesModel),
        typeof(MsixPackageApplicationsModel),
        typeof(MsixPackageDependenciesModel),
    };
}
