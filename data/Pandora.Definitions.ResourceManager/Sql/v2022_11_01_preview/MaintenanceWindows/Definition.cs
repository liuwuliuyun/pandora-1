using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Sql.v2022_11_01_preview.MaintenanceWindows;

internal class Definition : ResourceDefinition
{
    public string Name => "MaintenanceWindows";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new CreateOrUpdateOperation(),
        new GetOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {
        typeof(DayOfWeekConstant),
    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(MaintenanceWindowTimeRangeModel),
        typeof(MaintenanceWindowsModel),
        typeof(MaintenanceWindowsPropertiesModel),
    };
}
