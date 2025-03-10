using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.DataProtection.v2023_01_01.DeletedBackupInstances;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum StatusConstant
{
    [Description("ConfiguringProtection")]
    ConfiguringProtection,

    [Description("ConfiguringProtectionFailed")]
    ConfiguringProtectionFailed,

    [Description("ProtectionConfigured")]
    ProtectionConfigured,

    [Description("ProtectionStopped")]
    ProtectionStopped,

    [Description("SoftDeleted")]
    SoftDeleted,

    [Description("SoftDeleting")]
    SoftDeleting,
}
