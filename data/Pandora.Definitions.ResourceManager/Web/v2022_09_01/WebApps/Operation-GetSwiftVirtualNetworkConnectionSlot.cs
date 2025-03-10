using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Web.v2022_09_01.WebApps;

internal class GetSwiftVirtualNetworkConnectionSlotOperation : Pandora.Definitions.Operations.GetOperation
{
    public override ResourceID? ResourceId() => new SlotId();

    public override Type? ResponseObject() => typeof(SwiftVirtualNetworkModel);

    public override string? UriSuffix() => "/networkConfig/virtualNetwork";


}
