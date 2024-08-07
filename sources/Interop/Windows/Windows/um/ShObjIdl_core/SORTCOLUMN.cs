// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='SORTCOLUMN.xml' path='doc/member[@name="SORTCOLUMN"]/*' />
public partial struct SORTCOLUMN
{
    /// <include file='SORTCOLUMN.xml' path='doc/member[@name="SORTCOLUMN.propkey"]/*' />
    public PROPERTYKEY propkey;

    /// <include file='SORTCOLUMN.xml' path='doc/member[@name="SORTCOLUMN.direction"]/*' />
    [NativeTypeName("SORTDIRECTION")]
    public int direction;
}
