using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Consumption.v2019_10_01.Events;

internal class ListOperation : Pandora.Definitions.Operations.ListOperation
{
    public override string? FieldContainingPaginationDetails() => "nextLink";

    public override ResourceID? ResourceId() => new ScopeId();

    public override Type NestedItemType() => typeof(EventSummaryModel);

    public override Type? OptionsObject() => typeof(ListOperation.ListOptions);

    public override string? UriSuffix() => "/providers/Microsoft.Consumption/events";

    internal class ListOptions
    {
        [QueryStringName("endDate")]
        public string EndDate { get; set; }

        [QueryStringName("startDate")]
        public string StartDate { get; set; }
    }
}
