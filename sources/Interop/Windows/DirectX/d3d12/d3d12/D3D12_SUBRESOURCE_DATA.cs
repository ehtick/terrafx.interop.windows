// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.611.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_SUBRESOURCE_DATA.xml' path='doc/member[@name="D3D12_SUBRESOURCE_DATA"]/*' />
public unsafe partial struct D3D12_SUBRESOURCE_DATA
{
    /// <include file='D3D12_SUBRESOURCE_DATA.xml' path='doc/member[@name="D3D12_SUBRESOURCE_DATA.pData"]/*' />
    [NativeTypeName("const void *")]
    public void* pData;

    /// <include file='D3D12_SUBRESOURCE_DATA.xml' path='doc/member[@name="D3D12_SUBRESOURCE_DATA.RowPitch"]/*' />
    [NativeTypeName("LONG_PTR")]
    public nint RowPitch;

    /// <include file='D3D12_SUBRESOURCE_DATA.xml' path='doc/member[@name="D3D12_SUBRESOURCE_DATA.SlicePitch"]/*' />
    [NativeTypeName("LONG_PTR")]
    public nint SlicePitch;
}
