using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.CosmosDB.v2023_04_15.CosmosDB;

internal class TableResourcesListTablesOperation : Pandora.Definitions.Operations.GetOperation
{
    public override ResourceID? ResourceId() => new DatabaseAccountId();

    public override Type? ResponseObject() => typeof(TableListResultModel);

    public override string? UriSuffix() => "/tables";


}
