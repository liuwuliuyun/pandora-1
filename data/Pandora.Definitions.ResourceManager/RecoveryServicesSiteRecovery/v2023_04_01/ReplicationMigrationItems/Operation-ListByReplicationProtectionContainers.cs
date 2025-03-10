using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.RecoveryServicesSiteRecovery.v2023_04_01.ReplicationMigrationItems;

internal class ListByReplicationProtectionContainersOperation : Pandora.Definitions.Operations.ListOperation
{
    public override string? FieldContainingPaginationDetails() => "nextLink";

    public override ResourceID? ResourceId() => new ReplicationProtectionContainerId();

    public override Type NestedItemType() => typeof(MigrationItemModel);

    public override Type? OptionsObject() => typeof(ListByReplicationProtectionContainersOperation.ListByReplicationProtectionContainersOptions);

    public override string? UriSuffix() => "/replicationMigrationItems";

    internal class ListByReplicationProtectionContainersOptions
    {
        [QueryStringName("$filter")]
        [Optional]
        public string Filter { get; set; }

        [QueryStringName("skipToken")]
        [Optional]
        public string SkipToken { get; set; }

        [QueryStringName("takeToken")]
        [Optional]
        public string TakeToken { get; set; }
    }
}
