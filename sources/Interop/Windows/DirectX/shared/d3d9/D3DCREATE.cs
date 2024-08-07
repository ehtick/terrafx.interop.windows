// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public static partial class D3DCREATE
{
    [NativeTypeName("#define D3DCREATE_FPU_PRESERVE 0x00000002L")]
    public const int D3DCREATE_FPU_PRESERVE = 0x00000002;

    [NativeTypeName("#define D3DCREATE_MULTITHREADED 0x00000004L")]
    public const int D3DCREATE_MULTITHREADED = 0x00000004;

    [NativeTypeName("#define D3DCREATE_PUREDEVICE 0x00000010L")]
    public const int D3DCREATE_PUREDEVICE = 0x00000010;

    [NativeTypeName("#define D3DCREATE_SOFTWARE_VERTEXPROCESSING 0x00000020L")]
    public const int D3DCREATE_SOFTWARE_VERTEXPROCESSING = 0x00000020;

    [NativeTypeName("#define D3DCREATE_HARDWARE_VERTEXPROCESSING 0x00000040L")]
    public const int D3DCREATE_HARDWARE_VERTEXPROCESSING = 0x00000040;

    [NativeTypeName("#define D3DCREATE_MIXED_VERTEXPROCESSING 0x00000080L")]
    public const int D3DCREATE_MIXED_VERTEXPROCESSING = 0x00000080;

    [NativeTypeName("#define D3DCREATE_DISABLE_DRIVER_MANAGEMENT 0x00000100L")]
    public const int D3DCREATE_DISABLE_DRIVER_MANAGEMENT = 0x00000100;

    [NativeTypeName("#define D3DCREATE_ADAPTERGROUP_DEVICE 0x00000200L")]
    public const int D3DCREATE_ADAPTERGROUP_DEVICE = 0x00000200;

    [NativeTypeName("#define D3DCREATE_DISABLE_DRIVER_MANAGEMENT_EX 0x00000400L")]
    public const int D3DCREATE_DISABLE_DRIVER_MANAGEMENT_EX = 0x00000400;

    [NativeTypeName("#define D3DCREATE_NOWINDOWCHANGES 0x00000800L")]
    public const int D3DCREATE_NOWINDOWCHANGES = 0x00000800;

    [NativeTypeName("#define D3DCREATE_DISABLE_PSGP_THREADING 0x00002000L")]
    public const int D3DCREATE_DISABLE_PSGP_THREADING = 0x00002000;

    [NativeTypeName("#define D3DCREATE_ENABLE_PRESENTSTATS 0x00004000L")]
    public const int D3DCREATE_ENABLE_PRESENTSTATS = 0x00004000;

    [NativeTypeName("#define D3DCREATE_DISABLE_PRINTSCREEN 0x00008000L")]
    public const int D3DCREATE_DISABLE_PRINTSCREEN = 0x00008000;

    [NativeTypeName("#define D3DCREATE_SCREENSAVER 0x10000000L")]
    public const int D3DCREATE_SCREENSAVER = 0x10000000;
}
