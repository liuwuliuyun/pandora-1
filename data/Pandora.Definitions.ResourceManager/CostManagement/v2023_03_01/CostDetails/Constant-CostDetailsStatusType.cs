using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.CostManagement.v2023_03_01.CostDetails;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum CostDetailsStatusTypeConstant
{
    [Description("Completed")]
    Completed,

    [Description("Failed")]
    Failed,

    [Description("NoDataFound")]
    NoDataFound,
}
