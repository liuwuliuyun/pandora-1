using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Network.v2023_02_01.VirtualWANs;

internal class VirtualHubIPConfigurationId : ResourceID
{
    public string? CommonAlias => "VirtualHubIPConfiguration";

    public string ID => "/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/ipConfigurations/{ipConfigurationName}";

    public List<ResourceIDSegment> Segments => new List<ResourceIDSegment>
    {
        ResourceIDSegment.Static("subscriptions", "subscriptions"),
        ResourceIDSegment.SubscriptionId("subscriptionId"),
        ResourceIDSegment.Static("resourceGroups", "resourceGroups"),
        ResourceIDSegment.ResourceGroup("resourceGroupName"),
        ResourceIDSegment.Static("providers", "providers"),
        ResourceIDSegment.ResourceProvider("resourceProvider", "Microsoft.Network"),
        ResourceIDSegment.Static("virtualHubs", "virtualHubs"),
        ResourceIDSegment.UserSpecified("virtualHubName"),
        ResourceIDSegment.Static("ipConfigurations", "ipConfigurations"),
        ResourceIDSegment.UserSpecified("ipConfigurationName"),
    };
}
