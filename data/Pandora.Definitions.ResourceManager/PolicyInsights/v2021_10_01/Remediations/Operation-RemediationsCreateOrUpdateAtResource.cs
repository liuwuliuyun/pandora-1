using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.PolicyInsights.v2021_10_01.Remediations;

internal class RemediationsCreateOrUpdateAtResourceOperation : Pandora.Definitions.Operations.PutOperation
{
    public override Type? RequestObject() => typeof(RemediationModel);

    public override ResourceID? ResourceId() => new ScopedRemediationId();

    public override Type? ResponseObject() => typeof(RemediationModel);


}
