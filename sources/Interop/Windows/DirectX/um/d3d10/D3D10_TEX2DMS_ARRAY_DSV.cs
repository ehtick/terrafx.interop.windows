// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D10_TEX2DMS_ARRAY_DSV.xml' path='doc/member[@name="D3D10_TEX2DMS_ARRAY_DSV"]/*' />
public partial struct D3D10_TEX2DMS_ARRAY_DSV
{
    /// <include file='D3D10_TEX2DMS_ARRAY_DSV.xml' path='doc/member[@name="D3D10_TEX2DMS_ARRAY_DSV.FirstArraySlice"]/*' />
    public uint FirstArraySlice;

    /// <include file='D3D10_TEX2DMS_ARRAY_DSV.xml' path='doc/member[@name="D3D10_TEX2DMS_ARRAY_DSV.ArraySize"]/*' />
    public uint ArraySize;
}
