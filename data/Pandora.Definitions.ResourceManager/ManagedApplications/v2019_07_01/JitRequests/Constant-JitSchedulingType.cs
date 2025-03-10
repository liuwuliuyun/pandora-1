using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.ManagedApplications.v2019_07_01.JitRequests;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum JitSchedulingTypeConstant
{
    [Description("NotSpecified")]
    NotSpecified,

    [Description("Once")]
    Once,

    [Description("Recurring")]
    Recurring,
}
