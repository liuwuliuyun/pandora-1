using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Network.v2023_04_01.ExpressRouteServiceProviders;

internal class Definition : ResourceDefinition
{
    public string Name => "ExpressRouteServiceProviders";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new ListOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {
        typeof(ProvisioningStateConstant),
    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(ExpressRouteServiceProviderModel),
        typeof(ExpressRouteServiceProviderBandwidthsOfferedModel),
        typeof(ExpressRouteServiceProviderPropertiesFormatModel),
    };
}
