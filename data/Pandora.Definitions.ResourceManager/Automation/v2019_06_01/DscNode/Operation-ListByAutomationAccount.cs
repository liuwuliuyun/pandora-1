using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Automation.v2019_06_01.DscNode;

internal class ListByAutomationAccountOperation : Pandora.Definitions.Operations.ListOperation
{
    public override string? FieldContainingPaginationDetails() => "nextLink";

    public override ResourceID? ResourceId() => new AutomationAccountId();

    public override Type NestedItemType() => typeof(DscNodeModel);

    public override Type? OptionsObject() => typeof(ListByAutomationAccountOperation.ListByAutomationAccountOptions);

    public override string? UriSuffix() => "/nodes";

    internal class ListByAutomationAccountOptions
    {
        [QueryStringName("$filter")]
        [Optional]
        public string Filter { get; set; }

        [QueryStringName("$inlinecount")]
        [Optional]
        public string Inlinecount { get; set; }

        [QueryStringName("$skip")]
        [Optional]
        public int Skip { get; set; }

        [QueryStringName("$top")]
        [Optional]
        public int Top { get; set; }
    }
}
