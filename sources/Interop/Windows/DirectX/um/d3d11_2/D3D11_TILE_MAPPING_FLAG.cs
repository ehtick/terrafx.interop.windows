// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11_2.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.Versioning;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D11_TILE_MAPPING_FLAG.xml' path='doc/member[@name="D3D11_TILE_MAPPING_FLAG"]/*' />
[Flags]
[SupportedOSPlatform("windows6.3")]
public enum D3D11_TILE_MAPPING_FLAG
{
    /// <include file='D3D11_TILE_MAPPING_FLAG.xml' path='doc/member[@name="D3D11_TILE_MAPPING_FLAG.D3D11_TILE_MAPPING_NO_OVERWRITE"]/*' />
    D3D11_TILE_MAPPING_NO_OVERWRITE = 0x1,
}
