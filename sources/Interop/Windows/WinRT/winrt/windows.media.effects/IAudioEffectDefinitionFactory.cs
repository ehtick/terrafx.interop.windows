// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.effects.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAudioEffectDefinitionFactory.xml' path='doc/member[@name="IAudioEffectDefinitionFactory"]/*' />
[Guid("8E1DA646-E705-45ED-8A2B-FC4E4F405A97")]
[NativeTypeName("struct IAudioEffectDefinitionFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAudioEffectDefinitionFactory : IAudioEffectDefinitionFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAudioEffectDefinitionFactory));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioEffectDefinitionFactory*, Guid*, void**, int>)(lpVtbl[0]))((IAudioEffectDefinitionFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioEffectDefinitionFactory*, uint>)(lpVtbl[1]))((IAudioEffectDefinitionFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioEffectDefinitionFactory*, uint>)(lpVtbl[2]))((IAudioEffectDefinitionFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioEffectDefinitionFactory*, uint*, Guid**, int>)(lpVtbl[3]))((IAudioEffectDefinitionFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioEffectDefinitionFactory*, HSTRING*, int>)(lpVtbl[4]))((IAudioEffectDefinitionFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioEffectDefinitionFactory*, TrustLevel*, int>)(lpVtbl[5]))((IAudioEffectDefinitionFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAudioEffectDefinitionFactory.xml' path='doc/member[@name="IAudioEffectDefinitionFactory.Create"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Create(HSTRING activatableClassId, [NativeTypeName("ABI::Windows::Media::Effects::IAudioEffectDefinition **")] IAudioEffectDefinition** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioEffectDefinitionFactory*, HSTRING, IAudioEffectDefinition**, int>)(lpVtbl[6]))((IAudioEffectDefinitionFactory*)Unsafe.AsPointer(ref this), activatableClassId, value);
    }

    /// <include file='IAudioEffectDefinitionFactory.xml' path='doc/member[@name="IAudioEffectDefinitionFactory.CreateWithProperties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateWithProperties(HSTRING activatableClassId, [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")] IPropertySet* props, [NativeTypeName("ABI::Windows::Media::Effects::IAudioEffectDefinition **")] IAudioEffectDefinition** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioEffectDefinitionFactory*, HSTRING, IPropertySet*, IAudioEffectDefinition**, int>)(lpVtbl[7]))((IAudioEffectDefinitionFactory*)Unsafe.AsPointer(ref this), activatableClassId, props, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Create(HSTRING activatableClassId, [NativeTypeName("ABI::Windows::Media::Effects::IAudioEffectDefinition **")] IAudioEffectDefinition** value);

        [VtblIndex(7)]
        HRESULT CreateWithProperties(HSTRING activatableClassId, [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")] IPropertySet* props, [NativeTypeName("ABI::Windows::Media::Effects::IAudioEffectDefinition **")] IAudioEffectDefinition** value);
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

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Media::Effects::IAudioEffectDefinition **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAudioEffectDefinition**, int> Create;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::Collections::IPropertySet *, ABI::Windows::Media::Effects::IAudioEffectDefinition **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IPropertySet*, IAudioEffectDefinition**, int> CreateWithProperties;
    }
}
