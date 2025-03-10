using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.KubernetesConfiguration.v2022_03_01.SourceControlConfiguration;

internal class ScopedSourceControlConfigurationId : ResourceID
{
    public string? CommonAlias => null;

    public string ID => "/{scope}/providers/Microsoft.KubernetesConfiguration/sourceControlConfigurations/{sourceControlConfigurationName}";

    public List<ResourceIDSegment> Segments => new List<ResourceIDSegment>
    {
        ResourceIDSegment.Scope("scope"),
        ResourceIDSegment.Static("staticProviders", "providers"),
        ResourceIDSegment.ResourceProvider("staticMicrosoftKubernetesConfiguration", "Microsoft.KubernetesConfiguration"),
        ResourceIDSegment.Static("staticSourceControlConfigurations", "sourceControlConfigurations"),
        ResourceIDSegment.UserSpecified("sourceControlConfigurationName"),
    };
}
