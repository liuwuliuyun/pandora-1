using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.MachineLearningServices.v2023_04_01_preview.EnvironmentVersion;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum AutoRebuildSettingConstant
{
    [Description("Disabled")]
    Disabled,

    [Description("OnBaseImageUpdate")]
    OnBaseImageUpdate,
}
