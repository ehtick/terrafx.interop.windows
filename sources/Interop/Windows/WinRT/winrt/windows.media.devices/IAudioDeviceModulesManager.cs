// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.devices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAudioDeviceModulesManager.xml' path='doc/member[@name="IAudioDeviceModulesManager"]/*' />
[Guid("6AA40C4D-960A-4D1C-B318-0022604547ED")]
[NativeTypeName("struct IAudioDeviceModulesManager : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAudioDeviceModulesManager : IAudioDeviceModulesManager.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAudioDeviceModulesManager));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioDeviceModulesManager*, Guid*, void**, int>)(lpVtbl[0]))((IAudioDeviceModulesManager*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioDeviceModulesManager*, uint>)(lpVtbl[1]))((IAudioDeviceModulesManager*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioDeviceModulesManager*, uint>)(lpVtbl[2]))((IAudioDeviceModulesManager*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioDeviceModulesManager*, uint*, Guid**, int>)(lpVtbl[3]))((IAudioDeviceModulesManager*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioDeviceModulesManager*, HSTRING*, int>)(lpVtbl[4]))((IAudioDeviceModulesManager*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioDeviceModulesManager*, TrustLevel*, int>)(lpVtbl[5]))((IAudioDeviceModulesManager*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAudioDeviceModulesManager.xml' path='doc/member[@name="IAudioDeviceModulesManager.add_ModuleNotificationReceived"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT add_ModuleNotificationReceived([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CDevices__CAudioDeviceModulesManager_Windows__CMedia__CDevices__CAudioDeviceModuleNotificationEventArgs_t *")] ITypedEventHandler<Pointer<IAudioDeviceModulesManager>, Pointer<IAudioDeviceModuleNotificationEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioDeviceModulesManager*, ITypedEventHandler<Pointer<IAudioDeviceModulesManager>, Pointer<IAudioDeviceModuleNotificationEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[6]))((IAudioDeviceModulesManager*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IAudioDeviceModulesManager.xml' path='doc/member[@name="IAudioDeviceModulesManager.remove_ModuleNotificationReceived"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT remove_ModuleNotificationReceived(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioDeviceModulesManager*, EventRegistrationToken, int>)(lpVtbl[7]))((IAudioDeviceModulesManager*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IAudioDeviceModulesManager.xml' path='doc/member[@name="IAudioDeviceModulesManager.FindAllById"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT FindAllById(HSTRING moduleId, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CDevices__CAudioDeviceModule_t **")] IVectorView<Pointer<IAudioDeviceModule>>** modules)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioDeviceModulesManager*, HSTRING, IVectorView<Pointer<IAudioDeviceModule>>**, int>)(lpVtbl[8]))((IAudioDeviceModulesManager*)Unsafe.AsPointer(ref this), moduleId, modules);
    }

    /// <include file='IAudioDeviceModulesManager.xml' path='doc/member[@name="IAudioDeviceModulesManager.FindAll"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT FindAll([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CDevices__CAudioDeviceModule_t **")] IVectorView<Pointer<IAudioDeviceModule>>** modules)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioDeviceModulesManager*, IVectorView<Pointer<IAudioDeviceModule>>**, int>)(lpVtbl[9]))((IAudioDeviceModulesManager*)Unsafe.AsPointer(ref this), modules);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT add_ModuleNotificationReceived([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CDevices__CAudioDeviceModulesManager_Windows__CMedia__CDevices__CAudioDeviceModuleNotificationEventArgs_t *")] ITypedEventHandler<Pointer<IAudioDeviceModulesManager>, Pointer<IAudioDeviceModuleNotificationEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(7)]
        HRESULT remove_ModuleNotificationReceived(EventRegistrationToken token);

        [VtblIndex(8)]
        HRESULT FindAllById(HSTRING moduleId, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CDevices__CAudioDeviceModule_t **")] IVectorView<Pointer<IAudioDeviceModule>>** modules);

        [VtblIndex(9)]
        HRESULT FindAll([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CDevices__CAudioDeviceModule_t **")] IVectorView<Pointer<IAudioDeviceModule>>** modules);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CDevices__CAudioDeviceModulesManager_Windows__CMedia__CDevices__CAudioDeviceModuleNotificationEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IAudioDeviceModulesManager>, Pointer<IAudioDeviceModuleNotificationEventArgs>>*, EventRegistrationToken*, int> add_ModuleNotificationReceived;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_ModuleNotificationReceived;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CDevices__CAudioDeviceModule_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IVectorView<Pointer<IAudioDeviceModule>>**, int> FindAllById;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CDevices__CAudioDeviceModule_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<Pointer<IAudioDeviceModule>>**, int> FindAll;
    }
}
