// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.haptics.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISimpleHapticsController.xml' path='doc/member[@name="ISimpleHapticsController"]/*' />
[Guid("3D577EF9-4CEE-11E6-B535-001BDC06AB3B")]
[NativeTypeName("struct ISimpleHapticsController : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISimpleHapticsController : ISimpleHapticsController.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISimpleHapticsController));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISimpleHapticsController*, Guid*, void**, int>)(lpVtbl[0]))((ISimpleHapticsController*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISimpleHapticsController*, uint>)(lpVtbl[1]))((ISimpleHapticsController*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISimpleHapticsController*, uint>)(lpVtbl[2]))((ISimpleHapticsController*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged<ISimpleHapticsController*, uint*, Guid**, int>)(lpVtbl[3]))((ISimpleHapticsController*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ISimpleHapticsController*, HSTRING*, int>)(lpVtbl[4]))((ISimpleHapticsController*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ISimpleHapticsController*, TrustLevel*, int>)(lpVtbl[5]))((ISimpleHapticsController*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISimpleHapticsController.xml' path='doc/member[@name="ISimpleHapticsController.get_Id"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Id(HSTRING* value)
    {
        return ((delegate* unmanaged<ISimpleHapticsController*, HSTRING*, int>)(lpVtbl[6]))((ISimpleHapticsController*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISimpleHapticsController.xml' path='doc/member[@name="ISimpleHapticsController.get_SupportedFeedback"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_SupportedFeedback([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CHaptics__CSimpleHapticsControllerFeedback_t **")] IVectorView<IntPtr>** value)
    {
        return ((delegate* unmanaged<ISimpleHapticsController*, IVectorView<IntPtr>**, int>)(lpVtbl[7]))((ISimpleHapticsController*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISimpleHapticsController.xml' path='doc/member[@name="ISimpleHapticsController.get_IsIntensitySupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_IsIntensitySupported([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<ISimpleHapticsController*, byte*, int>)(lpVtbl[8]))((ISimpleHapticsController*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISimpleHapticsController.xml' path='doc/member[@name="ISimpleHapticsController.get_IsPlayCountSupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_IsPlayCountSupported([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<ISimpleHapticsController*, byte*, int>)(lpVtbl[9]))((ISimpleHapticsController*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISimpleHapticsController.xml' path='doc/member[@name="ISimpleHapticsController.get_IsPlayDurationSupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_IsPlayDurationSupported([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<ISimpleHapticsController*, byte*, int>)(lpVtbl[10]))((ISimpleHapticsController*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISimpleHapticsController.xml' path='doc/member[@name="ISimpleHapticsController.get_IsReplayPauseIntervalSupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_IsReplayPauseIntervalSupported([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<ISimpleHapticsController*, byte*, int>)(lpVtbl[11]))((ISimpleHapticsController*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISimpleHapticsController.xml' path='doc/member[@name="ISimpleHapticsController.StopFeedback"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT StopFeedback()
    {
        return ((delegate* unmanaged<ISimpleHapticsController*, int>)(lpVtbl[12]))((ISimpleHapticsController*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ISimpleHapticsController.xml' path='doc/member[@name="ISimpleHapticsController.SendHapticFeedback"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT SendHapticFeedback([NativeTypeName("ABI::Windows::Devices::Haptics::ISimpleHapticsControllerFeedback *")] ISimpleHapticsControllerFeedback* feedback)
    {
        return ((delegate* unmanaged<ISimpleHapticsController*, ISimpleHapticsControllerFeedback*, int>)(lpVtbl[13]))((ISimpleHapticsController*)Unsafe.AsPointer(ref this), feedback);
    }

    /// <include file='ISimpleHapticsController.xml' path='doc/member[@name="ISimpleHapticsController.SendHapticFeedbackWithIntensity"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT SendHapticFeedbackWithIntensity([NativeTypeName("ABI::Windows::Devices::Haptics::ISimpleHapticsControllerFeedback *")] ISimpleHapticsControllerFeedback* feedback, double intensity)
    {
        return ((delegate* unmanaged<ISimpleHapticsController*, ISimpleHapticsControllerFeedback*, double, int>)(lpVtbl[14]))((ISimpleHapticsController*)Unsafe.AsPointer(ref this), feedback, intensity);
    }

    /// <include file='ISimpleHapticsController.xml' path='doc/member[@name="ISimpleHapticsController.SendHapticFeedbackForDuration"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT SendHapticFeedbackForDuration([NativeTypeName("ABI::Windows::Devices::Haptics::ISimpleHapticsControllerFeedback *")] ISimpleHapticsControllerFeedback* feedback, double intensity, [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan playDuration)
    {
        return ((delegate* unmanaged<ISimpleHapticsController*, ISimpleHapticsControllerFeedback*, double, TimeSpan, int>)(lpVtbl[15]))((ISimpleHapticsController*)Unsafe.AsPointer(ref this), feedback, intensity, playDuration);
    }

    /// <include file='ISimpleHapticsController.xml' path='doc/member[@name="ISimpleHapticsController.SendHapticFeedbackForPlayCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT SendHapticFeedbackForPlayCount([NativeTypeName("ABI::Windows::Devices::Haptics::ISimpleHapticsControllerFeedback *")] ISimpleHapticsControllerFeedback* feedback, double intensity, [NativeTypeName("INT32")] int playCount, [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan replayPauseInterval)
    {
        return ((delegate* unmanaged<ISimpleHapticsController*, ISimpleHapticsControllerFeedback*, double, int, TimeSpan, int>)(lpVtbl[16]))((ISimpleHapticsController*)Unsafe.AsPointer(ref this), feedback, intensity, playCount, replayPauseInterval);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Id(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_SupportedFeedback([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CHaptics__CSimpleHapticsControllerFeedback_t **")] IVectorView<IntPtr>** value);

        [VtblIndex(8)]
        HRESULT get_IsIntensitySupported([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(9)]
        HRESULT get_IsPlayCountSupported([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(10)]
        HRESULT get_IsPlayDurationSupported([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(11)]
        HRESULT get_IsReplayPauseIntervalSupported([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(12)]
        HRESULT StopFeedback();

        [VtblIndex(13)]
        HRESULT SendHapticFeedback([NativeTypeName("ABI::Windows::Devices::Haptics::ISimpleHapticsControllerFeedback *")] ISimpleHapticsControllerFeedback* feedback);

        [VtblIndex(14)]
        HRESULT SendHapticFeedbackWithIntensity([NativeTypeName("ABI::Windows::Devices::Haptics::ISimpleHapticsControllerFeedback *")] ISimpleHapticsControllerFeedback* feedback, double intensity);

        [VtblIndex(15)]
        HRESULT SendHapticFeedbackForDuration([NativeTypeName("ABI::Windows::Devices::Haptics::ISimpleHapticsControllerFeedback *")] ISimpleHapticsControllerFeedback* feedback, double intensity, [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan playDuration);

        [VtblIndex(16)]
        HRESULT SendHapticFeedbackForPlayCount([NativeTypeName("ABI::Windows::Devices::Haptics::ISimpleHapticsControllerFeedback *")] ISimpleHapticsControllerFeedback* feedback, double intensity, [NativeTypeName("INT32")] int playCount, [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan replayPauseInterval);
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Id;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CHaptics__CSimpleHapticsControllerFeedback_t **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IVectorView<IntPtr>**, int> get_SupportedFeedback;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsIntensitySupported;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsPlayCountSupported;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsPlayDurationSupported;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsReplayPauseIntervalSupported;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> StopFeedback;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Haptics::ISimpleHapticsControllerFeedback *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISimpleHapticsControllerFeedback*, int> SendHapticFeedback;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Haptics::ISimpleHapticsControllerFeedback *, DOUBLE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISimpleHapticsControllerFeedback*, double, int> SendHapticFeedbackWithIntensity;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Haptics::ISimpleHapticsControllerFeedback *, DOUBLE, ABI::Windows::Foundation::TimeSpan) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISimpleHapticsControllerFeedback*, double, TimeSpan, int> SendHapticFeedbackForDuration;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Haptics::ISimpleHapticsControllerFeedback *, DOUBLE, INT32, ABI::Windows::Foundation::TimeSpan) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISimpleHapticsControllerFeedback*, double, int, TimeSpan, int> SendHapticFeedbackForPlayCount;
    }
}
