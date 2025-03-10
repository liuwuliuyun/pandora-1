using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Advisor.v2023_01_01.Prediction;

internal class Definition : ResourceDefinition
{
    public string Name => "Prediction";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new PredictOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {
        typeof(CategoryConstant),
        typeof(ImpactConstant),
        typeof(PredictionTypeConstant),
    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(PredictionRequestModel),
        typeof(PredictionRequestPropertiesModel),
        typeof(PredictionResponseModel),
        typeof(PredictionResponsePropertiesModel),
        typeof(ShortDescriptionModel),
    };
}
