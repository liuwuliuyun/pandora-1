using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Insights.v2018_03_01.MetricAlertsStatus;

internal class ListOperation : Pandora.Definitions.Operations.GetOperation
{
    public override ResourceID? ResourceId() => new MetricAlertId();

    public override Type? ResponseObject() => typeof(MetricAlertStatusCollectionModel);

    public override string? UriSuffix() => "/status";


}
