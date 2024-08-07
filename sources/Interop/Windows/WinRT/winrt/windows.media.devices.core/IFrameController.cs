// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.devices.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IFrameController.xml' path='doc/member[@name="IFrameController"]/*' />
[Guid("C16459D9-BAEF-4052-9177-48AFF2AF7522")]
[NativeTypeName("struct IFrameController : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IFrameController : IFrameController.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IFrameController));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IFrameController*, Guid*, void**, int>)(lpVtbl[0]))((IFrameController*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IFrameController*, uint>)(lpVtbl[1]))((IFrameController*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IFrameController*, uint>)(lpVtbl[2]))((IFrameController*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IFrameController*, uint*, Guid**, int>)(lpVtbl[3]))((IFrameController*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IFrameController*, HSTRING*, int>)(lpVtbl[4]))((IFrameController*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IFrameController*, TrustLevel*, int>)(lpVtbl[5]))((IFrameController*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IFrameController.xml' path='doc/member[@name="IFrameController.get_ExposureControl"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ExposureControl([NativeTypeName("ABI::Windows::Media::Devices::Core::IFrameExposureControl **")] IFrameExposureControl** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFrameController*, IFrameExposureControl**, int>)(lpVtbl[6]))((IFrameController*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFrameController.xml' path='doc/member[@name="IFrameController.get_ExposureCompensationControl"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ExposureCompensationControl([NativeTypeName("ABI::Windows::Media::Devices::Core::IFrameExposureCompensationControl **")] IFrameExposureCompensationControl** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFrameController*, IFrameExposureCompensationControl**, int>)(lpVtbl[7]))((IFrameController*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFrameController.xml' path='doc/member[@name="IFrameController.get_IsoSpeedControl"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_IsoSpeedControl([NativeTypeName("ABI::Windows::Media::Devices::Core::IFrameIsoSpeedControl **")] IFrameIsoSpeedControl** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFrameController*, IFrameIsoSpeedControl**, int>)(lpVtbl[8]))((IFrameController*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFrameController.xml' path='doc/member[@name="IFrameController.get_FocusControl"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_FocusControl([NativeTypeName("ABI::Windows::Media::Devices::Core::IFrameFocusControl **")] IFrameFocusControl** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFrameController*, IFrameFocusControl**, int>)(lpVtbl[9]))((IFrameController*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFrameController.xml' path='doc/member[@name="IFrameController.get_PhotoConfirmationEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_PhotoConfirmationEnabled([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_boolean_t **")] IReference<bool>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFrameController*, IReference<bool>**, int>)(lpVtbl[10]))((IFrameController*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFrameController.xml' path='doc/member[@name="IFrameController.put_PhotoConfirmationEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_PhotoConfirmationEnabled([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_boolean_t *")] IReference<bool>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFrameController*, IReference<bool>*, int>)(lpVtbl[11]))((IFrameController*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ExposureControl([NativeTypeName("ABI::Windows::Media::Devices::Core::IFrameExposureControl **")] IFrameExposureControl** value);

        [VtblIndex(7)]
        HRESULT get_ExposureCompensationControl([NativeTypeName("ABI::Windows::Media::Devices::Core::IFrameExposureCompensationControl **")] IFrameExposureCompensationControl** value);

        [VtblIndex(8)]
        HRESULT get_IsoSpeedControl([NativeTypeName("ABI::Windows::Media::Devices::Core::IFrameIsoSpeedControl **")] IFrameIsoSpeedControl** value);

        [VtblIndex(9)]
        HRESULT get_FocusControl([NativeTypeName("ABI::Windows::Media::Devices::Core::IFrameFocusControl **")] IFrameFocusControl** value);

        [VtblIndex(10)]
        HRESULT get_PhotoConfirmationEnabled([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_boolean_t **")] IReference<bool>** value);

        [VtblIndex(11)]
        HRESULT put_PhotoConfirmationEnabled([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_boolean_t *")] IReference<bool>* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Devices::Core::IFrameExposureControl **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IFrameExposureControl**, int> get_ExposureControl;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Devices::Core::IFrameExposureCompensationControl **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IFrameExposureCompensationControl**, int> get_ExposureCompensationControl;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Devices::Core::IFrameIsoSpeedControl **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IFrameIsoSpeedControl**, int> get_IsoSpeedControl;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Devices::Core::IFrameFocusControl **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IFrameFocusControl**, int> get_FocusControl;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_boolean_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<bool>**, int> get_PhotoConfirmationEnabled;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_boolean_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<bool>*, int> put_PhotoConfirmationEnabled;
    }
}
