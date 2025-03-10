using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.StorageSync.v2020_03_01.WorkflowResource;

internal class WorkflowsListByStorageSyncServiceOperation : Pandora.Definitions.Operations.GetOperation
{
    public override ResourceID? ResourceId() => new StorageSyncServiceId();

    public override Type? ResponseObject() => typeof(WorkflowArrayModel);

    public override string? UriSuffix() => "/workflows";


}
