// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("8F1B8AD8-0B6B-4874-90C5-BD76011E8F7C")]
    [NativeTypeName("struct ITfMessagePump : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ITfMessagePump : ITfMessagePump.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfMessagePump*, Guid*, void**, int>)(lpVtbl[0]))((ITfMessagePump*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfMessagePump*, uint>)(lpVtbl[1]))((ITfMessagePump*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfMessagePump*, uint>)(lpVtbl[2]))((ITfMessagePump*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT PeekMessageA([NativeTypeName("LPMSG")] MSG* pMsg, HWND hwnd, uint wMsgFilterMin, uint wMsgFilterMax, uint wRemoveMsg, BOOL* pfResult)
        {
            return ((delegate* unmanaged<ITfMessagePump*, MSG*, HWND, uint, uint, uint, BOOL*, int>)(lpVtbl[3]))((ITfMessagePump*)Unsafe.AsPointer(ref this), pMsg, hwnd, wMsgFilterMin, wMsgFilterMax, wRemoveMsg, pfResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetMessageA([NativeTypeName("LPMSG")] MSG* pMsg, HWND hwnd, uint wMsgFilterMin, uint wMsgFilterMax, BOOL* pfResult)
        {
            return ((delegate* unmanaged<ITfMessagePump*, MSG*, HWND, uint, uint, BOOL*, int>)(lpVtbl[4]))((ITfMessagePump*)Unsafe.AsPointer(ref this), pMsg, hwnd, wMsgFilterMin, wMsgFilterMax, pfResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT PeekMessageW([NativeTypeName("LPMSG")] MSG* pMsg, HWND hwnd, uint wMsgFilterMin, uint wMsgFilterMax, uint wRemoveMsg, BOOL* pfResult)
        {
            return ((delegate* unmanaged<ITfMessagePump*, MSG*, HWND, uint, uint, uint, BOOL*, int>)(lpVtbl[5]))((ITfMessagePump*)Unsafe.AsPointer(ref this), pMsg, hwnd, wMsgFilterMin, wMsgFilterMax, wRemoveMsg, pfResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetMessageW([NativeTypeName("LPMSG")] MSG* pMsg, HWND hwnd, uint wMsgFilterMin, uint wMsgFilterMax, BOOL* pfResult)
        {
            return ((delegate* unmanaged<ITfMessagePump*, MSG*, HWND, uint, uint, BOOL*, int>)(lpVtbl[6]))((ITfMessagePump*)Unsafe.AsPointer(ref this), pMsg, hwnd, wMsgFilterMin, wMsgFilterMax, pfResult);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT PeekMessageA([NativeTypeName("LPMSG")] MSG* pMsg, HWND hwnd, uint wMsgFilterMin, uint wMsgFilterMax, uint wRemoveMsg, BOOL* pfResult);

            [VtblIndex(4)]
            HRESULT GetMessageA([NativeTypeName("LPMSG")] MSG* pMsg, HWND hwnd, uint wMsgFilterMin, uint wMsgFilterMax, BOOL* pfResult);

            [VtblIndex(5)]
            HRESULT PeekMessageW([NativeTypeName("LPMSG")] MSG* pMsg, HWND hwnd, uint wMsgFilterMin, uint wMsgFilterMax, uint wRemoveMsg, BOOL* pfResult);

            [VtblIndex(6)]
            HRESULT GetMessageW([NativeTypeName("LPMSG")] MSG* pMsg, HWND hwnd, uint wMsgFilterMin, uint wMsgFilterMax, BOOL* pfResult);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfMessagePump*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ITfMessagePump*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ITfMessagePump*, uint> Release;

            [NativeTypeName("HRESULT (LPMSG, HWND, UINT, UINT, UINT, BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfMessagePump*, MSG*, HWND, uint, uint, uint, BOOL*, int> PeekMessageA;

            [NativeTypeName("HRESULT (LPMSG, HWND, UINT, UINT, BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfMessagePump*, MSG*, HWND, uint, uint, BOOL*, int> GetMessageA;

            [NativeTypeName("HRESULT (LPMSG, HWND, UINT, UINT, UINT, BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfMessagePump*, MSG*, HWND, uint, uint, uint, BOOL*, int> PeekMessageW;

            [NativeTypeName("HRESULT (LPMSG, HWND, UINT, UINT, BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfMessagePump*, MSG*, HWND, uint, uint, BOOL*, int> GetMessageW;
        }
    }
}