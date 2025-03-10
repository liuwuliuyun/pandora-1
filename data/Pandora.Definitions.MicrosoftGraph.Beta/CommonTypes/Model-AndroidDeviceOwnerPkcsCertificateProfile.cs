// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


namespace Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;

internal class AndroidDeviceOwnerPkcsCertificateProfileModel
{
    [JsonPropertyName("assignments")]
    public List<DeviceConfigurationAssignmentModel>? Assignments { get; set; }

    [JsonPropertyName("certificateAccessType")]
    public AndroidDeviceOwnerCertificateAccessTypeConstant? CertificateAccessType { get; set; }

    [JsonPropertyName("certificateStore")]
    public CertificateStoreConstant? CertificateStore { get; set; }

    [JsonPropertyName("certificateTemplateName")]
    public string? CertificateTemplateName { get; set; }

    [JsonPropertyName("certificateValidityPeriodScale")]
    public CertificateValidityPeriodScaleConstant? CertificateValidityPeriodScale { get; set; }

    [JsonPropertyName("certificateValidityPeriodValue")]
    public int? CertificateValidityPeriodValue { get; set; }

    [JsonPropertyName("certificationAuthority")]
    public string? CertificationAuthority { get; set; }

    [JsonPropertyName("certificationAuthorityName")]
    public string? CertificationAuthorityName { get; set; }

    [JsonPropertyName("certificationAuthorityType")]
    public DeviceManagementCertificationAuthorityConstant? CertificationAuthorityType { get; set; }

    [JsonPropertyName("createdDateTime")]
    public DateTime? CreatedDateTime { get; set; }

    [JsonPropertyName("customSubjectAlternativeNames")]
    public List<CustomSubjectAlternativeNameModel>? CustomSubjectAlternativeNames { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("deviceManagementApplicabilityRuleDeviceMode")]
    public DeviceManagementApplicabilityRuleDeviceModeModel? DeviceManagementApplicabilityRuleDeviceMode { get; set; }

    [JsonPropertyName("deviceManagementApplicabilityRuleOsEdition")]
    public DeviceManagementApplicabilityRuleOsEditionModel? DeviceManagementApplicabilityRuleOsEdition { get; set; }

    [JsonPropertyName("deviceManagementApplicabilityRuleOsVersion")]
    public DeviceManagementApplicabilityRuleOsVersionModel? DeviceManagementApplicabilityRuleOsVersion { get; set; }

    [JsonPropertyName("deviceSettingStateSummaries")]
    public List<SettingStateDeviceSummaryModel>? DeviceSettingStateSummaries { get; set; }

    [JsonPropertyName("deviceStatusOverview")]
    public DeviceConfigurationDeviceOverviewModel? DeviceStatusOverview { get; set; }

    [JsonPropertyName("deviceStatuses")]
    public List<DeviceConfigurationDeviceStatusModel>? DeviceStatuses { get; set; }

    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    [JsonPropertyName("extendedKeyUsages")]
    public List<ExtendedKeyUsageModel>? ExtendedKeyUsages { get; set; }

    [JsonPropertyName("groupAssignments")]
    public List<DeviceConfigurationGroupAssignmentModel>? GroupAssignments { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("lastModifiedDateTime")]
    public DateTime? LastModifiedDateTime { get; set; }

    [JsonPropertyName("managedDeviceCertificateStates")]
    public List<ManagedDeviceCertificateStateModel>? ManagedDeviceCertificateStates { get; set; }

    [JsonPropertyName("@odata.type")]
    public string? ODataType { get; set; }

    [JsonPropertyName("renewalThresholdPercentage")]
    public int? RenewalThresholdPercentage { get; set; }

    [JsonPropertyName("roleScopeTagIds")]
    public List<string>? RoleScopeTagIds { get; set; }

    [JsonPropertyName("rootCertificate")]
    public AndroidDeviceOwnerTrustedRootCertificateModel? RootCertificate { get; set; }

    [JsonPropertyName("silentCertificateAccessDetails")]
    public List<AndroidDeviceOwnerSilentCertificateAccessModel>? SilentCertificateAccessDetails { get; set; }

    [JsonPropertyName("subjectAlternativeNameFormatString")]
    public string? SubjectAlternativeNameFormatString { get; set; }

    [JsonPropertyName("subjectAlternativeNameType")]
    public SubjectAlternativeNameTypeConstant? SubjectAlternativeNameType { get; set; }

    [JsonPropertyName("subjectNameFormat")]
    public SubjectNameFormatConstant? SubjectNameFormat { get; set; }

    [JsonPropertyName("subjectNameFormatString")]
    public string? SubjectNameFormatString { get; set; }

    [JsonPropertyName("supportsScopeTags")]
    public bool? SupportsScopeTags { get; set; }

    [JsonPropertyName("userStatusOverview")]
    public DeviceConfigurationUserOverviewModel? UserStatusOverview { get; set; }

    [JsonPropertyName("userStatuses")]
    public List<DeviceConfigurationUserStatusModel>? UserStatuses { get; set; }

    [JsonPropertyName("version")]
    public int? Version { get; set; }
}
