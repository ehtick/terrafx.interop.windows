// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("305104FB-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct ISVGAnimatedPreserveAspectRatio : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct ISVGAnimatedPreserveAspectRatio : ISVGAnimatedPreserveAspectRatio.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISVGAnimatedPreserveAspectRatio*, Guid*, void**, int>)(lpVtbl[0]))((ISVGAnimatedPreserveAspectRatio*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISVGAnimatedPreserveAspectRatio*, uint>)(lpVtbl[1]))((ISVGAnimatedPreserveAspectRatio*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISVGAnimatedPreserveAspectRatio*, uint>)(lpVtbl[2]))((ISVGAnimatedPreserveAspectRatio*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount(uint* pctinfo)
        {
            return ((delegate* unmanaged<ISVGAnimatedPreserveAspectRatio*, uint*, int>)(lpVtbl[3]))((ISVGAnimatedPreserveAspectRatio*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<ISVGAnimatedPreserveAspectRatio*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISVGAnimatedPreserveAspectRatio*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<ISVGAnimatedPreserveAspectRatio*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISVGAnimatedPreserveAspectRatio*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return ((delegate* unmanaged<ISVGAnimatedPreserveAspectRatio*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISVGAnimatedPreserveAspectRatio*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT putref_baseVal(ISVGPreserveAspectRatio* v)
        {
            return ((delegate* unmanaged<ISVGAnimatedPreserveAspectRatio*, ISVGPreserveAspectRatio*, int>)(lpVtbl[7]))((ISVGAnimatedPreserveAspectRatio*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_baseVal(ISVGPreserveAspectRatio** p)
        {
            return ((delegate* unmanaged<ISVGAnimatedPreserveAspectRatio*, ISVGPreserveAspectRatio**, int>)(lpVtbl[8]))((ISVGAnimatedPreserveAspectRatio*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT putref_animVal(ISVGPreserveAspectRatio* v)
        {
            return ((delegate* unmanaged<ISVGAnimatedPreserveAspectRatio*, ISVGPreserveAspectRatio*, int>)(lpVtbl[9]))((ISVGAnimatedPreserveAspectRatio*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT get_animVal(ISVGPreserveAspectRatio** p)
        {
            return ((delegate* unmanaged<ISVGAnimatedPreserveAspectRatio*, ISVGPreserveAspectRatio**, int>)(lpVtbl[10]))((ISVGAnimatedPreserveAspectRatio*)Unsafe.AsPointer(ref this), p);
        }

        public interface Interface : IDispatch.Interface
        {
            [VtblIndex(7)]
            HRESULT putref_baseVal(ISVGPreserveAspectRatio* v);

            [VtblIndex(8)]
            HRESULT get_baseVal(ISVGPreserveAspectRatio** p);

            [VtblIndex(9)]
            HRESULT putref_animVal(ISVGPreserveAspectRatio* v);

            [VtblIndex(10)]
            HRESULT get_animVal(ISVGPreserveAspectRatio** p);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGAnimatedPreserveAspectRatio*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGAnimatedPreserveAspectRatio*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGAnimatedPreserveAspectRatio*, uint> Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGAnimatedPreserveAspectRatio*, uint*, int> GetTypeInfoCount;

            [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGAnimatedPreserveAspectRatio*, uint, uint, ITypeInfo**, int> GetTypeInfo;

            [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGAnimatedPreserveAspectRatio*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

            [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGAnimatedPreserveAspectRatio*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;

            [NativeTypeName("HRESULT (ISVGPreserveAspectRatio *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGAnimatedPreserveAspectRatio*, ISVGPreserveAspectRatio*, int> putref_baseVal;

            [NativeTypeName("HRESULT (ISVGPreserveAspectRatio **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGAnimatedPreserveAspectRatio*, ISVGPreserveAspectRatio**, int> get_baseVal;

            [NativeTypeName("HRESULT (ISVGPreserveAspectRatio *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGAnimatedPreserveAspectRatio*, ISVGPreserveAspectRatio*, int> putref_animVal;

            [NativeTypeName("HRESULT (ISVGPreserveAspectRatio **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISVGAnimatedPreserveAspectRatio*, ISVGPreserveAspectRatio**, int> get_animVal;
        }
    }
}