// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in Microsoft.Direct3D.D3D12 v1.600.10
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;

/// <include file='ID3D12VideoDecodeCommandList2.xml' path='doc/member[@name="ID3D12VideoDecodeCommandList2"]/*' />
[Guid("6E120880-C114-4153-8036-D247051E1729")]
[NativeTypeName("struct ID3D12VideoDecodeCommandList2 : ID3D12VideoDecodeCommandList1")]
[NativeInheritance("ID3D12VideoDecodeCommandList1")]
[SupportedOSPlatform("windows10.0.19041.0")]
public unsafe partial struct ID3D12VideoDecodeCommandList2 : ID3D12VideoDecodeCommandList2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12VideoDecodeCommandList2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12VideoDecodeCommandList2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, uint>)(lpVtbl[1]))((ID3D12VideoDecodeCommandList2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, uint>)(lpVtbl[2]))((ID3D12VideoDecodeCommandList2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ID3D12Object.GetPrivateData" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint* pDataSize, void* pData)
    {
        return ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, Guid*, uint*, void*, int>)(lpVtbl[3]))((ID3D12VideoDecodeCommandList2*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
    }

    /// <inheritdoc cref="ID3D12Object.SetPrivateData" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint DataSize, [NativeTypeName("const void *")] void* pData)
    {
        return ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, Guid*, uint, void*, int>)(lpVtbl[4]))((ID3D12VideoDecodeCommandList2*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
    }

    /// <inheritdoc cref="ID3D12Object.SetPrivateDataInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
    {
        return ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, Guid*, IUnknown*, int>)(lpVtbl[5]))((ID3D12VideoDecodeCommandList2*)Unsafe.AsPointer(ref this), guid, pData);
    }

    /// <inheritdoc cref="ID3D12Object.SetName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetName([NativeTypeName("LPCWSTR")] ushort* Name)
    {
        return ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, ushort*, int>)(lpVtbl[6]))((ID3D12VideoDecodeCommandList2*)Unsafe.AsPointer(ref this), Name);
    }

    /// <inheritdoc cref="ID3D12DeviceChild.GetDevice" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDevice([NativeTypeName("const IID &")] Guid* riid, void** ppvDevice)
    {
        return ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, Guid*, void**, int>)(lpVtbl[7]))((ID3D12VideoDecodeCommandList2*)Unsafe.AsPointer(ref this), riid, ppvDevice);
    }

    /// <inheritdoc cref="ID3D12CommandList.GetType" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public new D3D12_COMMAND_LIST_TYPE GetType()
    {
        return ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, D3D12_COMMAND_LIST_TYPE>)(lpVtbl[8]))((ID3D12VideoDecodeCommandList2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ID3D12VideoDecodeCommandList.Close" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Close()
    {
        return ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, int>)(lpVtbl[9]))((ID3D12VideoDecodeCommandList2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ID3D12VideoDecodeCommandList.Reset" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Reset(ID3D12CommandAllocator* pAllocator)
    {
        return ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, ID3D12CommandAllocator*, int>)(lpVtbl[10]))((ID3D12VideoDecodeCommandList2*)Unsafe.AsPointer(ref this), pAllocator);
    }

    /// <inheritdoc cref="ID3D12VideoDecodeCommandList.ClearState" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public void ClearState()
    {
        ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, void>)(lpVtbl[11]))((ID3D12VideoDecodeCommandList2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ID3D12VideoDecodeCommandList.ResourceBarrier" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public void ResourceBarrier(uint NumBarriers, [NativeTypeName("const D3D12_RESOURCE_BARRIER *")] D3D12_RESOURCE_BARRIER* pBarriers)
    {
        ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, uint, D3D12_RESOURCE_BARRIER*, void>)(lpVtbl[12]))((ID3D12VideoDecodeCommandList2*)Unsafe.AsPointer(ref this), NumBarriers, pBarriers);
    }

    /// <inheritdoc cref="ID3D12VideoDecodeCommandList.DiscardResource" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public void DiscardResource(ID3D12Resource* pResource, [NativeTypeName("const D3D12_DISCARD_REGION *")] D3D12_DISCARD_REGION* pRegion)
    {
        ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, ID3D12Resource*, D3D12_DISCARD_REGION*, void>)(lpVtbl[13]))((ID3D12VideoDecodeCommandList2*)Unsafe.AsPointer(ref this), pResource, pRegion);
    }

    /// <inheritdoc cref="ID3D12VideoDecodeCommandList.BeginQuery" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public void BeginQuery(ID3D12QueryHeap* pQueryHeap, D3D12_QUERY_TYPE Type, uint Index)
    {
        ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, ID3D12QueryHeap*, D3D12_QUERY_TYPE, uint, void>)(lpVtbl[14]))((ID3D12VideoDecodeCommandList2*)Unsafe.AsPointer(ref this), pQueryHeap, Type, Index);
    }

    /// <inheritdoc cref="ID3D12VideoDecodeCommandList.EndQuery" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public void EndQuery(ID3D12QueryHeap* pQueryHeap, D3D12_QUERY_TYPE Type, uint Index)
    {
        ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, ID3D12QueryHeap*, D3D12_QUERY_TYPE, uint, void>)(lpVtbl[15]))((ID3D12VideoDecodeCommandList2*)Unsafe.AsPointer(ref this), pQueryHeap, Type, Index);
    }

    /// <inheritdoc cref="ID3D12VideoDecodeCommandList.ResolveQueryData" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public void ResolveQueryData(ID3D12QueryHeap* pQueryHeap, D3D12_QUERY_TYPE Type, uint StartIndex, uint NumQueries, ID3D12Resource* pDestinationBuffer, [NativeTypeName("UINT64")] ulong AlignedDestinationBufferOffset)
    {
        ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, ID3D12QueryHeap*, D3D12_QUERY_TYPE, uint, uint, ID3D12Resource*, ulong, void>)(lpVtbl[16]))((ID3D12VideoDecodeCommandList2*)Unsafe.AsPointer(ref this), pQueryHeap, Type, StartIndex, NumQueries, pDestinationBuffer, AlignedDestinationBufferOffset);
    }

    /// <inheritdoc cref="ID3D12VideoDecodeCommandList.SetPredication" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public void SetPredication(ID3D12Resource* pBuffer, [NativeTypeName("UINT64")] ulong AlignedBufferOffset, D3D12_PREDICATION_OP Operation)
    {
        ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, ID3D12Resource*, ulong, D3D12_PREDICATION_OP, void>)(lpVtbl[17]))((ID3D12VideoDecodeCommandList2*)Unsafe.AsPointer(ref this), pBuffer, AlignedBufferOffset, Operation);
    }

    /// <inheritdoc cref="ID3D12VideoDecodeCommandList.SetMarker" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public void SetMarker(uint Metadata, [NativeTypeName("const void *")] void* pData, uint Size)
    {
        ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, uint, void*, uint, void>)(lpVtbl[18]))((ID3D12VideoDecodeCommandList2*)Unsafe.AsPointer(ref this), Metadata, pData, Size);
    }

    /// <inheritdoc cref="ID3D12VideoDecodeCommandList.BeginEvent" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public void BeginEvent(uint Metadata, [NativeTypeName("const void *")] void* pData, uint Size)
    {
        ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, uint, void*, uint, void>)(lpVtbl[19]))((ID3D12VideoDecodeCommandList2*)Unsafe.AsPointer(ref this), Metadata, pData, Size);
    }

    /// <inheritdoc cref="ID3D12VideoDecodeCommandList.EndEvent" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public void EndEvent()
    {
        ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, void>)(lpVtbl[20]))((ID3D12VideoDecodeCommandList2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ID3D12VideoDecodeCommandList.DecodeFrame" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public void DecodeFrame(ID3D12VideoDecoder* pDecoder, [NativeTypeName("const D3D12_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS *")] D3D12_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS* pOutputArguments, [NativeTypeName("const D3D12_VIDEO_DECODE_INPUT_STREAM_ARGUMENTS *")] D3D12_VIDEO_DECODE_INPUT_STREAM_ARGUMENTS* pInputArguments)
    {
        ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, ID3D12VideoDecoder*, D3D12_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS*, D3D12_VIDEO_DECODE_INPUT_STREAM_ARGUMENTS*, void>)(lpVtbl[21]))((ID3D12VideoDecodeCommandList2*)Unsafe.AsPointer(ref this), pDecoder, pOutputArguments, pInputArguments);
    }

    /// <inheritdoc cref="ID3D12VideoDecodeCommandList.WriteBufferImmediate" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public void WriteBufferImmediate(uint Count, [NativeTypeName("const D3D12_WRITEBUFFERIMMEDIATE_PARAMETER *")] D3D12_WRITEBUFFERIMMEDIATE_PARAMETER* pParams, [NativeTypeName("const D3D12_WRITEBUFFERIMMEDIATE_MODE *")] D3D12_WRITEBUFFERIMMEDIATE_MODE* pModes)
    {
        ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, uint, D3D12_WRITEBUFFERIMMEDIATE_PARAMETER*, D3D12_WRITEBUFFERIMMEDIATE_MODE*, void>)(lpVtbl[22]))((ID3D12VideoDecodeCommandList2*)Unsafe.AsPointer(ref this), Count, pParams, pModes);
    }

    /// <inheritdoc cref="ID3D12VideoDecodeCommandList1.DecodeFrame1" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public void DecodeFrame1(ID3D12VideoDecoder* pDecoder, [NativeTypeName("const D3D12_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS1 *")] D3D12_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS1* pOutputArguments, [NativeTypeName("const D3D12_VIDEO_DECODE_INPUT_STREAM_ARGUMENTS *")] D3D12_VIDEO_DECODE_INPUT_STREAM_ARGUMENTS* pInputArguments)
    {
        ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, ID3D12VideoDecoder*, D3D12_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS1*, D3D12_VIDEO_DECODE_INPUT_STREAM_ARGUMENTS*, void>)(lpVtbl[23]))((ID3D12VideoDecodeCommandList2*)Unsafe.AsPointer(ref this), pDecoder, pOutputArguments, pInputArguments);
    }

    /// <include file='ID3D12VideoDecodeCommandList2.xml' path='doc/member[@name="ID3D12VideoDecodeCommandList2.SetProtectedResourceSession"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public void SetProtectedResourceSession(ID3D12ProtectedResourceSession* pProtectedResourceSession)
    {
        ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, ID3D12ProtectedResourceSession*, void>)(lpVtbl[24]))((ID3D12VideoDecodeCommandList2*)Unsafe.AsPointer(ref this), pProtectedResourceSession);
    }

    /// <include file='ID3D12VideoDecodeCommandList2.xml' path='doc/member[@name="ID3D12VideoDecodeCommandList2.InitializeExtensionCommand"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public void InitializeExtensionCommand(ID3D12VideoExtensionCommand* pExtensionCommand, [NativeTypeName("const void *")] void* pInitializationParameters, [NativeTypeName("SIZE_T")] nuint InitializationParametersSizeInBytes)
    {
        ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, ID3D12VideoExtensionCommand*, void*, nuint, void>)(lpVtbl[25]))((ID3D12VideoDecodeCommandList2*)Unsafe.AsPointer(ref this), pExtensionCommand, pInitializationParameters, InitializationParametersSizeInBytes);
    }

    /// <include file='ID3D12VideoDecodeCommandList2.xml' path='doc/member[@name="ID3D12VideoDecodeCommandList2.ExecuteExtensionCommand"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public void ExecuteExtensionCommand(ID3D12VideoExtensionCommand* pExtensionCommand, [NativeTypeName("const void *")] void* pExecutionParameters, [NativeTypeName("SIZE_T")] nuint ExecutionParametersSizeInBytes)
    {
        ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, ID3D12VideoExtensionCommand*, void*, nuint, void>)(lpVtbl[26]))((ID3D12VideoDecodeCommandList2*)Unsafe.AsPointer(ref this), pExtensionCommand, pExecutionParameters, ExecutionParametersSizeInBytes);
    }

    public interface Interface : ID3D12VideoDecodeCommandList1.Interface
    {
        [VtblIndex(24)]
        void SetProtectedResourceSession(ID3D12ProtectedResourceSession* pProtectedResourceSession);

        [VtblIndex(25)]
        void InitializeExtensionCommand(ID3D12VideoExtensionCommand* pExtensionCommand, [NativeTypeName("const void *")] void* pInitializationParameters, [NativeTypeName("SIZE_T")] nuint InitializationParametersSizeInBytes);

        [VtblIndex(26)]
        void ExecuteExtensionCommand(ID3D12VideoExtensionCommand* pExtensionCommand, [NativeTypeName("const void *")] void* pExecutionParameters, [NativeTypeName("SIZE_T")] nuint ExecutionParametersSizeInBytes);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint*, void*, int> GetPrivateData;

        [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint, void*, int> SetPrivateData;

        [NativeTypeName("HRESULT (const GUID &, const IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, IUnknown*, int> SetPrivateDataInterface;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SetName;

        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> GetDevice;

        [NativeTypeName("D3D12_COMMAND_LIST_TYPE () __attribute__((stdcall))")]
        public new delegate* unmanaged<TSelf*, D3D12_COMMAND_LIST_TYPE> GetType;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Close;

        [NativeTypeName("HRESULT (ID3D12CommandAllocator *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D12CommandAllocator*, int> Reset;

        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void> ClearState;

        [NativeTypeName("void (UINT, const D3D12_RESOURCE_BARRIER *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, D3D12_RESOURCE_BARRIER*, void> ResourceBarrier;

        [NativeTypeName("void (ID3D12Resource *, const D3D12_DISCARD_REGION *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D12Resource*, D3D12_DISCARD_REGION*, void> DiscardResource;

        [NativeTypeName("void (ID3D12QueryHeap *, D3D12_QUERY_TYPE, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D12QueryHeap*, D3D12_QUERY_TYPE, uint, void> BeginQuery;

        [NativeTypeName("void (ID3D12QueryHeap *, D3D12_QUERY_TYPE, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D12QueryHeap*, D3D12_QUERY_TYPE, uint, void> EndQuery;

        [NativeTypeName("void (ID3D12QueryHeap *, D3D12_QUERY_TYPE, UINT, UINT, ID3D12Resource *, UINT64) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D12QueryHeap*, D3D12_QUERY_TYPE, uint, uint, ID3D12Resource*, ulong, void> ResolveQueryData;

        [NativeTypeName("void (ID3D12Resource *, UINT64, D3D12_PREDICATION_OP) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D12Resource*, ulong, D3D12_PREDICATION_OP, void> SetPredication;

        [NativeTypeName("void (UINT, const void *, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, void*, uint, void> SetMarker;

        [NativeTypeName("void (UINT, const void *, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, void*, uint, void> BeginEvent;

        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void> EndEvent;

        [NativeTypeName("void (ID3D12VideoDecoder *, const D3D12_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS *, const D3D12_VIDEO_DECODE_INPUT_STREAM_ARGUMENTS *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D12VideoDecoder*, D3D12_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS*, D3D12_VIDEO_DECODE_INPUT_STREAM_ARGUMENTS*, void> DecodeFrame;

        [NativeTypeName("void (UINT, const D3D12_WRITEBUFFERIMMEDIATE_PARAMETER *, const D3D12_WRITEBUFFERIMMEDIATE_MODE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, D3D12_WRITEBUFFERIMMEDIATE_PARAMETER*, D3D12_WRITEBUFFERIMMEDIATE_MODE*, void> WriteBufferImmediate;

        [NativeTypeName("void (ID3D12VideoDecoder *, const D3D12_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS1 *, const D3D12_VIDEO_DECODE_INPUT_STREAM_ARGUMENTS *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D12VideoDecoder*, D3D12_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS1*, D3D12_VIDEO_DECODE_INPUT_STREAM_ARGUMENTS*, void> DecodeFrame1;

        [NativeTypeName("void (ID3D12ProtectedResourceSession *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D12ProtectedResourceSession*, void> SetProtectedResourceSession;

        [NativeTypeName("void (ID3D12VideoExtensionCommand *, const void *, SIZE_T) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D12VideoExtensionCommand*, void*, nuint, void> InitializeExtensionCommand;

        [NativeTypeName("void (ID3D12VideoExtensionCommand *, const void *, SIZE_T) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D12VideoExtensionCommand*, void*, nuint, void> ExecuteExtensionCommand;
    }
}
