// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum CoachmarkLocationTypeConstant
{
    [Description("Unknown")]
    @unknown,

    [Description("FromEmail")]
    @fromEmail,

    [Description("Subject")]
    @subject,

    [Description("ExternalTag")]
    @externalTag,

    [Description("DisplayName")]
    @displayName,

    [Description("MessageBody")]
    @messageBody,
}
