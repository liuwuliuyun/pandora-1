using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.RecoveryServicesBackup.v2022_10_01.ValidateOperation;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum CopyOptionsConstant
{
    [Description("CreateCopy")]
    CreateCopy,

    [Description("FailOnConflict")]
    FailOnConflict,

    [Description("Invalid")]
    Invalid,

    [Description("Overwrite")]
    Overwrite,

    [Description("Skip")]
    Skip,
}
