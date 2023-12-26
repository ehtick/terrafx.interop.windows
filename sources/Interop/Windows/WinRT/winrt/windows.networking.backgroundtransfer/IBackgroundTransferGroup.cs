// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.backgroundtransfer.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IBackgroundTransferGroup.xml' path='doc/member[@name="IBackgroundTransferGroup"]/*' />
[Guid("D8C3E3E4-6459-4540-85EB-AAA1C8903677")]
[NativeTypeName("struct IBackgroundTransferGroup : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBackgroundTransferGroup : IBackgroundTransferGroup.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBackgroundTransferGroup));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTransferGroup*, Guid*, void**, int>)(lpVtbl[0]))((IBackgroundTransferGroup*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTransferGroup*, uint>)(lpVtbl[1]))((IBackgroundTransferGroup*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTransferGroup*, uint>)(lpVtbl[2]))((IBackgroundTransferGroup*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTransferGroup*, uint*, Guid**, int>)(lpVtbl[3]))((IBackgroundTransferGroup*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTransferGroup*, HSTRING*, int>)(lpVtbl[4]))((IBackgroundTransferGroup*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTransferGroup*, TrustLevel*, int>)(lpVtbl[5]))((IBackgroundTransferGroup*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IBackgroundTransferGroup.xml' path='doc/member[@name="IBackgroundTransferGroup.get_Name"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Name(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTransferGroup*, HSTRING*, int>)(lpVtbl[6]))((IBackgroundTransferGroup*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBackgroundTransferGroup.xml' path='doc/member[@name="IBackgroundTransferGroup.get_TransferBehavior"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_TransferBehavior([NativeTypeName("ABI::Windows::Networking::BackgroundTransfer::BackgroundTransferBehavior *")] BackgroundTransferBehavior* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTransferGroup*, BackgroundTransferBehavior*, int>)(lpVtbl[7]))((IBackgroundTransferGroup*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBackgroundTransferGroup.xml' path='doc/member[@name="IBackgroundTransferGroup.put_TransferBehavior"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_TransferBehavior([NativeTypeName("ABI::Windows::Networking::BackgroundTransfer::BackgroundTransferBehavior")] BackgroundTransferBehavior value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTransferGroup*, BackgroundTransferBehavior, int>)(lpVtbl[8]))((IBackgroundTransferGroup*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Name(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_TransferBehavior([NativeTypeName("ABI::Windows::Networking::BackgroundTransfer::BackgroundTransferBehavior *")] BackgroundTransferBehavior* value);

        [VtblIndex(8)]
        HRESULT put_TransferBehavior([NativeTypeName("ABI::Windows::Networking::BackgroundTransfer::BackgroundTransferBehavior")] BackgroundTransferBehavior value);
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Name;

        [NativeTypeName("HRESULT (ABI::Windows::Networking::BackgroundTransfer::BackgroundTransferBehavior *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BackgroundTransferBehavior*, int> get_TransferBehavior;

        [NativeTypeName("HRESULT (ABI::Windows::Networking::BackgroundTransfer::BackgroundTransferBehavior) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BackgroundTransferBehavior, int> put_TransferBehavior;
    }
}
