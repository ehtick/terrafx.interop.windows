// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("79EAC9C1-BAF9-11CE-8C82-00AA004BA90B")]
    [NativeTypeName("struct IBindStatusCallback : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IBindStatusCallback : IBindStatusCallback.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IBindStatusCallback*, Guid*, void**, int>)(lpVtbl[0]))((IBindStatusCallback*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IBindStatusCallback*, uint>)(lpVtbl[1]))((IBindStatusCallback*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IBindStatusCallback*, uint>)(lpVtbl[2]))((IBindStatusCallback*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT OnStartBinding([NativeTypeName("DWORD")] uint dwReserved, IBinding* pib)
        {
            return ((delegate* unmanaged<IBindStatusCallback*, uint, IBinding*, int>)(lpVtbl[3]))((IBindStatusCallback*)Unsafe.AsPointer(ref this), dwReserved, pib);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetPriority([NativeTypeName("LONG *")] int* pnPriority)
        {
            return ((delegate* unmanaged<IBindStatusCallback*, int*, int>)(lpVtbl[4]))((IBindStatusCallback*)Unsafe.AsPointer(ref this), pnPriority);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT OnLowResource([NativeTypeName("DWORD")] uint reserved)
        {
            return ((delegate* unmanaged<IBindStatusCallback*, uint, int>)(lpVtbl[5]))((IBindStatusCallback*)Unsafe.AsPointer(ref this), reserved);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT OnProgress([NativeTypeName("ULONG")] uint ulProgress, [NativeTypeName("ULONG")] uint ulProgressMax, [NativeTypeName("ULONG")] uint ulStatusCode, [NativeTypeName("LPCWSTR")] ushort* szStatusText)
        {
            return ((delegate* unmanaged<IBindStatusCallback*, uint, uint, uint, ushort*, int>)(lpVtbl[6]))((IBindStatusCallback*)Unsafe.AsPointer(ref this), ulProgress, ulProgressMax, ulStatusCode, szStatusText);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT OnStopBinding(HRESULT hresult, [NativeTypeName("LPCWSTR")] ushort* szError)
        {
            return ((delegate* unmanaged<IBindStatusCallback*, HRESULT, ushort*, int>)(lpVtbl[7]))((IBindStatusCallback*)Unsafe.AsPointer(ref this), hresult, szError);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetBindInfo([NativeTypeName("DWORD *")] uint* grfBINDF, BINDINFO* pbindinfo)
        {
            return ((delegate* unmanaged<IBindStatusCallback*, uint*, BINDINFO*, int>)(lpVtbl[8]))((IBindStatusCallback*)Unsafe.AsPointer(ref this), grfBINDF, pbindinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT OnDataAvailable([NativeTypeName("DWORD")] uint grfBSCF, [NativeTypeName("DWORD")] uint dwSize, FORMATETC* pformatetc, STGMEDIUM* pstgmed)
        {
            return ((delegate* unmanaged<IBindStatusCallback*, uint, uint, FORMATETC*, STGMEDIUM*, int>)(lpVtbl[9]))((IBindStatusCallback*)Unsafe.AsPointer(ref this), grfBSCF, dwSize, pformatetc, pstgmed);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT OnObjectAvailable([NativeTypeName("const IID &")] Guid* riid, IUnknown* punk)
        {
            return ((delegate* unmanaged<IBindStatusCallback*, Guid*, IUnknown*, int>)(lpVtbl[10]))((IBindStatusCallback*)Unsafe.AsPointer(ref this), riid, punk);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT OnStartBinding([NativeTypeName("DWORD")] uint dwReserved, IBinding* pib);

            [VtblIndex(4)]
            HRESULT GetPriority([NativeTypeName("LONG *")] int* pnPriority);

            [VtblIndex(5)]
            HRESULT OnLowResource([NativeTypeName("DWORD")] uint reserved);

            [VtblIndex(6)]
            HRESULT OnProgress([NativeTypeName("ULONG")] uint ulProgress, [NativeTypeName("ULONG")] uint ulProgressMax, [NativeTypeName("ULONG")] uint ulStatusCode, [NativeTypeName("LPCWSTR")] ushort* szStatusText);

            [VtblIndex(7)]
            HRESULT OnStopBinding(HRESULT hresult, [NativeTypeName("LPCWSTR")] ushort* szError);

            [VtblIndex(8)]
            HRESULT GetBindInfo([NativeTypeName("DWORD *")] uint* grfBINDF, BINDINFO* pbindinfo);

            [VtblIndex(9)]
            HRESULT OnDataAvailable([NativeTypeName("DWORD")] uint grfBSCF, [NativeTypeName("DWORD")] uint dwSize, FORMATETC* pformatetc, STGMEDIUM* pstgmed);

            [VtblIndex(10)]
            HRESULT OnObjectAvailable([NativeTypeName("const IID &")] Guid* riid, IUnknown* punk);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IBindStatusCallback*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IBindStatusCallback*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IBindStatusCallback*, uint> Release;

            [NativeTypeName("HRESULT (DWORD, IBinding *) __attribute__((stdcall))")]
            public delegate* unmanaged<IBindStatusCallback*, uint, IBinding*, int> OnStartBinding;

            [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IBindStatusCallback*, int*, int> GetPriority;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<IBindStatusCallback*, uint, int> OnLowResource;

            [NativeTypeName("HRESULT (ULONG, ULONG, ULONG, LPCWSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IBindStatusCallback*, uint, uint, uint, ushort*, int> OnProgress;

            [NativeTypeName("HRESULT (HRESULT, LPCWSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IBindStatusCallback*, HRESULT, ushort*, int> OnStopBinding;

            [NativeTypeName("HRESULT (DWORD *, BINDINFO *) __attribute__((stdcall))")]
            public delegate* unmanaged<IBindStatusCallback*, uint*, BINDINFO*, int> GetBindInfo;

            [NativeTypeName("HRESULT (DWORD, DWORD, FORMATETC *, STGMEDIUM *) __attribute__((stdcall))")]
            public delegate* unmanaged<IBindStatusCallback*, uint, uint, FORMATETC*, STGMEDIUM*, int> OnDataAvailable;

            [NativeTypeName("HRESULT (const IID &, IUnknown *) __attribute__((stdcall))")]
            public delegate* unmanaged<IBindStatusCallback*, Guid*, IUnknown*, int> OnObjectAvailable;
        }
    }
}