// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public unsafe partial struct CABINET_INFO64_W
{
    [NativeTypeName("PCWSTR")]
    public char* CabinetPath;

    [NativeTypeName("PCWSTR")]
    public char* CabinetFile;

    [NativeTypeName("PCWSTR")]
    public char* DiskName;

    [NativeTypeName("USHORT")]
    public ushort SetId;

    [NativeTypeName("USHORT")]
    public ushort CabinetNumber;
}
