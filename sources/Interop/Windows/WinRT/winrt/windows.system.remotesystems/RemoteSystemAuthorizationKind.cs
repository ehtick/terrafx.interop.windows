// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.remotesystems.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='RemoteSystemAuthorizationKind.xml' path='doc/member[@name="RemoteSystemAuthorizationKind"]/*' />
public enum RemoteSystemAuthorizationKind
{
    /// <include file='RemoteSystemAuthorizationKind.xml' path='doc/member[@name="RemoteSystemAuthorizationKind.RemoteSystemAuthorizationKind_SameUser"]/*' />
    RemoteSystemAuthorizationKind_SameUser = 0,

    /// <include file='RemoteSystemAuthorizationKind.xml' path='doc/member[@name="RemoteSystemAuthorizationKind.RemoteSystemAuthorizationKind_Anonymous"]/*' />
    RemoteSystemAuthorizationKind_Anonymous = 1,
}
