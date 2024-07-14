// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.background.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IBackgroundWorkCostStatics2.xml' path='doc/member[@name="IBackgroundWorkCostStatics2"]/*' />
[Guid("D868C976-81F6-57C8-AB2B-400B749E21D6")]
[NativeTypeName("struct IBackgroundWorkCostStatics2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBackgroundWorkCostStatics2 : IBackgroundWorkCostStatics2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBackgroundWorkCostStatics2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundWorkCostStatics2*, Guid*, void**, int>)(lpVtbl[0]))((IBackgroundWorkCostStatics2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundWorkCostStatics2*, uint>)(lpVtbl[1]))((IBackgroundWorkCostStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundWorkCostStatics2*, uint>)(lpVtbl[2]))((IBackgroundWorkCostStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundWorkCostStatics2*, uint*, Guid**, int>)(lpVtbl[3]))((IBackgroundWorkCostStatics2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundWorkCostStatics2*, HSTRING*, int>)(lpVtbl[4]))((IBackgroundWorkCostStatics2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundWorkCostStatics2*, TrustLevel*, int>)(lpVtbl[5]))((IBackgroundWorkCostStatics2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IBackgroundWorkCostStatics2.xml' path='doc/member[@name="IBackgroundWorkCostStatics2.get_AppEnergyUseLevel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_AppEnergyUseLevel([NativeTypeName("ABI::Windows::ApplicationModel::Background::EnergyUseLevel *")] EnergyUseLevel* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundWorkCostStatics2*, EnergyUseLevel*, int>)(lpVtbl[6]))((IBackgroundWorkCostStatics2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBackgroundWorkCostStatics2.xml' path='doc/member[@name="IBackgroundWorkCostStatics2.get_AppEnergyUsePrediction"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_AppEnergyUsePrediction([NativeTypeName("ABI::Windows::ApplicationModel::Background::EnergyUseLevel *")] EnergyUseLevel* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundWorkCostStatics2*, EnergyUseLevel*, int>)(lpVtbl[7]))((IBackgroundWorkCostStatics2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBackgroundWorkCostStatics2.xml' path='doc/member[@name="IBackgroundWorkCostStatics2.get_AppLastThrottledInStandbyTimestamp"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_AppLastThrottledInStandbyTimestamp([NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundWorkCostStatics2*, WinRTDateTime*, int>)(lpVtbl[8]))((IBackgroundWorkCostStatics2*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_AppEnergyUseLevel([NativeTypeName("ABI::Windows::ApplicationModel::Background::EnergyUseLevel *")] EnergyUseLevel* value);

        [VtblIndex(7)]
        HRESULT get_AppEnergyUsePrediction([NativeTypeName("ABI::Windows::ApplicationModel::Background::EnergyUseLevel *")] EnergyUseLevel* value);

        [VtblIndex(8)]
        HRESULT get_AppLastThrottledInStandbyTimestamp([NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Background::EnergyUseLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EnergyUseLevel*, int> get_AppEnergyUseLevel;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Background::EnergyUseLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EnergyUseLevel*, int> get_AppEnergyUsePrediction;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WinRTDateTime*, int> get_AppLastThrottledInStandbyTimestamp;
    }
}
