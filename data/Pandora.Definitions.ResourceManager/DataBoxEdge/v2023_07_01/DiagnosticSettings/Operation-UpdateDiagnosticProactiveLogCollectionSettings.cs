using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.DataBoxEdge.v2023_07_01.DiagnosticSettings;

internal class UpdateDiagnosticProactiveLogCollectionSettingsOperation : Pandora.Definitions.Operations.PutOperation
{
    public override IEnumerable<HttpStatusCode> ExpectedStatusCodes() => new List<HttpStatusCode>
        {
                HttpStatusCode.Accepted,
                HttpStatusCode.OK,
        };

    public override bool LongRunning() => true;

    public override Type? RequestObject() => typeof(DiagnosticProactiveLogCollectionSettingsModel);

    public override ResourceID? ResourceId() => new DataBoxEdgeDeviceId();

    public override Type? ResponseObject() => typeof(DiagnosticProactiveLogCollectionSettingsModel);

    public override string? UriSuffix() => "/diagnosticProactiveLogCollectionSettings/default";


}
