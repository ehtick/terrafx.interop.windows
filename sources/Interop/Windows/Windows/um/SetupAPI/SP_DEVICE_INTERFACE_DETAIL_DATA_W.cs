// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='SP_DEVICE_INTERFACE_DETAIL_DATA_W.xml' path='doc/member[@name="SP_DEVICE_INTERFACE_DETAIL_DATA_W"]/*' />
public partial struct SP_DEVICE_INTERFACE_DETAIL_DATA_W
{
    /// <include file='SP_DEVICE_INTERFACE_DETAIL_DATA_W.xml' path='doc/member[@name="SP_DEVICE_INTERFACE_DETAIL_DATA_W.cbSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='SP_DEVICE_INTERFACE_DETAIL_DATA_W.xml' path='doc/member[@name="SP_DEVICE_INTERFACE_DETAIL_DATA_W.DevicePath"]/*' />
    [NativeTypeName("WCHAR[1]")]
    public _DevicePath_e__FixedBuffer DevicePath;

    /// <include file='_DevicePath_e__FixedBuffer.xml' path='doc/member[@name="_DevicePath_e__FixedBuffer"]/*' />
    public partial struct _DevicePath_e__FixedBuffer
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
