using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.SecurityInsights.v2022_07_01_preview.CheckDataConnectorRequirements;

internal class DataConnectorsCheckRequirementsPostOperation : Pandora.Definitions.Operations.PostOperation
{
    public override IEnumerable<HttpStatusCode> ExpectedStatusCodes() => new List<HttpStatusCode>
        {
                HttpStatusCode.OK,
        };

    public override Type? RequestObject() => typeof(DataConnectorsCheckRequirementsModel);

    public override ResourceID? ResourceId() => new WorkspaceId();

    public override Type? ResponseObject() => typeof(DataConnectorRequirementsStateModel);

    public override string? UriSuffix() => "/providers/Microsoft.SecurityInsights/dataConnectorsCheckRequirements";


}
