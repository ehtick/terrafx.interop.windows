// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.printers.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPrint3DDeviceStatics.xml' path='doc/member[@name="IPrint3DDeviceStatics"]/*' />
[Guid("FDE3620A-67CD-41B7-A344-5150A1FD75B5")]
[NativeTypeName("struct IPrint3DDeviceStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPrint3DDeviceStatics : IPrint3DDeviceStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPrint3DDeviceStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrint3DDeviceStatics*, Guid*, void**, int>)(lpVtbl[0]))((IPrint3DDeviceStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrint3DDeviceStatics*, uint>)(lpVtbl[1]))((IPrint3DDeviceStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrint3DDeviceStatics*, uint>)(lpVtbl[2]))((IPrint3DDeviceStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrint3DDeviceStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IPrint3DDeviceStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrint3DDeviceStatics*, HSTRING*, int>)(lpVtbl[4]))((IPrint3DDeviceStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrint3DDeviceStatics*, TrustLevel*, int>)(lpVtbl[5]))((IPrint3DDeviceStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPrint3DDeviceStatics.xml' path='doc/member[@name="IPrint3DDeviceStatics.FromIdAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT FromIdAsync(HSTRING deviceId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CPrinters__CPrint3DDevice_t **")] IAsyncOperation<Pointer<IPrint3DDevice>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrint3DDeviceStatics*, HSTRING, IAsyncOperation<Pointer<IPrint3DDevice>>**, int>)(lpVtbl[6]))((IPrint3DDeviceStatics*)Unsafe.AsPointer(ref this), deviceId, operation);
    }

    /// <include file='IPrint3DDeviceStatics.xml' path='doc/member[@name="IPrint3DDeviceStatics.GetDeviceSelector"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDeviceSelector(HSTRING* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrint3DDeviceStatics*, HSTRING*, int>)(lpVtbl[7]))((IPrint3DDeviceStatics*)Unsafe.AsPointer(ref this), result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT FromIdAsync(HSTRING deviceId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CPrinters__CPrint3DDevice_t **")] IAsyncOperation<Pointer<IPrint3DDevice>>** operation);

        [VtblIndex(7)]
        HRESULT GetDeviceSelector(HSTRING* result);
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

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CPrinters__CPrint3DDevice_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<Pointer<IPrint3DDevice>>**, int> FromIdAsync;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> GetDeviceSelector;
    }
}
