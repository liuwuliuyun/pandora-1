// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum DefenderMonitorFileActivityConstant
{
    [Description("UserDefined")]
    @userDefined,

    [Description("Disable")]
    @disable,

    [Description("MonitorAllFiles")]
    @monitorAllFiles,

    [Description("MonitorIncomingFilesOnly")]
    @monitorIncomingFilesOnly,

    [Description("MonitorOutgoingFilesOnly")]
    @monitorOutgoingFilesOnly,
}
