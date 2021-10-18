// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/IsolatedAppLauncher.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F686878F-7B42-4CC4-96FB-F4F3B6E3D24D")]
    [NativeTypeName("struct IIsolatedAppLauncher : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IIsolatedAppLauncher
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IIsolatedAppLauncher*, Guid*, void**, int>)(lpVtbl[0]))((IIsolatedAppLauncher*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IIsolatedAppLauncher*, uint>)(lpVtbl[1]))((IIsolatedAppLauncher*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IIsolatedAppLauncher*, uint>)(lpVtbl[2]))((IIsolatedAppLauncher*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int Launch([NativeTypeName("LPCWSTR")] ushort* appUserModelId, [NativeTypeName("LPCWSTR")] ushort* arguments, [NativeTypeName("const IsolatedAppLauncherTelemetryParameters *")] IsolatedAppLauncherTelemetryParameters* telemetryParameters)
        {
            return ((delegate* unmanaged<IIsolatedAppLauncher*, ushort*, ushort*, IsolatedAppLauncherTelemetryParameters*, int>)(lpVtbl[3]))((IIsolatedAppLauncher*)Unsafe.AsPointer(ref this), appUserModelId, arguments, telemetryParameters);
        }
    }
}