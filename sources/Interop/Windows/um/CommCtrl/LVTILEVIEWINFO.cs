// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct LVTILEVIEWINFO
    {
        [NativeTypeName("UINT")]
        public uint cbSize;

        [NativeTypeName("DWORD")]
        public uint dwMask;

        [NativeTypeName("DWORD")]
        public uint dwFlags;

        public SIZE sizeTile;

        public int cLines;

        public RECT rcLabelMargin;
    }
}