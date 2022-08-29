// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsiQuery.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='MSITRANSFORM_VALIDATE.xml' path='doc/member[@name="MSITRANSFORM_VALIDATE"]/*' />
public enum MSITRANSFORM_VALIDATE
{
    /// <include file='MSITRANSFORM_VALIDATE.xml' path='doc/member[@name="MSITRANSFORM_VALIDATE.MSITRANSFORM_VALIDATE_LANGUAGE"]/*' />
    MSITRANSFORM_VALIDATE_LANGUAGE = 0x00000001,

    /// <include file='MSITRANSFORM_VALIDATE.xml' path='doc/member[@name="MSITRANSFORM_VALIDATE.MSITRANSFORM_VALIDATE_PRODUCT"]/*' />
    MSITRANSFORM_VALIDATE_PRODUCT = 0x00000002,

    /// <include file='MSITRANSFORM_VALIDATE.xml' path='doc/member[@name="MSITRANSFORM_VALIDATE.MSITRANSFORM_VALIDATE_PLATFORM"]/*' />
    MSITRANSFORM_VALIDATE_PLATFORM = 0x00000004,

    /// <include file='MSITRANSFORM_VALIDATE.xml' path='doc/member[@name="MSITRANSFORM_VALIDATE.MSITRANSFORM_VALIDATE_MAJORVERSION"]/*' />
    MSITRANSFORM_VALIDATE_MAJORVERSION = 0x00000008,

    /// <include file='MSITRANSFORM_VALIDATE.xml' path='doc/member[@name="MSITRANSFORM_VALIDATE.MSITRANSFORM_VALIDATE_MINORVERSION"]/*' />
    MSITRANSFORM_VALIDATE_MINORVERSION = 0x00000010,

    /// <include file='MSITRANSFORM_VALIDATE.xml' path='doc/member[@name="MSITRANSFORM_VALIDATE.MSITRANSFORM_VALIDATE_UPDATEVERSION"]/*' />
    MSITRANSFORM_VALIDATE_UPDATEVERSION = 0x00000020,

    /// <include file='MSITRANSFORM_VALIDATE.xml' path='doc/member[@name="MSITRANSFORM_VALIDATE.MSITRANSFORM_VALIDATE_NEWLESSBASEVERSION"]/*' />
    MSITRANSFORM_VALIDATE_NEWLESSBASEVERSION = 0x00000040,

    /// <include file='MSITRANSFORM_VALIDATE.xml' path='doc/member[@name="MSITRANSFORM_VALIDATE.MSITRANSFORM_VALIDATE_NEWLESSEQUALBASEVERSION"]/*' />
    MSITRANSFORM_VALIDATE_NEWLESSEQUALBASEVERSION = 0x00000080,

    /// <include file='MSITRANSFORM_VALIDATE.xml' path='doc/member[@name="MSITRANSFORM_VALIDATE.MSITRANSFORM_VALIDATE_NEWEQUALBASEVERSION"]/*' />
    MSITRANSFORM_VALIDATE_NEWEQUALBASEVERSION = 0x00000100,

    /// <include file='MSITRANSFORM_VALIDATE.xml' path='doc/member[@name="MSITRANSFORM_VALIDATE.MSITRANSFORM_VALIDATE_NEWGREATEREQUALBASEVERSION"]/*' />
    MSITRANSFORM_VALIDATE_NEWGREATEREQUALBASEVERSION = 0x00000200,

    /// <include file='MSITRANSFORM_VALIDATE.xml' path='doc/member[@name="MSITRANSFORM_VALIDATE.MSITRANSFORM_VALIDATE_NEWGREATERBASEVERSION"]/*' />
    MSITRANSFORM_VALIDATE_NEWGREATERBASEVERSION = 0x00000400,

    /// <include file='MSITRANSFORM_VALIDATE.xml' path='doc/member[@name="MSITRANSFORM_VALIDATE.MSITRANSFORM_VALIDATE_UPGRADECODE"]/*' />
    MSITRANSFORM_VALIDATE_UPGRADECODE = 0x00000800,
}
