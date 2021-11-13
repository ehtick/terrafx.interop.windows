// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dvdmedia.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public partial struct AM_PROPERTY_SPHLI
    {
        public ushort HLISS;

        public ushort Reserved;

        [NativeTypeName("ULONG")]
        public uint StartPTM;

        [NativeTypeName("ULONG")]
        public uint EndPTM;

        public ushort StartX;

        public ushort StartY;

        public ushort StopX;

        public ushort StopY;

        public AM_COLCON ColCon;
    }
}