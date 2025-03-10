using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Resources.v2021_04_01.Deployments;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum AliasPatternTypeConstant
{
    [Description("Extract")]
    Extract,

    [Description("NotSpecified")]
    NotSpecified,
}
