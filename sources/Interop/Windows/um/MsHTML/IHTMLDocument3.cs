// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3050F485-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IHTMLDocument3 : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IHTMLDocument3
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLDocument3*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLDocument3*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLDocument3*, uint>)(lpVtbl[1]))((IHTMLDocument3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLDocument3*, uint>)(lpVtbl[2]))((IHTMLDocument3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLDocument3*, uint*, int>)(lpVtbl[3]))((IHTMLDocument3*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLDocument3*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLDocument3*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLDocument3*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLDocument3*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLDocument3*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLDocument3*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int releaseCapture()
        {
            return ((delegate* unmanaged<IHTMLDocument3*, int>)(lpVtbl[7]))((IHTMLDocument3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int recalc([NativeTypeName("VARIANT_BOOL")] short fForce = 0)
        {
            return ((delegate* unmanaged<IHTMLDocument3*, short, int>)(lpVtbl[8]))((IHTMLDocument3*)Unsafe.AsPointer(ref this), fForce);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int createTextNode([NativeTypeName("BSTR")] ushort* text, IHTMLDOMNode** newTextNode)
        {
            return ((delegate* unmanaged<IHTMLDocument3*, ushort*, IHTMLDOMNode**, int>)(lpVtbl[9]))((IHTMLDocument3*)Unsafe.AsPointer(ref this), text, newTextNode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int get_documentElement(IHTMLElement** p)
        {
            return ((delegate* unmanaged<IHTMLDocument3*, IHTMLElement**, int>)(lpVtbl[10]))((IHTMLDocument3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int get_uniqueID([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLDocument3*, ushort**, int>)(lpVtbl[11]))((IHTMLDocument3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int attachEvent([NativeTypeName("BSTR")] ushort* @event, IDispatch* pDisp, [NativeTypeName("VARIANT_BOOL *")] short* pfResult)
        {
            return ((delegate* unmanaged<IHTMLDocument3*, ushort*, IDispatch*, short*, int>)(lpVtbl[12]))((IHTMLDocument3*)Unsafe.AsPointer(ref this), @event, pDisp, pfResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int detachEvent([NativeTypeName("BSTR")] ushort* @event, IDispatch* pDisp)
        {
            return ((delegate* unmanaged<IHTMLDocument3*, ushort*, IDispatch*, int>)(lpVtbl[13]))((IHTMLDocument3*)Unsafe.AsPointer(ref this), @event, pDisp);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int put_onrowsdelete(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument3*, VARIANT, int>)(lpVtbl[14]))((IHTMLDocument3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int get_onrowsdelete(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument3*, VARIANT*, int>)(lpVtbl[15]))((IHTMLDocument3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int put_onrowsinserted(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument3*, VARIANT, int>)(lpVtbl[16]))((IHTMLDocument3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int get_onrowsinserted(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument3*, VARIANT*, int>)(lpVtbl[17]))((IHTMLDocument3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int put_oncellchange(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument3*, VARIANT, int>)(lpVtbl[18]))((IHTMLDocument3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int get_oncellchange(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument3*, VARIANT*, int>)(lpVtbl[19]))((IHTMLDocument3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int put_ondatasetchanged(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument3*, VARIANT, int>)(lpVtbl[20]))((IHTMLDocument3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int get_ondatasetchanged(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument3*, VARIANT*, int>)(lpVtbl[21]))((IHTMLDocument3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("HRESULT")]
        public int put_ondataavailable(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument3*, VARIANT, int>)(lpVtbl[22]))((IHTMLDocument3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        [return: NativeTypeName("HRESULT")]
        public int get_ondataavailable(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument3*, VARIANT*, int>)(lpVtbl[23]))((IHTMLDocument3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        [return: NativeTypeName("HRESULT")]
        public int put_ondatasetcomplete(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument3*, VARIANT, int>)(lpVtbl[24]))((IHTMLDocument3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        [return: NativeTypeName("HRESULT")]
        public int get_ondatasetcomplete(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument3*, VARIANT*, int>)(lpVtbl[25]))((IHTMLDocument3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        [return: NativeTypeName("HRESULT")]
        public int put_onpropertychange(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument3*, VARIANT, int>)(lpVtbl[26]))((IHTMLDocument3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        [return: NativeTypeName("HRESULT")]
        public int get_onpropertychange(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument3*, VARIANT*, int>)(lpVtbl[27]))((IHTMLDocument3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        [return: NativeTypeName("HRESULT")]
        public int put_dir([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLDocument3*, ushort*, int>)(lpVtbl[28]))((IHTMLDocument3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        [return: NativeTypeName("HRESULT")]
        public int get_dir([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLDocument3*, ushort**, int>)(lpVtbl[29]))((IHTMLDocument3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        [return: NativeTypeName("HRESULT")]
        public int put_oncontextmenu(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument3*, VARIANT, int>)(lpVtbl[30]))((IHTMLDocument3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        [return: NativeTypeName("HRESULT")]
        public int get_oncontextmenu(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument3*, VARIANT*, int>)(lpVtbl[31]))((IHTMLDocument3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        [return: NativeTypeName("HRESULT")]
        public int put_onstop(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument3*, VARIANT, int>)(lpVtbl[32]))((IHTMLDocument3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        [return: NativeTypeName("HRESULT")]
        public int get_onstop(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument3*, VARIANT*, int>)(lpVtbl[33]))((IHTMLDocument3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        [return: NativeTypeName("HRESULT")]
        public int createDocumentFragment(IHTMLDocument2** pNewDoc)
        {
            return ((delegate* unmanaged<IHTMLDocument3*, IHTMLDocument2**, int>)(lpVtbl[34]))((IHTMLDocument3*)Unsafe.AsPointer(ref this), pNewDoc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        [return: NativeTypeName("HRESULT")]
        public int get_parentDocument(IHTMLDocument2** p)
        {
            return ((delegate* unmanaged<IHTMLDocument3*, IHTMLDocument2**, int>)(lpVtbl[35]))((IHTMLDocument3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        [return: NativeTypeName("HRESULT")]
        public int put_enableDownload([NativeTypeName("VARIANT_BOOL")] short v)
        {
            return ((delegate* unmanaged<IHTMLDocument3*, short, int>)(lpVtbl[36]))((IHTMLDocument3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        [return: NativeTypeName("HRESULT")]
        public int get_enableDownload([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLDocument3*, short*, int>)(lpVtbl[37]))((IHTMLDocument3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        [return: NativeTypeName("HRESULT")]
        public int put_baseUrl([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLDocument3*, ushort*, int>)(lpVtbl[38]))((IHTMLDocument3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        [return: NativeTypeName("HRESULT")]
        public int get_baseUrl([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLDocument3*, ushort**, int>)(lpVtbl[39]))((IHTMLDocument3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        [return: NativeTypeName("HRESULT")]
        public int get_childNodes(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDocument3*, IDispatch**, int>)(lpVtbl[40]))((IHTMLDocument3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        [return: NativeTypeName("HRESULT")]
        public int put_inheritStyleSheets([NativeTypeName("VARIANT_BOOL")] short v)
        {
            return ((delegate* unmanaged<IHTMLDocument3*, short, int>)(lpVtbl[41]))((IHTMLDocument3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(42)]
        [return: NativeTypeName("HRESULT")]
        public int get_inheritStyleSheets([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLDocument3*, short*, int>)(lpVtbl[42]))((IHTMLDocument3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(43)]
        [return: NativeTypeName("HRESULT")]
        public int put_onbeforeeditfocus(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument3*, VARIANT, int>)(lpVtbl[43]))((IHTMLDocument3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(44)]
        [return: NativeTypeName("HRESULT")]
        public int get_onbeforeeditfocus(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument3*, VARIANT*, int>)(lpVtbl[44]))((IHTMLDocument3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(45)]
        [return: NativeTypeName("HRESULT")]
        public int getElementsByName([NativeTypeName("BSTR")] ushort* v, IHTMLElementCollection** pelColl)
        {
            return ((delegate* unmanaged<IHTMLDocument3*, ushort*, IHTMLElementCollection**, int>)(lpVtbl[45]))((IHTMLDocument3*)Unsafe.AsPointer(ref this), v, pelColl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(46)]
        [return: NativeTypeName("HRESULT")]
        public int getElementById([NativeTypeName("BSTR")] ushort* v, IHTMLElement** pel)
        {
            return ((delegate* unmanaged<IHTMLDocument3*, ushort*, IHTMLElement**, int>)(lpVtbl[46]))((IHTMLDocument3*)Unsafe.AsPointer(ref this), v, pel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(47)]
        [return: NativeTypeName("HRESULT")]
        public int getElementsByTagName([NativeTypeName("BSTR")] ushort* v, IHTMLElementCollection** pelColl)
        {
            return ((delegate* unmanaged<IHTMLDocument3*, ushort*, IHTMLElementCollection**, int>)(lpVtbl[47]))((IHTMLDocument3*)Unsafe.AsPointer(ref this), v, pelColl);
        }
    }
}
