// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


namespace Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;

internal class UnifiedRbacApplicationModel
{
    [JsonPropertyName("customAppScopes")]
    public List<CustomAppScopeModel>? CustomAppScopes { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("@odata.type")]
    public string? ODataType { get; set; }

    [JsonPropertyName("resourceNamespaces")]
    public List<UnifiedRbacResourceNamespaceModel>? ResourceNamespaces { get; set; }

    [JsonPropertyName("roleAssignments")]
    public List<UnifiedRoleAssignmentModel>? RoleAssignments { get; set; }

    [JsonPropertyName("roleDefinitions")]
    public List<UnifiedRoleDefinitionModel>? RoleDefinitions { get; set; }

    [JsonPropertyName("transitiveRoleAssignments")]
    public List<UnifiedRoleAssignmentModel>? TransitiveRoleAssignments { get; set; }
}
