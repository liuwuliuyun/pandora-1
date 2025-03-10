// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.Interfaces;
using Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;
using System;

namespace Pandora.Definitions.MicrosoftGraph.Beta.Applications.Beta.ApplicationSynchronization;

internal class Definition : ResourceDefinition
{
    public string Name => "ApplicationSynchronization";

    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new AcquireSynchronizationAccessTokenOperation(),
        new CreateUpdateSynchronizationOperation(),
        new DeleteSynchronizationOperation(),
        new GetSynchronizationOperation()
    };

    public IEnumerable<System.Type> Constants => new List<System.Type>
    {

    };

    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(AcquireSynchronizationAccessTokenRequestModel)
    };
}
