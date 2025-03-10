using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.TrafficManager.v2022_04_01.Profiles;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum ProfileStatusConstant
{
    [Description("Disabled")]
    Disabled,

    [Description("Enabled")]
    Enabled,
}
