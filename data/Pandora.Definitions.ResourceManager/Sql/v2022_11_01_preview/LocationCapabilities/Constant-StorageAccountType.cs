using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Sql.v2022_11_01_preview.LocationCapabilities;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum StorageAccountTypeConstant
{
    [Description("GRS")]
    GRS,

    [Description("GZRS")]
    GZRS,

    [Description("LRS")]
    LRS,

    [Description("ZRS")]
    ZRS,
}
