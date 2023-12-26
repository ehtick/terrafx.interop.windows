// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.calls.background.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPhoneCallOriginDataRequestTriggerDetails.xml' path='doc/member[@name="IPhoneCallOriginDataRequestTriggerDetails"]/*' />
[Guid("6E9B5B3F-C54B-4E82-4CC9-E329A4184592")]
[NativeTypeName("struct IPhoneCallOriginDataRequestTriggerDetails : IInspectable")]
[NativeInheritance("IInspectable")]
[Obsolete("PhoneCallOriginDataRequestTriggerDetails is deprecated and might not work for all platforms. For more info, see MSDN.")]
public unsafe partial struct IPhoneCallOriginDataRequestTriggerDetails : IPhoneCallOriginDataRequestTriggerDetails.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPhoneCallOriginDataRequestTriggerDetails));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallOriginDataRequestTriggerDetails*, Guid*, void**, int>)(lpVtbl[0]))((IPhoneCallOriginDataRequestTriggerDetails*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallOriginDataRequestTriggerDetails*, uint>)(lpVtbl[1]))((IPhoneCallOriginDataRequestTriggerDetails*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallOriginDataRequestTriggerDetails*, uint>)(lpVtbl[2]))((IPhoneCallOriginDataRequestTriggerDetails*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallOriginDataRequestTriggerDetails*, uint*, Guid**, int>)(lpVtbl[3]))((IPhoneCallOriginDataRequestTriggerDetails*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallOriginDataRequestTriggerDetails*, HSTRING*, int>)(lpVtbl[4]))((IPhoneCallOriginDataRequestTriggerDetails*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallOriginDataRequestTriggerDetails*, TrustLevel*, int>)(lpVtbl[5]))((IPhoneCallOriginDataRequestTriggerDetails*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPhoneCallOriginDataRequestTriggerDetails.xml' path='doc/member[@name="IPhoneCallOriginDataRequestTriggerDetails.get_RequestId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [Obsolete("PhoneCallOriginDataRequestTriggerDetails is deprecated and might not work for all platforms. For more info, see MSDN.")]
    public HRESULT get_RequestId(Guid* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallOriginDataRequestTriggerDetails*, Guid*, int>)(lpVtbl[6]))((IPhoneCallOriginDataRequestTriggerDetails*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IPhoneCallOriginDataRequestTriggerDetails.xml' path='doc/member[@name="IPhoneCallOriginDataRequestTriggerDetails.get_PhoneNumber"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [Obsolete("PhoneCallOriginDataRequestTriggerDetails is deprecated and might not work for all platforms. For more info, see MSDN.")]
    public HRESULT get_PhoneNumber(HSTRING* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallOriginDataRequestTriggerDetails*, HSTRING*, int>)(lpVtbl[7]))((IPhoneCallOriginDataRequestTriggerDetails*)Unsafe.AsPointer(ref this), result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        [Obsolete("PhoneCallOriginDataRequestTriggerDetails is deprecated and might not work for all platforms. For more info, see MSDN.")]
        HRESULT get_RequestId(Guid* result);

        [VtblIndex(7)]
        [Obsolete("PhoneCallOriginDataRequestTriggerDetails is deprecated and might not work for all platforms. For more info, see MSDN.")]
        HRESULT get_PhoneNumber(HSTRING* result);
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

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        [Obsolete("PhoneCallOriginDataRequestTriggerDetails is deprecated and might not work for all platforms. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> get_RequestId;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        [Obsolete("PhoneCallOriginDataRequestTriggerDetails is deprecated and might not work for all platforms. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_PhoneNumber;
    }
}
