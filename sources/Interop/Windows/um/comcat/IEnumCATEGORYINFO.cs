// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/comcat.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0002E011-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IEnumCATEGORYINFO : IUnknown")]
    public unsafe partial struct IEnumCATEGORYINFO
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IEnumCATEGORYINFO*, Guid*, void**, int>)(lpVtbl[0]))((IEnumCATEGORYINFO*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IEnumCATEGORYINFO*, uint>)(lpVtbl[1]))((IEnumCATEGORYINFO*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IEnumCATEGORYINFO*, uint>)(lpVtbl[2]))((IEnumCATEGORYINFO*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Next([NativeTypeName("ULONG")] uint celt, CATEGORYINFO* rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched)
        {
            return ((delegate* unmanaged<IEnumCATEGORYINFO*, uint, CATEGORYINFO*, uint*, int>)(lpVtbl[3]))((IEnumCATEGORYINFO*)Unsafe.AsPointer(ref this), celt, rgelt, pceltFetched);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Skip([NativeTypeName("ULONG")] uint celt)
        {
            return ((delegate* unmanaged<IEnumCATEGORYINFO*, uint, int>)(lpVtbl[4]))((IEnumCATEGORYINFO*)Unsafe.AsPointer(ref this), celt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Reset()
        {
            return ((delegate* unmanaged<IEnumCATEGORYINFO*, int>)(lpVtbl[5]))((IEnumCATEGORYINFO*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Clone(IEnumCATEGORYINFO** ppenum)
        {
            return ((delegate* unmanaged<IEnumCATEGORYINFO*, IEnumCATEGORYINFO**, int>)(lpVtbl[6]))((IEnumCATEGORYINFO*)Unsafe.AsPointer(ref this), ppenum);
        }
    }
}
