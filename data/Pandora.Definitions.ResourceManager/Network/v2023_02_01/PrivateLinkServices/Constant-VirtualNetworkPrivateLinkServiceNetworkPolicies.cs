using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Network.v2023_02_01.PrivateLinkServices;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum VirtualNetworkPrivateLinkServiceNetworkPoliciesConstant
{
    [Description("Disabled")]
    Disabled,

    [Description("Enabled")]
    Enabled,
}
