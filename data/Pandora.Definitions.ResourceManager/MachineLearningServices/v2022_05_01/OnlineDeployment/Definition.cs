using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.MachineLearningServices.v2022_05_01.OnlineDeployment;

internal class Definition : ResourceDefinition
{
    public string Name => "OnlineDeployment";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new CreateOrUpdateOperation(),
        new DeleteOperation(),
        new GetOperation(),
        new GetLogsOperation(),
        new ListOperation(),
        new ListSkusOperation(),
        new UpdateOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {
        typeof(ContainerTypeConstant),
        typeof(DeploymentProvisioningStateConstant),
        typeof(EndpointComputeTypeConstant),
        typeof(ScaleTypeConstant),
        typeof(SkuScaleTypeConstant),
        typeof(SkuTierConstant),
    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(CodeConfigurationModel),
        typeof(ContainerResourceRequirementsModel),
        typeof(ContainerResourceSettingsModel),
        typeof(DefaultScaleSettingsModel),
        typeof(DeploymentLogsModel),
        typeof(DeploymentLogsRequestModel),
        typeof(KubernetesOnlineDeploymentModel),
        typeof(ManagedOnlineDeploymentModel),
        typeof(OnlineDeploymentModel),
        typeof(OnlineDeploymentTrackedResourceModel),
        typeof(OnlineRequestSettingsModel),
        typeof(OnlineScaleSettingsModel),
        typeof(PartialMinimalTrackedResourceWithSkuModel),
        typeof(PartialSkuModel),
        typeof(ProbeSettingsModel),
        typeof(SkuModel),
        typeof(SkuCapacityModel),
        typeof(SkuResourceModel),
        typeof(SkuSettingModel),
        typeof(TargetUtilizationScaleSettingsModel),
    };
}
