using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.MachineLearningServices.v2023_04_01_preview.ComponentVersion;

internal class RegistryComponentVersionsCreateOrUpdateOperation : Pandora.Definitions.Operations.PutOperation
{
    public override bool LongRunning() => true;

    public override Type? RequestObject() => typeof(ComponentVersionResourceModel);

    public override ResourceID? ResourceId() => new RegistryComponentVersionId();

    public override Type? ResponseObject() => typeof(ComponentVersionResourceModel);


}
