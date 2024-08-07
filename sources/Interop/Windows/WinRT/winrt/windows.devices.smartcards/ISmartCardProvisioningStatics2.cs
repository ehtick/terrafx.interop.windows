// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.smartcards.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISmartCardProvisioningStatics2.xml' path='doc/member[@name="ISmartCardProvisioningStatics2"]/*' />
[Guid("3447C6A8-C9A0-4BD6-B50D-251F4E8D3A62")]
[NativeTypeName("struct ISmartCardProvisioningStatics2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISmartCardProvisioningStatics2 : ISmartCardProvisioningStatics2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISmartCardProvisioningStatics2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardProvisioningStatics2*, Guid*, void**, int>)(lpVtbl[0]))((ISmartCardProvisioningStatics2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardProvisioningStatics2*, uint>)(lpVtbl[1]))((ISmartCardProvisioningStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardProvisioningStatics2*, uint>)(lpVtbl[2]))((ISmartCardProvisioningStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardProvisioningStatics2*, uint*, Guid**, int>)(lpVtbl[3]))((ISmartCardProvisioningStatics2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardProvisioningStatics2*, HSTRING*, int>)(lpVtbl[4]))((ISmartCardProvisioningStatics2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardProvisioningStatics2*, TrustLevel*, int>)(lpVtbl[5]))((ISmartCardProvisioningStatics2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISmartCardProvisioningStatics2.xml' path='doc/member[@name="ISmartCardProvisioningStatics2.RequestAttestedVirtualSmartCardCreationAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT RequestAttestedVirtualSmartCardCreationAsync(HSTRING friendlyName, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* administrativeKey, [NativeTypeName("ABI::Windows::Devices::SmartCards::ISmartCardPinPolicy *")] ISmartCardPinPolicy* pinPolicy, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardProvisioning_t **")] IAsyncOperation<Pointer<ISmartCardProvisioning>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardProvisioningStatics2*, HSTRING, IBuffer*, ISmartCardPinPolicy*, IAsyncOperation<Pointer<ISmartCardProvisioning>>**, int>)(lpVtbl[6]))((ISmartCardProvisioningStatics2*)Unsafe.AsPointer(ref this), friendlyName, administrativeKey, pinPolicy, result);
    }

    /// <include file='ISmartCardProvisioningStatics2.xml' path='doc/member[@name="ISmartCardProvisioningStatics2.RequestAttestedVirtualSmartCardCreationAsyncWithCardId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT RequestAttestedVirtualSmartCardCreationAsyncWithCardId(HSTRING friendlyName, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* administrativeKey, [NativeTypeName("ABI::Windows::Devices::SmartCards::ISmartCardPinPolicy *")] ISmartCardPinPolicy* pinPolicy, Guid cardId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardProvisioning_t **")] IAsyncOperation<Pointer<ISmartCardProvisioning>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardProvisioningStatics2*, HSTRING, IBuffer*, ISmartCardPinPolicy*, Guid, IAsyncOperation<Pointer<ISmartCardProvisioning>>**, int>)(lpVtbl[7]))((ISmartCardProvisioningStatics2*)Unsafe.AsPointer(ref this), friendlyName, administrativeKey, pinPolicy, cardId, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT RequestAttestedVirtualSmartCardCreationAsync(HSTRING friendlyName, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* administrativeKey, [NativeTypeName("ABI::Windows::Devices::SmartCards::ISmartCardPinPolicy *")] ISmartCardPinPolicy* pinPolicy, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardProvisioning_t **")] IAsyncOperation<Pointer<ISmartCardProvisioning>>** result);

        [VtblIndex(7)]
        HRESULT RequestAttestedVirtualSmartCardCreationAsyncWithCardId(HSTRING friendlyName, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* administrativeKey, [NativeTypeName("ABI::Windows::Devices::SmartCards::ISmartCardPinPolicy *")] ISmartCardPinPolicy* pinPolicy, Guid cardId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardProvisioning_t **")] IAsyncOperation<Pointer<ISmartCardProvisioning>>** result);
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

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Devices::SmartCards::ISmartCardPinPolicy *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardProvisioning_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IBuffer*, ISmartCardPinPolicy*, IAsyncOperation<Pointer<ISmartCardProvisioning>>**, int> RequestAttestedVirtualSmartCardCreationAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Devices::SmartCards::ISmartCardPinPolicy *, GUID, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardProvisioning_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IBuffer*, ISmartCardPinPolicy*, Guid, IAsyncOperation<Pointer<ISmartCardProvisioning>>**, int> RequestAttestedVirtualSmartCardCreationAsyncWithCardId;
    }
}
