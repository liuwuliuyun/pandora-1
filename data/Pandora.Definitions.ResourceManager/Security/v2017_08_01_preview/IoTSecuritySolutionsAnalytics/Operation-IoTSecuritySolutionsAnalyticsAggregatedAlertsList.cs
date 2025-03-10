using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Security.v2017_08_01_preview.IoTSecuritySolutionsAnalytics;

internal class IoTSecuritySolutionsAnalyticsAggregatedAlertsListOperation : Pandora.Definitions.Operations.ListOperation
{
    public override string? FieldContainingPaginationDetails() => "nextLink";

    public override ResourceID? ResourceId() => new IotSecuritySolutionId();

    public override Type NestedItemType() => typeof(IoTSecurityAggregatedAlertModel);

    public override Type? OptionsObject() => typeof(IoTSecuritySolutionsAnalyticsAggregatedAlertsListOperation.IoTSecuritySolutionsAnalyticsAggregatedAlertsListOptions);

    public override string? UriSuffix() => "/analyticsModels/default/aggregatedAlerts";

    internal class IoTSecuritySolutionsAnalyticsAggregatedAlertsListOptions
    {
        [QueryStringName("$top")]
        [Optional]
        public int Top { get; set; }
    }
}
