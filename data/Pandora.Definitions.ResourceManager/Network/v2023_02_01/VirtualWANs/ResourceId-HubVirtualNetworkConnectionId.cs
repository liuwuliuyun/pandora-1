using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Network.v2023_02_01.VirtualWANs;

internal class HubVirtualNetworkConnectionId : ResourceID
{
    public string? CommonAlias => null;

    public string ID => "/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/hubVirtualNetworkConnections/{hubVirtualNetworkConnectionName}";

    public List<ResourceIDSegment> Segments => new List<ResourceIDSegment>
    {
        ResourceIDSegment.Static("staticSubscriptions", "subscriptions"),
        ResourceIDSegment.SubscriptionId("subscriptionId"),
        ResourceIDSegment.Static("staticResourceGroups", "resourceGroups"),
        ResourceIDSegment.ResourceGroup("resourceGroupName"),
        ResourceIDSegment.Static("staticProviders", "providers"),
        ResourceIDSegment.ResourceProvider("staticMicrosoftNetwork", "Microsoft.Network"),
        ResourceIDSegment.Static("staticVirtualHubs", "virtualHubs"),
        ResourceIDSegment.UserSpecified("virtualHubName"),
        ResourceIDSegment.Static("staticHubVirtualNetworkConnections", "hubVirtualNetworkConnections"),
        ResourceIDSegment.UserSpecified("hubVirtualNetworkConnectionName"),
    };
}
