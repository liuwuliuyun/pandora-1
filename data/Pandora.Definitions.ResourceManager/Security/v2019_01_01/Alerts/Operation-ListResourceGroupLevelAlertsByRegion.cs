using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Security.v2019_01_01.Alerts;

internal class ListResourceGroupLevelAlertsByRegionOperation : Pandora.Definitions.Operations.ListOperation
{
    public override string? FieldContainingPaginationDetails() => "nextLink";

    public override ResourceID? ResourceId() => new ProviderLocationId();

    public override Type NestedItemType() => typeof(AlertModel);

    public override Type? OptionsObject() => typeof(ListResourceGroupLevelAlertsByRegionOperation.ListResourceGroupLevelAlertsByRegionOptions);

    public override string? UriSuffix() => "/alerts";

    internal class ListResourceGroupLevelAlertsByRegionOptions
    {
        [QueryStringName("autoDismissRuleName")]
        [Optional]
        public string AutoDismissRuleName { get; set; }

        [QueryStringName("$expand")]
        [Optional]
        public string Expand { get; set; }

        [QueryStringName("$filter")]
        [Optional]
        public string Filter { get; set; }

        [QueryStringName("$select")]
        [Optional]
        public string Select { get; set; }
    }
}
