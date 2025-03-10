// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum PrintJobProcessingStateConstant
{
    [Description("Unknown")]
    @unknown,

    [Description("Pending")]
    @pending,

    [Description("Processing")]
    @processing,

    [Description("Paused")]
    @paused,

    [Description("Stopped")]
    @stopped,

    [Description("Completed")]
    @completed,

    [Description("Canceled")]
    @canceled,

    [Description("Aborted")]
    @aborted,
}
