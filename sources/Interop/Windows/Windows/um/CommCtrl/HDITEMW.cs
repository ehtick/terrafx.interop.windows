// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct HDITEMW
    {
        public uint mask;

        public int cxy;

        [NativeTypeName("LPWSTR")]
        public ushort* pszText;

        public HBITMAP hbm;

        public int cchTextMax;

        public int fmt;

        public LPARAM lParam;

        public int iImage;

        public int iOrder;

        public uint type;

        public void* pvFilter;

        public uint state;
    }
}