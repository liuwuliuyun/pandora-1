using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.DataMigration.v2021_06_30.CustomOperation;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum NameCheckFailureReasonConstant
{
    [Description("AlreadyExists")]
    AlreadyExists,

    [Description("Invalid")]
    Invalid,
}
