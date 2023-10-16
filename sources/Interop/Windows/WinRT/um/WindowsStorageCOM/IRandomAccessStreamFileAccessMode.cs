// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WindowsStorageCOM.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IRandomAccessStreamFileAccessMode.xml' path='doc/member[@name="IRandomAccessStreamFileAccessMode"]/*' />
[Guid("332E5848-2E15-458E-85C4-C911C0C3D6F4")]
[NativeTypeName("struct IRandomAccessStreamFileAccessMode : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct IRandomAccessStreamFileAccessMode : IRandomAccessStreamFileAccessMode.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IRandomAccessStreamFileAccessMode));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IRandomAccessStreamFileAccessMode*, Guid*, void**, int>)(lpVtbl[0]))((IRandomAccessStreamFileAccessMode*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IRandomAccessStreamFileAccessMode*, uint>)(lpVtbl[1]))((IRandomAccessStreamFileAccessMode*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IRandomAccessStreamFileAccessMode*, uint>)(lpVtbl[2]))((IRandomAccessStreamFileAccessMode*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IRandomAccessStreamFileAccessMode.xml' path='doc/member[@name="IRandomAccessStreamFileAccessMode.GetMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetMode([NativeTypeName("DWORD *")] uint* fileAccessMode)
    {
        return ((delegate* unmanaged[MemberFunction]<IRandomAccessStreamFileAccessMode*, uint*, int>)(lpVtbl[3]))((IRandomAccessStreamFileAccessMode*)Unsafe.AsPointer(ref this), fileAccessMode);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetMode([NativeTypeName("DWORD *")] uint* fileAccessMode);
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

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetMode;
    }
}
