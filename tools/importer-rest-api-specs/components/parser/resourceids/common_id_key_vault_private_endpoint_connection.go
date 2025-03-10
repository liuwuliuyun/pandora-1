package resourceids

import (
	"github.com/hashicorp/pandora/tools/importer-rest-api-specs/models"
	"github.com/hashicorp/pandora/tools/sdk/resourcemanager"
)

var _ commonIdMatcher = commonIdKeyVaultPrivateEndpointConnection{}

type commonIdKeyVaultPrivateEndpointConnection struct{}

func (c commonIdKeyVaultPrivateEndpointConnection) id() models.ParsedResourceId {
	name := "KeyVaultPrivateEndpointConnection"
	return models.ParsedResourceId{
		CommonAlias: &name,
		Constants:   map[string]resourcemanager.ConstantDetails{},
		Segments: []resourcemanager.ResourceIdSegment{
			models.StaticResourceIDSegment("subscriptions", "subscriptions"),
			models.SubscriptionIDResourceIDSegment("subscriptionId"),
			models.StaticResourceIDSegment("resourceGroups", "resourceGroups"),
			models.ResourceGroupResourceIDSegment("resourceGroupName"),
			models.StaticResourceIDSegment("providers", "providers"),
			models.ResourceProviderResourceIDSegment("resourceProvider", "Microsoft.KeyVault"),
			models.StaticResourceIDSegment("vaults", "vaults"),
			models.UserSpecifiedResourceIDSegment("vaultName"),
			models.StaticResourceIDSegment("privateEndpointConnections", "privateEndpointConnections"),
			models.UserSpecifiedResourceIDSegment("privateEndpointConnectionName"),
		},
	}
}
