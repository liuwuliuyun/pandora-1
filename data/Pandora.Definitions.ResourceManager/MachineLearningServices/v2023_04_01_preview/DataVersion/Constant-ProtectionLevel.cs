using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.MachineLearningServices.v2023_04_01_preview.DataVersion;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum ProtectionLevelConstant
{
    [Description("All")]
    All,

    [Description("None")]
    None,
}
