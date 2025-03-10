using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.RecoveryServicesBackup.v2023_01_15.BackupUsageSummariesCRR;

internal class BackupUsageSummariesCRRListOperation : Pandora.Definitions.Operations.GetOperation
{
    public override ResourceID? ResourceId() => new VaultId();

    public override Type? ResponseObject() => typeof(BackupManagementUsageModel);

    public override Type? OptionsObject() => typeof(BackupUsageSummariesCRRListOperation.BackupUsageSummariesCRRListOptions);

    public override string? UriSuffix() => "/backupUsageSummaries";

    internal class BackupUsageSummariesCRRListOptions
    {
        [QueryStringName("$filter")]
        [Optional]
        public string Filter { get; set; }
    }
}
