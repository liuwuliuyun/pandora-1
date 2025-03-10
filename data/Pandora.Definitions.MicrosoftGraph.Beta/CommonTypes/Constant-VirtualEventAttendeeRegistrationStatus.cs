// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum VirtualEventAttendeeRegistrationStatusConstant
{
    [Description("Registered")]
    @registered,

    [Description("Canceled")]
    @canceled,

    [Description("Waitlisted")]
    @waitlisted,

    [Description("PendingApproval")]
    @pendingApproval,

    [Description("RejectedByOrganizer")]
    @rejectedByOrganizer,
}
