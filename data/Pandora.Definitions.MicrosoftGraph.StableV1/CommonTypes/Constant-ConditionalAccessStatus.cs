// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.MicrosoftGraph.StableV1.CommonTypes;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum ConditionalAccessStatusConstant
{
    [Description("Success")]
    @success,

    [Description("Failure")]
    @failure,

    [Description("NotApplied")]
    @notApplied,
}
