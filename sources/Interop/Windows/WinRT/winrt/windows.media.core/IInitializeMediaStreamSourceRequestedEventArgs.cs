// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IInitializeMediaStreamSourceRequestedEventArgs.xml' path='doc/member[@name="IInitializeMediaStreamSourceRequestedEventArgs"]/*' />
[Guid("25BC45E1-9B08-4C2E-A855-4542F1A75DEB")]
[NativeTypeName("struct IInitializeMediaStreamSourceRequestedEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IInitializeMediaStreamSourceRequestedEventArgs : IInitializeMediaStreamSourceRequestedEventArgs.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IInitializeMediaStreamSourceRequestedEventArgs));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IInitializeMediaStreamSourceRequestedEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((IInitializeMediaStreamSourceRequestedEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IInitializeMediaStreamSourceRequestedEventArgs*, uint>)(lpVtbl[1]))((IInitializeMediaStreamSourceRequestedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IInitializeMediaStreamSourceRequestedEventArgs*, uint>)(lpVtbl[2]))((IInitializeMediaStreamSourceRequestedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IInitializeMediaStreamSourceRequestedEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((IInitializeMediaStreamSourceRequestedEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IInitializeMediaStreamSourceRequestedEventArgs*, HSTRING*, int>)(lpVtbl[4]))((IInitializeMediaStreamSourceRequestedEventArgs*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IInitializeMediaStreamSourceRequestedEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((IInitializeMediaStreamSourceRequestedEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IInitializeMediaStreamSourceRequestedEventArgs.xml' path='doc/member[@name="IInitializeMediaStreamSourceRequestedEventArgs.get_Source"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Source([NativeTypeName("ABI::Windows::Media::Core::IMediaStreamSource **")] IMediaStreamSource** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IInitializeMediaStreamSourceRequestedEventArgs*, IMediaStreamSource**, int>)(lpVtbl[6]))((IInitializeMediaStreamSourceRequestedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IInitializeMediaStreamSourceRequestedEventArgs.xml' path='doc/member[@name="IInitializeMediaStreamSourceRequestedEventArgs.get_RandomAccessStream"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_RandomAccessStream([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream **")] IRandomAccessStream** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IInitializeMediaStreamSourceRequestedEventArgs*, IRandomAccessStream**, int>)(lpVtbl[7]))((IInitializeMediaStreamSourceRequestedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IInitializeMediaStreamSourceRequestedEventArgs.xml' path='doc/member[@name="IInitializeMediaStreamSourceRequestedEventArgs.GetDeferral"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetDeferral([NativeTypeName("ABI::Windows::Foundation::IDeferral **")] IDeferral** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IInitializeMediaStreamSourceRequestedEventArgs*, IDeferral**, int>)(lpVtbl[8]))((IInitializeMediaStreamSourceRequestedEventArgs*)Unsafe.AsPointer(ref this), result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Source([NativeTypeName("ABI::Windows::Media::Core::IMediaStreamSource **")] IMediaStreamSource** value);

        [VtblIndex(7)]
        HRESULT get_RandomAccessStream([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream **")] IRandomAccessStream** value);

        [VtblIndex(8)]
        HRESULT GetDeferral([NativeTypeName("ABI::Windows::Foundation::IDeferral **")] IDeferral** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Core::IMediaStreamSource **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaStreamSource**, int> get_Source;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStream **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRandomAccessStream**, int> get_RandomAccessStream;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IDeferral **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDeferral**, int> GetDeferral;
    }
}
