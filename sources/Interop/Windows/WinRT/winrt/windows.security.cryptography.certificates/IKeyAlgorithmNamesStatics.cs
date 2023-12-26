// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.cryptography.certificates.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IKeyAlgorithmNamesStatics.xml' path='doc/member[@name="IKeyAlgorithmNamesStatics"]/*' />
[Guid("479065D7-7AC7-4581-8C3B-D07027140448")]
[NativeTypeName("struct IKeyAlgorithmNamesStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IKeyAlgorithmNamesStatics : IKeyAlgorithmNamesStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IKeyAlgorithmNamesStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyAlgorithmNamesStatics*, Guid*, void**, int>)(lpVtbl[0]))((IKeyAlgorithmNamesStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyAlgorithmNamesStatics*, uint>)(lpVtbl[1]))((IKeyAlgorithmNamesStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyAlgorithmNamesStatics*, uint>)(lpVtbl[2]))((IKeyAlgorithmNamesStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyAlgorithmNamesStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IKeyAlgorithmNamesStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyAlgorithmNamesStatics*, HSTRING*, int>)(lpVtbl[4]))((IKeyAlgorithmNamesStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyAlgorithmNamesStatics*, TrustLevel*, int>)(lpVtbl[5]))((IKeyAlgorithmNamesStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IKeyAlgorithmNamesStatics.xml' path='doc/member[@name="IKeyAlgorithmNamesStatics.get_Rsa"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Rsa(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyAlgorithmNamesStatics*, HSTRING*, int>)(lpVtbl[6]))((IKeyAlgorithmNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKeyAlgorithmNamesStatics.xml' path='doc/member[@name="IKeyAlgorithmNamesStatics.get_Dsa"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Dsa(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyAlgorithmNamesStatics*, HSTRING*, int>)(lpVtbl[7]))((IKeyAlgorithmNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKeyAlgorithmNamesStatics.xml' path='doc/member[@name="IKeyAlgorithmNamesStatics.get_Ecdh256"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Ecdh256(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyAlgorithmNamesStatics*, HSTRING*, int>)(lpVtbl[8]))((IKeyAlgorithmNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKeyAlgorithmNamesStatics.xml' path='doc/member[@name="IKeyAlgorithmNamesStatics.get_Ecdh384"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Ecdh384(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyAlgorithmNamesStatics*, HSTRING*, int>)(lpVtbl[9]))((IKeyAlgorithmNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKeyAlgorithmNamesStatics.xml' path='doc/member[@name="IKeyAlgorithmNamesStatics.get_Ecdh521"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Ecdh521(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyAlgorithmNamesStatics*, HSTRING*, int>)(lpVtbl[10]))((IKeyAlgorithmNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKeyAlgorithmNamesStatics.xml' path='doc/member[@name="IKeyAlgorithmNamesStatics.get_Ecdsa256"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Ecdsa256(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyAlgorithmNamesStatics*, HSTRING*, int>)(lpVtbl[11]))((IKeyAlgorithmNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKeyAlgorithmNamesStatics.xml' path='doc/member[@name="IKeyAlgorithmNamesStatics.get_Ecdsa384"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_Ecdsa384(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyAlgorithmNamesStatics*, HSTRING*, int>)(lpVtbl[12]))((IKeyAlgorithmNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKeyAlgorithmNamesStatics.xml' path='doc/member[@name="IKeyAlgorithmNamesStatics.get_Ecdsa521"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_Ecdsa521(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKeyAlgorithmNamesStatics*, HSTRING*, int>)(lpVtbl[13]))((IKeyAlgorithmNamesStatics*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Rsa(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_Dsa(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_Ecdh256(HSTRING* value);

        [VtblIndex(9)]
        HRESULT get_Ecdh384(HSTRING* value);

        [VtblIndex(10)]
        HRESULT get_Ecdh521(HSTRING* value);

        [VtblIndex(11)]
        HRESULT get_Ecdsa256(HSTRING* value);

        [VtblIndex(12)]
        HRESULT get_Ecdsa384(HSTRING* value);

        [VtblIndex(13)]
        HRESULT get_Ecdsa521(HSTRING* value);
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Rsa;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Dsa;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Ecdh256;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Ecdh384;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Ecdh521;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Ecdsa256;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Ecdsa384;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Ecdsa521;
    }
}
