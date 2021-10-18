// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HDITEMW
    {
        [NativeTypeName("UINT")]
        public uint mask;

        public int cxy;

        [NativeTypeName("LPWSTR")]
        public ushort* pszText;

        [NativeTypeName("HBITMAP")]
        public IntPtr hbm;

        public int cchTextMax;

        public int fmt;

        [NativeTypeName("LPARAM")]
        public nint lParam;

        public int iImage;

        public int iOrder;

        [NativeTypeName("UINT")]
        public uint type;

        public void* pvFilter;

        [NativeTypeName("UINT")]
        public uint state;
    }
}