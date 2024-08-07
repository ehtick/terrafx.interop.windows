// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

public static partial class D3D
{
    [NativeTypeName("#define D3D_SDK_VERSION 32")]
    public const int D3D_SDK_VERSION = 32;

    [NativeTypeName("#define D3D_OK S_OK")]
    public const int D3D_OK = ((int)(0));
}
