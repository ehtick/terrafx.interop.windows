// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICoreApplicationView3.xml' path='doc/member[@name="ICoreApplicationView3"]/*' />
[Guid("07EBE1B3-A4CF-4550-AB70-B07E85330BC8")]
[NativeTypeName("struct ICoreApplicationView3 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICoreApplicationView3 : ICoreApplicationView3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICoreApplicationView3));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreApplicationView3*, Guid*, void**, int>)(lpVtbl[0]))((ICoreApplicationView3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreApplicationView3*, uint>)(lpVtbl[1]))((ICoreApplicationView3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreApplicationView3*, uint>)(lpVtbl[2]))((ICoreApplicationView3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreApplicationView3*, uint*, Guid**, int>)(lpVtbl[3]))((ICoreApplicationView3*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreApplicationView3*, HSTRING*, int>)(lpVtbl[4]))((ICoreApplicationView3*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreApplicationView3*, TrustLevel*, int>)(lpVtbl[5]))((ICoreApplicationView3*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICoreApplicationView3.xml' path='doc/member[@name="ICoreApplicationView3.get_IsComponent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_IsComponent([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreApplicationView3*, byte*, int>)(lpVtbl[6]))((ICoreApplicationView3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreApplicationView3.xml' path='doc/member[@name="ICoreApplicationView3.get_TitleBar"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_TitleBar([NativeTypeName("ABI::Windows::ApplicationModel::Core::ICoreApplicationViewTitleBar **")] ICoreApplicationViewTitleBar** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreApplicationView3*, ICoreApplicationViewTitleBar**, int>)(lpVtbl[7]))((ICoreApplicationView3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreApplicationView3.xml' path='doc/member[@name="ICoreApplicationView3.add_HostedViewClosing"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT add_HostedViewClosing([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCore__CCoreApplicationView_Windows__CApplicationModel__CCore__CHostedViewClosingEventArgs_t *")] ITypedEventHandler<Pointer<ICoreApplicationView>, Pointer<IHostedViewClosingEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreApplicationView3*, ITypedEventHandler<Pointer<ICoreApplicationView>, Pointer<IHostedViewClosingEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[8]))((ICoreApplicationView3*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='ICoreApplicationView3.xml' path='doc/member[@name="ICoreApplicationView3.remove_HostedViewClosing"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT remove_HostedViewClosing(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreApplicationView3*, EventRegistrationToken, int>)(lpVtbl[9]))((ICoreApplicationView3*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_IsComponent([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT get_TitleBar([NativeTypeName("ABI::Windows::ApplicationModel::Core::ICoreApplicationViewTitleBar **")] ICoreApplicationViewTitleBar** value);

        [VtblIndex(8)]
        HRESULT add_HostedViewClosing([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCore__CCoreApplicationView_Windows__CApplicationModel__CCore__CHostedViewClosingEventArgs_t *")] ITypedEventHandler<Pointer<ICoreApplicationView>, Pointer<IHostedViewClosingEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(9)]
        HRESULT remove_HostedViewClosing(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsComponent;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Core::ICoreApplicationViewTitleBar **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICoreApplicationViewTitleBar**, int> get_TitleBar;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCore__CCoreApplicationView_Windows__CApplicationModel__CCore__CHostedViewClosingEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<ICoreApplicationView>, Pointer<IHostedViewClosingEventArgs>>*, EventRegistrationToken*, int> add_HostedViewClosing;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_HostedViewClosing;
    }
}
