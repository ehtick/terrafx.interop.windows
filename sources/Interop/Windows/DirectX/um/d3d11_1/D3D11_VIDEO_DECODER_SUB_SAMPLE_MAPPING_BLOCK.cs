// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11_1.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D11_VIDEO_DECODER_SUB_SAMPLE_MAPPING_BLOCK.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_SUB_SAMPLE_MAPPING_BLOCK"]/*' />
public partial struct D3D11_VIDEO_DECODER_SUB_SAMPLE_MAPPING_BLOCK
{
    /// <include file='D3D11_VIDEO_DECODER_SUB_SAMPLE_MAPPING_BLOCK.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_SUB_SAMPLE_MAPPING_BLOCK.ClearSize"]/*' />
    public uint ClearSize;

    /// <include file='D3D11_VIDEO_DECODER_SUB_SAMPLE_MAPPING_BLOCK.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_SUB_SAMPLE_MAPPING_BLOCK.EncryptedSize"]/*' />
    public uint EncryptedSize;
}
