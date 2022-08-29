// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D11_FEATURE_DATA_FORMAT_SUPPORT2.xml' path='doc/member[@name="D3D11_FEATURE_DATA_FORMAT_SUPPORT2"]/*' />
public partial struct D3D11_FEATURE_DATA_FORMAT_SUPPORT2
{
    /// <include file='D3D11_FEATURE_DATA_FORMAT_SUPPORT2.xml' path='doc/member[@name="D3D11_FEATURE_DATA_FORMAT_SUPPORT2.InFormat"]/*' />
    public DXGI_FORMAT InFormat;

    /// <include file='D3D11_FEATURE_DATA_FORMAT_SUPPORT2.xml' path='doc/member[@name="D3D11_FEATURE_DATA_FORMAT_SUPPORT2.OutFormatSupport2"]/*' />
    public uint OutFormatSupport2;
}
