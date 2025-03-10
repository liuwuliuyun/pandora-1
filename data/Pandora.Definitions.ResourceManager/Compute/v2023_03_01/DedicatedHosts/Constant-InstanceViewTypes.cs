using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Compute.v2023_03_01.DedicatedHosts;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum InstanceViewTypesConstant
{
    [Description("instanceView")]
    InstanceView,

    [Description("userData")]
    UserData,
}
