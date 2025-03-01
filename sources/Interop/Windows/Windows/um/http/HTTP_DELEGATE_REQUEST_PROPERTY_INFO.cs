// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='HTTP_DELEGATE_REQUEST_PROPERTY_INFO.xml' path='doc/member[@name="HTTP_DELEGATE_REQUEST_PROPERTY_INFO"]/*' />
public unsafe partial struct HTTP_DELEGATE_REQUEST_PROPERTY_INFO
{
    /// <include file='HTTP_DELEGATE_REQUEST_PROPERTY_INFO.xml' path='doc/member[@name="HTTP_DELEGATE_REQUEST_PROPERTY_INFO.PropertyId"]/*' />
    public HTTP_DELEGATE_REQUEST_PROPERTY_ID PropertyId;

    /// <include file='HTTP_DELEGATE_REQUEST_PROPERTY_INFO.xml' path='doc/member[@name="HTTP_DELEGATE_REQUEST_PROPERTY_INFO.PropertyInfoLength"]/*' />
    [NativeTypeName("ULONG")]
    public uint PropertyInfoLength;

    /// <include file='HTTP_DELEGATE_REQUEST_PROPERTY_INFO.xml' path='doc/member[@name="HTTP_DELEGATE_REQUEST_PROPERTY_INFO.PropertyInfo"]/*' />
    [NativeTypeName("PVOID")]
    public void* PropertyInfo;
}
