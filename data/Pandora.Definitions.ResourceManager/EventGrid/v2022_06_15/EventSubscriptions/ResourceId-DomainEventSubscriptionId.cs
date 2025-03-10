using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.EventGrid.v2022_06_15.EventSubscriptions;

internal class DomainEventSubscriptionId : ResourceID
{
    public string? CommonAlias => null;

    public string ID => "/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/domains/{domainName}/eventSubscriptions/{eventSubscriptionName}";

    public List<ResourceIDSegment> Segments => new List<ResourceIDSegment>
    {
        ResourceIDSegment.Static("staticSubscriptions", "subscriptions"),
        ResourceIDSegment.SubscriptionId("subscriptionId"),
        ResourceIDSegment.Static("staticResourceGroups", "resourceGroups"),
        ResourceIDSegment.ResourceGroup("resourceGroupName"),
        ResourceIDSegment.Static("staticProviders", "providers"),
        ResourceIDSegment.ResourceProvider("staticMicrosoftEventGrid", "Microsoft.EventGrid"),
        ResourceIDSegment.Static("staticDomains", "domains"),
        ResourceIDSegment.UserSpecified("domainName"),
        ResourceIDSegment.Static("staticEventSubscriptions", "eventSubscriptions"),
        ResourceIDSegment.UserSpecified("eventSubscriptionName"),
    };
}
