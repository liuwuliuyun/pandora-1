using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Dynatrace.v2021_09_01.TagRules;

internal class Definition : ResourceDefinition
{
    public string Name => "TagRules";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new CreateOrUpdateOperation(),
        new DeleteOperation(),
        new GetOperation(),
        new ListOperation(),
        new UpdateOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {
        typeof(ProvisioningStateConstant),
        typeof(SendAadLogsStatusConstant),
        typeof(SendActivityLogsStatusConstant),
        typeof(SendSubscriptionLogsStatusConstant),
        typeof(TagActionConstant),
    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(FilteringTagModel),
        typeof(LogRulesModel),
        typeof(MetricRulesModel),
        typeof(MonitoringTagRulesPropertiesModel),
        typeof(TagRuleModel),
        typeof(TagRuleUpdateModel),
    };
}
