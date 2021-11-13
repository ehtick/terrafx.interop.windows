// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("00020404-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IEnumVARIANT : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IEnumVARIANT : IEnumVARIANT.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IEnumVARIANT*, Guid*, void**, int>)(lpVtbl[0]))((IEnumVARIANT*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IEnumVARIANT*, uint>)(lpVtbl[1]))((IEnumVARIANT*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IEnumVARIANT*, uint>)(lpVtbl[2]))((IEnumVARIANT*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Next([NativeTypeName("ULONG")] uint celt, VARIANT* rgVar, [NativeTypeName("ULONG *")] uint* pCeltFetched)
        {
            return ((delegate* unmanaged<IEnumVARIANT*, uint, VARIANT*, uint*, int>)(lpVtbl[3]))((IEnumVARIANT*)Unsafe.AsPointer(ref this), celt, rgVar, pCeltFetched);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT Skip([NativeTypeName("ULONG")] uint celt)
        {
            return ((delegate* unmanaged<IEnumVARIANT*, uint, int>)(lpVtbl[4]))((IEnumVARIANT*)Unsafe.AsPointer(ref this), celt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT Reset()
        {
            return ((delegate* unmanaged<IEnumVARIANT*, int>)(lpVtbl[5]))((IEnumVARIANT*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Clone(IEnumVARIANT** ppEnum)
        {
            return ((delegate* unmanaged<IEnumVARIANT*, IEnumVARIANT**, int>)(lpVtbl[6]))((IEnumVARIANT*)Unsafe.AsPointer(ref this), ppEnum);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT Next([NativeTypeName("ULONG")] uint celt, VARIANT* rgVar, [NativeTypeName("ULONG *")] uint* pCeltFetched);

            [VtblIndex(4)]
            HRESULT Skip([NativeTypeName("ULONG")] uint celt);

            [VtblIndex(5)]
            HRESULT Reset();

            [VtblIndex(6)]
            HRESULT Clone(IEnumVARIANT** ppEnum);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IEnumVARIANT*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IEnumVARIANT*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IEnumVARIANT*, uint> Release;

            [NativeTypeName("HRESULT (ULONG, VARIANT *, ULONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IEnumVARIANT*, uint, VARIANT*, uint*, int> Next;

            [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
            public delegate* unmanaged<IEnumVARIANT*, uint, int> Skip;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IEnumVARIANT*, int> Reset;

            [NativeTypeName("HRESULT (IEnumVARIANT **) __attribute__((stdcall))")]
            public delegate* unmanaged<IEnumVARIANT*, IEnumVARIANT**, int> Clone;
        }
    }
}