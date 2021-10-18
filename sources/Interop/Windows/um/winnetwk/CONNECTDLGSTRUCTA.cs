// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnetwk.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct CONNECTDLGSTRUCTA
    {
        [NativeTypeName("DWORD")]
        public uint cbStructure;

        [NativeTypeName("HWND")]
        public IntPtr hwndOwner;

        [NativeTypeName("LPNETRESOURCEA")]
        public NETRESOURCEA* lpConnRes;

        [NativeTypeName("DWORD")]
        public uint dwFlags;

        [NativeTypeName("DWORD")]
        public uint dwDevNum;
    }
}