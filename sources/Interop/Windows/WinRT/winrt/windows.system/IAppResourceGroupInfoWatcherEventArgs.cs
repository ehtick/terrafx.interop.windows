// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAppResourceGroupInfoWatcherEventArgs.xml' path='doc/member[@name="IAppResourceGroupInfoWatcherEventArgs"]/*' />
[Guid("7A787637-6302-4D2F-BF89-1C12D0B2A6B9")]
[NativeTypeName("struct IAppResourceGroupInfoWatcherEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppResourceGroupInfoWatcherEventArgs : IAppResourceGroupInfoWatcherEventArgs.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppResourceGroupInfoWatcherEventArgs));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppResourceGroupInfoWatcherEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((IAppResourceGroupInfoWatcherEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppResourceGroupInfoWatcherEventArgs*, uint>)(lpVtbl[1]))((IAppResourceGroupInfoWatcherEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppResourceGroupInfoWatcherEventArgs*, uint>)(lpVtbl[2]))((IAppResourceGroupInfoWatcherEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppResourceGroupInfoWatcherEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((IAppResourceGroupInfoWatcherEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppResourceGroupInfoWatcherEventArgs*, HSTRING*, int>)(lpVtbl[4]))((IAppResourceGroupInfoWatcherEventArgs*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppResourceGroupInfoWatcherEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((IAppResourceGroupInfoWatcherEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAppResourceGroupInfoWatcherEventArgs.xml' path='doc/member[@name="IAppResourceGroupInfoWatcherEventArgs.get_AppDiagnosticInfos"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_AppDiagnosticInfos([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CSystem__CAppDiagnosticInfo_t **")] IVectorView<IntPtr>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppResourceGroupInfoWatcherEventArgs*, IVectorView<IntPtr>**, int>)(lpVtbl[6]))((IAppResourceGroupInfoWatcherEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppResourceGroupInfoWatcherEventArgs.xml' path='doc/member[@name="IAppResourceGroupInfoWatcherEventArgs.get_AppResourceGroupInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_AppResourceGroupInfo([NativeTypeName("ABI::Windows::System::IAppResourceGroupInfo **")] IAppResourceGroupInfo** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppResourceGroupInfoWatcherEventArgs*, IAppResourceGroupInfo**, int>)(lpVtbl[7]))((IAppResourceGroupInfoWatcherEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_AppDiagnosticInfos([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CSystem__CAppDiagnosticInfo_t **")] IVectorView<IntPtr>** value);

        [VtblIndex(7)]
        HRESULT get_AppResourceGroupInfo([NativeTypeName("ABI::Windows::System::IAppResourceGroupInfo **")] IAppResourceGroupInfo** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CSystem__CAppDiagnosticInfo_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<IntPtr>**, int> get_AppDiagnosticInfos;

        [NativeTypeName("HRESULT (ABI::Windows::System::IAppResourceGroupInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppResourceGroupInfo**, int> get_AppResourceGroupInfo;
    }
}
