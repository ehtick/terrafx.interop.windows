// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/tcpmib.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct MIB_TCPSTATS_W2K
    {
        [NativeTypeName("DWORD")]
        public uint dwRtoAlgorithm;

        [NativeTypeName("DWORD")]
        public uint dwRtoMin;

        [NativeTypeName("DWORD")]
        public uint dwRtoMax;

        [NativeTypeName("DWORD")]
        public uint dwMaxConn;

        [NativeTypeName("DWORD")]
        public uint dwActiveOpens;

        [NativeTypeName("DWORD")]
        public uint dwPassiveOpens;

        [NativeTypeName("DWORD")]
        public uint dwAttemptFails;

        [NativeTypeName("DWORD")]
        public uint dwEstabResets;

        [NativeTypeName("DWORD")]
        public uint dwCurrEstab;

        [NativeTypeName("DWORD")]
        public uint dwInSegs;

        [NativeTypeName("DWORD")]
        public uint dwOutSegs;

        [NativeTypeName("DWORD")]
        public uint dwRetransSegs;

        [NativeTypeName("DWORD")]
        public uint dwInErrs;

        [NativeTypeName("DWORD")]
        public uint dwOutRsts;

        [NativeTypeName("DWORD")]
        public uint dwNumConns;
    }
}
