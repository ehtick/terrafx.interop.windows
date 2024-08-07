// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='PREVIEWHANDLERFRAMEINFO.xml' path='doc/member[@name="PREVIEWHANDLERFRAMEINFO"]/*' />
public partial struct PREVIEWHANDLERFRAMEINFO
{
    /// <include file='PREVIEWHANDLERFRAMEINFO.xml' path='doc/member[@name="PREVIEWHANDLERFRAMEINFO.haccel"]/*' />
    public HACCEL haccel;

    /// <include file='PREVIEWHANDLERFRAMEINFO.xml' path='doc/member[@name="PREVIEWHANDLERFRAMEINFO.cAccelEntries"]/*' />
    public uint cAccelEntries;
}
