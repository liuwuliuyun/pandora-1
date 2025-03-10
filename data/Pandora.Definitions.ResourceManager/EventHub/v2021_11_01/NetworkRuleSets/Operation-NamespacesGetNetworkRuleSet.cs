using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.EventHub.v2021_11_01.NetworkRuleSets;

internal class NamespacesGetNetworkRuleSetOperation : Pandora.Definitions.Operations.GetOperation
{
    public override ResourceID? ResourceId() => new NamespaceId();

    public override Type? ResponseObject() => typeof(NetworkRuleSetModel);

    public override string? UriSuffix() => "/networkRuleSets/default";


}
