using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.ContainerApps.v2022_11_01_preview.ManagedEnvironments;

internal class ManagedCertificatesCreateOrUpdateOperation : Pandora.Definitions.Operations.PutOperation
{
    public override bool LongRunning() => true;

    public override Type? RequestObject() => typeof(ManagedCertificateModel);

    public override ResourceID? ResourceId() => new ManagedCertificateId();

    public override Type? ResponseObject() => typeof(ManagedCertificateModel);


}
