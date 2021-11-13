// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public partial struct NMTREEVIEWA
    {
        public NMHDR hdr;

        public uint action;

        public TVITEMA itemOld;

        public TVITEMA itemNew;

        public POINT ptDrag;
    }
}