using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Network.v2023_02_01.VpnGateways;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum IkeIntegrityConstant
{
    [Description("GCMAES128")]
    GCMAESOneTwoEight,

    [Description("GCMAES256")]
    GCMAESTwoFiveSix,

    [Description("MD5")]
    MDFive,

    [Description("SHA1")]
    SHAOne,

    [Description("SHA384")]
    SHAThreeEightFour,

    [Description("SHA256")]
    SHATwoFiveSix,
}
