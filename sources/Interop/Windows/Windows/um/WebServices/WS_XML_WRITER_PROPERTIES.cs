// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='WS_XML_WRITER_PROPERTIES.xml' path='doc/member[@name="WS_XML_WRITER_PROPERTIES"]/*' />
public unsafe partial struct WS_XML_WRITER_PROPERTIES
{
    /// <include file='WS_XML_WRITER_PROPERTIES.xml' path='doc/member[@name="WS_XML_WRITER_PROPERTIES.properties"]/*' />
    public WS_XML_WRITER_PROPERTY* properties;

    /// <include file='WS_XML_WRITER_PROPERTIES.xml' path='doc/member[@name="WS_XML_WRITER_PROPERTIES.propertyCount"]/*' />
    [NativeTypeName("ULONG")]
    public uint propertyCount;
}
