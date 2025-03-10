using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.ServiceBus.v2022_01_01_preview.NamespacesPrivateLinkResources;

internal class PrivateLinkResourcesGetOperation : Pandora.Definitions.Operations.GetOperation
{
    public override ResourceID? ResourceId() => new NamespaceId();

    public override Type? ResponseObject() => typeof(PrivateLinkResourcesListResultModel);

    public override string? UriSuffix() => "/privateLinkResources";


}
