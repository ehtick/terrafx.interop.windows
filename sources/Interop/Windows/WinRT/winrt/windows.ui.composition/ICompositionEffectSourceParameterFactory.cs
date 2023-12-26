// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICompositionEffectSourceParameterFactory.xml' path='doc/member[@name="ICompositionEffectSourceParameterFactory"]/*' />
[Guid("B3D9F276-ABA3-4724-ACF3-D0397464DB1C")]
[NativeTypeName("struct ICompositionEffectSourceParameterFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICompositionEffectSourceParameterFactory : ICompositionEffectSourceParameterFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICompositionEffectSourceParameterFactory));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionEffectSourceParameterFactory*, Guid*, void**, int>)(lpVtbl[0]))((ICompositionEffectSourceParameterFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionEffectSourceParameterFactory*, uint>)(lpVtbl[1]))((ICompositionEffectSourceParameterFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionEffectSourceParameterFactory*, uint>)(lpVtbl[2]))((ICompositionEffectSourceParameterFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionEffectSourceParameterFactory*, uint*, Guid**, int>)(lpVtbl[3]))((ICompositionEffectSourceParameterFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionEffectSourceParameterFactory*, HSTRING*, int>)(lpVtbl[4]))((ICompositionEffectSourceParameterFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionEffectSourceParameterFactory*, TrustLevel*, int>)(lpVtbl[5]))((ICompositionEffectSourceParameterFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICompositionEffectSourceParameterFactory.xml' path='doc/member[@name="ICompositionEffectSourceParameterFactory.Create"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Create(HSTRING name, [NativeTypeName("ABI::Windows::UI::Composition::ICompositionEffectSourceParameter **")] ICompositionEffectSourceParameter** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionEffectSourceParameterFactory*, HSTRING, ICompositionEffectSourceParameter**, int>)(lpVtbl[6]))((ICompositionEffectSourceParameterFactory*)Unsafe.AsPointer(ref this), name, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Create(HSTRING name, [NativeTypeName("ABI::Windows::UI::Composition::ICompositionEffectSourceParameter **")] ICompositionEffectSourceParameter** value);
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

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::UI::Composition::ICompositionEffectSourceParameter **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, ICompositionEffectSourceParameter**, int> Create;
    }
}
