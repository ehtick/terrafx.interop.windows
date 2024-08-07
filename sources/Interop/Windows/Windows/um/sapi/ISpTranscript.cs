// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='ISpTranscript.xml' path='doc/member[@name="ISpTranscript"]/*' />
[Guid("10F63BCE-201A-11D3-AC70-00C04F8EE6C0")]
[NativeTypeName("struct ISpTranscript : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ISpTranscript : ISpTranscript.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpTranscript));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpTranscript*, Guid*, void**, int>)(lpVtbl[0]))((ISpTranscript*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpTranscript*, uint>)(lpVtbl[1]))((ISpTranscript*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpTranscript*, uint>)(lpVtbl[2]))((ISpTranscript*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ISpTranscript.xml' path='doc/member[@name="ISpTranscript.GetTranscript"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTranscript([NativeTypeName("LPWSTR *")] char** ppszTranscript)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpTranscript*, char**, int>)(lpVtbl[3]))((ISpTranscript*)Unsafe.AsPointer(ref this), ppszTranscript);
    }

    /// <include file='ISpTranscript.xml' path='doc/member[@name="ISpTranscript.AppendTranscript"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT AppendTranscript([NativeTypeName("LPCWSTR")] char* pszTranscript)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpTranscript*, char*, int>)(lpVtbl[4]))((ISpTranscript*)Unsafe.AsPointer(ref this), pszTranscript);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetTranscript([NativeTypeName("LPWSTR *")] char** ppszTranscript);

        [VtblIndex(4)]
        HRESULT AppendTranscript([NativeTypeName("LPCWSTR")] char* pszTranscript);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> GetTranscript;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> AppendTranscript;
    }
}
