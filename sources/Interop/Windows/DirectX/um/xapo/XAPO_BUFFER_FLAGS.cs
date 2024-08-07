// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xapo.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.DirectX;

/// <include file='XAPO_BUFFER_FLAGS.xml' path='doc/member[@name="XAPO_BUFFER_FLAGS"]/*' />
[Flags]
public enum XAPO_BUFFER_FLAGS
{
    /// <include file='XAPO_BUFFER_FLAGS.xml' path='doc/member[@name="XAPO_BUFFER_FLAGS.XAPO_BUFFER_SILENT"]/*' />
    XAPO_BUFFER_SILENT,

    /// <include file='XAPO_BUFFER_FLAGS.xml' path='doc/member[@name="XAPO_BUFFER_FLAGS.XAPO_BUFFER_VALID"]/*' />
    XAPO_BUFFER_VALID,
}
