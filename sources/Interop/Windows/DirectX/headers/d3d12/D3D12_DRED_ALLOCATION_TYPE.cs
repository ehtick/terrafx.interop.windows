// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_DRED_ALLOCATION_TYPE.xml' path='doc/member[@name="D3D12_DRED_ALLOCATION_TYPE"]/*' />
public enum D3D12_DRED_ALLOCATION_TYPE
{
    /// <include file='D3D12_DRED_ALLOCATION_TYPE.xml' path='doc/member[@name="D3D12_DRED_ALLOCATION_TYPE.D3D12_DRED_ALLOCATION_TYPE_COMMAND_QUEUE"]/*' />
    D3D12_DRED_ALLOCATION_TYPE_COMMAND_QUEUE = 19,

    /// <include file='D3D12_DRED_ALLOCATION_TYPE.xml' path='doc/member[@name="D3D12_DRED_ALLOCATION_TYPE.D3D12_DRED_ALLOCATION_TYPE_COMMAND_ALLOCATOR"]/*' />
    D3D12_DRED_ALLOCATION_TYPE_COMMAND_ALLOCATOR = 20,

    /// <include file='D3D12_DRED_ALLOCATION_TYPE.xml' path='doc/member[@name="D3D12_DRED_ALLOCATION_TYPE.D3D12_DRED_ALLOCATION_TYPE_PIPELINE_STATE"]/*' />
    D3D12_DRED_ALLOCATION_TYPE_PIPELINE_STATE = 21,

    /// <include file='D3D12_DRED_ALLOCATION_TYPE.xml' path='doc/member[@name="D3D12_DRED_ALLOCATION_TYPE.D3D12_DRED_ALLOCATION_TYPE_COMMAND_LIST"]/*' />
    D3D12_DRED_ALLOCATION_TYPE_COMMAND_LIST = 22,

    /// <include file='D3D12_DRED_ALLOCATION_TYPE.xml' path='doc/member[@name="D3D12_DRED_ALLOCATION_TYPE.D3D12_DRED_ALLOCATION_TYPE_FENCE"]/*' />
    D3D12_DRED_ALLOCATION_TYPE_FENCE = 23,

    /// <include file='D3D12_DRED_ALLOCATION_TYPE.xml' path='doc/member[@name="D3D12_DRED_ALLOCATION_TYPE.D3D12_DRED_ALLOCATION_TYPE_DESCRIPTOR_HEAP"]/*' />
    D3D12_DRED_ALLOCATION_TYPE_DESCRIPTOR_HEAP = 24,

    /// <include file='D3D12_DRED_ALLOCATION_TYPE.xml' path='doc/member[@name="D3D12_DRED_ALLOCATION_TYPE.D3D12_DRED_ALLOCATION_TYPE_HEAP"]/*' />
    D3D12_DRED_ALLOCATION_TYPE_HEAP = 25,

    /// <include file='D3D12_DRED_ALLOCATION_TYPE.xml' path='doc/member[@name="D3D12_DRED_ALLOCATION_TYPE.D3D12_DRED_ALLOCATION_TYPE_QUERY_HEAP"]/*' />
    D3D12_DRED_ALLOCATION_TYPE_QUERY_HEAP = 27,

    /// <include file='D3D12_DRED_ALLOCATION_TYPE.xml' path='doc/member[@name="D3D12_DRED_ALLOCATION_TYPE.D3D12_DRED_ALLOCATION_TYPE_COMMAND_SIGNATURE"]/*' />
    D3D12_DRED_ALLOCATION_TYPE_COMMAND_SIGNATURE = 28,

    /// <include file='D3D12_DRED_ALLOCATION_TYPE.xml' path='doc/member[@name="D3D12_DRED_ALLOCATION_TYPE.D3D12_DRED_ALLOCATION_TYPE_PIPELINE_LIBRARY"]/*' />
    D3D12_DRED_ALLOCATION_TYPE_PIPELINE_LIBRARY = 29,

    /// <include file='D3D12_DRED_ALLOCATION_TYPE.xml' path='doc/member[@name="D3D12_DRED_ALLOCATION_TYPE.D3D12_DRED_ALLOCATION_TYPE_VIDEO_DECODER"]/*' />
    D3D12_DRED_ALLOCATION_TYPE_VIDEO_DECODER = 30,

    /// <include file='D3D12_DRED_ALLOCATION_TYPE.xml' path='doc/member[@name="D3D12_DRED_ALLOCATION_TYPE.D3D12_DRED_ALLOCATION_TYPE_VIDEO_PROCESSOR"]/*' />
    D3D12_DRED_ALLOCATION_TYPE_VIDEO_PROCESSOR = 32,

    /// <include file='D3D12_DRED_ALLOCATION_TYPE.xml' path='doc/member[@name="D3D12_DRED_ALLOCATION_TYPE.D3D12_DRED_ALLOCATION_TYPE_RESOURCE"]/*' />
    D3D12_DRED_ALLOCATION_TYPE_RESOURCE = 34,

    /// <include file='D3D12_DRED_ALLOCATION_TYPE.xml' path='doc/member[@name="D3D12_DRED_ALLOCATION_TYPE.D3D12_DRED_ALLOCATION_TYPE_PASS"]/*' />
    D3D12_DRED_ALLOCATION_TYPE_PASS = 35,

