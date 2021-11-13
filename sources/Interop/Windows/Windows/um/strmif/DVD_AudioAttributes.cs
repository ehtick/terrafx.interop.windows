// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct DVD_AudioAttributes
    {
        public DVD_AUDIO_APPMODE AppMode;

        public byte AppModeData;

        public DVD_AUDIO_FORMAT AudioFormat;

        [NativeTypeName("LCID")]
        public uint Language;

        public DVD_AUDIO_LANG_EXT LanguageExtension;

        public BOOL fHasMultichannelInfo;

        [NativeTypeName("DWORD")]
        public uint dwFrequency;

        public byte bQuantization;

        public byte bNumberOfChannels;

        [NativeTypeName("DWORD [2]")]
        public fixed uint dwReserved[2];
    }
}