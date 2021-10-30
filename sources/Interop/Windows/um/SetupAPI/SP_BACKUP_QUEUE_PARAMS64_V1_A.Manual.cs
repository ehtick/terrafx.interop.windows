// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct SP_BACKUP_QUEUE_PARAMS64_V1_A
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("CHAR [260]")]
        public fixed sbyte FullInfPath[260];

        [NativeTypeName("INT")]
        public int FilenameOffset;
    }
}
