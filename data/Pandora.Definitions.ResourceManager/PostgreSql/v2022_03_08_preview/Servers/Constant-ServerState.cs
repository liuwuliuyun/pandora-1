using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.PostgreSql.v2022_03_08_preview.Servers;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum ServerStateConstant
{
    [Description("Disabled")]
    Disabled,

    [Description("Dropping")]
    Dropping,

    [Description("Ready")]
    Ready,

    [Description("Starting")]
    Starting,

    [Description("Stopped")]
    Stopped,

    [Description("Stopping")]
    Stopping,

    [Description("Updating")]
    Updating,
}
