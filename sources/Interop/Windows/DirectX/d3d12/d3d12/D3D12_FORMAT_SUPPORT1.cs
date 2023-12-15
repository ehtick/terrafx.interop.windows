// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.611.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_FORMAT_SUPPORT1.xml' path='doc/member[@name="D3D12_FORMAT_SUPPORT1"]/*' />
[Flags]
public enum D3D12_FORMAT_SUPPORT1
{
    /// <include file='D3D12_FORMAT_SUPPORT1.xml' path='doc/member[@name="D3D12_FORMAT_SUPPORT1.D3D12_FORMAT_SUPPORT1_NONE"]/*' />
    D3D12_FORMAT_SUPPORT1_NONE = 0,

    /// <include file='D3D12_FORMAT_SUPPORT1.xml' path='doc/member[@name="D3D12_FORMAT_SUPPORT1.D3D12_FORMAT_SUPPORT1_BUFFER"]/*' />
    D3D12_FORMAT_SUPPORT1_BUFFER = 0x1,

    /// <include file='D3D12_FORMAT_SUPPORT1.xml' path='doc/member[@name="D3D12_FORMAT_SUPPORT1.D3D12_FORMAT_SUPPORT1_IA_VERTEX_BUFFER"]/*' />
    D3D12_FORMAT_SUPPORT1_IA_VERTEX_BUFFER = 0x2,

    /// <include file='D3D12_FORMAT_SUPPORT1.xml' path='doc/member[@name="D3D12_FORMAT_SUPPORT1.D3D12_FORMAT_SUPPORT1_IA_INDEX_BUFFER"]/*' />
    D3D12_FORMAT_SUPPORT1_IA_INDEX_BUFFER = 0x4,

    /// <include file='D3D12_FORMAT_SUPPORT1.xml' path='doc/member[@name="D3D12_FORMAT_SUPPORT1.D3D12_FORMAT_SUPPORT1_SO_BUFFER"]/*' />
    D3D12_FORMAT_SUPPORT1_SO_BUFFER = 0x8,

    /// <include file='D3D12_FORMAT_SUPPORT1.xml' path='doc/member[@name="D3D12_FORMAT_SUPPORT1.D3D12_FORMAT_SUPPORT1_TEXTURE1D"]/*' />
    D3D12_FORMAT_SUPPORT1_TEXTURE1D = 0x10,

    /// <include file='D3D12_FORMAT_SUPPORT1.xml' path='doc/member[@name="D3D12_FORMAT_SUPPORT1.D3D12_FORMAT_SUPPORT1_TEXTURE2D"]/*' />
    D3D12_FORMAT_SUPPORT1_TEXTURE2D = 0x20,

    /// <include file='D3D12_FORMAT_SUPPORT1.xml' path='doc/member[@name="D3D12_FORMAT_SUPPORT1.D3D12_FORMAT_SUPPORT1_TEXTURE3D"]/*' />
    D3D12_FORMAT_SUPPORT1_TEXTURE3D = 0x40,

    /// <include file='D3D12_FORMAT_SUPPORT1.xml' path='doc/member[@name="D3D12_FORMAT_SUPPORT1.D3D12_FORMAT_SUPPORT1_TEXTURECUBE"]/*' />
    D3D12_FORMAT_SUPPORT1_TEXTURECUBE = 0x80,

    /// <include file='D3D12_FORMAT_SUPPORT1.xml' path='doc/member[@name="D3D12_FORMAT_SUPPORT1.D3D12_FORMAT_SUPPORT1_SHADER_LOAD"]/*' />
    D3D12_FORMAT_SUPPORT1_SHADER_LOAD = 0x100,

    /// <include file='D3D12_FORMAT_SUPPORT1.xml' path='doc/member[@name="D3D12_FORMAT_SUPPORT1.D3D12_FORMAT_SUPPORT1_SHADER_SAMPLE"]/*' />
    D3D12_FORMAT_SUPPORT1_SHADER_SAMPLE = 0x200,

    /// <include file='D3D12_FORMAT_SUPPORT1.xml' path='doc/member[@name="D3D12_FORMAT_SUPPORT1.D3D12_FORMAT_SUPPORT1_SHADER_SAMPLE_COMPARISON"]/*' />
    D3D12_FORMAT_SUPPORT1_SHADER_SAMPLE_COMPARISON = 0x400,

    /// <include file='D3D12_FORMAT_SUPPORT1.xml' path='doc/member[@name="D3D12_FORMAT_SUPPORT1.D3D12_FORMAT_SUPPORT1_SHADER_SAMPLE_MONO_TEXT"]/*' />
    D3D12_FORMAT_SUPPORT1_SHADER_SAMPLE_MONO_TEXT = 0x800,

    /// <include file='D3D12_FORMAT_SUPPORT1.xml' path='doc/member[@name="D3D12_FORMAT_SUPPORT1.D3D12_FORMAT_SUPPORT1_MIP"]/*' />
    D3D12_FORMAT_SUPPORT1_MIP = 0x1000,

    /// <include file='D3D12_FORMAT_SUPPORT1.xml' path='doc/member[@name="D3D12_FORMAT_SUPPORT1.D3D12_FORMAT_SUPPORT1_RENDER_TARGET"]/*' />
    D3D12_FORMAT_SUPPORT1_RENDER_TARGET = 0x4000,

