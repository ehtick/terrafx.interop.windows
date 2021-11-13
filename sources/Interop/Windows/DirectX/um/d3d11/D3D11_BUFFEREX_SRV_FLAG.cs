// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.DirectX
{
    [Flags]
    public enum D3D11_BUFFEREX_SRV_FLAG
    {
        D3D11_BUFFEREX_SRV_FLAG_RAW = 0x1,
    }
}