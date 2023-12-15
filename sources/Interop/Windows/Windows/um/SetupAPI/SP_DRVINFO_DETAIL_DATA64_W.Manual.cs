// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

public unsafe partial struct SP_DRVINFO_DETAIL_DATA64_W
{
    [NativeTypeName("DWORD")]
    public uint cbSize;

    public FILETIME InfDate;

    [NativeTypeName("DWORD")]
    public uint CompatIDsOffset;

    [NativeTypeName("DWORD")]
    public uint CompatIDsLength;

    [NativeTypeName("ULONG_PTR")]
    public nuint Reserved;

    [NativeTypeName("WCHAR[256]")]
    public _SectionName_e__FixedBuffer SectionName;

    [NativeTypeName("WCHAR[260]")]
    public _InfFileName_e__FixedBuffer InfFileName;

    [NativeTypeName("WCHAR[256]")]
    public _DrvDescription_e__FixedBuffer DrvDescription;

    [NativeTypeName("WCHAR[1]")]
    public _HardwareID_e__FixedBuffer HardwareID;

    [InlineArray(256)]
    public partial struct _SectionName_e__FixedBuffer
    {
        public char e0;
    }

    [InlineArray(260)]
    public partial struct _InfFileName_e__FixedBuffer
    {
        public char e0;
    }

    [InlineArray(256)]
    public partial struct _DrvDescription_e__FixedBuffer
    {
        public char e0;
    }

    public partial struct _HardwareID_e__FixedBuffer
    {
        public char e0;

        [UnscopedRef]
        public ref char this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Unsafe.Add(ref e0, index);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<char> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
