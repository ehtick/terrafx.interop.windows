// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IOpenSearchSource.xml' path='doc/member[@name="IOpenSearchSource"]/*' />
[Guid("F0EE7333-E6FC-479B-9F25-A860C234A38E")]
[NativeTypeName("struct IOpenSearchSource : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IOpenSearchSource : IOpenSearchSource.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IOpenSearchSource));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IOpenSearchSource*, Guid*, void**, int>)(lpVtbl[0]))((IOpenSearchSource*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IOpenSearchSource*, uint>)(lpVtbl[1]))((IOpenSearchSource*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IOpenSearchSource*, uint>)(lpVtbl[2]))((IOpenSearchSource*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IOpenSearchSource.xml' path='doc/member[@name="IOpenSearchSource.GetResults"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetResults(HWND hwnd, [NativeTypeName("LPCWSTR")] char* pszQuery, [NativeTypeName("DWORD")] uint dwStartIndex, [NativeTypeName("DWORD")] uint dwCount, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged[MemberFunction]<IOpenSearchSource*, HWND, char*, uint, uint, Guid*, void**, int>)(lpVtbl[3]))((IOpenSearchSource*)Unsafe.AsPointer(ref this), hwnd, pszQuery, dwStartIndex, dwCount, riid, ppv);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetResults(HWND hwnd, [NativeTypeName("LPCWSTR")] char* pszQuery, [NativeTypeName("DWORD")] uint dwStartIndex, [NativeTypeName("DWORD")] uint dwCount, [NativeTypeName("const IID &")] Guid* riid, void** ppv);
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

        [NativeTypeName("HRESULT (HWND, LPCWSTR, DWORD, DWORD, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HWND, char*, uint, uint, Guid*, void**, int> GetResults;
    }
}
