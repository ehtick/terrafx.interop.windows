// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10effect.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public static unsafe partial class DirectX
{
    public static int D3D10_BYTES_FROM_BITS(int x)
    {
        return (((x) + 7) / 8);
    }
}
