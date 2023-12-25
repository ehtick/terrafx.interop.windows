// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.input.core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IRadialControllerIndependentInputSource.xml' path='doc/member[@name="IRadialControllerIndependentInputSource"]/*' />
[Guid("3D577EF6-4CEE-11E6-B535-001BDC06AB3B")]
[NativeTypeName("struct IRadialControllerIndependentInputSource : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IRadialControllerIndependentInputSource : IRadialControllerIndependentInputSource.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IRadialControllerIndependentInputSource));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialControllerIndependentInputSource*, Guid*, void**, int>)(lpVtbl[0]))((IRadialControllerIndependentInputSource*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialControllerIndependentInputSource*, uint>)(lpVtbl[1]))((IRadialControllerIndependentInputSource*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialControllerIndependentInputSource*, uint>)(lpVtbl[2]))((IRadialControllerIndependentInputSource*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialControllerIndependentInputSource*, uint*, Guid**, int>)(lpVtbl[3]))((IRadialControllerIndependentInputSource*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialControllerIndependentInputSource*, HSTRING*, int>)(lpVtbl[4]))((IRadialControllerIndependentInputSource*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialControllerIndependentInputSource*, TrustLevel*, int>)(lpVtbl[5]))((IRadialControllerIndependentInputSource*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IRadialControllerIndependentInputSource.xml' path='doc/member[@name="IRadialControllerIndependentInputSource.get_Controller"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Controller([NativeTypeName("ABI::Windows::UI::Input::IRadialController **")] IRadialController** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialControllerIndependentInputSource*, IRadialController**, int>)(lpVtbl[6]))((IRadialControllerIndependentInputSource*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRadialControllerIndependentInputSource.xml' path='doc/member[@name="IRadialControllerIndependentInputSource.get_Dispatcher"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Dispatcher([NativeTypeName("ABI::Windows::UI::Core::ICoreDispatcher **")] ICoreDispatcher** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialControllerIndependentInputSource*, ICoreDispatcher**, int>)(lpVtbl[7]))((IRadialControllerIndependentInputSource*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Controller([NativeTypeName("ABI::Windows::UI::Input::IRadialController **")] IRadialController** value);

        [VtblIndex(7)]
        HRESULT get_Dispatcher([NativeTypeName("ABI::Windows::UI::Core::ICoreDispatcher **")] ICoreDispatcher** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::UI::Input::IRadialController **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRadialController**, int> get_Controller;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Core::ICoreDispatcher **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICoreDispatcher**, int> get_Dispatcher;
    }
}
