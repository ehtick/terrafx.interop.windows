// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/HolographicSpaceInterop.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.WinRT
{
    [SupportedOSPlatform("windows10.0.15063.0")]
    [Guid("5C4EE536-6A98-4B86-A170-587013D6FD4B")]
    [NativeTypeName("struct IHolographicSpaceInterop : IInspectable")]
    [NativeInheritance("IInspectable")]
    public unsafe partial struct IHolographicSpaceInterop : IHolographicSpaceInterop.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHolographicSpaceInterop*, Guid*, void**, int>)(lpVtbl[0]))((IHolographicSpaceInterop*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHolographicSpaceInterop*, uint>)(lpVtbl[1]))((IHolographicSpaceInterop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHolographicSpaceInterop*, uint>)(lpVtbl[2]))((IHolographicSpaceInterop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IHolographicSpaceInterop*, uint*, Guid**, int>)(lpVtbl[3]))((IHolographicSpaceInterop*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetRuntimeClassName(HSTRING* className)
        {
            return ((delegate* unmanaged<IHolographicSpaceInterop*, HSTRING*, int>)(lpVtbl[4]))((IHolographicSpaceInterop*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetTrustLevel(TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IHolographicSpaceInterop*, TrustLevel*, int>)(lpVtbl[5]))((IHolographicSpaceInterop*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT CreateForWindow(HWND window, [NativeTypeName("const IID &")] Guid* riid, void** holographicSpace)
        {
            return ((delegate* unmanaged<IHolographicSpaceInterop*, HWND, Guid*, void**, int>)(lpVtbl[6]))((IHolographicSpaceInterop*)Unsafe.AsPointer(ref this), window, riid, holographicSpace);
        }

        public interface Interface : IInspectable.Interface
        {
            [VtblIndex(6)]
            HRESULT CreateForWindow(HWND window, [NativeTypeName("const IID &")] Guid* riid, void** holographicSpace);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IHolographicSpaceInterop*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IHolographicSpaceInterop*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IHolographicSpaceInterop*, uint> Release;

            [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
            public delegate* unmanaged<IHolographicSpaceInterop*, uint*, Guid**, int> GetIids;

            [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHolographicSpaceInterop*, HSTRING*, int> GetRuntimeClassName;

            [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHolographicSpaceInterop*, TrustLevel*, int> GetTrustLevel;

            [NativeTypeName("HRESULT (HWND, const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IHolographicSpaceInterop*, HWND, Guid*, void**, int> CreateForWindow;
        }
    }
}