using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Sql.v2021_02_01_preview.TransparentDataEncryptions;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum TransparentDataEncryptionStateConstant
{
    [Description("Disabled")]
    Disabled,

    [Description("Enabled")]
    Enabled,
}
