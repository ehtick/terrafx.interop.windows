// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxcapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the University of Illinois Open Source License.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX
{
    [Guid("D2C21B26-8350-4BDC-976A-331CE6F4C54C")]
    [NativeTypeName("struct IDxcContainerReflection : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDxcContainerReflection : IDxcContainerReflection.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDxcContainerReflection*, Guid*, void**, int>)(lpVtbl[0]))((IDxcContainerReflection*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDxcContainerReflection*, uint>)(lpVtbl[1]))((IDxcContainerReflection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDxcContainerReflection*, uint>)(lpVtbl[2]))((IDxcContainerReflection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Load(IDxcBlob* pContainer)
        {
            return ((delegate* unmanaged<IDxcContainerReflection*, IDxcBlob*, int>)(lpVtbl[3]))((IDxcContainerReflection*)Unsafe.AsPointer(ref this), pContainer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetPartCount([NativeTypeName("UINT32 *")] uint* pResult)
        {
            return ((delegate* unmanaged<IDxcContainerReflection*, uint*, int>)(lpVtbl[4]))((IDxcContainerReflection*)Unsafe.AsPointer(ref this), pResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetPartKind([NativeTypeName("UINT32")] uint idx, [NativeTypeName("UINT32 *")] uint* pResult)
        {
            return ((delegate* unmanaged<IDxcContainerReflection*, uint, uint*, int>)(lpVtbl[5]))((IDxcContainerReflection*)Unsafe.AsPointer(ref this), idx, pResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetPartContent([NativeTypeName("UINT32")] uint idx, IDxcBlob** ppResult)
        {
            return ((delegate* unmanaged<IDxcContainerReflection*, uint, IDxcBlob**, int>)(lpVtbl[6]))((IDxcContainerReflection*)Unsafe.AsPointer(ref this), idx, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT FindFirstPartKind([NativeTypeName("UINT32")] uint kind, [NativeTypeName("UINT32 *")] uint* pResult)
        {
            return ((delegate* unmanaged<IDxcContainerReflection*, uint, uint*, int>)(lpVtbl[7]))((IDxcContainerReflection*)Unsafe.AsPointer(ref this), kind, pResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetPartReflection([NativeTypeName("UINT32")] uint idx, [NativeTypeName("const IID &")] Guid* iid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDxcContainerReflection*, uint, Guid*, void**, int>)(lpVtbl[8]))((IDxcContainerReflection*)Unsafe.AsPointer(ref this), idx, iid, ppvObject);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT Load(IDxcBlob* pContainer);

            [VtblIndex(4)]
            HRESULT GetPartCount([NativeTypeName("UINT32 *")] uint* pResult);

            [VtblIndex(5)]
            HRESULT GetPartKind([NativeTypeName("UINT32")] uint idx, [NativeTypeName("UINT32 *")] uint* pResult);

            [VtblIndex(6)]
            HRESULT GetPartContent([NativeTypeName("UINT32")] uint idx, IDxcBlob** ppResult);

            [VtblIndex(7)]
            HRESULT FindFirstPartKind([NativeTypeName("UINT32")] uint kind, [NativeTypeName("UINT32 *")] uint* pResult);

            [VtblIndex(8)]
            HRESULT GetPartReflection([NativeTypeName("UINT32")] uint idx, [NativeTypeName("const IID &")] Guid* iid, void** ppvObject);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDxcContainerReflection*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDxcContainerReflection*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDxcContainerReflection*, uint> Release;

            [NativeTypeName("HRESULT (IDxcBlob *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDxcContainerReflection*, IDxcBlob*, int> Load;

            [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDxcContainerReflection*, uint*, int> GetPartCount;

            [NativeTypeName("HRESULT (UINT32, UINT32 *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDxcContainerReflection*, uint, uint*, int> GetPartKind;

            [NativeTypeName("HRESULT (UINT32, IDxcBlob **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDxcContainerReflection*, uint, IDxcBlob**, int> GetPartContent;

            [NativeTypeName("HRESULT (UINT32, UINT32 *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDxcContainerReflection*, uint, uint*, int> FindFirstPartKind;

            [NativeTypeName("HRESULT (UINT32, const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDxcContainerReflection*, uint, Guid*, void**, int> GetPartReflection;
        }
    }
}