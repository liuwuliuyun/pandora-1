using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.ServiceLinker.v2022_05_01.Links;

internal class LinkerUpdateOperation : Pandora.Definitions.Operations.PatchOperation
{
    public override bool LongRunning() => true;

    public override Type? RequestObject() => typeof(LinkerPatchModel);

    public override ResourceID? ResourceId() => new ScopedLinkerId();

    public override Type? ResponseObject() => typeof(LinkerResourceModel);


}
