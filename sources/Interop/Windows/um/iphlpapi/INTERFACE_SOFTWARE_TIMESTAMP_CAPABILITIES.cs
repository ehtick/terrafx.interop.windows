// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/iphlpapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct INTERFACE_SOFTWARE_TIMESTAMP_CAPABILITIES
    {
        [NativeTypeName("BOOLEAN")]
        public byte AllReceive;

        [NativeTypeName("BOOLEAN")]
        public byte AllTransmit;

        [NativeTypeName("BOOLEAN")]
        public byte TaggedTransmit;
    }
}