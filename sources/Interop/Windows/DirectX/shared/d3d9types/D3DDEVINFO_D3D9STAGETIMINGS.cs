// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3DDEVINFO_D3D9STAGETIMINGS.xml' path='doc/member[@name="D3DDEVINFO_D3D9STAGETIMINGS"]/*' />
public partial struct D3DDEVINFO_D3D9STAGETIMINGS
{
    /// <include file='D3DDEVINFO_D3D9STAGETIMINGS.xml' path='doc/member[@name="D3DDEVINFO_D3D9STAGETIMINGS.MemoryProcessingPercent"]/*' />
    public float MemoryProcessingPercent;

    /// <include file='D3DDEVINFO_D3D9STAGETIMINGS.xml' path='doc/member[@name="D3DDEVINFO_D3D9STAGETIMINGS.ComputationProcessingPercent"]/*' />
    public float ComputationProcessingPercent;
}
