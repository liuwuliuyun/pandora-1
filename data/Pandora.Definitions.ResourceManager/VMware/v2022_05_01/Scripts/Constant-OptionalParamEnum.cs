using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.VMware.v2022_05_01.Scripts;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum OptionalParamEnumConstant
{
    [Description("Optional")]
    Optional,

    [Description("Required")]
    Required,
}
