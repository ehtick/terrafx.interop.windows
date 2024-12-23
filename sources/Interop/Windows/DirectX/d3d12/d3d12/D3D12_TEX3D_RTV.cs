// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_TEX3D_RTV.xml' path='doc/member[@name="D3D12_TEX3D_RTV"]/*' />
public partial struct D3D12_TEX3D_RTV
{
    /// <include file='D3D12_TEX3D_RTV.xml' path='doc/member[@name="D3D12_TEX3D_RTV.MipSlice"]/*' />
    public uint MipSlice;

    /// <include file='D3D12_TEX3D_RTV.xml' path='doc/member[@name="D3D12_TEX3D_RTV.FirstWSlice"]/*' />
    public uint FirstWSlice;

    /// <include file='D3D12_TEX3D_RTV.xml' path='doc/member[@name="D3D12_TEX3D_RTV.WSize"]/*' />
    public uint WSize;
}