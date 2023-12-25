// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.activation.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IFileActivatedEventArgsWithCallerPackageFamilyName.xml' path='doc/member[@name="IFileActivatedEventArgsWithCallerPackageFamilyName"]/*' />
[Guid("2D60F06B-D25F-4D25-8653-E1C5E1108309")]
[NativeTypeName("struct IFileActivatedEventArgsWithCallerPackageFamilyName : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IFileActivatedEventArgsWithCallerPackageFamilyName : IFileActivatedEventArgsWithCallerPackageFamilyName.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IFileActivatedEventArgsWithCallerPackageFamilyName));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileActivatedEventArgsWithCallerPackageFamilyName*, Guid*, void**, int>)(lpVtbl[0]))((IFileActivatedEventArgsWithCallerPackageFamilyName*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IFileActivatedEventArgsWithCallerPackageFamilyName*, uint>)(lpVtbl[1]))((IFileActivatedEventArgsWithCallerPackageFamilyName*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IFileActivatedEventArgsWithCallerPackageFamilyName*, uint>)(lpVtbl[2]))((IFileActivatedEventArgsWithCallerPackageFamilyName*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileActivatedEventArgsWithCallerPackageFamilyName*, uint*, Guid**, int>)(lpVtbl[3]))((IFileActivatedEventArgsWithCallerPackageFamilyName*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileActivatedEventArgsWithCallerPackageFamilyName*, HSTRING*, int>)(lpVtbl[4]))((IFileActivatedEventArgsWithCallerPackageFamilyName*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileActivatedEventArgsWithCallerPackageFamilyName*, TrustLevel*, int>)(lpVtbl[5]))((IFileActivatedEventArgsWithCallerPackageFamilyName*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IFileActivatedEventArgsWithCallerPackageFamilyName.xml' path='doc/member[@name="IFileActivatedEventArgsWithCallerPackageFamilyName.get_CallerPackageFamilyName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_CallerPackageFamilyName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileActivatedEventArgsWithCallerPackageFamilyName*, HSTRING*, int>)(lpVtbl[6]))((IFileActivatedEventArgsWithCallerPackageFamilyName*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_CallerPackageFamilyName(HSTRING* value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_CallerPackageFamilyName;
    }
}
