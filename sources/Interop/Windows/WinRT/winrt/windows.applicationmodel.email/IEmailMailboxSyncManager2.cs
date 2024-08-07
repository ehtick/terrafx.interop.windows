// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.email.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IEmailMailboxSyncManager2.xml' path='doc/member[@name="IEmailMailboxSyncManager2"]/*' />
[Guid("CD8DC97E-95C1-4F89-81B7-E6AECB6695FC")]
[NativeTypeName("struct IEmailMailboxSyncManager2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IEmailMailboxSyncManager2 : IEmailMailboxSyncManager2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IEmailMailboxSyncManager2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxSyncManager2*, Guid*, void**, int>)(lpVtbl[0]))((IEmailMailboxSyncManager2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxSyncManager2*, uint>)(lpVtbl[1]))((IEmailMailboxSyncManager2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxSyncManager2*, uint>)(lpVtbl[2]))((IEmailMailboxSyncManager2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxSyncManager2*, uint*, Guid**, int>)(lpVtbl[3]))((IEmailMailboxSyncManager2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxSyncManager2*, HSTRING*, int>)(lpVtbl[4]))((IEmailMailboxSyncManager2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxSyncManager2*, TrustLevel*, int>)(lpVtbl[5]))((IEmailMailboxSyncManager2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IEmailMailboxSyncManager2.xml' path='doc/member[@name="IEmailMailboxSyncManager2.put_Status"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT put_Status([NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailMailboxSyncStatus")] EmailMailboxSyncStatus value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxSyncManager2*, EmailMailboxSyncStatus, int>)(lpVtbl[6]))((IEmailMailboxSyncManager2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMailboxSyncManager2.xml' path='doc/member[@name="IEmailMailboxSyncManager2.put_LastSuccessfulSyncTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_LastSuccessfulSyncTime([NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxSyncManager2*, WinRTDateTime, int>)(lpVtbl[7]))((IEmailMailboxSyncManager2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMailboxSyncManager2.xml' path='doc/member[@name="IEmailMailboxSyncManager2.put_LastAttemptedSyncTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_LastAttemptedSyncTime([NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxSyncManager2*, WinRTDateTime, int>)(lpVtbl[8]))((IEmailMailboxSyncManager2*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT put_Status([NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailMailboxSyncStatus")] EmailMailboxSyncStatus value);

        [VtblIndex(7)]
        HRESULT put_LastSuccessfulSyncTime([NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime value);

        [VtblIndex(8)]
        HRESULT put_LastAttemptedSyncTime([NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime value);
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

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Email::EmailMailboxSyncStatus) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EmailMailboxSyncStatus, int> put_Status;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WinRTDateTime, int> put_LastSuccessfulSyncTime;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WinRTDateTime, int> put_LastAttemptedSyncTime;
    }
}
