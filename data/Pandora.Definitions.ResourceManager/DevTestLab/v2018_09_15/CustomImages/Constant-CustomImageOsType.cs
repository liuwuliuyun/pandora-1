using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.DevTestLab.v2018_09_15.CustomImages;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum CustomImageOsTypeConstant
{
    [Description("Linux")]
    Linux,

    [Description("None")]
    None,

    [Description("Windows")]
    Windows,
}
