// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dvdmedia.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public partial struct AM_DVD_YUV
    {
        [NativeTypeName("UCHAR")]
        public byte Reserved;

        [NativeTypeName("UCHAR")]
        public byte Y;

        [NativeTypeName("UCHAR")]
        public byte U;

        [NativeTypeName("UCHAR")]
        public byte V;
    }
}