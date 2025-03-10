using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Sql.v2022_11_01_preview.Databases;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum ReplicaTypeConstant
{
    [Description("Primary")]
    Primary,

    [Description("ReadableSecondary")]
    ReadableSecondary,
}
