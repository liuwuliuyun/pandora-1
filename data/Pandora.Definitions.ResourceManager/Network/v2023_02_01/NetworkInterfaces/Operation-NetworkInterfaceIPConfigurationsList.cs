using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Network.v2023_02_01.NetworkInterfaces;

internal class NetworkInterfaceIPConfigurationsListOperation : Pandora.Definitions.Operations.ListOperation
{
    public override string? FieldContainingPaginationDetails() => "nextLink";

    public override ResourceID? ResourceId() => new NetworkInterfaceId();

    public override Type NestedItemType() => typeof(NetworkInterfaceIPConfigurationModel);

    public override string? UriSuffix() => "/ipConfigurations";


}
