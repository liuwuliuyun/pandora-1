using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Sql.v2022_11_01_preview.ManagedBackupShortTermRetentionPolicies;

internal class ListByDatabaseOperation : Pandora.Definitions.Operations.ListOperation
{
    public override string? FieldContainingPaginationDetails() => "nextLink";

    public override ResourceID? ResourceId() => new ManagedInstanceDatabaseId();

    public override Type NestedItemType() => typeof(ManagedBackupShortTermRetentionPolicyModel);

    public override string? UriSuffix() => "/backupShortTermRetentionPolicies";


}
