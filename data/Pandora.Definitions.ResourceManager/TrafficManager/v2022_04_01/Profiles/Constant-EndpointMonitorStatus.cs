using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.TrafficManager.v2022_04_01.Profiles;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum EndpointMonitorStatusConstant
{
    [Description("CheckingEndpoint")]
    CheckingEndpoint,

    [Description("Degraded")]
    Degraded,

    [Description("Disabled")]
    Disabled,

    [Description("Inactive")]
    Inactive,

    [Description("Online")]
    Online,

    [Description("Stopped")]
    Stopped,

    [Description("Unmonitored")]
    Unmonitored,
}
