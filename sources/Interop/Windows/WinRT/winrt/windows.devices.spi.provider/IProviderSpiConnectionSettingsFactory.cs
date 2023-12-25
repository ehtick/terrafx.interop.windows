// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.spi.provider.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IProviderSpiConnectionSettingsFactory.xml' path='doc/member[@name="IProviderSpiConnectionSettingsFactory"]/*' />
[Guid("66456B5A-0C79-43E3-9F3C-E59780AC18FA")]
[NativeTypeName("struct IProviderSpiConnectionSettingsFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IProviderSpiConnectionSettingsFactory : IProviderSpiConnectionSettingsFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IProviderSpiConnectionSettingsFactory));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IProviderSpiConnectionSettingsFactory*, Guid*, void**, int>)(lpVtbl[0]))((IProviderSpiConnectionSettingsFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IProviderSpiConnectionSettingsFactory*, uint>)(lpVtbl[1]))((IProviderSpiConnectionSettingsFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IProviderSpiConnectionSettingsFactory*, uint>)(lpVtbl[2]))((IProviderSpiConnectionSettingsFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IProviderSpiConnectionSettingsFactory*, uint*, Guid**, int>)(lpVtbl[3]))((IProviderSpiConnectionSettingsFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IProviderSpiConnectionSettingsFactory*, HSTRING*, int>)(lpVtbl[4]))((IProviderSpiConnectionSettingsFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IProviderSpiConnectionSettingsFactory*, TrustLevel*, int>)(lpVtbl[5]))((IProviderSpiConnectionSettingsFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IProviderSpiConnectionSettingsFactory.xml' path='doc/member[@name="IProviderSpiConnectionSettingsFactory.Create"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Create([NativeTypeName("INT32")] int chipSelectLine, [NativeTypeName("ABI::Windows::Devices::Spi::Provider::IProviderSpiConnectionSettings **")] IProviderSpiConnectionSettings** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IProviderSpiConnectionSettingsFactory*, int, IProviderSpiConnectionSettings**, int>)(lpVtbl[6]))((IProviderSpiConnectionSettingsFactory*)Unsafe.AsPointer(ref this), chipSelectLine, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Create([NativeTypeName("INT32")] int chipSelectLine, [NativeTypeName("ABI::Windows::Devices::Spi::Provider::IProviderSpiConnectionSettings **")] IProviderSpiConnectionSettings** value);
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

        [NativeTypeName("HRESULT (INT32, ABI::Windows::Devices::Spi::Provider::IProviderSpiConnectionSettings **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, IProviderSpiConnectionSettings**, int> Create;
    }
}
