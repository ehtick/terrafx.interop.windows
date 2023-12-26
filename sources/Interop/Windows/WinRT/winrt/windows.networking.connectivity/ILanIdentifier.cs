// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.connectivity.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ILanIdentifier.xml' path='doc/member[@name="ILanIdentifier"]/*' />
[Guid("48AA53AA-1108-4546-A6CB-9A74DA4B7BA0")]
[NativeTypeName("struct ILanIdentifier : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ILanIdentifier : ILanIdentifier.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ILanIdentifier));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ILanIdentifier*, Guid*, void**, int>)(lpVtbl[0]))((ILanIdentifier*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ILanIdentifier*, uint>)(lpVtbl[1]))((ILanIdentifier*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ILanIdentifier*, uint>)(lpVtbl[2]))((ILanIdentifier*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ILanIdentifier*, uint*, Guid**, int>)(lpVtbl[3]))((ILanIdentifier*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ILanIdentifier*, HSTRING*, int>)(lpVtbl[4]))((ILanIdentifier*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ILanIdentifier*, TrustLevel*, int>)(lpVtbl[5]))((ILanIdentifier*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ILanIdentifier.xml' path='doc/member[@name="ILanIdentifier.get_InfrastructureId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_InfrastructureId([NativeTypeName("ABI::Windows::Networking::Connectivity::ILanIdentifierData **")] ILanIdentifierData** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ILanIdentifier*, ILanIdentifierData**, int>)(lpVtbl[6]))((ILanIdentifier*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ILanIdentifier.xml' path='doc/member[@name="ILanIdentifier.get_PortId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_PortId([NativeTypeName("ABI::Windows::Networking::Connectivity::ILanIdentifierData **")] ILanIdentifierData** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ILanIdentifier*, ILanIdentifierData**, int>)(lpVtbl[7]))((ILanIdentifier*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ILanIdentifier.xml' path='doc/member[@name="ILanIdentifier.get_NetworkAdapterId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_NetworkAdapterId(Guid* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ILanIdentifier*, Guid*, int>)(lpVtbl[8]))((ILanIdentifier*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_InfrastructureId([NativeTypeName("ABI::Windows::Networking::Connectivity::ILanIdentifierData **")] ILanIdentifierData** value);

        [VtblIndex(7)]
        HRESULT get_PortId([NativeTypeName("ABI::Windows::Networking::Connectivity::ILanIdentifierData **")] ILanIdentifierData** value);

        [VtblIndex(8)]
        HRESULT get_NetworkAdapterId(Guid* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Networking::Connectivity::ILanIdentifierData **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ILanIdentifierData**, int> get_InfrastructureId;

        [NativeTypeName("HRESULT (ABI::Windows::Networking::Connectivity::ILanIdentifierData **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ILanIdentifierData**, int> get_PortId;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> get_NetworkAdapterId;
    }
}
