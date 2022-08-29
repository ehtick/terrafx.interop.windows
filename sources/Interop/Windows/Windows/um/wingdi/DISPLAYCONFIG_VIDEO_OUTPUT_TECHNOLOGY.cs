// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='DISPLAYCONFIG_VIDEO_OUTPUT_TECHNOLOGY.xml' path='doc/member[@name="DISPLAYCONFIG_VIDEO_OUTPUT_TECHNOLOGY"]/*' />
public enum DISPLAYCONFIG_VIDEO_OUTPUT_TECHNOLOGY
{
    /// <include file='DISPLAYCONFIG_VIDEO_OUTPUT_TECHNOLOGY.xml' path='doc/member[@name="DISPLAYCONFIG_VIDEO_OUTPUT_TECHNOLOGY.DISPLAYCONFIG_OUTPUT_TECHNOLOGY_OTHER"]/*' />
    DISPLAYCONFIG_OUTPUT_TECHNOLOGY_OTHER = -1,

    /// <include file='DISPLAYCONFIG_VIDEO_OUTPUT_TECHNOLOGY.xml' path='doc/member[@name="DISPLAYCONFIG_VIDEO_OUTPUT_TECHNOLOGY.DISPLAYCONFIG_OUTPUT_TECHNOLOGY_HD15"]/*' />
    DISPLAYCONFIG_OUTPUT_TECHNOLOGY_HD15 = 0,

    /// <include file='DISPLAYCONFIG_VIDEO_OUTPUT_TECHNOLOGY.xml' path='doc/member[@name="DISPLAYCONFIG_VIDEO_OUTPUT_TECHNOLOGY.DISPLAYCONFIG_OUTPUT_TECHNOLOGY_SVIDEO"]/*' />
    DISPLAYCONFIG_OUTPUT_TECHNOLOGY_SVIDEO = 1,

    /// <include file='DISPLAYCONFIG_VIDEO_OUTPUT_TECHNOLOGY.xml' path='doc/member[@name="DISPLAYCONFIG_VIDEO_OUTPUT_TECHNOLOGY.DISPLAYCONFIG_OUTPUT_TECHNOLOGY_COMPOSITE_VIDEO"]/*' />
    DISPLAYCONFIG_OUTPUT_TECHNOLOGY_COMPOSITE_VIDEO = 2,

    /// <include file='DISPLAYCONFIG_VIDEO_OUTPUT_TECHNOLOGY.xml' path='doc/member[@name="DISPLAYCONFIG_VIDEO_OUTPUT_TECHNOLOGY.DISPLAYCONFIG_OUTPUT_TECHNOLOGY_COMPONENT_VIDEO"]/*' />
    DISPLAYCONFIG_OUTPUT_TECHNOLOGY_COMPONENT_VIDEO = 3,

    /// <include file='DISPLAYCONFIG_VIDEO_OUTPUT_TECHNOLOGY.xml' path='doc/member[@name="DISPLAYCONFIG_VIDEO_OUTPUT_TECHNOLOGY.DISPLAYCONFIG_OUTPUT_TECHNOLOGY_DVI"]/*' />
    DISPLAYCONFIG_OUTPUT_TECHNOLOGY_DVI = 4,

    /// <include file='DISPLAYCONFIG_VIDEO_OUTPUT_TECHNOLOGY.xml' path='doc/member[@name="DISPLAYCONFIG_VIDEO_OUTPUT_TECHNOLOGY.DISPLAYCONFIG_OUTPUT_TECHNOLOGY_HDMI"]/*' />
    DISPLAYCONFIG_OUTPUT_TECHNOLOGY_HDMI = 5,

    /// <include file='DISPLAYCONFIG_VIDEO_OUTPUT_TECHNOLOGY.xml' path='doc/member[@name="DISPLAYCONFIG_VIDEO_OUTPUT_TECHNOLOGY.DISPLAYCONFIG_OUTPUT_TECHNOLOGY_LVDS"]/*' />
    DISPLAYCONFIG_OUTPUT_TECHNOLOGY_LVDS = 6,

    /// <include file='DISPLAYCONFIG_VIDEO_OUTPUT_TECHNOLOGY.xml' path='doc/member[@name="DISPLAYCONFIG_VIDEO_OUTPUT_TECHNOLOGY.DISPLAYCONFIG_OUTPUT_TECHNOLOGY_D_JPN"]/*' />
    DISPLAYCONFIG_OUTPUT_TECHNOLOGY_D_JPN = 8,

    /// <include file='DISPLAYCONFIG_VIDEO_OUTPUT_TECHNOLOGY.xml' path='doc/member[@name="DISPLAYCONFIG_VIDEO_OUTPUT_TECHNOLOGY.DISPLAYCONFIG_OUTPUT_TECHNOLOGY_SDI"]/*' />
    DISPLAYCONFIG_OUTPUT_TECHNOLOGY_SDI = 9,

