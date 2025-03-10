// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum FirewallPacketQueueingMethodTypeConstant
{
    [Description("DeviceDefault")]
    @deviceDefault,

    [Description("Disabled")]
    @disabled,

    [Description("QueueInbound")]
    @queueInbound,

    [Description("QueueOutbound")]
    @queueOutbound,

    [Description("QueueBoth")]
    @queueBoth,
}
