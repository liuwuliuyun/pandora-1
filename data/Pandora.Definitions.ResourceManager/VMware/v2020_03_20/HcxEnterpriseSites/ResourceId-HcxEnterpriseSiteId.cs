using System.Collections.Generic;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.ResourceManager.VMware.v2020_03_20.HcxEnterpriseSites
{
    internal class HcxEnterpriseSiteId : ResourceID
    {
        public string? CommonAlias => null;

        public string ID => "/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/hcxEnterpriseSites/{hcxEnterpriseSiteName}";

        public List<ResourceIDSegment> Segments => new List<ResourceIDSegment>
        {
                new()
                {
                    Name = "staticSubscriptions",
                    Type = ResourceIDSegmentType.Static,
                    FixedValue = "subscriptions"
                },

                new()
                {
                    Name = "subscriptionId",
                    Type = ResourceIDSegmentType.SubscriptionId
                },

                new()
                {
                    Name = "staticResourceGroups",
                    Type = ResourceIDSegmentType.Static,
                    FixedValue = "resourceGroups"
                },

                new()
                {
                    Name = "resourceGroupName",
                    Type = ResourceIDSegmentType.ResourceGroup
                },

                new()
                {
                    Name = "staticProviders",
                    Type = ResourceIDSegmentType.Static,
                    FixedValue = "providers"
                },

                new()
                {
                    Name = "staticMicrosoftAVS",
                    Type = ResourceIDSegmentType.ResourceProvider,
                    FixedValue = "Microsoft.AVS"
                },

                new()
                {
                    Name = "staticPrivateClouds",
                    Type = ResourceIDSegmentType.Static,
                    FixedValue = "privateClouds"
                },

                new()
                {
                    Name = "privateCloudName",
                    Type = ResourceIDSegmentType.UserSpecified
                },

                new()
                {
                    Name = "staticHcxEnterpriseSites",
                    Type = ResourceIDSegmentType.Static,
                    FixedValue = "hcxEnterpriseSites"
                },

                new()
                {
                    Name = "hcxEnterpriseSiteName",
                    Type = ResourceIDSegmentType.UserSpecified
                },

        };
    }
}