    /// <include file='DISPLAYCONFIG_VIDEO_OUTPUT_TECHNOLOGY.xml' path='doc/member[@name="DISPLAYCONFIG_VIDEO_OUTPUT_TECHNOLOGY.DISPLAYCONFIG_OUTPUT_TECHNOLOGY_DISPLAYPORT_EXTERNAL"]/*' />
    DISPLAYCONFIG_OUTPUT_TECHNOLOGY_DISPLAYPORT_EXTERNAL = 10,

    /// <include file='DISPLAYCONFIG_VIDEO_OUTPUT_TECHNOLOGY.xml' path='doc/member[@name="DISPLAYCONFIG_VIDEO_OUTPUT_TECHNOLOGY.DISPLAYCONFIG_OUTPUT_TECHNOLOGY_DISPLAYPORT_EMBEDDED"]/*' />
    DISPLAYCONFIG_OUTPUT_TECHNOLOGY_DISPLAYPORT_EMBEDDED = 11,

    /// <include file='DISPLAYCONFIG_VIDEO_OUTPUT_TECHNOLOGY.xml' path='doc/member[@name="DISPLAYCONFIG_VIDEO_OUTPUT_TECHNOLOGY.DISPLAYCONFIG_OUTPUT_TECHNOLOGY_UDI_EXTERNAL"]/*' />
    DISPLAYCONFIG_OUTPUT_TECHNOLOGY_UDI_EXTERNAL = 12,

    /// <include file='DISPLAYCONFIG_VIDEO_OUTPUT_TECHNOLOGY.xml' path='doc/member[@name="DISPLAYCONFIG_VIDEO_OUTPUT_TECHNOLOGY.DISPLAYCONFIG_OUTPUT_TECHNOLOGY_UDI_EMBEDDED"]/*' />
    DISPLAYCONFIG_OUTPUT_TECHNOLOGY_UDI_EMBEDDED = 13,

    /// <include file='DISPLAYCONFIG_VIDEO_OUTPUT_TECHNOLOGY.xml' path='doc/member[@name="DISPLAYCONFIG_VIDEO_OUTPUT_TECHNOLOGY.DISPLAYCONFIG_OUTPUT_TECHNOLOGY_SDTVDONGLE"]/*' />
    DISPLAYCONFIG_OUTPUT_TECHNOLOGY_SDTVDONGLE = 14,

    /// <include file='DISPLAYCONFIG_VIDEO_OUTPUT_TECHNOLOGY.xml' path='doc/member[@name="DISPLAYCONFIG_VIDEO_OUTPUT_TECHNOLOGY.DISPLAYCONFIG_OUTPUT_TECHNOLOGY_MIRACAST"]/*' />
    DISPLAYCONFIG_OUTPUT_TECHNOLOGY_MIRACAST = 15,

    /// <include file='DISPLAYCONFIG_VIDEO_OUTPUT_TECHNOLOGY.xml' path='doc/member[@name="DISPLAYCONFIG_VIDEO_OUTPUT_TECHNOLOGY.DISPLAYCONFIG_OUTPUT_TECHNOLOGY_INDIRECT_WIRED"]/*' />
    DISPLAYCONFIG_OUTPUT_TECHNOLOGY_INDIRECT_WIRED = 16,

    /// <include file='DISPLAYCONFIG_VIDEO_OUTPUT_TECHNOLOGY.xml' path='doc/member[@name="DISPLAYCONFIG_VIDEO_OUTPUT_TECHNOLOGY.DISPLAYCONFIG_OUTPUT_TECHNOLOGY_INDIRECT_VIRTUAL"]/*' />
    DISPLAYCONFIG_OUTPUT_TECHNOLOGY_INDIRECT_VIRTUAL = 17,

    /// <include file='DISPLAYCONFIG_VIDEO_OUTPUT_TECHNOLOGY.xml' path='doc/member[@name="DISPLAYCONFIG_VIDEO_OUTPUT_TECHNOLOGY.DISPLAYCONFIG_OUTPUT_TECHNOLOGY_DISPLAYPORT_USB_TUNNEL"]/*' />
    DISPLAYCONFIG_OUTPUT_TECHNOLOGY_DISPLAYPORT_USB_TUNNEL = 18,

    /// <include file='DISPLAYCONFIG_VIDEO_OUTPUT_TECHNOLOGY.xml' path='doc/member[@name="DISPLAYCONFIG_VIDEO_OUTPUT_TECHNOLOGY.DISPLAYCONFIG_OUTPUT_TECHNOLOGY_INTERNAL"]/*' />
    DISPLAYCONFIG_OUTPUT_TECHNOLOGY_INTERNAL = unchecked((int)(0x80000000)),

    /// <include file='DISPLAYCONFIG_VIDEO_OUTPUT_TECHNOLOGY.xml' path='doc/member[@name="DISPLAYCONFIG_VIDEO_OUTPUT_TECHNOLOGY.DISPLAYCONFIG_OUTPUT_TECHNOLOGY_FORCE_UINT32"]/*' />
    DISPLAYCONFIG_OUTPUT_TECHNOLOGY_FORCE_UINT32 = unchecked((int)(0xFFFFFFFF)),
}
