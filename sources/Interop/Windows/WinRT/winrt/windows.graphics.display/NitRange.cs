// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.display.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='NitRange.xml' path='doc/member[@name="NitRange"]/*' />
public partial struct NitRange
{
    /// <include file='NitRange.xml' path='doc/member[@name="NitRange.MinNits"]/*' />
    public float MinNits;

    /// <include file='NitRange.xml' path='doc/member[@name="NitRange.MaxNits"]/*' />
    public float MaxNits;

    /// <include file='NitRange.xml' path='doc/member[@name="NitRange.StepSizeNits"]/*' />
    public float StepSizeNits;
}
