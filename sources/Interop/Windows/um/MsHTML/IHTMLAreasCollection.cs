// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3050F383-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IHTMLAreasCollection : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IHTMLAreasCollection
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLAreasCollection*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLAreasCollection*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLAreasCollection*, uint>)(lpVtbl[1]))((IHTMLAreasCollection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLAreasCollection*, uint>)(lpVtbl[2]))((IHTMLAreasCollection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLAreasCollection*, uint*, int>)(lpVtbl[3]))((IHTMLAreasCollection*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLAreasCollection*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLAreasCollection*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLAreasCollection*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLAreasCollection*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLAreasCollection*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLAreasCollection*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int put_length([NativeTypeName("long")] int v)
        {
            return ((delegate* unmanaged<IHTMLAreasCollection*, int, int>)(lpVtbl[7]))((IHTMLAreasCollection*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int get_length([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLAreasCollection*, int*, int>)(lpVtbl[8]))((IHTMLAreasCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int get__newEnum(IUnknown** p)
        {
            return ((delegate* unmanaged<IHTMLAreasCollection*, IUnknown**, int>)(lpVtbl[9]))((IHTMLAreasCollection*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int item(VARIANT name, VARIANT index, IDispatch** pdisp)
        {
            return ((delegate* unmanaged<IHTMLAreasCollection*, VARIANT, VARIANT, IDispatch**, int>)(lpVtbl[10]))((IHTMLAreasCollection*)Unsafe.AsPointer(ref this), name, index, pdisp);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int tags(VARIANT tagName, IDispatch** pdisp)
        {
            return ((delegate* unmanaged<IHTMLAreasCollection*, VARIANT, IDispatch**, int>)(lpVtbl[11]))((IHTMLAreasCollection*)Unsafe.AsPointer(ref this), tagName, pdisp);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int add(IHTMLElement* element, VARIANT before)
        {
            return ((delegate* unmanaged<IHTMLAreasCollection*, IHTMLElement*, VARIANT, int>)(lpVtbl[12]))((IHTMLAreasCollection*)Unsafe.AsPointer(ref this), element, before);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int remove([NativeTypeName("long")] int index = -1)
        {
            return ((delegate* unmanaged<IHTMLAreasCollection*, int, int>)(lpVtbl[13]))((IHTMLAreasCollection*)Unsafe.AsPointer(ref this), index);
        }
    }
}
