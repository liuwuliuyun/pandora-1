using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Security.v2020_01_01.SecureScore;

internal class Definition : ResourceDefinition
{
    public string Name => "SecureScore";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new SecureScoreControlsListBySecureScoreOperation(),
        new SecureScoresGetOperation(),
        new SecureScoresListOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {
        typeof(ControlTypeConstant),
        typeof(ExpandControlsEnumConstant),
    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(AzureResourceLinkModel),
        typeof(ScoreDetailsModel),
        typeof(SecureScoreControlDefinitionItemModel),
        typeof(SecureScoreControlDefinitionItemPropertiesModel),
        typeof(SecureScoreControlDefinitionSourceModel),
        typeof(SecureScoreControlDetailsModel),
        typeof(SecureScoreControlScoreDetailsModel),
        typeof(SecureScoreItemModel),
        typeof(SecureScoreItemPropertiesModel),
    };
}
