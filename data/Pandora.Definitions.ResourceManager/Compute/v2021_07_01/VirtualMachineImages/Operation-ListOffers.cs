using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Compute.v2021_07_01.VirtualMachineImages;

internal class ListOffersOperation : Pandora.Definitions.Operations.GetOperation
{
    public override ResourceID? ResourceId() => new PublisherId();

    public override Type? ResponseObject() => typeof(List<VirtualMachineImageResourceModel>);

    public override string? UriSuffix() => "/artifactTypes/vmImage/offers";


}
