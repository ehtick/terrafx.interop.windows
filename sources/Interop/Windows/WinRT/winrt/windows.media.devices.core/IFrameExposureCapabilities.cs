// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.devices.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IFrameExposureCapabilities.xml' path='doc/member[@name="IFrameExposureCapabilities"]/*' />
[Guid("BDBE9CE3-3985-4E72-97C2-0590D61307A1")]
[NativeTypeName("struct IFrameExposureCapabilities : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IFrameExposureCapabilities : IFrameExposureCapabilities.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IFrameExposureCapabilities));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IFrameExposureCapabilities*, Guid*, void**, int>)(lpVtbl[0]))((IFrameExposureCapabilities*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IFrameExposureCapabilities*, uint>)(lpVtbl[1]))((IFrameExposureCapabilities*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IFrameExposureCapabilities*, uint>)(lpVtbl[2]))((IFrameExposureCapabilities*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IFrameExposureCapabilities*, uint*, Guid**, int>)(lpVtbl[3]))((IFrameExposureCapabilities*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IFrameExposureCapabilities*, HSTRING*, int>)(lpVtbl[4]))((IFrameExposureCapabilities*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IFrameExposureCapabilities*, TrustLevel*, int>)(lpVtbl[5]))((IFrameExposureCapabilities*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IFrameExposureCapabilities.xml' path='doc/member[@name="IFrameExposureCapabilities.get_Supported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Supported([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFrameExposureCapabilities*, byte*, int>)(lpVtbl[6]))((IFrameExposureCapabilities*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFrameExposureCapabilities.xml' path='doc/member[@name="IFrameExposureCapabilities.get_Min"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Min([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFrameExposureCapabilities*, TimeSpan*, int>)(lpVtbl[7]))((IFrameExposureCapabilities*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFrameExposureCapabilities.xml' path='doc/member[@name="IFrameExposureCapabilities.get_Max"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Max([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFrameExposureCapabilities*, TimeSpan*, int>)(lpVtbl[8]))((IFrameExposureCapabilities*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFrameExposureCapabilities.xml' path='doc/member[@name="IFrameExposureCapabilities.get_Step"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Step([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFrameExposureCapabilities*, TimeSpan*, int>)(lpVtbl[9]))((IFrameExposureCapabilities*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Supported([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT get_Min([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value);

        [VtblIndex(8)]
        HRESULT get_Max([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value);

        [VtblIndex(9)]
        HRESULT get_Step([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value);
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

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_Supported;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan*, int> get_Min;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan*, int> get_Max;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan*, int> get_Step;
    }
}
