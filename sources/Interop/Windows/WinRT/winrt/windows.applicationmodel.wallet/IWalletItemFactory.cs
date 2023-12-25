// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.wallet.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IWalletItemFactory.xml' path='doc/member[@name="IWalletItemFactory"]/*' />
[Guid("53E27470-4F0B-4A3E-99E5-0BBB1EAB38D4")]
[NativeTypeName("struct IWalletItemFactory : IInspectable")]
[NativeInheritance("IInspectable")]
[Obsolete("IWalletItemFactory is deprecated and might not work on all platforms. For more info, see MSDN.")]
public unsafe partial struct IWalletItemFactory : IWalletItemFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWalletItemFactory));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItemFactory*, Guid*, void**, int>)(lpVtbl[0]))((IWalletItemFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItemFactory*, uint>)(lpVtbl[1]))((IWalletItemFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItemFactory*, uint>)(lpVtbl[2]))((IWalletItemFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItemFactory*, uint*, Guid**, int>)(lpVtbl[3]))((IWalletItemFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItemFactory*, HSTRING*, int>)(lpVtbl[4]))((IWalletItemFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItemFactory*, TrustLevel*, int>)(lpVtbl[5]))((IWalletItemFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IWalletItemFactory.xml' path='doc/member[@name="IWalletItemFactory.CreateWalletItem"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [Obsolete("IWalletItemFactory is deprecated and might not work on all platforms. For more info, see MSDN.")]
    public HRESULT CreateWalletItem([NativeTypeName("ABI::Windows::ApplicationModel::Wallet::WalletItemKind")] WalletItemKind kind, HSTRING displayName, [NativeTypeName("ABI::Windows::ApplicationModel::Wallet::IWalletItem **")] IWalletItem** walletItem)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItemFactory*, WalletItemKind, HSTRING, IWalletItem**, int>)(lpVtbl[6]))((IWalletItemFactory*)Unsafe.AsPointer(ref this), kind, displayName, walletItem);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        [Obsolete("IWalletItemFactory is deprecated and might not work on all platforms. For more info, see MSDN.")]
        HRESULT CreateWalletItem([NativeTypeName("ABI::Windows::ApplicationModel::Wallet::WalletItemKind")] WalletItemKind kind, HSTRING displayName, [NativeTypeName("ABI::Windows::ApplicationModel::Wallet::IWalletItem **")] IWalletItem** walletItem);
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

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Wallet::WalletItemKind, HSTRING, ABI::Windows::ApplicationModel::Wallet::IWalletItem **) __attribute__((stdcall))")]
        [Obsolete("IWalletItemFactory is deprecated and might not work on all platforms. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WalletItemKind, HSTRING, IWalletItem**, int> CreateWalletItem;
    }
}
