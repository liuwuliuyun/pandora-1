using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Consumption.v2022_09_01.Lots;

internal class CustomerId : ResourceID
{
    public string? CommonAlias => null;

    public string ID => "/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/customers/{customerId}";

    public List<ResourceIDSegment> Segments => new List<ResourceIDSegment>
    {
        ResourceIDSegment.Static("staticProviders", "providers"),
        ResourceIDSegment.ResourceProvider("staticMicrosoftBilling", "Microsoft.Billing"),
        ResourceIDSegment.Static("staticBillingAccounts", "billingAccounts"),
        ResourceIDSegment.UserSpecified("billingAccountId"),
        ResourceIDSegment.Static("staticCustomers", "customers"),
        ResourceIDSegment.UserSpecified("customerId"),
    };
}
