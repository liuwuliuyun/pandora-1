using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.ContainerService.v2023_04_02_preview.ManagedClusters;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum KeyVaultNetworkAccessTypesConstant
{
    [Description("Private")]
    Private,

    [Description("Public")]
    Public,
}
