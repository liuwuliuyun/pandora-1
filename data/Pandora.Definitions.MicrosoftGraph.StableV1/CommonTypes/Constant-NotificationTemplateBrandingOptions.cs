// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.MicrosoftGraph.StableV1.CommonTypes;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum NotificationTemplateBrandingOptionsConstant
{
    [Description("None")]
    @none,

    [Description("IncludeCompanyLogo")]
    @includeCompanyLogo,

    [Description("IncludeCompanyName")]
    @includeCompanyName,

    [Description("IncludeContactInformation")]
    @includeContactInformation,

    [Description("IncludeCompanyPortalLink")]
    @includeCompanyPortalLink,

    [Description("IncludeDeviceDetails")]
    @includeDeviceDetails,
}
