using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Media.v2022_07_01.Encodings;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum H264VideoProfileConstant
{
    [Description("Auto")]
    Auto,

    [Description("Baseline")]
    Baseline,

    [Description("High")]
    High,

    [Description("High444")]
    HighFourFourFour,

    [Description("High422")]
    HighFourTwoTwo,

    [Description("Main")]
    Main,
}
