// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imm.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct IMEMENUITEMINFOW
    {
        public uint cbSize;

        public uint fType;

        public uint fState;

        public uint wID;

        public HBITMAP hbmpChecked;

        public HBITMAP hbmpUnchecked;

        [NativeTypeName("DWORD")]
        public uint dwItemData;

        [NativeTypeName("WCHAR [80]")]
        public fixed ushort szString[80];

        public HBITMAP hbmpItem;
    }
}