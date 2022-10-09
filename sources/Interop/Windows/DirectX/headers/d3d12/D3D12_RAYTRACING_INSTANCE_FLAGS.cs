// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_RAYTRACING_INSTANCE_FLAGS.xml' path='doc/member[@name="D3D12_RAYTRACING_INSTANCE_FLAGS"]/*' />
[Flags]
public enum D3D12_RAYTRACING_INSTANCE_FLAGS
{
    /// <include file='D3D12_RAYTRACING_INSTANCE_FLAGS.xml' path='doc/member[@name="D3D12_RAYTRACING_INSTANCE_FLAGS.D3D12_RAYTRACING_INSTANCE_FLAG_NONE"]/*' />
    D3D12_RAYTRACING_INSTANCE_FLAG_NONE = 0,

    /// <include file='D3D12_RAYTRACING_INSTANCE_FLAGS.xml' path='doc/member[@name="D3D12_RAYTRACING_INSTANCE_FLAGS.D3D12_RAYTRACING_INSTANCE_FLAG_TRIANGLE_CULL_DISABLE"]/*' />
    D3D12_RAYTRACING_INSTANCE_FLAG_TRIANGLE_CULL_DISABLE = 0x1,

    /// <include file='D3D12_RAYTRACING_INSTANCE_FLAGS.xml' path='doc/member[@name="D3D12_RAYTRACING_INSTANCE_FLAGS.D3D12_RAYTRACING_INSTANCE_FLAG_TRIANGLE_FRONT_COUNTERCLOCKWISE"]/*' />
    D3D12_RAYTRACING_INSTANCE_FLAG_TRIANGLE_FRONT_COUNTERCLOCKWISE = 0x2,

    /// <include file='D3D12_RAYTRACING_INSTANCE_FLAGS.xml' path='doc/member[@name="D3D12_RAYTRACING_INSTANCE_FLAGS.D3D12_RAYTRACING_INSTANCE_FLAG_FORCE_OPAQUE"]/*' />
    D3D12_RAYTRACING_INSTANCE_FLAG_FORCE_OPAQUE = 0x4,

    /// <include file='D3D12_RAYTRACING_INSTANCE_FLAGS.xml' path='doc/member[@name="D3D12_RAYTRACING_INSTANCE_FLAGS.D3D12_RAYTRACING_INSTANCE_FLAG_FORCE_NON_OPAQUE"]/*' />
    D3D12_RAYTRACING_INSTANCE_FLAG_FORCE_NON_OPAQUE = 0x8,
}
