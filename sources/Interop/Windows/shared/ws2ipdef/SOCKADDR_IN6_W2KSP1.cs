// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ws2ipdef.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct SOCKADDR_IN6_W2KSP1
    {
        public short sin6_family;

        [NativeTypeName("USHORT")]
        public ushort sin6_port;

        [NativeTypeName("ULONG")]
        public uint sin6_flowinfo;

        [NativeTypeName("struct in6_addr")]
        public IN6_ADDR sin6_addr;

        [NativeTypeName("ULONG")]
        public uint sin6_scope_id;
    }
}