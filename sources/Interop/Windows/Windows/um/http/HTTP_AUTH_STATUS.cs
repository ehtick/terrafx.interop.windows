// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='HTTP_AUTH_STATUS.xml' path='doc/member[@name="HTTP_AUTH_STATUS"]/*' />
public enum HTTP_AUTH_STATUS
{
    /// <include file='HTTP_AUTH_STATUS.xml' path='doc/member[@name="HTTP_AUTH_STATUS.HttpAuthStatusSuccess"]/*' />
    HttpAuthStatusSuccess,

    /// <include file='HTTP_AUTH_STATUS.xml' path='doc/member[@name="HTTP_AUTH_STATUS.HttpAuthStatusNotAuthenticated"]/*' />
    HttpAuthStatusNotAuthenticated,

    /// <include file='HTTP_AUTH_STATUS.xml' path='doc/member[@name="HTTP_AUTH_STATUS.HttpAuthStatusFailure"]/*' />
    HttpAuthStatusFailure,
}