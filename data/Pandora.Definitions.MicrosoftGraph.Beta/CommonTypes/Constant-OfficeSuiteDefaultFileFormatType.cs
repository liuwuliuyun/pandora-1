// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum OfficeSuiteDefaultFileFormatTypeConstant
{
    [Description("NotConfigured")]
    @notConfigured,

    [Description("OfficeOpenXMLFormat")]
    @officeOpenXMLFormat,

    [Description("OfficeOpenDocumentFormat")]
    @officeOpenDocumentFormat,
}
