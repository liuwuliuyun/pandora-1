// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.Interfaces;
using Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;
using System;

namespace Pandora.Definitions.MicrosoftGraph.Beta.Applications.Beta.ApplicationTokenLifetimePolicy;

internal class Definition : ResourceDefinition
{
    public string Name => "ApplicationTokenLifetimePolicy";

    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new AddApplicationTokenLifetimePolicyOperation(),
        new GetApplicationTokenLifetimePoliciesCountOperation(),
        new ListTokenLifetimePoliciesOperation(),
        new RemoveApplicationTokenLifetimePolicyOperation()
    };

    public IEnumerable<System.Type> Constants => new List<System.Type>
    {

    };

    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(AddApplicationTokenLifetimePolicyRequestModel)
    };
}
