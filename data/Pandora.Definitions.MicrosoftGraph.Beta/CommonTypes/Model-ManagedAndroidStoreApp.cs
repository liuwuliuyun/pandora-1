// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


namespace Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;

internal class ManagedAndroidStoreAppModel
{
    [JsonPropertyName("appAvailability")]
    public ManagedAppAvailabilityConstant? AppAvailability { get; set; }

    [JsonPropertyName("appStoreUrl")]
    public string? AppStoreUrl { get; set; }

    [JsonPropertyName("assignments")]
    public List<MobileAppAssignmentModel>? Assignments { get; set; }

    [JsonPropertyName("categories")]
    public List<MobileAppCategoryModel>? Categories { get; set; }

    [JsonPropertyName("createdDateTime")]
    public DateTime? CreatedDateTime { get; set; }

    [JsonPropertyName("dependentAppCount")]
    public int? DependentAppCount { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("developer")]
    public string? Developer { get; set; }

    [JsonPropertyName("deviceStatuses")]
    public List<MobileAppInstallStatusModel>? DeviceStatuses { get; set; }

    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("informationUrl")]
    public string? InformationUrl { get; set; }

    [JsonPropertyName("installSummary")]
    public MobileAppInstallSummaryModel? InstallSummary { get; set; }

    [JsonPropertyName("isAssigned")]
    public bool? IsAssigned { get; set; }

    [JsonPropertyName("isFeatured")]
    public bool? IsFeatured { get; set; }

    [JsonPropertyName("largeIcon")]
    public MimeContentModel? LargeIcon { get; set; }

    [JsonPropertyName("lastModifiedDateTime")]
    public DateTime? LastModifiedDateTime { get; set; }

    [JsonPropertyName("minimumSupportedOperatingSystem")]
    public AndroidMinimumOperatingSystemModel? MinimumSupportedOperatingSystem { get; set; }

    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    [JsonPropertyName("@odata.type")]
    public string? ODataType { get; set; }

    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    [JsonPropertyName("packageId")]
    public string? PackageId { get; set; }

    [JsonPropertyName("privacyInformationUrl")]
    public string? PrivacyInformationUrl { get; set; }

    [JsonPropertyName("publisher")]
    public string? Publisher { get; set; }

    [JsonPropertyName("publishingState")]
    public MobileAppPublishingStateConstant? PublishingState { get; set; }

    [JsonPropertyName("relationships")]
    public List<MobileAppRelationshipModel>? Relationships { get; set; }

    [JsonPropertyName("roleScopeTagIds")]
    public List<string>? RoleScopeTagIds { get; set; }

    [JsonPropertyName("supersededAppCount")]
    public int? SupersededAppCount { get; set; }

    [JsonPropertyName("supersedingAppCount")]
    public int? SupersedingAppCount { get; set; }

    [JsonPropertyName("uploadState")]
    public int? UploadState { get; set; }

    [JsonPropertyName("userStatuses")]
    public List<UserAppInstallStatusModel>? UserStatuses { get; set; }

    [JsonPropertyName("version")]
    public string? Version { get; set; }
}
