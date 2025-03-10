// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum ProvisioningActionConstant
{
    [Description("Other")]
    @other,

    [Description("Create")]
    @create,

    [Description("Delete")]
    @delete,

    [Description("Disable")]
    @disable,

    [Description("Update")]
    @update,

    [Description("StagedDelete")]
    @stagedDelete,
}
