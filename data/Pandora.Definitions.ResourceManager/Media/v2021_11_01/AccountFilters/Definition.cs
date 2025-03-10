using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Media.v2021_11_01.AccountFilters;

internal class Definition : ResourceDefinition
{
    public string Name => "AccountFilters";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new AccountFiltersCreateOrUpdateOperation(),
        new AccountFiltersDeleteOperation(),
        new AccountFiltersGetOperation(),
        new AccountFiltersListOperation(),
        new AccountFiltersUpdateOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {
        typeof(FilterTrackPropertyCompareOperationConstant),
        typeof(FilterTrackPropertyTypeConstant),
    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(AccountFilterModel),
        typeof(FilterTrackPropertyConditionModel),
        typeof(FilterTrackSelectionModel),
        typeof(FirstQualityModel),
        typeof(MediaFilterPropertiesModel),
        typeof(PresentationTimeRangeModel),
    };
}
