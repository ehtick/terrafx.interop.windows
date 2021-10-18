// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct WINHTTP_PROXY_RESULT_ENTRY
    {
        [NativeTypeName("BOOL")]
        public int fProxy;

        [NativeTypeName("BOOL")]
        public int fBypass;

        [NativeTypeName("INTERNET_SCHEME")]
        public int ProxyScheme;

        [NativeTypeName("PWSTR")]
        public ushort* pwszProxy;

        [NativeTypeName("INTERNET_PORT")]
        public ushort ProxyPort;
    }
}