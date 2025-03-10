using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Consumption.v2023_11_01.ReservationTransactions;

internal class ListOperation : Pandora.Definitions.Operations.ListOperation
{
    public override string? FieldContainingPaginationDetails() => "nextLink";

    public override ResourceID? ResourceId() => new BillingAccountId();

    public override Type NestedItemType() => typeof(ReservationTransactionModel);

    public override Type? OptionsObject() => typeof(ListOperation.ListOptions);

    public override string? UriSuffix() => "/providers/Microsoft.Consumption/reservationTransactions";

    internal class ListOptions
    {
        [QueryStringName("$filter")]
        [Optional]
        public string Filter { get; set; }

        [QueryStringName("previewMarkupPercentage")]
        [Optional]
        public float PreviewMarkupPercentage { get; set; }

        [QueryStringName("useMarkupIfPartner")]
        [Optional]
        public bool UseMarkupIfPartner { get; set; }
    }
}
