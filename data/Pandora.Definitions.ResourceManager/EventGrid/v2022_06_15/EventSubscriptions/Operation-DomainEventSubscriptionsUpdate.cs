using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.EventGrid.v2022_06_15.EventSubscriptions;

internal class DomainEventSubscriptionsUpdateOperation : Pandora.Definitions.Operations.PatchOperation
{
    public override IEnumerable<HttpStatusCode> ExpectedStatusCodes() => new List<HttpStatusCode>
        {
                HttpStatusCode.Created,
        };

    public override bool LongRunning() => true;

    public override Type? RequestObject() => typeof(EventSubscriptionUpdateParametersModel);

    public override ResourceID? ResourceId() => new DomainEventSubscriptionId();

    public override Type? ResponseObject() => typeof(EventSubscriptionModel);


}
