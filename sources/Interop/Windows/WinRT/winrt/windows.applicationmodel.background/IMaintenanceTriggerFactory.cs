// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.background.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMaintenanceTriggerFactory.xml' path='doc/member[@name="IMaintenanceTriggerFactory"]/*' />
[Guid("4B3DDB2E-97DD-4629-88B0-B06CF9482AE5")]
[NativeTypeName("struct IMaintenanceTriggerFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMaintenanceTriggerFactory : IMaintenanceTriggerFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMaintenanceTriggerFactory));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMaintenanceTriggerFactory*, Guid*, void**, int>)(lpVtbl[0]))((IMaintenanceTriggerFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMaintenanceTriggerFactory*, uint>)(lpVtbl[1]))((IMaintenanceTriggerFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMaintenanceTriggerFactory*, uint>)(lpVtbl[2]))((IMaintenanceTriggerFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMaintenanceTriggerFactory*, uint*, Guid**, int>)(lpVtbl[3]))((IMaintenanceTriggerFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMaintenanceTriggerFactory*, HSTRING*, int>)(lpVtbl[4]))((IMaintenanceTriggerFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMaintenanceTriggerFactory*, TrustLevel*, int>)(lpVtbl[5]))((IMaintenanceTriggerFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMaintenanceTriggerFactory.xml' path='doc/member[@name="IMaintenanceTriggerFactory.Create"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Create([NativeTypeName("UINT32")] uint freshnessTime, [NativeTypeName("boolean")] byte oneShot, [NativeTypeName("ABI::Windows::ApplicationModel::Background::IMaintenanceTrigger **")] IMaintenanceTrigger** trigger)
    {
        return ((delegate* unmanaged[MemberFunction]<IMaintenanceTriggerFactory*, uint, byte, IMaintenanceTrigger**, int>)(lpVtbl[6]))((IMaintenanceTriggerFactory*)Unsafe.AsPointer(ref this), freshnessTime, oneShot, trigger);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Create([NativeTypeName("UINT32")] uint freshnessTime, [NativeTypeName("boolean")] byte oneShot, [NativeTypeName("ABI::Windows::ApplicationModel::Background::IMaintenanceTrigger **")] IMaintenanceTrigger** trigger);
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

        [NativeTypeName("HRESULT (UINT32, boolean, ABI::Windows::ApplicationModel::Background::IMaintenanceTrigger **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, byte, IMaintenanceTrigger**, int> Create;
    }
}
