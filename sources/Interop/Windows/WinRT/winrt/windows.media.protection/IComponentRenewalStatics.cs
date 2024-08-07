// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.protection.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IComponentRenewalStatics.xml' path='doc/member[@name="IComponentRenewalStatics"]/*' />
[Guid("6FFBCD67-B795-48C5-8B7B-A7C4EFE202E3")]
[NativeTypeName("struct IComponentRenewalStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IComponentRenewalStatics : IComponentRenewalStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IComponentRenewalStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IComponentRenewalStatics*, Guid*, void**, int>)(lpVtbl[0]))((IComponentRenewalStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IComponentRenewalStatics*, uint>)(lpVtbl[1]))((IComponentRenewalStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IComponentRenewalStatics*, uint>)(lpVtbl[2]))((IComponentRenewalStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IComponentRenewalStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IComponentRenewalStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IComponentRenewalStatics*, HSTRING*, int>)(lpVtbl[4]))((IComponentRenewalStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IComponentRenewalStatics*, TrustLevel*, int>)(lpVtbl[5]))((IComponentRenewalStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IComponentRenewalStatics.xml' path='doc/member[@name="IComponentRenewalStatics.RenewSystemComponentsAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT RenewSystemComponentsAsync([NativeTypeName("ABI::Windows::Media::Protection::IRevocationAndRenewalInformation *")] IRevocationAndRenewalInformation* information, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CMedia__CProtection__CRenewalStatus_UINT32_t **")] IAsyncOperationWithProgress<RenewalStatus, uint>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IComponentRenewalStatics*, IRevocationAndRenewalInformation*, IAsyncOperationWithProgress<RenewalStatus, uint>**, int>)(lpVtbl[6]))((IComponentRenewalStatics*)Unsafe.AsPointer(ref this), information, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT RenewSystemComponentsAsync([NativeTypeName("ABI::Windows::Media::Protection::IRevocationAndRenewalInformation *")] IRevocationAndRenewalInformation* information, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CMedia__CProtection__CRenewalStatus_UINT32_t **")] IAsyncOperationWithProgress<RenewalStatus, uint>** operation);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Protection::IRevocationAndRenewalInformation *, ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CMedia__CProtection__CRenewalStatus_UINT32_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRevocationAndRenewalInformation*, IAsyncOperationWithProgress<RenewalStatus, uint>**, int> RenewSystemComponentsAsync;
    }
}
