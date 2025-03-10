using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.DataProtection.v2023_01_01.DeletedBackupInstances;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum DataStoreTypesConstant
{
    [Description("ArchiveStore")]
    ArchiveStore,

    [Description("OperationalStore")]
    OperationalStore,

    [Description("VaultStore")]
    VaultStore,
}
