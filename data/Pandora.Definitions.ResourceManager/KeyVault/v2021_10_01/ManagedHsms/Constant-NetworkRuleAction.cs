using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.KeyVault.v2021_10_01.ManagedHsms;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum NetworkRuleActionConstant
{
    [Description("Allow")]
    Allow,

    [Description("Deny")]
    Deny,
}
