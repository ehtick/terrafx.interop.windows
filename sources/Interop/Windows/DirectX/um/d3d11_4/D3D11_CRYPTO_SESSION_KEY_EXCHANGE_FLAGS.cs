// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11_4.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D11_CRYPTO_SESSION_KEY_EXCHANGE_FLAGS.xml' path='doc/member[@name="D3D11_CRYPTO_SESSION_KEY_EXCHANGE_FLAGS"]/*' />
[Flags]
public enum D3D11_CRYPTO_SESSION_KEY_EXCHANGE_FLAGS
{
    /// <include file='D3D11_CRYPTO_SESSION_KEY_EXCHANGE_FLAGS.xml' path='doc/member[@name="D3D11_CRYPTO_SESSION_KEY_EXCHANGE_FLAGS.D3D11_CRYPTO_SESSION_KEY_EXCHANGE_FLAG_NONE"]/*' />
    D3D11_CRYPTO_SESSION_KEY_EXCHANGE_FLAG_NONE = 0,
}
