using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Network.v2023_04_01.DscpConfiguration;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum PublicIPAddressSkuTierConstant
{
    [Description("Global")]
    Global,

    [Description("Regional")]
    Regional,
}
