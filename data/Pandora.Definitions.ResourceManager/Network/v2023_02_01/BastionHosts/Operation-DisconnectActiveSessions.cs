using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Network.v2023_02_01.BastionHosts;

internal class DisconnectActiveSessionsOperation : Pandora.Definitions.Operations.ListOperation
{
    public override IEnumerable<HttpStatusCode> ExpectedStatusCodes() => new List<HttpStatusCode>
        {
                HttpStatusCode.OK,
        };

    public override string? FieldContainingPaginationDetails() => "nextLink";

    public override Type? RequestObject() => typeof(SessionIdsModel);

    public override ResourceID? ResourceId() => new BastionHostId();

    public override Type NestedItemType() => typeof(BastionSessionStateModel);

    public override string? UriSuffix() => "/disconnectActiveSessions";

    public override System.Net.Http.HttpMethod Method() => System.Net.Http.HttpMethod.Post;


}
