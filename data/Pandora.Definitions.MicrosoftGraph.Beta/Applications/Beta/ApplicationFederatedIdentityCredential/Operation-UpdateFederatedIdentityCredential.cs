using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;
using System.Collections.Generic;
using System.Net;
using System;

// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

namespace Pandora.Definitions.MicrosoftGraph.Beta.Applications.Beta.ApplicationFederatedIdentityCredential;

internal class UpdateFederatedIdentityCredentialOperation : Operations.PatchOperation
{

    public override IEnumerable<HttpStatusCode> ExpectedStatusCodes() => new List<HttpStatusCode>
        {
                HttpStatusCode.OK,
        };
    public override Type? RequestObject() => typeof(FederatedIdentityCredentialModel);
    public override ResourceID? ResourceId() => new FederatedIdentityCredentialId();
    public override Type? ResponseObject() => typeof(FederatedIdentityCredentialModel);
    public override string? UriSuffix() => null;
}
