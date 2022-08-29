// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effects.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D2D1_BITMAPSOURCE_INTERPOLATION_MODE.xml' path='doc/member[@name="D2D1_BITMAPSOURCE_INTERPOLATION_MODE"]/*' />
public enum D2D1_BITMAPSOURCE_INTERPOLATION_MODE : uint
{
    /// <include file='D2D1_BITMAPSOURCE_INTERPOLATION_MODE.xml' path='doc/member[@name="D2D1_BITMAPSOURCE_INTERPOLATION_MODE.D2D1_BITMAPSOURCE_INTERPOLATION_MODE_NEAREST_NEIGHBOR"]/*' />
    D2D1_BITMAPSOURCE_INTERPOLATION_MODE_NEAREST_NEIGHBOR = 0,

    /// <include file='D2D1_BITMAPSOURCE_INTERPOLATION_MODE.xml' path='doc/member[@name="D2D1_BITMAPSOURCE_INTERPOLATION_MODE.D2D1_BITMAPSOURCE_INTERPOLATION_MODE_LINEAR"]/*' />
    D2D1_BITMAPSOURCE_INTERPOLATION_MODE_LINEAR = 1,

    /// <include file='D2D1_BITMAPSOURCE_INTERPOLATION_MODE.xml' path='doc/member[@name="D2D1_BITMAPSOURCE_INTERPOLATION_MODE.D2D1_BITMAPSOURCE_INTERPOLATION_MODE_CUBIC"]/*' />
    D2D1_BITMAPSOURCE_INTERPOLATION_MODE_CUBIC = 2,

    /// <include file='D2D1_BITMAPSOURCE_INTERPOLATION_MODE.xml' path='doc/member[@name="D2D1_BITMAPSOURCE_INTERPOLATION_MODE.D2D1_BITMAPSOURCE_INTERPOLATION_MODE_FANT"]/*' />
    D2D1_BITMAPSOURCE_INTERPOLATION_MODE_FANT = 6,

    /// <include file='D2D1_BITMAPSOURCE_INTERPOLATION_MODE.xml' path='doc/member[@name="D2D1_BITMAPSOURCE_INTERPOLATION_MODE.D2D1_BITMAPSOURCE_INTERPOLATION_MODE_MIPMAP_LINEAR"]/*' />
    D2D1_BITMAPSOURCE_INTERPOLATION_MODE_MIPMAP_LINEAR = 7,

    /// <include file='D2D1_BITMAPSOURCE_INTERPOLATION_MODE.xml' path='doc/member[@name="D2D1_BITMAPSOURCE_INTERPOLATION_MODE.D2D1_BITMAPSOURCE_INTERPOLATION_MODE_FORCE_DWORD"]/*' />
    D2D1_BITMAPSOURCE_INTERPOLATION_MODE_FORCE_DWORD = 0xffffffff,
}
