// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe partial struct SHFILEOPSTRUCTA
    {
        [NativeTypeName("HWND")]
        public IntPtr hwnd;

        [NativeTypeName("UINT")]
        public uint wFunc;

        [NativeTypeName("PCZZSTR")]
        public sbyte* pFrom;

        [NativeTypeName("PCZZSTR")]
        public sbyte* pTo;

        [NativeTypeName("FILEOP_FLAGS")]
        public ushort fFlags;

        [NativeTypeName("BOOL")]
        public int fAnyOperationsAborted;

        [NativeTypeName("LPVOID")]
        public void* hNameMappings;

        [NativeTypeName("PCSTR")]
        public sbyte* lpszProgressTitle;
    }
}