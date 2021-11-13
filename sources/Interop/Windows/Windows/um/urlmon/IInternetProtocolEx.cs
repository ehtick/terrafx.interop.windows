// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("C7A98E66-1010-492C-A1C8-C809E1F75905")]
    [NativeTypeName("struct IInternetProtocolEx : IInternetProtocol")]
    [NativeInheritance("IInternetProtocol")]
    public unsafe partial struct IInternetProtocolEx : IInternetProtocolEx.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IInternetProtocolEx*, Guid*, void**, int>)(lpVtbl[0]))((IInternetProtocolEx*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IInternetProtocolEx*, uint>)(lpVtbl[1]))((IInternetProtocolEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IInternetProtocolEx*, uint>)(lpVtbl[2]))((IInternetProtocolEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Start([NativeTypeName("LPCWSTR")] ushort* szUrl, IInternetProtocolSink* pOIProtSink, IInternetBindInfo* pOIBindInfo, [NativeTypeName("DWORD")] uint grfPI, HANDLE_PTR dwReserved)
        {
            return ((delegate* unmanaged<IInternetProtocolEx*, ushort*, IInternetProtocolSink*, IInternetBindInfo*, uint, HANDLE_PTR, int>)(lpVtbl[3]))((IInternetProtocolEx*)Unsafe.AsPointer(ref this), szUrl, pOIProtSink, pOIBindInfo, grfPI, dwReserved);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT Continue(PROTOCOLDATA* pProtocolData)
        {
            return ((delegate* unmanaged<IInternetProtocolEx*, PROTOCOLDATA*, int>)(lpVtbl[4]))((IInternetProtocolEx*)Unsafe.AsPointer(ref this), pProtocolData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT Abort(HRESULT hrReason, [NativeTypeName("DWORD")] uint dwOptions)
        {
            return ((delegate* unmanaged<IInternetProtocolEx*, HRESULT, uint, int>)(lpVtbl[5]))((IInternetProtocolEx*)Unsafe.AsPointer(ref this), hrReason, dwOptions);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Terminate([NativeTypeName("DWORD")] uint dwOptions)
        {
            return ((delegate* unmanaged<IInternetProtocolEx*, uint, int>)(lpVtbl[6]))((IInternetProtocolEx*)Unsafe.AsPointer(ref this), dwOptions);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT Suspend()
        {
            return ((delegate* unmanaged<IInternetProtocolEx*, int>)(lpVtbl[7]))((IInternetProtocolEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT Resume()
        {
            return ((delegate* unmanaged<IInternetProtocolEx*, int>)(lpVtbl[8]))((IInternetProtocolEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT Read(void* pv, [NativeTypeName("ULONG")] uint cb, [NativeTypeName("ULONG *")] uint* pcbRead)
        {
            return ((delegate* unmanaged<IInternetProtocolEx*, void*, uint, uint*, int>)(lpVtbl[9]))((IInternetProtocolEx*)Unsafe.AsPointer(ref this), pv, cb, pcbRead);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT Seek(LARGE_INTEGER dlibMove, [NativeTypeName("DWORD")] uint dwOrigin, ULARGE_INTEGER* plibNewPosition)
        {
            return ((delegate* unmanaged<IInternetProtocolEx*, LARGE_INTEGER, uint, ULARGE_INTEGER*, int>)(lpVtbl[10]))((IInternetProtocolEx*)Unsafe.AsPointer(ref this), dlibMove, dwOrigin, plibNewPosition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT LockRequest([NativeTypeName("DWORD")] uint dwOptions)
        {
            return ((delegate* unmanaged<IInternetProtocolEx*, uint, int>)(lpVtbl[11]))((IInternetProtocolEx*)Unsafe.AsPointer(ref this), dwOptions);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT UnlockRequest()
        {
            return ((delegate* unmanaged<IInternetProtocolEx*, int>)(lpVtbl[12]))((IInternetProtocolEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT StartEx(IUri* pUri, IInternetProtocolSink* pOIProtSink, IInternetBindInfo* pOIBindInfo, [NativeTypeName("DWORD")] uint grfPI, HANDLE_PTR dwReserved)
        {
            return ((delegate* unmanaged<IInternetProtocolEx*, IUri*, IInternetProtocolSink*, IInternetBindInfo*, uint, HANDLE_PTR, int>)(lpVtbl[13]))((IInternetProtocolEx*)Unsafe.AsPointer(ref this), pUri, pOIProtSink, pOIBindInfo, grfPI, dwReserved);
        }

        public interface Interface : IInternetProtocol.Interface
        {
            [VtblIndex(13)]
            HRESULT StartEx(IUri* pUri, IInternetProtocolSink* pOIProtSink, IInternetBindInfo* pOIBindInfo, [NativeTypeName("DWORD")] uint grfPI, HANDLE_PTR dwReserved);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IInternetProtocolEx*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IInternetProtocolEx*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IInternetProtocolEx*, uint> Release;

            [NativeTypeName("HRESULT (LPCWSTR, IInternetProtocolSink *, IInternetBindInfo *, DWORD, HANDLE_PTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IInternetProtocolEx*, ushort*, IInternetProtocolSink*, IInternetBindInfo*, uint, HANDLE_PTR, int> Start;

            [NativeTypeName("HRESULT (PROTOCOLDATA *) __attribute__((stdcall))")]
            public delegate* unmanaged<IInternetProtocolEx*, PROTOCOLDATA*, int> Continue;

            [NativeTypeName("HRESULT (HRESULT, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<IInternetProtocolEx*, HRESULT, uint, int> Abort;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<IInternetProtocolEx*, uint, int> Terminate;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IInternetProtocolEx*, int> Suspend;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IInternetProtocolEx*, int> Resume;

            [NativeTypeName("HRESULT (void *, ULONG, ULONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IInternetProtocolEx*, void*, uint, uint*, int> Read;

            [NativeTypeName("HRESULT (LARGE_INTEGER, DWORD, ULARGE_INTEGER *) __attribute__((stdcall))")]
            public delegate* unmanaged<IInternetProtocolEx*, LARGE_INTEGER, uint, ULARGE_INTEGER*, int> Seek;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<IInternetProtocolEx*, uint, int> LockRequest;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IInternetProtocolEx*, int> UnlockRequest;

            [NativeTypeName("HRESULT (IUri *, IInternetProtocolSink *, IInternetBindInfo *, DWORD, HANDLE_PTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IInternetProtocolEx*, IUri*, IInternetProtocolSink*, IInternetBindInfo*, uint, HANDLE_PTR, int> StartEx;
        }
    }
}