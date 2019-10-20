// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11shader.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct D3D11_LIBRARY_DESC
    {
        [NativeTypeName("LPCSTR")]
        public sbyte* Creator;

        [NativeTypeName("UINT")]
        public uint Flags;

        [NativeTypeName("UINT")]
        public uint FunctionCount;
    }
}