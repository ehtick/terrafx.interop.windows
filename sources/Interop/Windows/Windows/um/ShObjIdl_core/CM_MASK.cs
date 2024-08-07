// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows;

/// <include file='CM_MASK.xml' path='doc/member[@name="CM_MASK"]/*' />
[Flags]
public enum CM_MASK
{
    /// <include file='CM_MASK.xml' path='doc/member[@name="CM_MASK.CM_MASK_WIDTH"]/*' />
    CM_MASK_WIDTH = 0x1,

    /// <include file='CM_MASK.xml' path='doc/member[@name="CM_MASK.CM_MASK_DEFAULTWIDTH"]/*' />
    CM_MASK_DEFAULTWIDTH = 0x2,

    /// <include file='CM_MASK.xml' path='doc/member[@name="CM_MASK.CM_MASK_IDEALWIDTH"]/*' />
    CM_MASK_IDEALWIDTH = 0x4,

    /// <include file='CM_MASK.xml' path='doc/member[@name="CM_MASK.CM_MASK_NAME"]/*' />
    CM_MASK_NAME = 0x8,

    /// <include file='CM_MASK.xml' path='doc/member[@name="CM_MASK.CM_MASK_STATE"]/*' />
    CM_MASK_STATE = 0x10,
}
