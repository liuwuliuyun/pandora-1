using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Network.v2023_02_01.NetworkManagerEffectiveConnectivityConfiguration;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum ConnectivityTopologyConstant
{
    [Description("HubAndSpoke")]
    HubAndSpoke,

    [Description("Mesh")]
    Mesh,
}
