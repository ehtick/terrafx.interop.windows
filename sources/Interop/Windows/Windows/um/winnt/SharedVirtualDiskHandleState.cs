// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='SharedVirtualDiskHandleState.xml' path='doc/member[@name="SharedVirtualDiskHandleState"]/*' />
public enum SharedVirtualDiskHandleState
{
    /// <include file='SharedVirtualDiskHandleState.xml' path='doc/member[@name="SharedVirtualDiskHandleState.SharedVirtualDiskHandleStateNone"]/*' />
    SharedVirtualDiskHandleStateNone = 0,

    /// <include file='SharedVirtualDiskHandleState.xml' path='doc/member[@name="SharedVirtualDiskHandleState.SharedVirtualDiskHandleStateFileShared"]/*' />
    SharedVirtualDiskHandleStateFileShared = 1,

    /// <include file='SharedVirtualDiskHandleState.xml' path='doc/member[@name="SharedVirtualDiskHandleState.SharedVirtualDiskHandleStateHandleShared"]/*' />
    SharedVirtualDiskHandleStateHandleShared = 3,
}
