// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.calls.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IVoipCallCoordinator2.xml' path='doc/member[@name="IVoipCallCoordinator2"]/*' />
[Guid("BEB4A9F3-C704-4234-89CE-E88CC0D28FBE")]
[NativeTypeName("struct IVoipCallCoordinator2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IVoipCallCoordinator2 : IVoipCallCoordinator2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IVoipCallCoordinator2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IVoipCallCoordinator2*, Guid*, void**, int>)(lpVtbl[0]))((IVoipCallCoordinator2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IVoipCallCoordinator2*, uint>)(lpVtbl[1]))((IVoipCallCoordinator2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IVoipCallCoordinator2*, uint>)(lpVtbl[2]))((IVoipCallCoordinator2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IVoipCallCoordinator2*, uint*, Guid**, int>)(lpVtbl[3]))((IVoipCallCoordinator2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IVoipCallCoordinator2*, HSTRING*, int>)(lpVtbl[4]))((IVoipCallCoordinator2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IVoipCallCoordinator2*, TrustLevel*, int>)(lpVtbl[5]))((IVoipCallCoordinator2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IVoipCallCoordinator2.xml' path='doc/member[@name="IVoipCallCoordinator2.SetupNewAcceptedCall"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetupNewAcceptedCall(HSTRING context, HSTRING contactName, HSTRING contactNumber, HSTRING serviceName, [NativeTypeName("ABI::Windows::ApplicationModel::Calls::VoipPhoneCallMedia")] VoipPhoneCallMedia media, [NativeTypeName("ABI::Windows::ApplicationModel::Calls::IVoipPhoneCall **")] IVoipPhoneCall** call)
    {
        return ((delegate* unmanaged[MemberFunction]<IVoipCallCoordinator2*, HSTRING, HSTRING, HSTRING, HSTRING, VoipPhoneCallMedia, IVoipPhoneCall**, int>)(lpVtbl[6]))((IVoipCallCoordinator2*)Unsafe.AsPointer(ref this), context, contactName, contactNumber, serviceName, media, call);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT SetupNewAcceptedCall(HSTRING context, HSTRING contactName, HSTRING contactNumber, HSTRING serviceName, [NativeTypeName("ABI::Windows::ApplicationModel::Calls::VoipPhoneCallMedia")] VoipPhoneCallMedia media, [NativeTypeName("ABI::Windows::ApplicationModel::Calls::IVoipPhoneCall **")] IVoipPhoneCall** call);
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

        [NativeTypeName("HRESULT (HSTRING, HSTRING, HSTRING, HSTRING, ABI::Windows::ApplicationModel::Calls::VoipPhoneCallMedia, ABI::Windows::ApplicationModel::Calls::IVoipPhoneCall **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, HSTRING, HSTRING, VoipPhoneCallMedia, IVoipPhoneCall**, int> SetupNewAcceptedCall;
    }
}
