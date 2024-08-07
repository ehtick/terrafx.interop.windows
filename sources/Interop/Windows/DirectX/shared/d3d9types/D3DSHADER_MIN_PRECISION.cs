// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3DSHADER_MIN_PRECISION.xml' path='doc/member[@name="D3DSHADER_MIN_PRECISION"]/*' />
public enum D3DSHADER_MIN_PRECISION
{
    /// <include file='D3DSHADER_MIN_PRECISION.xml' path='doc/member[@name="D3DSHADER_MIN_PRECISION.D3DMP_DEFAULT"]/*' />
    D3DMP_DEFAULT = 0,

    /// <include file='D3DSHADER_MIN_PRECISION.xml' path='doc/member[@name="D3DSHADER_MIN_PRECISION.D3DMP_16"]/*' />
    D3DMP_16 = 1,

    /// <include file='D3DSHADER_MIN_PRECISION.xml' path='doc/member[@name="D3DSHADER_MIN_PRECISION.D3DMP_2_8"]/*' />
    D3DMP_2_8 = 2,
}
