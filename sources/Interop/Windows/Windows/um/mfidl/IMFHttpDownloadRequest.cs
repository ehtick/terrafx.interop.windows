// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows
{
    [SupportedOSPlatform("windows10.0.15063.0")]
    [Guid("F779FDDF-26E7-4270-8A8B-B983D1859DE0")]
    [NativeTypeName("struct IMFHttpDownloadRequest : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFHttpDownloadRequest : IMFHttpDownloadRequest.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFHttpDownloadRequest*, Guid*, void**, int>)(lpVtbl[0]))((IMFHttpDownloadRequest*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFHttpDownloadRequest*, uint>)(lpVtbl[1]))((IMFHttpDownloadRequest*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFHttpDownloadRequest*, uint>)(lpVtbl[2]))((IMFHttpDownloadRequest*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT AddHeader([NativeTypeName("LPCWSTR")] ushort* szHeader)
        {
            return ((delegate* unmanaged<IMFHttpDownloadRequest*, ushort*, int>)(lpVtbl[3]))((IMFHttpDownloadRequest*)Unsafe.AsPointer(ref this), szHeader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT BeginSendRequest([NativeTypeName("const BYTE *")] byte* pbPayload, [NativeTypeName("ULONG")] uint cbPayload, IMFAsyncCallback* pCallback, IUnknown* punkState)
        {
            return ((delegate* unmanaged<IMFHttpDownloadRequest*, byte*, uint, IMFAsyncCallback*, IUnknown*, int>)(lpVtbl[4]))((IMFHttpDownloadRequest*)Unsafe.AsPointer(ref this), pbPayload, cbPayload, pCallback, punkState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT EndSendRequest(IMFAsyncResult* pResult)
        {
            return ((delegate* unmanaged<IMFHttpDownloadRequest*, IMFAsyncResult*, int>)(lpVtbl[5]))((IMFHttpDownloadRequest*)Unsafe.AsPointer(ref this), pResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT BeginReceiveResponse(IMFAsyncCallback* pCallback, IUnknown* punkState)
        {
            return ((delegate* unmanaged<IMFHttpDownloadRequest*, IMFAsyncCallback*, IUnknown*, int>)(lpVtbl[6]))((IMFHttpDownloadRequest*)Unsafe.AsPointer(ref this), pCallback, punkState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT EndReceiveResponse(IMFAsyncResult* pResult)
        {
            return ((delegate* unmanaged<IMFHttpDownloadRequest*, IMFAsyncResult*, int>)(lpVtbl[7]))((IMFHttpDownloadRequest*)Unsafe.AsPointer(ref this), pResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT BeginReadPayload(byte* pb, [NativeTypeName("ULONG")] uint cb, IMFAsyncCallback* pCallback, IUnknown* punkState)
        {
            return ((delegate* unmanaged<IMFHttpDownloadRequest*, byte*, uint, IMFAsyncCallback*, IUnknown*, int>)(lpVtbl[8]))((IMFHttpDownloadRequest*)Unsafe.AsPointer(ref this), pb, cb, pCallback, punkState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT EndReadPayload(IMFAsyncResult* pResult, [NativeTypeName("QWORD *")] ulong* pqwOffset, [NativeTypeName("ULONG *")] uint* pcbRead)
        {
            return ((delegate* unmanaged<IMFHttpDownloadRequest*, IMFAsyncResult*, ulong*, uint*, int>)(lpVtbl[9]))((IMFHttpDownloadRequest*)Unsafe.AsPointer(ref this), pResult, pqwOffset, pcbRead);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT QueryHeader([NativeTypeName("LPCWSTR")] ushort* szHeaderName, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("LPWSTR *")] ushort** ppszHeaderValue)
        {
            return ((delegate* unmanaged<IMFHttpDownloadRequest*, ushort*, uint, ushort**, int>)(lpVtbl[10]))((IMFHttpDownloadRequest*)Unsafe.AsPointer(ref this), szHeaderName, dwIndex, ppszHeaderValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT GetURL([NativeTypeName("LPWSTR *")] ushort** ppszURL)
        {
            return ((delegate* unmanaged<IMFHttpDownloadRequest*, ushort**, int>)(lpVtbl[11]))((IMFHttpDownloadRequest*)Unsafe.AsPointer(ref this), ppszURL);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT HasNullSourceOrigin(BOOL* pfNullSourceOrigin)
        {
            return ((delegate* unmanaged<IMFHttpDownloadRequest*, BOOL*, int>)(lpVtbl[12]))((IMFHttpDownloadRequest*)Unsafe.AsPointer(ref this), pfNullSourceOrigin);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT GetTimeSeekResult([NativeTypeName("QWORD *")] ulong* pqwStartTime, [NativeTypeName("QWORD *")] ulong* pqwStopTime, [NativeTypeName("QWORD *")] ulong* pqwDuration)
        {
            return ((delegate* unmanaged<IMFHttpDownloadRequest*, ulong*, ulong*, ulong*, int>)(lpVtbl[13]))((IMFHttpDownloadRequest*)Unsafe.AsPointer(ref this), pqwStartTime, pqwStopTime, pqwDuration);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT GetHttpStatus([NativeTypeName("DWORD *")] uint* pdwHttpStatus)
        {
            return ((delegate* unmanaged<IMFHttpDownloadRequest*, uint*, int>)(lpVtbl[14]))((IMFHttpDownloadRequest*)Unsafe.AsPointer(ref this), pdwHttpStatus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT GetAtEndOfPayload(BOOL* pfAtEndOfPayload)
        {
            return ((delegate* unmanaged<IMFHttpDownloadRequest*, BOOL*, int>)(lpVtbl[15]))((IMFHttpDownloadRequest*)Unsafe.AsPointer(ref this), pfAtEndOfPayload);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT GetTotalLength([NativeTypeName("QWORD *")] ulong* pqwTotalLength)
        {
            return ((delegate* unmanaged<IMFHttpDownloadRequest*, ulong*, int>)(lpVtbl[16]))((IMFHttpDownloadRequest*)Unsafe.AsPointer(ref this), pqwTotalLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT GetRangeEndOffset([NativeTypeName("QWORD *")] ulong* pqwRangeEnd)
        {
            return ((delegate* unmanaged<IMFHttpDownloadRequest*, ulong*, int>)(lpVtbl[17]))((IMFHttpDownloadRequest*)Unsafe.AsPointer(ref this), pqwRangeEnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT Close()
        {
            return ((delegate* unmanaged<IMFHttpDownloadRequest*, int>)(lpVtbl[18]))((IMFHttpDownloadRequest*)Unsafe.AsPointer(ref this));
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT AddHeader([NativeTypeName("LPCWSTR")] ushort* szHeader);

            [VtblIndex(4)]
            HRESULT BeginSendRequest([NativeTypeName("const BYTE *")] byte* pbPayload, [NativeTypeName("ULONG")] uint cbPayload, IMFAsyncCallback* pCallback, IUnknown* punkState);

            [VtblIndex(5)]
            HRESULT EndSendRequest(IMFAsyncResult* pResult);

            [VtblIndex(6)]
            HRESULT BeginReceiveResponse(IMFAsyncCallback* pCallback, IUnknown* punkState);

            [VtblIndex(7)]
            HRESULT EndReceiveResponse(IMFAsyncResult* pResult);

            [VtblIndex(8)]
            HRESULT BeginReadPayload(byte* pb, [NativeTypeName("ULONG")] uint cb, IMFAsyncCallback* pCallback, IUnknown* punkState);

            [VtblIndex(9)]
            HRESULT EndReadPayload(IMFAsyncResult* pResult, [NativeTypeName("QWORD *")] ulong* pqwOffset, [NativeTypeName("ULONG *")] uint* pcbRead);

            [VtblIndex(10)]
            HRESULT QueryHeader([NativeTypeName("LPCWSTR")] ushort* szHeaderName, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("LPWSTR *")] ushort** ppszHeaderValue);

            [VtblIndex(11)]
            HRESULT GetURL([NativeTypeName("LPWSTR *")] ushort** ppszURL);

            [VtblIndex(12)]
            HRESULT HasNullSourceOrigin(BOOL* pfNullSourceOrigin);

            [VtblIndex(13)]
            HRESULT GetTimeSeekResult([NativeTypeName("QWORD *")] ulong* pqwStartTime, [NativeTypeName("QWORD *")] ulong* pqwStopTime, [NativeTypeName("QWORD *")] ulong* pqwDuration);

            [VtblIndex(14)]
            HRESULT GetHttpStatus([NativeTypeName("DWORD *")] uint* pdwHttpStatus);

            [VtblIndex(15)]
            HRESULT GetAtEndOfPayload(BOOL* pfAtEndOfPayload);

            [VtblIndex(16)]
            HRESULT GetTotalLength([NativeTypeName("QWORD *")] ulong* pqwTotalLength);

            [VtblIndex(17)]
            HRESULT GetRangeEndOffset([NativeTypeName("QWORD *")] ulong* pqwRangeEnd);

            [VtblIndex(18)]
            HRESULT Close();
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFHttpDownloadRequest*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFHttpDownloadRequest*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFHttpDownloadRequest*, uint> Release;

            [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFHttpDownloadRequest*, ushort*, int> AddHeader;

            [NativeTypeName("HRESULT (const BYTE *, ULONG, IMFAsyncCallback *, IUnknown *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFHttpDownloadRequest*, byte*, uint, IMFAsyncCallback*, IUnknown*, int> BeginSendRequest;

            [NativeTypeName("HRESULT (IMFAsyncResult *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFHttpDownloadRequest*, IMFAsyncResult*, int> EndSendRequest;

            [NativeTypeName("HRESULT (IMFAsyncCallback *, IUnknown *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFHttpDownloadRequest*, IMFAsyncCallback*, IUnknown*, int> BeginReceiveResponse;

            [NativeTypeName("HRESULT (IMFAsyncResult *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFHttpDownloadRequest*, IMFAsyncResult*, int> EndReceiveResponse;

            [NativeTypeName("HRESULT (BYTE *, ULONG, IMFAsyncCallback *, IUnknown *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFHttpDownloadRequest*, byte*, uint, IMFAsyncCallback*, IUnknown*, int> BeginReadPayload;

            [NativeTypeName("HRESULT (IMFAsyncResult *, QWORD *, ULONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFHttpDownloadRequest*, IMFAsyncResult*, ulong*, uint*, int> EndReadPayload;

            [NativeTypeName("HRESULT (LPCWSTR, DWORD, LPWSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFHttpDownloadRequest*, ushort*, uint, ushort**, int> QueryHeader;

            [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFHttpDownloadRequest*, ushort**, int> GetURL;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFHttpDownloadRequest*, BOOL*, int> HasNullSourceOrigin;

            [NativeTypeName("HRESULT (QWORD *, QWORD *, QWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFHttpDownloadRequest*, ulong*, ulong*, ulong*, int> GetTimeSeekResult;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFHttpDownloadRequest*, uint*, int> GetHttpStatus;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFHttpDownloadRequest*, BOOL*, int> GetAtEndOfPayload;

            [NativeTypeName("HRESULT (QWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFHttpDownloadRequest*, ulong*, int> GetTotalLength;

            [NativeTypeName("HRESULT (QWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFHttpDownloadRequest*, ulong*, int> GetRangeEndOffset;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFHttpDownloadRequest*, int> Close;
        }
    }
}