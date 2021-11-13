// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ctffunc.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("3527268B-7D53-4DD9-92B7-7296AE461249")]
    [NativeTypeName("struct ITfFnAdviseText : ITfFunction")]
    [NativeInheritance("ITfFunction")]
    public unsafe partial struct ITfFnAdviseText : ITfFnAdviseText.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfFnAdviseText*, Guid*, void**, int>)(lpVtbl[0]))((ITfFnAdviseText*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfFnAdviseText*, uint>)(lpVtbl[1]))((ITfFnAdviseText*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfFnAdviseText*, uint>)(lpVtbl[2]))((ITfFnAdviseText*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetDisplayName([NativeTypeName("BSTR *")] ushort** pbstrName)
        {
            return ((delegate* unmanaged<ITfFnAdviseText*, ushort**, int>)(lpVtbl[3]))((ITfFnAdviseText*)Unsafe.AsPointer(ref this), pbstrName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT OnTextUpdate(ITfRange* pRange, [NativeTypeName("const WCHAR *")] ushort* pchText, [NativeTypeName("LONG")] int cch)
        {
            return ((delegate* unmanaged<ITfFnAdviseText*, ITfRange*, ushort*, int, int>)(lpVtbl[4]))((ITfFnAdviseText*)Unsafe.AsPointer(ref this), pRange, pchText, cch);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT OnLatticeUpdate(ITfRange* pRange, ITfLMLattice* pLattice)
        {
            return ((delegate* unmanaged<ITfFnAdviseText*, ITfRange*, ITfLMLattice*, int>)(lpVtbl[5]))((ITfFnAdviseText*)Unsafe.AsPointer(ref this), pRange, pLattice);
        }

        public interface Interface : ITfFunction.Interface
        {
            [VtblIndex(4)]
            HRESULT OnTextUpdate(ITfRange* pRange, [NativeTypeName("const WCHAR *")] ushort* pchText, [NativeTypeName("LONG")] int cch);

            [VtblIndex(5)]
            HRESULT OnLatticeUpdate(ITfRange* pRange, ITfLMLattice* pLattice);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfFnAdviseText*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ITfFnAdviseText*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ITfFnAdviseText*, uint> Release;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfFnAdviseText*, ushort**, int> GetDisplayName;

            [NativeTypeName("HRESULT (ITfRange *, const WCHAR *, LONG) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfFnAdviseText*, ITfRange*, ushort*, int, int> OnTextUpdate;

            [NativeTypeName("HRESULT (ITfRange *, ITfLMLattice *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfFnAdviseText*, ITfRange*, ITfLMLattice*, int> OnLatticeUpdate;
        }
    }
}