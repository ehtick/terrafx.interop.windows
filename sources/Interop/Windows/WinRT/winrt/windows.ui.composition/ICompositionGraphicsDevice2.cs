// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICompositionGraphicsDevice2.xml' path='doc/member[@name="ICompositionGraphicsDevice2"]/*' />
[Guid("0FB8BDF6-C0F0-4BCC-9FB8-084982490D7D")]
[NativeTypeName("struct ICompositionGraphicsDevice2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICompositionGraphicsDevice2 : ICompositionGraphicsDevice2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICompositionGraphicsDevice2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionGraphicsDevice2*, Guid*, void**, int>)(lpVtbl[0]))((ICompositionGraphicsDevice2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionGraphicsDevice2*, uint>)(lpVtbl[1]))((ICompositionGraphicsDevice2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionGraphicsDevice2*, uint>)(lpVtbl[2]))((ICompositionGraphicsDevice2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionGraphicsDevice2*, uint*, Guid**, int>)(lpVtbl[3]))((ICompositionGraphicsDevice2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionGraphicsDevice2*, HSTRING*, int>)(lpVtbl[4]))((ICompositionGraphicsDevice2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionGraphicsDevice2*, TrustLevel*, int>)(lpVtbl[5]))((ICompositionGraphicsDevice2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICompositionGraphicsDevice2.xml' path='doc/member[@name="ICompositionGraphicsDevice2.CreateDrawingSurface2"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateDrawingSurface2([NativeTypeName("ABI::Windows::Graphics::SizeInt32")] SizeInt32 sizePixels, [NativeTypeName("ABI::Windows::Graphics::DirectX::DirectXPixelFormat")] DirectXPixelFormat pixelFormat, [NativeTypeName("ABI::Windows::Graphics::DirectX::DirectXAlphaMode")] DirectXAlphaMode alphaMode, [NativeTypeName("ABI::Windows::UI::Composition::ICompositionDrawingSurface **")] ICompositionDrawingSurface** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionGraphicsDevice2*, SizeInt32, DirectXPixelFormat, DirectXAlphaMode, ICompositionDrawingSurface**, int>)(lpVtbl[6]))((ICompositionGraphicsDevice2*)Unsafe.AsPointer(ref this), sizePixels, pixelFormat, alphaMode, result);
    }

    /// <include file='ICompositionGraphicsDevice2.xml' path='doc/member[@name="ICompositionGraphicsDevice2.CreateVirtualDrawingSurface"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateVirtualDrawingSurface([NativeTypeName("ABI::Windows::Graphics::SizeInt32")] SizeInt32 sizePixels, [NativeTypeName("ABI::Windows::Graphics::DirectX::DirectXPixelFormat")] DirectXPixelFormat pixelFormat, [NativeTypeName("ABI::Windows::Graphics::DirectX::DirectXAlphaMode")] DirectXAlphaMode alphaMode, [NativeTypeName("ABI::Windows::UI::Composition::ICompositionVirtualDrawingSurface **")] ICompositionVirtualDrawingSurface** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionGraphicsDevice2*, SizeInt32, DirectXPixelFormat, DirectXAlphaMode, ICompositionVirtualDrawingSurface**, int>)(lpVtbl[7]))((ICompositionGraphicsDevice2*)Unsafe.AsPointer(ref this), sizePixels, pixelFormat, alphaMode, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateDrawingSurface2([NativeTypeName("ABI::Windows::Graphics::SizeInt32")] SizeInt32 sizePixels, [NativeTypeName("ABI::Windows::Graphics::DirectX::DirectXPixelFormat")] DirectXPixelFormat pixelFormat, [NativeTypeName("ABI::Windows::Graphics::DirectX::DirectXAlphaMode")] DirectXAlphaMode alphaMode, [NativeTypeName("ABI::Windows::UI::Composition::ICompositionDrawingSurface **")] ICompositionDrawingSurface** result);

        [VtblIndex(7)]
        HRESULT CreateVirtualDrawingSurface([NativeTypeName("ABI::Windows::Graphics::SizeInt32")] SizeInt32 sizePixels, [NativeTypeName("ABI::Windows::Graphics::DirectX::DirectXPixelFormat")] DirectXPixelFormat pixelFormat, [NativeTypeName("ABI::Windows::Graphics::DirectX::DirectXAlphaMode")] DirectXAlphaMode alphaMode, [NativeTypeName("ABI::Windows::UI::Composition::ICompositionVirtualDrawingSurface **")] ICompositionVirtualDrawingSurface** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::SizeInt32, ABI::Windows::Graphics::DirectX::DirectXPixelFormat, ABI::Windows::Graphics::DirectX::DirectXAlphaMode, ABI::Windows::UI::Composition::ICompositionDrawingSurface **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SizeInt32, DirectXPixelFormat, DirectXAlphaMode, ICompositionDrawingSurface**, int> CreateDrawingSurface2;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::SizeInt32, ABI::Windows::Graphics::DirectX::DirectXPixelFormat, ABI::Windows::Graphics::DirectX::DirectXAlphaMode, ABI::Windows::UI::Composition::ICompositionVirtualDrawingSurface **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SizeInt32, DirectXPixelFormat, DirectXAlphaMode, ICompositionVirtualDrawingSurface**, int> CreateVirtualDrawingSurface;
    }
}
