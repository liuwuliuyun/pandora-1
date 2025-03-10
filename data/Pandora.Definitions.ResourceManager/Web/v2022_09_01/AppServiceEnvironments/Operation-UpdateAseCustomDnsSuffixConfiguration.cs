using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Web.v2022_09_01.AppServiceEnvironments;

internal class UpdateAseCustomDnsSuffixConfigurationOperation : Pandora.Definitions.Operations.PutOperation
{
    public override IEnumerable<HttpStatusCode> ExpectedStatusCodes() => new List<HttpStatusCode>
        {
                HttpStatusCode.OK,
        };

    public override Type? RequestObject() => typeof(CustomDnsSuffixConfigurationModel);

    public override ResourceID? ResourceId() => new HostingEnvironmentId();

    public override Type? ResponseObject() => typeof(CustomDnsSuffixConfigurationModel);

    public override string? UriSuffix() => "/configurations/customdnssuffix";


}
