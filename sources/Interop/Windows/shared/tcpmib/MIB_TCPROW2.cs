// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/tcpmib.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct MIB_TCPROW2
    {
        [NativeTypeName("DWORD")]
        public uint dwState;

        [NativeTypeName("DWORD")]
        public uint dwLocalAddr;

        [NativeTypeName("DWORD")]
        public uint dwLocalPort;

        [NativeTypeName("DWORD")]
        public uint dwRemoteAddr;

        [NativeTypeName("DWORD")]
        public uint dwRemotePort;

        [NativeTypeName("DWORD")]
        public uint dwOwningPid;

        public TCP_CONNECTION_OFFLOAD_STATE dwOffloadState;
    }
}
