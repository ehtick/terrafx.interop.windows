// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1helper.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.DirectX.DirectX;

namespace TerraFX.Interop.DirectX;

public partial struct D2D1_GRADIENT_STOP
{
    public D2D1_GRADIENT_STOP(float position, [NativeTypeName("const D2D1_COLOR_F &")] in DXGI_RGBA color)
    {
        this = GradientStop(position, color);
    }
}
