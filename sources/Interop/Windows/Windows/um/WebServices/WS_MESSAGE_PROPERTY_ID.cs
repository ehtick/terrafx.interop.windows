// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='WS_MESSAGE_PROPERTY_ID.xml' path='doc/member[@name="WS_MESSAGE_PROPERTY_ID"]/*' />
public enum WS_MESSAGE_PROPERTY_ID
{
    /// <include file='WS_MESSAGE_PROPERTY_ID.xml' path='doc/member[@name="WS_MESSAGE_PROPERTY_ID.WS_MESSAGE_PROPERTY_STATE"]/*' />
    WS_MESSAGE_PROPERTY_STATE = 0,

    /// <include file='WS_MESSAGE_PROPERTY_ID.xml' path='doc/member[@name="WS_MESSAGE_PROPERTY_ID.WS_MESSAGE_PROPERTY_HEAP"]/*' />
    WS_MESSAGE_PROPERTY_HEAP = 1,

    /// <include file='WS_MESSAGE_PROPERTY_ID.xml' path='doc/member[@name="WS_MESSAGE_PROPERTY_ID.WS_MESSAGE_PROPERTY_ENVELOPE_VERSION"]/*' />
    WS_MESSAGE_PROPERTY_ENVELOPE_VERSION = 2,

    /// <include file='WS_MESSAGE_PROPERTY_ID.xml' path='doc/member[@name="WS_MESSAGE_PROPERTY_ID.WS_MESSAGE_PROPERTY_ADDRESSING_VERSION"]/*' />
    WS_MESSAGE_PROPERTY_ADDRESSING_VERSION = 3,

    /// <include file='WS_MESSAGE_PROPERTY_ID.xml' path='doc/member[@name="WS_MESSAGE_PROPERTY_ID.WS_MESSAGE_PROPERTY_HEADER_BUFFER"]/*' />
    WS_MESSAGE_PROPERTY_HEADER_BUFFER = 4,

    /// <include file='WS_MESSAGE_PROPERTY_ID.xml' path='doc/member[@name="WS_MESSAGE_PROPERTY_ID.WS_MESSAGE_PROPERTY_HEADER_POSITION"]/*' />
    WS_MESSAGE_PROPERTY_HEADER_POSITION = 5,

    /// <include file='WS_MESSAGE_PROPERTY_ID.xml' path='doc/member[@name="WS_MESSAGE_PROPERTY_ID.WS_MESSAGE_PROPERTY_BODY_READER"]/*' />
    WS_MESSAGE_PROPERTY_BODY_READER = 6,

    /// <include file='WS_MESSAGE_PROPERTY_ID.xml' path='doc/member[@name="WS_MESSAGE_PROPERTY_ID.WS_MESSAGE_PROPERTY_BODY_WRITER"]/*' />
    WS_MESSAGE_PROPERTY_BODY_WRITER = 7,

    /// <include file='WS_MESSAGE_PROPERTY_ID.xml' path='doc/member[@name="WS_MESSAGE_PROPERTY_ID.WS_MESSAGE_PROPERTY_IS_ADDRESSED"]/*' />
    WS_MESSAGE_PROPERTY_IS_ADDRESSED = 8,

    /// <include file='WS_MESSAGE_PROPERTY_ID.xml' path='doc/member[@name="WS_MESSAGE_PROPERTY_ID.WS_MESSAGE_PROPERTY_HEAP_PROPERTIES"]/*' />
    WS_MESSAGE_PROPERTY_HEAP_PROPERTIES = 9,

    /// <include file='WS_MESSAGE_PROPERTY_ID.xml' path='doc/member[@name="WS_MESSAGE_PROPERTY_ID.WS_MESSAGE_PROPERTY_XML_READER_PROPERTIES"]/*' />
    WS_MESSAGE_PROPERTY_XML_READER_PROPERTIES = 10,

    /// <include file='WS_MESSAGE_PROPERTY_ID.xml' path='doc/member[@name="WS_MESSAGE_PROPERTY_ID.WS_MESSAGE_PROPERTY_XML_WRITER_PROPERTIES"]/*' />
    WS_MESSAGE_PROPERTY_XML_WRITER_PROPERTIES = 11,

    /// <include file='WS_MESSAGE_PROPERTY_ID.xml' path='doc/member[@name="WS_MESSAGE_PROPERTY_ID.WS_MESSAGE_PROPERTY_IS_FAULT"]/*' />
    WS_MESSAGE_PROPERTY_IS_FAULT = 12,

    /// <include file='WS_MESSAGE_PROPERTY_ID.xml' path='doc/member[@name="WS_MESSAGE_PROPERTY_ID.WS_MESSAGE_PROPERTY_MAX_PROCESSED_HEADERS"]/*' />
    WS_MESSAGE_PROPERTY_MAX_PROCESSED_HEADERS = 13,

    /// <include file='WS_MESSAGE_PROPERTY_ID.xml' path='doc/member[@name="WS_MESSAGE_PROPERTY_ID.WS_MESSAGE_PROPERTY_USERNAME"]/*' />
    WS_MESSAGE_PROPERTY_USERNAME = 14,

    /// <include file='WS_MESSAGE_PROPERTY_ID.xml' path='doc/member[@name="WS_MESSAGE_PROPERTY_ID.WS_MESSAGE_PROPERTY_ENCODED_CERT"]/*' />
    WS_MESSAGE_PROPERTY_ENCODED_CERT = 15,

    /// <include file='WS_MESSAGE_PROPERTY_ID.xml' path='doc/member[@name="WS_MESSAGE_PROPERTY_ID.WS_MESSAGE_PROPERTY_TRANSPORT_SECURITY_WINDOWS_TOKEN"]/*' />
    WS_MESSAGE_PROPERTY_TRANSPORT_SECURITY_WINDOWS_TOKEN = 16,

    /// <include file='WS_MESSAGE_PROPERTY_ID.xml' path='doc/member[@name="WS_MESSAGE_PROPERTY_ID.WS_MESSAGE_PROPERTY_HTTP_HEADER_AUTH_WINDOWS_TOKEN"]/*' />
    WS_MESSAGE_PROPERTY_HTTP_HEADER_AUTH_WINDOWS_TOKEN = 17,

    /// <include file='WS_MESSAGE_PROPERTY_ID.xml' path='doc/member[@name="WS_MESSAGE_PROPERTY_ID.WS_MESSAGE_PROPERTY_MESSAGE_SECURITY_WINDOWS_TOKEN"]/*' />
    WS_MESSAGE_PROPERTY_MESSAGE_SECURITY_WINDOWS_TOKEN = 18,

    /// <include file='WS_MESSAGE_PROPERTY_ID.xml' path='doc/member[@name="WS_MESSAGE_PROPERTY_ID.WS_MESSAGE_PROPERTY_SAML_ASSERTION"]/*' />
    WS_MESSAGE_PROPERTY_SAML_ASSERTION = 19,

    /// <include file='WS_MESSAGE_PROPERTY_ID.xml' path='doc/member[@name="WS_MESSAGE_PROPERTY_ID.WS_MESSAGE_PROPERTY_SECURITY_CONTEXT"]/*' />
    WS_MESSAGE_PROPERTY_SECURITY_CONTEXT = 20,

    /// <include file='WS_MESSAGE_PROPERTY_ID.xml' path='doc/member[@name="WS_MESSAGE_PROPERTY_ID.WS_MESSAGE_PROPERTY_PROTECTION_LEVEL"]/*' />
    WS_MESSAGE_PROPERTY_PROTECTION_LEVEL = 21,
}
