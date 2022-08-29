// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DocObj.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows;

/// <include file='OLECMDID_BROWSERSTATEFLAG.xml' path='doc/member[@name="OLECMDID_BROWSERSTATEFLAG"]/*' />
[Flags]
public enum OLECMDID_BROWSERSTATEFLAG
{
    /// <include file='OLECMDID_BROWSERSTATEFLAG.xml' path='doc/member[@name="OLECMDID_BROWSERSTATEFLAG.OLECMDIDF_BROWSERSTATE_EXTENSIONSOFF"]/*' />
    OLECMDIDF_BROWSERSTATE_EXTENSIONSOFF = 0x00000001,

    /// <include file='OLECMDID_BROWSERSTATEFLAG.xml' path='doc/member[@name="OLECMDID_BROWSERSTATEFLAG.OLECMDIDF_BROWSERSTATE_IESECURITY"]/*' />
    OLECMDIDF_BROWSERSTATE_IESECURITY = 0x00000002,

    /// <include file='OLECMDID_BROWSERSTATEFLAG.xml' path='doc/member[@name="OLECMDID_BROWSERSTATEFLAG.OLECMDIDF_BROWSERSTATE_PROTECTEDMODE_OFF"]/*' />
    OLECMDIDF_BROWSERSTATE_PROTECTEDMODE_OFF = 0x00000004,

    /// <include file='OLECMDID_BROWSERSTATEFLAG.xml' path='doc/member[@name="OLECMDID_BROWSERSTATEFLAG.OLECMDIDF_BROWSERSTATE_RESET"]/*' />
    OLECMDIDF_BROWSERSTATE_RESET = 0x00000008,

    /// <include file='OLECMDID_BROWSERSTATEFLAG.xml' path='doc/member[@name="OLECMDID_BROWSERSTATEFLAG.OLECMDIDF_BROWSERSTATE_REQUIRESACTIVEX"]/*' />
    OLECMDIDF_BROWSERSTATE_REQUIRESACTIVEX = 0x00000010,

    /// <include file='OLECMDID_BROWSERSTATEFLAG.xml' path='doc/member[@name="OLECMDID_BROWSERSTATEFLAG.OLECMDIDF_BROWSERSTATE_DESKTOPHTMLDIALOG"]/*' />
    OLECMDIDF_BROWSERSTATE_DESKTOPHTMLDIALOG = 0x00000020,

    /// <include file='OLECMDID_BROWSERSTATEFLAG.xml' path='doc/member[@name="OLECMDID_BROWSERSTATEFLAG.OLECMDIDF_BROWSERSTATE_BLOCKEDVERSION"]/*' />
    OLECMDIDF_BROWSERSTATE_BLOCKEDVERSION = 0x00000040,
}
