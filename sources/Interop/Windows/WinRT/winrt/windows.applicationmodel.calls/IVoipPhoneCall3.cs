// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.calls.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IVoipPhoneCall3.xml' path='doc/member[@name="IVoipPhoneCall3"]/*' />
[Guid("0D891522-E258-4AA9-907A-1AA413C25523")]
[NativeTypeName("struct IVoipPhoneCall3 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IVoipPhoneCall3 : IVoipPhoneCall3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IVoipPhoneCall3));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IVoipPhoneCall3*, Guid*, void**, int>)(lpVtbl[0]))((IVoipPhoneCall3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IVoipPhoneCall3*, uint>)(lpVtbl[1]))((IVoipPhoneCall3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IVoipPhoneCall3*, uint>)(lpVtbl[2]))((IVoipPhoneCall3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IVoipPhoneCall3*, uint*, Guid**, int>)(lpVtbl[3]))((IVoipPhoneCall3*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IVoipPhoneCall3*, HSTRING*, int>)(lpVtbl[4]))((IVoipPhoneCall3*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IVoipPhoneCall3*, TrustLevel*, int>)(lpVtbl[5]))((IVoipPhoneCall3*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IVoipPhoneCall3.xml' path='doc/member[@name="IVoipPhoneCall3.NotifyCallAccepted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT NotifyCallAccepted([NativeTypeName("ABI::Windows::ApplicationModel::Calls::VoipPhoneCallMedia")] VoipPhoneCallMedia media)
    {
        return ((delegate* unmanaged[MemberFunction]<IVoipPhoneCall3*, VoipPhoneCallMedia, int>)(lpVtbl[6]))((IVoipPhoneCall3*)Unsafe.AsPointer(ref this), media);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT NotifyCallAccepted([NativeTypeName("ABI::Windows::ApplicationModel::Calls::VoipPhoneCallMedia")] VoipPhoneCallMedia media);
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

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Calls::VoipPhoneCallMedia) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, VoipPhoneCallMedia, int> NotifyCallAccepted;
    }
}
