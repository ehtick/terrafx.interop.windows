// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/hidpi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct HIDP_CAPS
    {
        [NativeTypeName("USAGE")]
        public ushort Usage;

        [NativeTypeName("USAGE")]
        public ushort UsagePage;

        public ushort InputReportByteLength;

        public ushort OutputReportByteLength;

        public ushort FeatureReportByteLength;

        [NativeTypeName("USHORT [17]")]
        public fixed ushort Reserved[17];

        public ushort NumberLinkCollectionNodes;

        public ushort NumberInputButtonCaps;

        public ushort NumberInputValueCaps;

        public ushort NumberInputDataIndices;

        public ushort NumberOutputButtonCaps;

        public ushort NumberOutputValueCaps;

        public ushort NumberOutputDataIndices;

        public ushort NumberFeatureButtonCaps;

        public ushort NumberFeatureValueCaps;

        public ushort NumberFeatureDataIndices;
    }
}