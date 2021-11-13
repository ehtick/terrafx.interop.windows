// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX
{
    [SupportedOSPlatform("windows10.0.18362.0")]
    [Guid("82BC481C-6B9B-4030-AEDB-7EE3D1DF1E63")]
    [NativeTypeName("struct ID3D12DeviceRemovedExtendedDataSettings : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ID3D12DeviceRemovedExtendedDataSettings : ID3D12DeviceRemovedExtendedDataSettings.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D12DeviceRemovedExtendedDataSettings*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12DeviceRemovedExtendedDataSettings*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D12DeviceRemovedExtendedDataSettings*, uint>)(lpVtbl[1]))((ID3D12DeviceRemovedExtendedDataSettings*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3D12DeviceRemovedExtendedDataSettings*, uint>)(lpVtbl[2]))((ID3D12DeviceRemovedExtendedDataSettings*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public void SetAutoBreadcrumbsEnablement(D3D12_DRED_ENABLEMENT Enablement)
        {
            ((delegate* unmanaged<ID3D12DeviceRemovedExtendedDataSettings*, D3D12_DRED_ENABLEMENT, void>)(lpVtbl[3]))((ID3D12DeviceRemovedExtendedDataSettings*)Unsafe.AsPointer(ref this), Enablement);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public void SetPageFaultEnablement(D3D12_DRED_ENABLEMENT Enablement)
        {
            ((delegate* unmanaged<ID3D12DeviceRemovedExtendedDataSettings*, D3D12_DRED_ENABLEMENT, void>)(lpVtbl[4]))((ID3D12DeviceRemovedExtendedDataSettings*)Unsafe.AsPointer(ref this), Enablement);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public void SetWatsonDumpEnablement(D3D12_DRED_ENABLEMENT Enablement)
        {
            ((delegate* unmanaged<ID3D12DeviceRemovedExtendedDataSettings*, D3D12_DRED_ENABLEMENT, void>)(lpVtbl[5]))((ID3D12DeviceRemovedExtendedDataSettings*)Unsafe.AsPointer(ref this), Enablement);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            void SetAutoBreadcrumbsEnablement(D3D12_DRED_ENABLEMENT Enablement);

            [VtblIndex(4)]
            void SetPageFaultEnablement(D3D12_DRED_ENABLEMENT Enablement);

            [VtblIndex(5)]
            void SetWatsonDumpEnablement(D3D12_DRED_ENABLEMENT Enablement);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D12DeviceRemovedExtendedDataSettings*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D12DeviceRemovedExtendedDataSettings*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D12DeviceRemovedExtendedDataSettings*, uint> Release;

            [NativeTypeName("void (D3D12_DRED_ENABLEMENT) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D12DeviceRemovedExtendedDataSettings*, D3D12_DRED_ENABLEMENT, void> SetAutoBreadcrumbsEnablement;

            [NativeTypeName("void (D3D12_DRED_ENABLEMENT) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D12DeviceRemovedExtendedDataSettings*, D3D12_DRED_ENABLEMENT, void> SetPageFaultEnablement;

            [NativeTypeName("void (D3D12_DRED_ENABLEMENT) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D12DeviceRemovedExtendedDataSettings*, D3D12_DRED_ENABLEMENT, void> SetWatsonDumpEnablement;
        }
    }
}