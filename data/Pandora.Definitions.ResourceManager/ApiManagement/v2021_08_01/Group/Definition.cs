using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.ApiManagement.v2021_08_01.Group;

internal class Definition : ResourceDefinition
{
    public string Name => "Group";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new CreateOrUpdateOperation(),
        new DeleteOperation(),
        new GetOperation(),
        new GetEntityTagOperation(),
        new ListByServiceOperation(),
        new UpdateOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {
        typeof(GroupTypeConstant),
    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(GroupContractModel),
        typeof(GroupContractPropertiesModel),
        typeof(GroupCreateParametersModel),
        typeof(GroupCreateParametersPropertiesModel),
        typeof(GroupUpdateParametersModel),
        typeof(GroupUpdateParametersPropertiesModel),
    };
}
