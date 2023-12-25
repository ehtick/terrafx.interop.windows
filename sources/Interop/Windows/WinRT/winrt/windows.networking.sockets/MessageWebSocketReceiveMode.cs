// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.sockets.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='MessageWebSocketReceiveMode.xml' path='doc/member[@name="MessageWebSocketReceiveMode"]/*' />
public enum MessageWebSocketReceiveMode
{
    /// <include file='MessageWebSocketReceiveMode.xml' path='doc/member[@name="MessageWebSocketReceiveMode.MessageWebSocketReceiveMode_FullMessage"]/*' />
    MessageWebSocketReceiveMode_FullMessage = 0,

    /// <include file='MessageWebSocketReceiveMode.xml' path='doc/member[@name="MessageWebSocketReceiveMode.MessageWebSocketReceiveMode_PartialMessage"]/*' />
    MessageWebSocketReceiveMode_PartialMessage = 1,
}
