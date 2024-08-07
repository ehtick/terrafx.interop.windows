// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MAP.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MAP"]/*' />
public unsafe partial struct D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MAP
{
    /// <include file='D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MAP.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MAP.SegmentsMapByteSize"]/*' />
    public uint SegmentsMapByteSize;

    /// <include file='D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MAP.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MAP.pSegmentsMap"]/*' />
    [NativeTypeName("UINT8 *")]
    public byte* pSegmentsMap;
}
