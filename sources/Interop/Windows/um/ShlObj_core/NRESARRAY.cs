// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct NRESARRAY
    {
        [NativeTypeName("UINT")]
        public uint cItems;

        [NativeTypeName("NETRESOURCE [1]")]
        public _nr_e__FixedBuffer nr;

        public partial struct _nr_e__FixedBuffer
        {
            public NETRESOURCEW e0;

            public ref NETRESOURCEW this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan(int.MaxValue)[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<NETRESOURCEW> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }
}
