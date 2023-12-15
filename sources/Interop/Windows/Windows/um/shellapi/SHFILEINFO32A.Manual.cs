// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct SHFILEINFO32A
{
    public HICON hIcon;

    public int iIcon;

    [NativeTypeName("DWORD")]
    public uint dwAttributes;

    [NativeTypeName("CHAR[260]")]
    public _szDisplayName_e__FixedBuffer szDisplayName;

    [NativeTypeName("CHAR[80]")]
    public _szTypeName_e__FixedBuffer szTypeName;

    [InlineArray(260)]
    public partial struct _szDisplayName_e__FixedBuffer
    {
        public sbyte e0;
    }

    [InlineArray(80)]
    public partial struct _szTypeName_e__FixedBuffer
    {
        public sbyte e0;
    }
}
