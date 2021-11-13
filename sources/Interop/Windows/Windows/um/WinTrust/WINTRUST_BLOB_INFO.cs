// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct WINTRUST_BLOB_INFO
    {
        [NativeTypeName("DWORD")]
        public uint cbStruct;

        public Guid gSubject;

        [NativeTypeName("LPCWSTR")]
        public ushort* pcwszDisplayName;

        [NativeTypeName("DWORD")]
        public uint cbMemObject;

        public byte* pbMemObject;

        [NativeTypeName("DWORD")]
        public uint cbMemSignedMsg;

        public byte* pbMemSignedMsg;
    }
}