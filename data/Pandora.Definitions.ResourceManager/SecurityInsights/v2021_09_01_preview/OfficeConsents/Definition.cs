using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.SecurityInsights.v2021_09_01_preview.OfficeConsents;

internal class Definition : ResourceDefinition
{
    public string Name => "OfficeConsents";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new OfficeConsentsDeleteOperation(),
        new OfficeConsentsGetOperation(),
        new OfficeConsentsListOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {

    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(OfficeConsentModel),
        typeof(OfficeConsentPropertiesModel),
    };
}
