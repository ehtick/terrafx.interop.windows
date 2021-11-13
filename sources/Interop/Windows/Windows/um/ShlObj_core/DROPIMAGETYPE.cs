// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public enum DROPIMAGETYPE
    {
        DROPIMAGE_INVALID = -1,
        DROPIMAGE_NONE = 0,
        DROPIMAGE_COPY = (1),
        DROPIMAGE_MOVE = (2),
        DROPIMAGE_LINK = (4),
        DROPIMAGE_LABEL = 6,
        DROPIMAGE_WARNING = 7,
        DROPIMAGE_NOIMAGE = 8,
    }
}