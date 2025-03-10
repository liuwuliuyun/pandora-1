using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Consumption.v2023_11_01.Events;

internal class ListByBillingProfileOperation : Pandora.Definitions.Operations.ListOperation
{
    public override string? FieldContainingPaginationDetails() => "nextLink";

    public override ResourceID? ResourceId() => new BillingProfileId();

    public override Type NestedItemType() => typeof(EventSummaryModel);

    public override Type? OptionsObject() => typeof(ListByBillingProfileOperation.ListByBillingProfileOptions);

    public override string? UriSuffix() => "/providers/Microsoft.Consumption/events";

    internal class ListByBillingProfileOptions
    {
        [QueryStringName("endDate")]
        public string EndDate { get; set; }

        [QueryStringName("startDate")]
        public string StartDate { get; set; }
    }
}
