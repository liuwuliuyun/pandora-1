using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.SecurityInsights.v2022_08_01.AlertRules;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum MatchingMethodConstant
{
    [Description("AllEntities")]
    AllEntities,

    [Description("AnyAlert")]
    AnyAlert,

    [Description("Selected")]
    Selected,
}
