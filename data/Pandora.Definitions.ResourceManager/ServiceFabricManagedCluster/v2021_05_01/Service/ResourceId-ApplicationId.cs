using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.ServiceFabricManagedCluster.v2021_05_01.Service;

internal class ApplicationId : ResourceID
{
    public string? CommonAlias => null;

    public string ID => "/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/managedClusters/{managedClusterName}/applications/{applicationName}";

    public List<ResourceIDSegment> Segments => new List<ResourceIDSegment>
    {
        ResourceIDSegment.Static("staticSubscriptions", "subscriptions"),
        ResourceIDSegment.SubscriptionId("subscriptionId"),
        ResourceIDSegment.Static("staticResourceGroups", "resourceGroups"),
        ResourceIDSegment.ResourceGroup("resourceGroupName"),
        ResourceIDSegment.Static("staticProviders", "providers"),
        ResourceIDSegment.ResourceProvider("staticMicrosoftServiceFabric", "Microsoft.ServiceFabric"),
        ResourceIDSegment.Static("staticManagedClusters", "managedClusters"),
        ResourceIDSegment.UserSpecified("managedClusterName"),
        ResourceIDSegment.Static("staticApplications", "applications"),
        ResourceIDSegment.UserSpecified("applicationName"),
    };
}
