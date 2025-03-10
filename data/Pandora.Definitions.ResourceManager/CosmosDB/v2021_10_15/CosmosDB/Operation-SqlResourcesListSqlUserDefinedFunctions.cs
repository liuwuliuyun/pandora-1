using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.CosmosDB.v2021_10_15.CosmosDB;

internal class SqlResourcesListSqlUserDefinedFunctionsOperation : Pandora.Definitions.Operations.GetOperation
{
    public override ResourceID? ResourceId() => new ContainerId();

    public override Type? ResponseObject() => typeof(SqlUserDefinedFunctionListResultModel);

    public override string? UriSuffix() => "/userDefinedFunctions";


}
