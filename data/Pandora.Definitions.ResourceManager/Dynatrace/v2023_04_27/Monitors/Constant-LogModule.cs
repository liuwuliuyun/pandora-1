using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Dynatrace.v2023_04_27.Monitors;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum LogModuleConstant
{
    [Description("DISABLED")]
    DISABLED,

    [Description("ENABLED")]
    ENABLED,
}