    /// <include file='D3D12_DRED_ALLOCATION_TYPE.xml' path='doc/member[@name="D3D12_DRED_ALLOCATION_TYPE.D3D12_DRED_ALLOCATION_TYPE_CRYPTOSESSION"]/*' />
    D3D12_DRED_ALLOCATION_TYPE_CRYPTOSESSION = 36,

    /// <include file='D3D12_DRED_ALLOCATION_TYPE.xml' path='doc/member[@name="D3D12_DRED_ALLOCATION_TYPE.D3D12_DRED_ALLOCATION_TYPE_CRYPTOSESSIONPOLICY"]/*' />
    D3D12_DRED_ALLOCATION_TYPE_CRYPTOSESSIONPOLICY = 37,

    /// <include file='D3D12_DRED_ALLOCATION_TYPE.xml' path='doc/member[@name="D3D12_DRED_ALLOCATION_TYPE.D3D12_DRED_ALLOCATION_TYPE_PROTECTEDRESOURCESESSION"]/*' />
    D3D12_DRED_ALLOCATION_TYPE_PROTECTEDRESOURCESESSION = 38,

    /// <include file='D3D12_DRED_ALLOCATION_TYPE.xml' path='doc/member[@name="D3D12_DRED_ALLOCATION_TYPE.D3D12_DRED_ALLOCATION_TYPE_VIDEO_DECODER_HEAP"]/*' />
    D3D12_DRED_ALLOCATION_TYPE_VIDEO_DECODER_HEAP = 39,

    /// <include file='D3D12_DRED_ALLOCATION_TYPE.xml' path='doc/member[@name="D3D12_DRED_ALLOCATION_TYPE.D3D12_DRED_ALLOCATION_TYPE_COMMAND_POOL"]/*' />
    D3D12_DRED_ALLOCATION_TYPE_COMMAND_POOL = 40,

    /// <include file='D3D12_DRED_ALLOCATION_TYPE.xml' path='doc/member[@name="D3D12_DRED_ALLOCATION_TYPE.D3D12_DRED_ALLOCATION_TYPE_COMMAND_RECORDER"]/*' />
    D3D12_DRED_ALLOCATION_TYPE_COMMAND_RECORDER = 41,

    /// <include file='D3D12_DRED_ALLOCATION_TYPE.xml' path='doc/member[@name="D3D12_DRED_ALLOCATION_TYPE.D3D12_DRED_ALLOCATION_TYPE_STATE_OBJECT"]/*' />
    D3D12_DRED_ALLOCATION_TYPE_STATE_OBJECT = 42,

    /// <include file='D3D12_DRED_ALLOCATION_TYPE.xml' path='doc/member[@name="D3D12_DRED_ALLOCATION_TYPE.D3D12_DRED_ALLOCATION_TYPE_METACOMMAND"]/*' />
    D3D12_DRED_ALLOCATION_TYPE_METACOMMAND = 43,

    /// <include file='D3D12_DRED_ALLOCATION_TYPE.xml' path='doc/member[@name="D3D12_DRED_ALLOCATION_TYPE.D3D12_DRED_ALLOCATION_TYPE_SCHEDULINGGROUP"]/*' />
    D3D12_DRED_ALLOCATION_TYPE_SCHEDULINGGROUP = 44,

    /// <include file='D3D12_DRED_ALLOCATION_TYPE.xml' path='doc/member[@name="D3D12_DRED_ALLOCATION_TYPE.D3D12_DRED_ALLOCATION_TYPE_VIDEO_MOTION_ESTIMATOR"]/*' />
    D3D12_DRED_ALLOCATION_TYPE_VIDEO_MOTION_ESTIMATOR = 45,

    /// <include file='D3D12_DRED_ALLOCATION_TYPE.xml' path='doc/member[@name="D3D12_DRED_ALLOCATION_TYPE.D3D12_DRED_ALLOCATION_TYPE_VIDEO_MOTION_VECTOR_HEAP"]/*' />
    D3D12_DRED_ALLOCATION_TYPE_VIDEO_MOTION_VECTOR_HEAP = 46,

    /// <include file='D3D12_DRED_ALLOCATION_TYPE.xml' path='doc/member[@name="D3D12_DRED_ALLOCATION_TYPE.D3D12_DRED_ALLOCATION_TYPE_VIDEO_EXTENSION_COMMAND"]/*' />
    D3D12_DRED_ALLOCATION_TYPE_VIDEO_EXTENSION_COMMAND = 47,

    /// <include file='D3D12_DRED_ALLOCATION_TYPE.xml' path='doc/member[@name="D3D12_DRED_ALLOCATION_TYPE.D3D12_DRED_ALLOCATION_TYPE_VIDEO_ENCODER"]/*' />
    D3D12_DRED_ALLOCATION_TYPE_VIDEO_ENCODER = 48,

    /// <include file='D3D12_DRED_ALLOCATION_TYPE.xml' path='doc/member[@name="D3D12_DRED_ALLOCATION_TYPE.D3D12_DRED_ALLOCATION_TYPE_VIDEO_ENCODER_HEAP"]/*' />
    D3D12_DRED_ALLOCATION_TYPE_VIDEO_ENCODER_HEAP = 49,

    /// <include file='D3D12_DRED_ALLOCATION_TYPE.xml' path='doc/member[@name="D3D12_DRED_ALLOCATION_TYPE.D3D12_DRED_ALLOCATION_TYPE_INVALID"]/*' />
    D3D12_DRED_ALLOCATION_TYPE_INVALID = unchecked((int)(0xffffffff)),
}
