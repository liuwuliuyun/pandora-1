using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.CosmosDB.v2021_10_15.CosmosDB;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum BackupPolicyTypeConstant
{
    [Description("Continuous")]
    Continuous,

    [Description("Periodic")]
    Periodic,
}
