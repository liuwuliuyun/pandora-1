using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.MicrosoftGraph.StableV1.CommonTypes;
using System.Collections.Generic;
using System.Net;
using System;

// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

namespace Pandora.Definitions.MicrosoftGraph.StableV1.Applications.StableV1.ApplicationAppManagementPolicy;

internal class AddApplicationAppManagementPolicyOperation : Operations.PostOperation
{

    public override IEnumerable<HttpStatusCode> ExpectedStatusCodes() => new List<HttpStatusCode>
        {
                HttpStatusCode.NoContent,
        };
    public override Type? RequestObject() => typeof(AddApplicationAppManagementPolicyRequestModel);
    public override ResourceID? ResourceId() => new ApplicationId();
    public override Type? ResponseObject() => null;
    public override string? UriSuffix() => "/appManagementPolicies/$ref";
}
