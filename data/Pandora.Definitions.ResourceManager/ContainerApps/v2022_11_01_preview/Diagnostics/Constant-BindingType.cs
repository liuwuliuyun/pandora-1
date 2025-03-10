using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.ContainerApps.v2022_11_01_preview.Diagnostics;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum BindingTypeConstant
{
    [Description("Disabled")]
    Disabled,

    [Description("SniEnabled")]
    SniEnabled,
}
