// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A048285E-25A9-4527-BD93-D68B68C44254")]
    [NativeTypeName("struct ID3D11VideoProcessorOutputView : ID3D11View")]
    public unsafe partial struct ID3D11VideoProcessorOutputView
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D11VideoProcessorOutputView*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11VideoProcessorOutputView*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D11VideoProcessorOutputView*, uint>)(lpVtbl[1]))((ID3D11VideoProcessorOutputView*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3D11VideoProcessorOutputView*, uint>)(lpVtbl[2]))((ID3D11VideoProcessorOutputView*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetDevice(ID3D11Device** ppDevice)
        {
            ((delegate* unmanaged<ID3D11VideoProcessorOutputView*, ID3D11Device**, void>)(lpVtbl[3]))((ID3D11VideoProcessorOutputView*)Unsafe.AsPointer(ref this), ppDevice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* pDataSize, void* pData)
        {
            return ((delegate* unmanaged<ID3D11VideoProcessorOutputView*, Guid*, uint*, void*, int>)(lpVtbl[4]))((ID3D11VideoProcessorOutputView*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return ((delegate* unmanaged<ID3D11VideoProcessorOutputView*, Guid*, uint, void*, int>)(lpVtbl[5]))((ID3D11VideoProcessorOutputView*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
        {
            return ((delegate* unmanaged<ID3D11VideoProcessorOutputView*, Guid*, IUnknown*, int>)(lpVtbl[6]))((ID3D11VideoProcessorOutputView*)Unsafe.AsPointer(ref this), guid, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetResource(ID3D11Resource** ppResource)
        {
            ((delegate* unmanaged<ID3D11VideoProcessorOutputView*, ID3D11Resource**, void>)(lpVtbl[7]))((ID3D11VideoProcessorOutputView*)Unsafe.AsPointer(ref this), ppResource);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetDesc(D3D11_VIDEO_PROCESSOR_OUTPUT_VIEW_DESC* pDesc)
        {
            ((delegate* unmanaged<ID3D11VideoProcessorOutputView*, D3D11_VIDEO_PROCESSOR_OUTPUT_VIEW_DESC*, void>)(lpVtbl[8]))((ID3D11VideoProcessorOutputView*)Unsafe.AsPointer(ref this), pDesc);
        }
    }
}
