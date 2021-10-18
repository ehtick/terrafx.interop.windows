// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct WINHTTP_CERTIFICATE_INFO
    {
        public FILETIME ftExpiry;

        public FILETIME ftStart;

        [NativeTypeName("LPWSTR")]
        public ushort* lpszSubjectInfo;

        [NativeTypeName("LPWSTR")]
        public ushort* lpszIssuerInfo;

        [NativeTypeName("LPWSTR")]
        public ushort* lpszProtocolName;

        [NativeTypeName("LPWSTR")]
        public ushort* lpszSignatureAlgName;

        [NativeTypeName("LPWSTR")]
        public ushort* lpszEncryptionAlgName;

        [NativeTypeName("DWORD")]
        public uint dwKeySize;
    }
}