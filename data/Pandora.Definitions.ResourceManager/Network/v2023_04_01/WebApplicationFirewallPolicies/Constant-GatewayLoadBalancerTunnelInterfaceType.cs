using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Network.v2023_04_01.WebApplicationFirewallPolicies;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum GatewayLoadBalancerTunnelInterfaceTypeConstant
{
    [Description("External")]
    External,

    [Description("Internal")]
    Internal,

    [Description("None")]
    None,
}
