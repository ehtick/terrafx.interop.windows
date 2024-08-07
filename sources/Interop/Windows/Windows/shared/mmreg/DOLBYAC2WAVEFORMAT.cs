// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/mmreg.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='DOLBYAC2WAVEFORMAT.xml' path='doc/member[@name="DOLBYAC2WAVEFORMAT"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct DOLBYAC2WAVEFORMAT
{
    /// <include file='DOLBYAC2WAVEFORMAT.xml' path='doc/member[@name="DOLBYAC2WAVEFORMAT.wfx"]/*' />
    public WAVEFORMATEX wfx;

    /// <include file='DOLBYAC2WAVEFORMAT.xml' path='doc/member[@name="DOLBYAC2WAVEFORMAT.nAuxBitsCode"]/*' />
    [NativeTypeName("WORD")]
    public ushort nAuxBitsCode;
}
