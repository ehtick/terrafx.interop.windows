// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/propsys.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='PSC_STATE.xml' path='doc/member[@name="PSC_STATE"]/*' />
public enum PSC_STATE
{
    /// <include file='PSC_STATE.xml' path='doc/member[@name="PSC_STATE.PSC_NORMAL"]/*' />
    PSC_NORMAL = 0,

    /// <include file='PSC_STATE.xml' path='doc/member[@name="PSC_STATE.PSC_NOTINSOURCE"]/*' />
    PSC_NOTINSOURCE = 1,

    /// <include file='PSC_STATE.xml' path='doc/member[@name="PSC_STATE.PSC_DIRTY"]/*' />
    PSC_DIRTY = 2,

    /// <include file='PSC_STATE.xml' path='doc/member[@name="PSC_STATE.PSC_READONLY"]/*' />
    PSC_READONLY = 3,
}
