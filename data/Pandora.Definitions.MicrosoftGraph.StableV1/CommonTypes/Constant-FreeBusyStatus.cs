// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.MicrosoftGraph.StableV1.CommonTypes;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum FreeBusyStatusConstant
{
    [Description("Unknown")]
    @unknown,

    [Description("Free")]
    @free,

    [Description("Tentative")]
    @tentative,

    [Description("Busy")]
    @busy,

    [Description("Oof")]
    @oof,

    [Description("WorkingElsewhere")]
    @workingElsewhere,
}
