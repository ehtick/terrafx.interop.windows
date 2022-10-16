// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.haptics.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IKnownSimpleHapticsControllerWaveformsStatics.xml' path='doc/member[@name="IKnownSimpleHapticsControllerWaveformsStatics"]/*' />
[Guid("3D577EF7-4CEE-11E6-B535-001BDC06AB3B")]
[NativeTypeName("struct IKnownSimpleHapticsControllerWaveformsStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IKnownSimpleHapticsControllerWaveformsStatics : IKnownSimpleHapticsControllerWaveformsStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IKnownSimpleHapticsControllerWaveformsStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IKnownSimpleHapticsControllerWaveformsStatics*, Guid*, void**, int>)(lpVtbl[0]))((IKnownSimpleHapticsControllerWaveformsStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IKnownSimpleHapticsControllerWaveformsStatics*, uint>)(lpVtbl[1]))((IKnownSimpleHapticsControllerWaveformsStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IKnownSimpleHapticsControllerWaveformsStatics*, uint>)(lpVtbl[2]))((IKnownSimpleHapticsControllerWaveformsStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged<IKnownSimpleHapticsControllerWaveformsStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IKnownSimpleHapticsControllerWaveformsStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IKnownSimpleHapticsControllerWaveformsStatics*, HSTRING*, int>)(lpVtbl[4]))((IKnownSimpleHapticsControllerWaveformsStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IKnownSimpleHapticsControllerWaveformsStatics*, TrustLevel*, int>)(lpVtbl[5]))((IKnownSimpleHapticsControllerWaveformsStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IKnownSimpleHapticsControllerWaveformsStatics.xml' path='doc/member[@name="IKnownSimpleHapticsControllerWaveformsStatics.get_Click"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Click([NativeTypeName("UINT16 *")] ushort* value)
    {
        return ((delegate* unmanaged<IKnownSimpleHapticsControllerWaveformsStatics*, ushort*, int>)(lpVtbl[6]))((IKnownSimpleHapticsControllerWaveformsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKnownSimpleHapticsControllerWaveformsStatics.xml' path='doc/member[@name="IKnownSimpleHapticsControllerWaveformsStatics.get_BuzzContinuous"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_BuzzContinuous([NativeTypeName("UINT16 *")] ushort* value)
    {
        return ((delegate* unmanaged<IKnownSimpleHapticsControllerWaveformsStatics*, ushort*, int>)(lpVtbl[7]))((IKnownSimpleHapticsControllerWaveformsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKnownSimpleHapticsControllerWaveformsStatics.xml' path='doc/member[@name="IKnownSimpleHapticsControllerWaveformsStatics.get_RumbleContinuous"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_RumbleContinuous([NativeTypeName("UINT16 *")] ushort* value)
    {
        return ((delegate* unmanaged<IKnownSimpleHapticsControllerWaveformsStatics*, ushort*, int>)(lpVtbl[8]))((IKnownSimpleHapticsControllerWaveformsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKnownSimpleHapticsControllerWaveformsStatics.xml' path='doc/member[@name="IKnownSimpleHapticsControllerWaveformsStatics.get_Press"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Press([NativeTypeName("UINT16 *")] ushort* value)
    {
        return ((delegate* unmanaged<IKnownSimpleHapticsControllerWaveformsStatics*, ushort*, int>)(lpVtbl[9]))((IKnownSimpleHapticsControllerWaveformsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKnownSimpleHapticsControllerWaveformsStatics.xml' path='doc/member[@name="IKnownSimpleHapticsControllerWaveformsStatics.get_Release"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Release([NativeTypeName("UINT16 *")] ushort* value)
    {
        return ((delegate* unmanaged<IKnownSimpleHapticsControllerWaveformsStatics*, ushort*, int>)(lpVtbl[10]))((IKnownSimpleHapticsControllerWaveformsStatics*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Click([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(7)]
        HRESULT get_BuzzContinuous([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(8)]
        HRESULT get_RumbleContinuous([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(9)]
        HRESULT get_Press([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(10)]
        HRESULT get_Release([NativeTypeName("UINT16 *")] ushort* value);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, Guid**, int> GetIids;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> GetRuntimeClassName;

        [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TrustLevel*, int> GetTrustLevel;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> get_Click;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> get_BuzzContinuous;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> get_RumbleContinuous;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> get_Press;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> get_Release;
    }
}
