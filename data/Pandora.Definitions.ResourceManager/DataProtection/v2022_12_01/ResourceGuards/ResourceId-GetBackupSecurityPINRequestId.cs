using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.DataProtection.v2022_12_01.ResourceGuards;

internal class GetBackupSecurityPINRequestId : ResourceID
{
    public string? CommonAlias => null;

    public string ID => "/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataProtection/resourceGuards/{resourceGuardName}/getBackupSecurityPINRequests/{getBackupSecurityPINRequestName}";

    public List<ResourceIDSegment> Segments => new List<ResourceIDSegment>
    {
        ResourceIDSegment.Static("staticSubscriptions", "subscriptions"),
        ResourceIDSegment.SubscriptionId("subscriptionId"),
        ResourceIDSegment.Static("staticResourceGroups", "resourceGroups"),
        ResourceIDSegment.ResourceGroup("resourceGroupName"),
        ResourceIDSegment.Static("staticProviders", "providers"),
        ResourceIDSegment.ResourceProvider("staticMicrosoftDataProtection", "Microsoft.DataProtection"),
        ResourceIDSegment.Static("staticResourceGuards", "resourceGuards"),
        ResourceIDSegment.UserSpecified("resourceGuardName"),
        ResourceIDSegment.Static("staticGetBackupSecurityPINRequests", "getBackupSecurityPINRequests"),
        ResourceIDSegment.UserSpecified("getBackupSecurityPINRequestName"),
    };
}
