// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11sdklayers.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX
{
    [SupportedOSPlatform("windows8.0")]
    [Guid("193DACDF-0DB2-4C05-A55C-EF06CAC56FD9")]
    [NativeTypeName("struct ID3D11RefTrackingOptions : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ID3D11RefTrackingOptions : ID3D11RefTrackingOptions.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D11RefTrackingOptions*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11RefTrackingOptions*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D11RefTrackingOptions*, uint>)(lpVtbl[1]))((ID3D11RefTrackingOptions*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3D11RefTrackingOptions*, uint>)(lpVtbl[2]))((ID3D11RefTrackingOptions*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetTrackingOptions(uint uOptions)
        {
            return ((delegate* unmanaged<ID3D11RefTrackingOptions*, uint, int>)(lpVtbl[3]))((ID3D11RefTrackingOptions*)Unsafe.AsPointer(ref this), uOptions);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT SetTrackingOptions(uint uOptions);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11RefTrackingOptions*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11RefTrackingOptions*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11RefTrackingOptions*, uint> Release;

            [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D11RefTrackingOptions*, uint, int> SetTrackingOptions;
        }
    }
}