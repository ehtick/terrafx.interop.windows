// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9caps.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public static partial class D3DVTXPCAPS
{
    [NativeTypeName("#define D3DVTXPCAPS_TEXGEN 0x00000001L")]
    public const int D3DVTXPCAPS_TEXGEN = 0x00000001;

    [NativeTypeName("#define D3DVTXPCAPS_MATERIALSOURCE7 0x00000002L")]
    public const int D3DVTXPCAPS_MATERIALSOURCE7 = 0x00000002;

    [NativeTypeName("#define D3DVTXPCAPS_DIRECTIONALLIGHTS 0x00000008L")]
    public const int D3DVTXPCAPS_DIRECTIONALLIGHTS = 0x00000008;

    [NativeTypeName("#define D3DVTXPCAPS_POSITIONALLIGHTS 0x00000010L")]
    public const int D3DVTXPCAPS_POSITIONALLIGHTS = 0x00000010;

    [NativeTypeName("#define D3DVTXPCAPS_LOCALVIEWER 0x00000020L")]
    public const int D3DVTXPCAPS_LOCALVIEWER = 0x00000020;

    [NativeTypeName("#define D3DVTXPCAPS_TWEENING 0x00000040L")]
    public const int D3DVTXPCAPS_TWEENING = 0x00000040;

    [NativeTypeName("#define D3DVTXPCAPS_TEXGEN_SPHEREMAP 0x00000100L")]
    public const int D3DVTXPCAPS_TEXGEN_SPHEREMAP = 0x00000100;

    [NativeTypeName("#define D3DVTXPCAPS_NO_TEXGEN_NONLOCALVIEWER 0x00000200L")]
    public const int D3DVTXPCAPS_NO_TEXGEN_NONLOCALVIEWER = 0x00000200;
}
