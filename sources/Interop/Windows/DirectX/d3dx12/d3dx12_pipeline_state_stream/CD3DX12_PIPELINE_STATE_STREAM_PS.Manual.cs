// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dx12_pipeline_state_stream.h in microsoft/DirectX-Headers tag v1.611.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

using static TerraFX.Interop.DirectX.D3D12_PIPELINE_STATE_SUBOBJECT_TYPE;

namespace TerraFX.Interop.DirectX;

public struct CD3DX12_PIPELINE_STATE_STREAM_PS
{
    public D3D12_PIPELINE_STATE_SUBOBJECT_TYPE pssType;

    public D3D12_SHADER_BYTECODE pssInner;

    public CD3DX12_PIPELINE_STATE_STREAM_PS()
    {
        pssType = D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_PS;
        pssInner = default;
    }

    public CD3DX12_PIPELINE_STATE_STREAM_PS([NativeTypeName("D3D12_SHADER_BYTECODE const &")] in D3D12_SHADER_BYTECODE i)
    {
        pssType = D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_PS;
        pssInner = i;
    }

    public static implicit operator CD3DX12_PIPELINE_STATE_STREAM_PS(in D3D12_SHADER_BYTECODE value) => new CD3DX12_PIPELINE_STATE_STREAM_PS(value);

    public static implicit operator D3D12_SHADER_BYTECODE(in CD3DX12_PIPELINE_STATE_STREAM_PS value) => value.pssInner;
}
