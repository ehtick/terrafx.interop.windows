// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IProcessMemoryReport.xml' path='doc/member[@name="IProcessMemoryReport"]/*' />
[Guid("087305A8-9B70-4782-8741-3A982B6CE5E4")]
[NativeTypeName("struct IProcessMemoryReport : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IProcessMemoryReport : IProcessMemoryReport.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IProcessMemoryReport));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IProcessMemoryReport*, Guid*, void**, int>)(lpVtbl[0]))((IProcessMemoryReport*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IProcessMemoryReport*, uint>)(lpVtbl[1]))((IProcessMemoryReport*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IProcessMemoryReport*, uint>)(lpVtbl[2]))((IProcessMemoryReport*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IProcessMemoryReport*, uint*, Guid**, int>)(lpVtbl[3]))((IProcessMemoryReport*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IProcessMemoryReport*, HSTRING*, int>)(lpVtbl[4]))((IProcessMemoryReport*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IProcessMemoryReport*, TrustLevel*, int>)(lpVtbl[5]))((IProcessMemoryReport*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IProcessMemoryReport.xml' path='doc/member[@name="IProcessMemoryReport.get_PrivateWorkingSetUsage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_PrivateWorkingSetUsage([NativeTypeName("UINT64 *")] ulong* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IProcessMemoryReport*, ulong*, int>)(lpVtbl[6]))((IProcessMemoryReport*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IProcessMemoryReport.xml' path='doc/member[@name="IProcessMemoryReport.get_TotalWorkingSetUsage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_TotalWorkingSetUsage([NativeTypeName("UINT64 *")] ulong* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IProcessMemoryReport*, ulong*, int>)(lpVtbl[7]))((IProcessMemoryReport*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_PrivateWorkingSetUsage([NativeTypeName("UINT64 *")] ulong* value);

        [VtblIndex(7)]
        HRESULT get_TotalWorkingSetUsage([NativeTypeName("UINT64 *")] ulong* value);
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

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong*, int> get_PrivateWorkingSetUsage;

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong*, int> get_TotalWorkingSetUsage;
    }
}
