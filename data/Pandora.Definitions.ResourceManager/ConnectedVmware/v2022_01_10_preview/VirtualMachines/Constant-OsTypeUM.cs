using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.ConnectedVmware.v2022_01_10_preview.VirtualMachines;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum OsTypeUMConstant
{
    [Description("Linux")]
    Linux,

    [Description("Windows")]
    Windows,
}
