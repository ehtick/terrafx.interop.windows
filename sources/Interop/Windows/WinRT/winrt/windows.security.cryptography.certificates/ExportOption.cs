// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.cryptography.certificates.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='ExportOption.xml' path='doc/member[@name="ExportOption"]/*' />
public enum ExportOption
{
    /// <include file='ExportOption.xml' path='doc/member[@name="ExportOption.ExportOption_NotExportable"]/*' />
    ExportOption_NotExportable = 0,

    /// <include file='ExportOption.xml' path='doc/member[@name="ExportOption.ExportOption_Exportable"]/*' />
    ExportOption_Exportable = 1,
}
