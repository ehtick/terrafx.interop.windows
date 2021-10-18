// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnetwk.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct NETRESOURCEW
    {
        [NativeTypeName("DWORD")]
        public uint dwScope;

        [NativeTypeName("DWORD")]
        public uint dwType;

        [NativeTypeName("DWORD")]
        public uint dwDisplayType;

        [NativeTypeName("DWORD")]
        public uint dwUsage;

        [NativeTypeName("LPWSTR")]
        public ushort* lpLocalName;

        [NativeTypeName("LPWSTR")]
        public ushort* lpRemoteName;

        [NativeTypeName("LPWSTR")]
        public ushort* lpComment;

        [NativeTypeName("LPWSTR")]
        public ushort* lpProvider;
    }
}
