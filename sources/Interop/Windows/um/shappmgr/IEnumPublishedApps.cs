// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shappmgr.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0B124F8C-91F0-11D1-B8B5-006008059382")]
    [NativeTypeName("struct IEnumPublishedApps : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IEnumPublishedApps
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IEnumPublishedApps*, Guid*, void**, int>)(lpVtbl[0]))((IEnumPublishedApps*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IEnumPublishedApps*, uint>)(lpVtbl[1]))((IEnumPublishedApps*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IEnumPublishedApps*, uint>)(lpVtbl[2]))((IEnumPublishedApps*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int Next(IPublishedApp** pia)
        {
            return ((delegate* unmanaged<IEnumPublishedApps*, IPublishedApp**, int>)(lpVtbl[3]))((IEnumPublishedApps*)Unsafe.AsPointer(ref this), pia);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int Reset()
        {
            return ((delegate* unmanaged<IEnumPublishedApps*, int>)(lpVtbl[4]))((IEnumPublishedApps*)Unsafe.AsPointer(ref this));
        }
    }
}