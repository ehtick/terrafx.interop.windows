// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows
{
    [Flags]
    public enum FOLDERVIEWOPTIONS
    {
        FVO_DEFAULT = 0,
        FVO_VISTALAYOUT = 0x1,
        FVO_CUSTOMPOSITION = 0x2,
        FVO_CUSTOMORDERING = 0x4,
        FVO_SUPPORTHYPERLINKS = 0x8,
        FVO_NOANIMATIONS = 0x10,
        FVO_NOSCROLLTIPS = 0x20,
    }
}