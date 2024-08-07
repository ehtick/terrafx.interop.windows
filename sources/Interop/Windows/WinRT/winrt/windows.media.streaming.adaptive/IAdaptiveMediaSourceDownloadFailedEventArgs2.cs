// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.streaming.adaptive.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAdaptiveMediaSourceDownloadFailedEventArgs2.xml' path='doc/member[@name="IAdaptiveMediaSourceDownloadFailedEventArgs2"]/*' />
[Guid("70919568-967C-4986-90C5-C6FC4B31E2D8")]
[NativeTypeName("struct IAdaptiveMediaSourceDownloadFailedEventArgs2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAdaptiveMediaSourceDownloadFailedEventArgs2 : IAdaptiveMediaSourceDownloadFailedEventArgs2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAdaptiveMediaSourceDownloadFailedEventArgs2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSourceDownloadFailedEventArgs2*, Guid*, void**, int>)(lpVtbl[0]))((IAdaptiveMediaSourceDownloadFailedEventArgs2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSourceDownloadFailedEventArgs2*, uint>)(lpVtbl[1]))((IAdaptiveMediaSourceDownloadFailedEventArgs2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSourceDownloadFailedEventArgs2*, uint>)(lpVtbl[2]))((IAdaptiveMediaSourceDownloadFailedEventArgs2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSourceDownloadFailedEventArgs2*, uint*, Guid**, int>)(lpVtbl[3]))((IAdaptiveMediaSourceDownloadFailedEventArgs2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSourceDownloadFailedEventArgs2*, HSTRING*, int>)(lpVtbl[4]))((IAdaptiveMediaSourceDownloadFailedEventArgs2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSourceDownloadFailedEventArgs2*, TrustLevel*, int>)(lpVtbl[5]))((IAdaptiveMediaSourceDownloadFailedEventArgs2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAdaptiveMediaSourceDownloadFailedEventArgs2.xml' path='doc/member[@name="IAdaptiveMediaSourceDownloadFailedEventArgs2.get_RequestId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_RequestId([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSourceDownloadFailedEventArgs2*, int*, int>)(lpVtbl[6]))((IAdaptiveMediaSourceDownloadFailedEventArgs2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAdaptiveMediaSourceDownloadFailedEventArgs2.xml' path='doc/member[@name="IAdaptiveMediaSourceDownloadFailedEventArgs2.get_ExtendedError"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ExtendedError(HRESULT* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSourceDownloadFailedEventArgs2*, HRESULT*, int>)(lpVtbl[7]))((IAdaptiveMediaSourceDownloadFailedEventArgs2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAdaptiveMediaSourceDownloadFailedEventArgs2.xml' path='doc/member[@name="IAdaptiveMediaSourceDownloadFailedEventArgs2.get_Statistics"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Statistics([NativeTypeName("ABI::Windows::Media::Streaming::Adaptive::IAdaptiveMediaSourceDownloadStatistics **")] IAdaptiveMediaSourceDownloadStatistics** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSourceDownloadFailedEventArgs2*, IAdaptiveMediaSourceDownloadStatistics**, int>)(lpVtbl[8]))((IAdaptiveMediaSourceDownloadFailedEventArgs2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAdaptiveMediaSourceDownloadFailedEventArgs2.xml' path='doc/member[@name="IAdaptiveMediaSourceDownloadFailedEventArgs2.get_Position"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Position([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **")] IReference<TimeSpan>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSourceDownloadFailedEventArgs2*, IReference<TimeSpan>**, int>)(lpVtbl[9]))((IAdaptiveMediaSourceDownloadFailedEventArgs2*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_RequestId([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(7)]
        HRESULT get_ExtendedError(HRESULT* value);

        [VtblIndex(8)]
        HRESULT get_Statistics([NativeTypeName("ABI::Windows::Media::Streaming::Adaptive::IAdaptiveMediaSourceDownloadStatistics **")] IAdaptiveMediaSourceDownloadStatistics** value);

        [VtblIndex(9)]
        HRESULT get_Position([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **")] IReference<TimeSpan>** value);
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

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_RequestId;

        [NativeTypeName("HRESULT (HRESULT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HRESULT*, int> get_ExtendedError;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Streaming::Adaptive::IAdaptiveMediaSourceDownloadStatistics **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAdaptiveMediaSourceDownloadStatistics**, int> get_Statistics;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<TimeSpan>**, int> get_Position;
    }
}
