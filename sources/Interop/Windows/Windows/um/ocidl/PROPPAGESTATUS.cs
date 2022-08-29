// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='PROPPAGESTATUS.xml' path='doc/member[@name="PROPPAGESTATUS"]/*' />
public enum PROPPAGESTATUS
{
    /// <include file='PROPPAGESTATUS.xml' path='doc/member[@name="PROPPAGESTATUS.PROPPAGESTATUS_DIRTY"]/*' />
    PROPPAGESTATUS_DIRTY = 0x1,

    /// <include file='PROPPAGESTATUS.xml' path='doc/member[@name="PROPPAGESTATUS.PROPPAGESTATUS_VALIDATE"]/*' />
    PROPPAGESTATUS_VALIDATE = 0x2,

    /// <include file='PROPPAGESTATUS.xml' path='doc/member[@name="PROPPAGESTATUS.PROPPAGESTATUS_CLEAN"]/*' />
    PROPPAGESTATUS_CLEAN = 0x4,
}
