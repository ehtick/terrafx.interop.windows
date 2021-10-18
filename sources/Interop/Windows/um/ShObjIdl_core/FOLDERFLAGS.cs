// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    [Flags]
    public enum FOLDERFLAGS
    {
        FWF_NONE = 0,
        FWF_AUTOARRANGE = 0x1,
        FWF_ABBREVIATEDNAMES = 0x2,
        FWF_SNAPTOGRID = 0x4,
        FWF_OWNERDATA = 0x8,
        FWF_BESTFITWINDOW = 0x10,
        FWF_DESKTOP = 0x20,
        FWF_SINGLESEL = 0x40,
        FWF_NOSUBFOLDERS = 0x80,
        FWF_TRANSPARENT = 0x100,
        FWF_NOCLIENTEDGE = 0x200,
        FWF_NOSCROLL = 0x400,
        FWF_ALIGNLEFT = 0x800,
        FWF_NOICONS = 0x1000,
        FWF_SHOWSELALWAYS = 0x2000,
        FWF_NOVISIBLE = 0x4000,
        FWF_SINGLECLICKACTIVATE = 0x8000,
        FWF_NOWEBVIEW = 0x10000,
        FWF_HIDEFILENAMES = 0x20000,
        FWF_CHECKSELECT = 0x40000,
        FWF_NOENUMREFRESH = 0x80000,
        FWF_NOGROUPING = 0x100000,
        FWF_FULLROWSELECT = 0x200000,
        FWF_NOFILTERS = 0x400000,
        FWF_NOCOLUMNHEADER = 0x800000,
        FWF_NOHEADERINALLVIEWS = 0x1000000,
        FWF_EXTENDEDTILES = 0x2000000,
        FWF_TRICHECKSELECT = 0x4000000,
        FWF_AUTOCHECKSELECT = 0x8000000,
        FWF_NOBROWSERVIEWSTATE = 0x10000000,
        FWF_SUBSETGROUPS = 0x20000000,
        FWF_USESEARCHFOLDER = 0x40000000,
        FWF_ALLOWRTLREADING = unchecked((int)(0x80000000)),
    }
}