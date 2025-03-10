using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Network.v2023_04_01.VirtualWANs;

internal class VPNConnectionId : ResourceID
{
    public string? CommonAlias => "VPNConnection";

    public string ID => "/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/vpnGateways/{vpnGatewayName}/vpnConnections/{vpnConnectionName}";

    public List<ResourceIDSegment> Segments => new List<ResourceIDSegment>
    {
        ResourceIDSegment.Static("subscriptions", "subscriptions"),
        ResourceIDSegment.SubscriptionId("subscriptionId"),
        ResourceIDSegment.Static("resourceGroups", "resourceGroups"),
        ResourceIDSegment.ResourceGroup("resourceGroupName"),
        ResourceIDSegment.Static("providers", "providers"),
        ResourceIDSegment.ResourceProvider("resourceProvider", "Microsoft.Network"),
        ResourceIDSegment.Static("vpnGateways", "vpnGateways"),
        ResourceIDSegment.UserSpecified("vpnGatewayName"),
        ResourceIDSegment.Static("vpnConnections", "vpnConnections"),
        ResourceIDSegment.UserSpecified("vpnConnectionName"),
    };
}
