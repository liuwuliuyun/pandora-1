using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Automation.v2020_01_13_preview.Usages;

internal class ListByAutomationAccountOperation : Pandora.Definitions.Operations.GetOperation
{
    public override ResourceID? ResourceId() => new AutomationAccountId();

    public override Type? ResponseObject() => typeof(UsageListResultModel);

    public override string? UriSuffix() => "/usages";


}
