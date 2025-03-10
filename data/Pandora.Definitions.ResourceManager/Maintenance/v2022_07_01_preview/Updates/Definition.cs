using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Maintenance.v2022_07_01_preview.Updates;

internal class Definition : ResourceDefinition
{
    public string Name => "Updates";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new ListOperation(),
        new ListParentOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {
        typeof(ImpactTypeConstant),
        typeof(MaintenanceScopeConstant),
        typeof(UpdateStatusConstant),
    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(ListUpdatesResultModel),
        typeof(UpdateModel),
        typeof(UpdatePropertiesModel),
    };
}
