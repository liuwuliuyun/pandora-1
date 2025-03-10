using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.StreamAnalytics.v2020_03_01.Functions;

internal class FunctionId : ResourceID
{
    public string? CommonAlias => null;

    public string ID => "/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StreamAnalytics/streamingJobs/{streamingJobName}/functions/{functionName}";

    public List<ResourceIDSegment> Segments => new List<ResourceIDSegment>
    {
        ResourceIDSegment.Static("staticSubscriptions", "subscriptions"),
        ResourceIDSegment.SubscriptionId("subscriptionId"),
        ResourceIDSegment.Static("staticResourceGroups", "resourceGroups"),
        ResourceIDSegment.ResourceGroup("resourceGroupName"),
        ResourceIDSegment.Static("staticProviders", "providers"),
        ResourceIDSegment.ResourceProvider("staticMicrosoftStreamAnalytics", "Microsoft.StreamAnalytics"),
        ResourceIDSegment.Static("staticStreamingJobs", "streamingJobs"),
        ResourceIDSegment.UserSpecified("streamingJobName"),
        ResourceIDSegment.Static("staticFunctions", "functions"),
        ResourceIDSegment.UserSpecified("functionName"),
    };
}
