// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.data.text.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ITextConversionGenerator.xml' path='doc/member[@name="ITextConversionGenerator"]/*' />
[Guid("03606A5E-2AA9-4AB6-AF8B-A562B63A8992")]
[NativeTypeName("struct ITextConversionGenerator : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ITextConversionGenerator : ITextConversionGenerator.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITextConversionGenerator));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextConversionGenerator*, Guid*, void**, int>)(lpVtbl[0]))((ITextConversionGenerator*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ITextConversionGenerator*, uint>)(lpVtbl[1]))((ITextConversionGenerator*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ITextConversionGenerator*, uint>)(lpVtbl[2]))((ITextConversionGenerator*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextConversionGenerator*, uint*, Guid**, int>)(lpVtbl[3]))((ITextConversionGenerator*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextConversionGenerator*, HSTRING*, int>)(lpVtbl[4]))((ITextConversionGenerator*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextConversionGenerator*, TrustLevel*, int>)(lpVtbl[5]))((ITextConversionGenerator*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ITextConversionGenerator.xml' path='doc/member[@name="ITextConversionGenerator.get_ResolvedLanguage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ResolvedLanguage(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextConversionGenerator*, HSTRING*, int>)(lpVtbl[6]))((ITextConversionGenerator*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextConversionGenerator.xml' path='doc/member[@name="ITextConversionGenerator.get_LanguageAvailableButNotInstalled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_LanguageAvailableButNotInstalled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextConversionGenerator*, byte*, int>)(lpVtbl[7]))((ITextConversionGenerator*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextConversionGenerator.xml' path='doc/member[@name="ITextConversionGenerator.GetCandidatesAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetCandidatesAsync(HSTRING input, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_HSTRING_t **")] IAsyncOperation<IntPtr>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextConversionGenerator*, HSTRING, IAsyncOperation<IntPtr>**, int>)(lpVtbl[8]))((ITextConversionGenerator*)Unsafe.AsPointer(ref this), input, result);
    }

    /// <include file='ITextConversionGenerator.xml' path='doc/member[@name="ITextConversionGenerator.GetCandidatesWithMaxCountAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetCandidatesWithMaxCountAsync(HSTRING input, [NativeTypeName("UINT32")] uint maxCandidates, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_HSTRING_t **")] IAsyncOperation<IntPtr>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextConversionGenerator*, HSTRING, uint, IAsyncOperation<IntPtr>**, int>)(lpVtbl[9]))((ITextConversionGenerator*)Unsafe.AsPointer(ref this), input, maxCandidates, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ResolvedLanguage(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_LanguageAvailableButNotInstalled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(8)]
        HRESULT GetCandidatesAsync(HSTRING input, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_HSTRING_t **")] IAsyncOperation<IntPtr>** result);

        [VtblIndex(9)]
        HRESULT GetCandidatesWithMaxCountAsync(HSTRING input, [NativeTypeName("UINT32")] uint maxCandidates, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_HSTRING_t **")] IAsyncOperation<IntPtr>** result);
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_ResolvedLanguage;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_LanguageAvailableButNotInstalled;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<IntPtr>**, int> GetCandidatesAsync;

        [NativeTypeName("HRESULT (HSTRING, UINT32, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, uint, IAsyncOperation<IntPtr>**, int> GetCandidatesWithMaxCountAsync;
    }
}
