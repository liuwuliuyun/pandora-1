using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Automation.v2019_06_01.TestJobStream;

internal class TestJobStreamId : ResourceID
{
    public string? CommonAlias => null;

    public string ID => "/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/runbooks/{runbookName}/draft/testJob/streams/{jobStreamId}";

    public List<ResourceIDSegment> Segments => new List<ResourceIDSegment>
    {
        ResourceIDSegment.Static("staticSubscriptions", "subscriptions"),
        ResourceIDSegment.SubscriptionId("subscriptionId"),
        ResourceIDSegment.Static("staticResourceGroups", "resourceGroups"),
        ResourceIDSegment.ResourceGroup("resourceGroupName"),
        ResourceIDSegment.Static("staticProviders", "providers"),
        ResourceIDSegment.ResourceProvider("staticMicrosoftAutomation", "Microsoft.Automation"),
        ResourceIDSegment.Static("staticAutomationAccounts", "automationAccounts"),
        ResourceIDSegment.UserSpecified("automationAccountName"),
        ResourceIDSegment.Static("staticRunbooks", "runbooks"),
        ResourceIDSegment.UserSpecified("runbookName"),
        ResourceIDSegment.Static("staticDraft", "draft"),
        ResourceIDSegment.Static("staticTestJob", "testJob"),
        ResourceIDSegment.Static("staticStreams", "streams"),
        ResourceIDSegment.UserSpecified("jobStreamId"),
    };
}