    /// <include file='D3D12_FORMAT_SUPPORT1.xml' path='doc/member[@name="D3D12_FORMAT_SUPPORT1.D3D12_FORMAT_SUPPORT1_BLENDABLE"]/*' />
    D3D12_FORMAT_SUPPORT1_BLENDABLE = 0x8000,

    /// <include file='D3D12_FORMAT_SUPPORT1.xml' path='doc/member[@name="D3D12_FORMAT_SUPPORT1.D3D12_FORMAT_SUPPORT1_DEPTH_STENCIL"]/*' />
    D3D12_FORMAT_SUPPORT1_DEPTH_STENCIL = 0x10000,

    /// <include file='D3D12_FORMAT_SUPPORT1.xml' path='doc/member[@name="D3D12_FORMAT_SUPPORT1.D3D12_FORMAT_SUPPORT1_MULTISAMPLE_RESOLVE"]/*' />
    D3D12_FORMAT_SUPPORT1_MULTISAMPLE_RESOLVE = 0x40000,

    /// <include file='D3D12_FORMAT_SUPPORT1.xml' path='doc/member[@name="D3D12_FORMAT_SUPPORT1.D3D12_FORMAT_SUPPORT1_DISPLAY"]/*' />
    D3D12_FORMAT_SUPPORT1_DISPLAY = 0x80000,

    /// <include file='D3D12_FORMAT_SUPPORT1.xml' path='doc/member[@name="D3D12_FORMAT_SUPPORT1.D3D12_FORMAT_SUPPORT1_CAST_WITHIN_BIT_LAYOUT"]/*' />
    D3D12_FORMAT_SUPPORT1_CAST_WITHIN_BIT_LAYOUT = 0x100000,

    /// <include file='D3D12_FORMAT_SUPPORT1.xml' path='doc/member[@name="D3D12_FORMAT_SUPPORT1.D3D12_FORMAT_SUPPORT1_MULTISAMPLE_RENDERTARGET"]/*' />
    D3D12_FORMAT_SUPPORT1_MULTISAMPLE_RENDERTARGET = 0x200000,

    /// <include file='D3D12_FORMAT_SUPPORT1.xml' path='doc/member[@name="D3D12_FORMAT_SUPPORT1.D3D12_FORMAT_SUPPORT1_MULTISAMPLE_LOAD"]/*' />
    D3D12_FORMAT_SUPPORT1_MULTISAMPLE_LOAD = 0x400000,

    /// <include file='D3D12_FORMAT_SUPPORT1.xml' path='doc/member[@name="D3D12_FORMAT_SUPPORT1.D3D12_FORMAT_SUPPORT1_SHADER_GATHER"]/*' />
    D3D12_FORMAT_SUPPORT1_SHADER_GATHER = 0x800000,

    /// <include file='D3D12_FORMAT_SUPPORT1.xml' path='doc/member[@name="D3D12_FORMAT_SUPPORT1.D3D12_FORMAT_SUPPORT1_BACK_BUFFER_CAST"]/*' />
    D3D12_FORMAT_SUPPORT1_BACK_BUFFER_CAST = 0x1000000,

    /// <include file='D3D12_FORMAT_SUPPORT1.xml' path='doc/member[@name="D3D12_FORMAT_SUPPORT1.D3D12_FORMAT_SUPPORT1_TYPED_UNORDERED_ACCESS_VIEW"]/*' />
    D3D12_FORMAT_SUPPORT1_TYPED_UNORDERED_ACCESS_VIEW = 0x2000000,

    /// <include file='D3D12_FORMAT_SUPPORT1.xml' path='doc/member[@name="D3D12_FORMAT_SUPPORT1.D3D12_FORMAT_SUPPORT1_SHADER_GATHER_COMPARISON"]/*' />
    D3D12_FORMAT_SUPPORT1_SHADER_GATHER_COMPARISON = 0x4000000,

    /// <include file='D3D12_FORMAT_SUPPORT1.xml' path='doc/member[@name="D3D12_FORMAT_SUPPORT1.D3D12_FORMAT_SUPPORT1_DECODER_OUTPUT"]/*' />
    D3D12_FORMAT_SUPPORT1_DECODER_OUTPUT = 0x8000000,

    /// <include file='D3D12_FORMAT_SUPPORT1.xml' path='doc/member[@name="D3D12_FORMAT_SUPPORT1.D3D12_FORMAT_SUPPORT1_VIDEO_PROCESSOR_OUTPUT"]/*' />
    D3D12_FORMAT_SUPPORT1_VIDEO_PROCESSOR_OUTPUT = 0x10000000,

    /// <include file='D3D12_FORMAT_SUPPORT1.xml' path='doc/member[@name="D3D12_FORMAT_SUPPORT1.D3D12_FORMAT_SUPPORT1_VIDEO_PROCESSOR_INPUT"]/*' />
    D3D12_FORMAT_SUPPORT1_VIDEO_PROCESSOR_INPUT = 0x20000000,

    /// <include file='D3D12_FORMAT_SUPPORT1.xml' path='doc/member[@name="D3D12_FORMAT_SUPPORT1.D3D12_FORMAT_SUPPORT1_VIDEO_ENCODER"]/*' />
    D3D12_FORMAT_SUPPORT1_VIDEO_ENCODER = 0x40000000,
}
