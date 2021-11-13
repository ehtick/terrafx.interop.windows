// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("6584CE6B-7D82-49C2-89C9-C6BC02BA8C38")]
    [NativeTypeName("struct IAppVisibilityEvents : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IAppVisibilityEvents : IAppVisibilityEvents.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAppVisibilityEvents*, Guid*, void**, int>)(lpVtbl[0]))((IAppVisibilityEvents*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppVisibilityEvents*, uint>)(lpVtbl[1]))((IAppVisibilityEvents*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppVisibilityEvents*, uint>)(lpVtbl[2]))((IAppVisibilityEvents*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT AppVisibilityOnMonitorChanged(HMONITOR hMonitor, MONITOR_APP_VISIBILITY previousMode, MONITOR_APP_VISIBILITY currentMode)
        {
            return ((delegate* unmanaged<IAppVisibilityEvents*, HMONITOR, MONITOR_APP_VISIBILITY, MONITOR_APP_VISIBILITY, int>)(lpVtbl[3]))((IAppVisibilityEvents*)Unsafe.AsPointer(ref this), hMonitor, previousMode, currentMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT LauncherVisibilityChange(BOOL currentVisibleState)
        {
            return ((delegate* unmanaged<IAppVisibilityEvents*, BOOL, int>)(lpVtbl[4]))((IAppVisibilityEvents*)Unsafe.AsPointer(ref this), currentVisibleState);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT AppVisibilityOnMonitorChanged(HMONITOR hMonitor, MONITOR_APP_VISIBILITY previousMode, MONITOR_APP_VISIBILITY currentMode);

            [VtblIndex(4)]
            HRESULT LauncherVisibilityChange(BOOL currentVisibleState);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IAppVisibilityEvents*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAppVisibilityEvents*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAppVisibilityEvents*, uint> Release;

            [NativeTypeName("HRESULT (HMONITOR, MONITOR_APP_VISIBILITY, MONITOR_APP_VISIBILITY) __attribute__((stdcall))")]
            public delegate* unmanaged<IAppVisibilityEvents*, HMONITOR, MONITOR_APP_VISIBILITY, MONITOR_APP_VISIBILITY, int> AppVisibilityOnMonitorChanged;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IAppVisibilityEvents*, BOOL, int> LauncherVisibilityChange;
        }
    }
}