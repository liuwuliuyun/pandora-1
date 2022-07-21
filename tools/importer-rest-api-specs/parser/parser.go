package parser

import (
	"fmt"
	"strings"

	"github.com/hashicorp/pandora/tools/importer-rest-api-specs/models"
	"github.com/hashicorp/pandora/tools/importer-rest-api-specs/parser/resourceids"
)

func (d *SwaggerDefinition) parse(serviceName, apiVersion string, resourceIds resourceids.ParseResult) (*models.AzureApiDefinition, error) {
	resources := make(map[string]models.AzureApiResource, 0)

	tags := d.findTags()
	// first we assume everything has a tag
	for _, tag := range tags {
		if tagShouldBeIgnored(tag) {
			continue
		}

		resource, err := d.parseResourcesWithinSwaggerTag(&tag, resourceIds)
		if err != nil {
			return nil, fmt.Errorf("finding resources for tag %q: %+v", tag, err)
		}

		if resource != nil {
			normalizedTag := normalizeTag(tag)
			normalizedTag = NormalizeResourceName(normalizedTag)
			resources[normalizedTag] = *resource
		}
	}

	// however some things don't, so we then need to iterate over any without them
	if _, shouldIgnore := tagsToIgnore[strings.ToLower(serviceName)]; !shouldIgnore {
		resource, err := d.parseResourcesWithinSwaggerTag(nil, resourceIds)
		if err != nil {
			return nil, fmt.Errorf("finding resources for tag %q: %+v", serviceName, err)
		}

		if resource != nil {
			normalizedTag := normalizeTag(serviceName)
			normalizedTag = NormalizeResourceName(normalizedTag)
			resources[normalizedTag] = *resource
		}
	}

	return &models.AzureApiDefinition{
		ServiceName: NormalizeServiceName(serviceName),
		ApiVersion:  apiVersion,
		Resources:   resources,
	}, nil
}

func (d *SwaggerDefinition) ParseResourceIds() (*resourceids.ParseResult, error) {
	parser := resourceids.NewParser(d.logger.Named("ResourceID Parser"), d.swaggerSpecExpanded)

	resourceIds, err := parser.Parse()
	if err != nil {
		return nil, fmt.Errorf("finding resource ids: %+v", err)
	}
	return resourceIds, nil
}
