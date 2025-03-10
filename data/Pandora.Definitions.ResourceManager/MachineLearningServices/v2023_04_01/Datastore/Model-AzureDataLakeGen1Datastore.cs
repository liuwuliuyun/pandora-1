using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.MachineLearningServices.v2023_04_01.Datastore;

[ValueForType("AzureDataLakeGen1")]
internal class AzureDataLakeGen1DatastoreModel : DatastoreModel
{
    [JsonPropertyName("serviceDataAccessAuthIdentity")]
    public ServiceDataAccessAuthIdentityConstant? ServiceDataAccessAuthIdentity { get; set; }

    [JsonPropertyName("storeName")]
    [Required]
    public string StoreName { get; set; }
}
