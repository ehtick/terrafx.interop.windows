// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11_1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX;

public partial struct D3D11_RENDER_TARGET_BLEND_DESC1
{
    public static ref readonly D3D11_RENDER_TARGET_BLEND_DESC1 DEFAULT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00,
                0x02, 0x00, 0x00, 0x00,
                0x01, 0x00, 0x00, 0x00,
                0x01, 0x00, 0x00, 0x00,
                0x02, 0x00, 0x00, 0x00,
                0x01, 0x00, 0x00, 0x00,
                0x01, 0x00, 0x00, 0x00,
                0x04, 0x00, 0x00, 0x00,
                0x0F, 0x00, 0x00, 0x00
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<D3D11_RENDER_TARGET_BLEND_DESC1>());
            return ref Unsafe.As<byte, D3D11_RENDER_TARGET_BLEND_DESC1>(ref MemoryMarshal.GetReference(data));
        }
    }
}
