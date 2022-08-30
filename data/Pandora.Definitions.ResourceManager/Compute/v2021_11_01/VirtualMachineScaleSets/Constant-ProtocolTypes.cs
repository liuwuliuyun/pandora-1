using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Compute.v2021_11_01.VirtualMachineScaleSets;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum ProtocolTypesConstant
{
    [Description("Http")]
    HTTP,

    [Description("Https")]
    HTTPS,
}
