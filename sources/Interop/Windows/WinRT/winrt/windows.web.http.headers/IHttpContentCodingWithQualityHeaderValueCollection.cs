// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.web.http.headers.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IHttpContentCodingWithQualityHeaderValueCollection.xml' path='doc/member[@name="IHttpContentCodingWithQualityHeaderValueCollection"]/*' />
[Guid("7C0D753E-E899-4378-B5C8-412D820711CC")]
[NativeTypeName("struct IHttpContentCodingWithQualityHeaderValueCollection : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IHttpContentCodingWithQualityHeaderValueCollection : IHttpContentCodingWithQualityHeaderValueCollection.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpContentCodingWithQualityHeaderValueCollection));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContentCodingWithQualityHeaderValueCollection*, Guid*, void**, int>)(lpVtbl[0]))((IHttpContentCodingWithQualityHeaderValueCollection*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContentCodingWithQualityHeaderValueCollection*, uint>)(lpVtbl[1]))((IHttpContentCodingWithQualityHeaderValueCollection*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContentCodingWithQualityHeaderValueCollection*, uint>)(lpVtbl[2]))((IHttpContentCodingWithQualityHeaderValueCollection*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContentCodingWithQualityHeaderValueCollection*, uint*, Guid**, int>)(lpVtbl[3]))((IHttpContentCodingWithQualityHeaderValueCollection*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContentCodingWithQualityHeaderValueCollection*, HSTRING*, int>)(lpVtbl[4]))((IHttpContentCodingWithQualityHeaderValueCollection*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContentCodingWithQualityHeaderValueCollection*, TrustLevel*, int>)(lpVtbl[5]))((IHttpContentCodingWithQualityHeaderValueCollection*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IHttpContentCodingWithQualityHeaderValueCollection.xml' path='doc/member[@name="IHttpContentCodingWithQualityHeaderValueCollection.ParseAdd"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT ParseAdd(HSTRING input)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContentCodingWithQualityHeaderValueCollection*, HSTRING, int>)(lpVtbl[6]))((IHttpContentCodingWithQualityHeaderValueCollection*)Unsafe.AsPointer(ref this), input);
    }

    /// <include file='IHttpContentCodingWithQualityHeaderValueCollection.xml' path='doc/member[@name="IHttpContentCodingWithQualityHeaderValueCollection.TryParseAdd"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT TryParseAdd(HSTRING input, [NativeTypeName("boolean *")] byte* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContentCodingWithQualityHeaderValueCollection*, HSTRING, byte*, int>)(lpVtbl[7]))((IHttpContentCodingWithQualityHeaderValueCollection*)Unsafe.AsPointer(ref this), input, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT ParseAdd(HSTRING input);

        [VtblIndex(7)]
        HRESULT TryParseAdd(HSTRING input, [NativeTypeName("boolean *")] byte* result);
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

        [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, Guid**, int> GetIids;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> GetRuntimeClassName;

        [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TrustLevel*, int> GetTrustLevel;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> ParseAdd;

        [NativeTypeName("HRESULT (HSTRING, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, byte*, int> TryParseAdd;
    }
}
