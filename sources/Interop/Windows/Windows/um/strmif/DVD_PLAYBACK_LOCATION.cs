// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public partial struct DVD_PLAYBACK_LOCATION
    {
        [NativeTypeName("ULONG")]
        public uint TitleNum;

        [NativeTypeName("ULONG")]
        public uint ChapterNum;

        [NativeTypeName("ULONG")]
        public uint TimeCode;
    }
}