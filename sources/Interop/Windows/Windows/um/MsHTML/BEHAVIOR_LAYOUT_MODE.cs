// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public enum BEHAVIOR_LAYOUT_MODE
    {
        BEHAVIORLAYOUTMODE_NATURAL = 0x1,
        BEHAVIORLAYOUTMODE_MINWIDTH = 0x2,
        BEHAVIORLAYOUTMODE_MAXWIDTH = 0x4,
        BEHAVIORLAYOUTMODE_MEDIA_RESOLUTION = 0x4000,
        BEHAVIORLAYOUTMODE_FINAL_PERCENT = 0x8000,
        BEHAVIOR_LAYOUT_MODE_Max = 2147483647,
    }
}