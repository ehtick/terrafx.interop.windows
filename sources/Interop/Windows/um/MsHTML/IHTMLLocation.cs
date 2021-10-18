// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("163BB1E0-6E00-11CF-837A-48DC04C10000")]
    [NativeTypeName("struct IHTMLLocation : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IHTMLLocation
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLLocation*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLLocation*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLLocation*, uint>)(lpVtbl[1]))((IHTMLLocation*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLLocation*, uint>)(lpVtbl[2]))((IHTMLLocation*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLLocation*, uint*, int>)(lpVtbl[3]))((IHTMLLocation*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLLocation*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLLocation*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLLocation*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLLocation*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLLocation*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLLocation*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int put_href([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLLocation*, ushort*, int>)(lpVtbl[7]))((IHTMLLocation*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int get_href([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLLocation*, ushort**, int>)(lpVtbl[8]))((IHTMLLocation*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int put_protocol([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLLocation*, ushort*, int>)(lpVtbl[9]))((IHTMLLocation*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int get_protocol([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLLocation*, ushort**, int>)(lpVtbl[10]))((IHTMLLocation*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int put_host([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLLocation*, ushort*, int>)(lpVtbl[11]))((IHTMLLocation*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int get_host([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLLocation*, ushort**, int>)(lpVtbl[12]))((IHTMLLocation*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int put_hostname([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLLocation*, ushort*, int>)(lpVtbl[13]))((IHTMLLocation*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int get_hostname([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLLocation*, ushort**, int>)(lpVtbl[14]))((IHTMLLocation*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int put_port([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLLocation*, ushort*, int>)(lpVtbl[15]))((IHTMLLocation*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int get_port([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLLocation*, ushort**, int>)(lpVtbl[16]))((IHTMLLocation*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int put_pathname([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLLocation*, ushort*, int>)(lpVtbl[17]))((IHTMLLocation*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int get_pathname([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLLocation*, ushort**, int>)(lpVtbl[18]))((IHTMLLocation*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int put_search([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLLocation*, ushort*, int>)(lpVtbl[19]))((IHTMLLocation*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int get_search([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLLocation*, ushort**, int>)(lpVtbl[20]))((IHTMLLocation*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int put_hash([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLLocation*, ushort*, int>)(lpVtbl[21]))((IHTMLLocation*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("HRESULT")]
        public int get_hash([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLLocation*, ushort**, int>)(lpVtbl[22]))((IHTMLLocation*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        [return: NativeTypeName("HRESULT")]
        public int reload([NativeTypeName("VARIANT_BOOL")] short flag = 0)
        {
            return ((delegate* unmanaged<IHTMLLocation*, short, int>)(lpVtbl[23]))((IHTMLLocation*)Unsafe.AsPointer(ref this), flag);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        [return: NativeTypeName("HRESULT")]
        public int replace([NativeTypeName("BSTR")] ushort* bstr)
        {
            return ((delegate* unmanaged<IHTMLLocation*, ushort*, int>)(lpVtbl[24]))((IHTMLLocation*)Unsafe.AsPointer(ref this), bstr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        [return: NativeTypeName("HRESULT")]
        public int assign([NativeTypeName("BSTR")] ushort* bstr)
        {
            return ((delegate* unmanaged<IHTMLLocation*, ushort*, int>)(lpVtbl[25]))((IHTMLLocation*)Unsafe.AsPointer(ref this), bstr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        [return: NativeTypeName("HRESULT")]
        public int toString([NativeTypeName("BSTR *")] ushort** @string)
        {
            return ((delegate* unmanaged<IHTMLLocation*, ushort**, int>)(lpVtbl[26]))((IHTMLLocation*)Unsafe.AsPointer(ref this), @string);
        }
    }
}
