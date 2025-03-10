using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.ApiManagement.v2021_08_01.ApiDiagnostic;

internal class Definition : ResourceDefinition
{
    public string Name => "ApiDiagnostic";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new CreateOrUpdateOperation(),
        new DeleteOperation(),
        new GetOperation(),
        new GetEntityTagOperation(),
        new ListByServiceOperation(),
        new UpdateOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {
        typeof(AlwaysLogConstant),
        typeof(DataMaskingModeConstant),
        typeof(HTTPCorrelationProtocolConstant),
        typeof(OperationNameFormatConstant),
        typeof(SamplingTypeConstant),
        typeof(VerbosityConstant),
    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(BodyDiagnosticSettingsModel),
        typeof(DataMaskingModel),
        typeof(DataMaskingEntityModel),
        typeof(DiagnosticContractModel),
        typeof(DiagnosticContractPropertiesModel),
        typeof(HTTPMessageDiagnosticModel),
        typeof(PipelineDiagnosticSettingsModel),
        typeof(SamplingSettingsModel),
    };
}
