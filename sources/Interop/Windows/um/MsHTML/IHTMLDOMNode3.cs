// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("305106E0-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IHTMLDOMNode3 : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IHTMLDOMNode3
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLDOMNode3*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLDOMNode3*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLDOMNode3*, uint>)(lpVtbl[1]))((IHTMLDOMNode3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLDOMNode3*, uint>)(lpVtbl[2]))((IHTMLDOMNode3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLDOMNode3*, uint*, int>)(lpVtbl[3]))((IHTMLDOMNode3*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLDOMNode3*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLDOMNode3*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLDOMNode3*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLDOMNode3*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLDOMNode3*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLDOMNode3*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int put_prefix(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDOMNode3*, VARIANT, int>)(lpVtbl[7]))((IHTMLDOMNode3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int get_prefix(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDOMNode3*, VARIANT*, int>)(lpVtbl[8]))((IHTMLDOMNode3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int get_localName(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDOMNode3*, VARIANT*, int>)(lpVtbl[9]))((IHTMLDOMNode3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int get_namespaceURI(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDOMNode3*, VARIANT*, int>)(lpVtbl[10]))((IHTMLDOMNode3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int put_textContent(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDOMNode3*, VARIANT, int>)(lpVtbl[11]))((IHTMLDOMNode3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int get_textContent(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDOMNode3*, VARIANT*, int>)(lpVtbl[12]))((IHTMLDOMNode3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int isEqualNode(IHTMLDOMNode3* otherNode, [NativeTypeName("VARIANT_BOOL *")] short* isEqual)
        {
            return ((delegate* unmanaged<IHTMLDOMNode3*, IHTMLDOMNode3*, short*, int>)(lpVtbl[13]))((IHTMLDOMNode3*)Unsafe.AsPointer(ref this), otherNode, isEqual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int lookupNamespaceURI(VARIANT* pvarPrefix, VARIANT* pvarNamespaceURI)
        {
            return ((delegate* unmanaged<IHTMLDOMNode3*, VARIANT*, VARIANT*, int>)(lpVtbl[14]))((IHTMLDOMNode3*)Unsafe.AsPointer(ref this), pvarPrefix, pvarNamespaceURI);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int lookupPrefix(VARIANT* pvarNamespaceURI, VARIANT* pvarPrefix)
        {
            return ((delegate* unmanaged<IHTMLDOMNode3*, VARIANT*, VARIANT*, int>)(lpVtbl[15]))((IHTMLDOMNode3*)Unsafe.AsPointer(ref this), pvarNamespaceURI, pvarPrefix);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int isDefaultNamespace(VARIANT* pvarNamespace, [NativeTypeName("VARIANT_BOOL *")] short* pfDefaultNamespace)
        {
            return ((delegate* unmanaged<IHTMLDOMNode3*, VARIANT*, short*, int>)(lpVtbl[16]))((IHTMLDOMNode3*)Unsafe.AsPointer(ref this), pvarNamespace, pfDefaultNamespace);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int appendChild(IHTMLDOMNode* newChild, IHTMLDOMNode** node)
        {
            return ((delegate* unmanaged<IHTMLDOMNode3*, IHTMLDOMNode*, IHTMLDOMNode**, int>)(lpVtbl[17]))((IHTMLDOMNode3*)Unsafe.AsPointer(ref this), newChild, node);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int insertBefore(IHTMLDOMNode* newChild, VARIANT refChild, IHTMLDOMNode** node)
        {
            return ((delegate* unmanaged<IHTMLDOMNode3*, IHTMLDOMNode*, VARIANT, IHTMLDOMNode**, int>)(lpVtbl[18]))((IHTMLDOMNode3*)Unsafe.AsPointer(ref this), newChild, refChild, node);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int removeChild(IHTMLDOMNode* oldChild, IHTMLDOMNode** node)
        {
            return ((delegate* unmanaged<IHTMLDOMNode3*, IHTMLDOMNode*, IHTMLDOMNode**, int>)(lpVtbl[19]))((IHTMLDOMNode3*)Unsafe.AsPointer(ref this), oldChild, node);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int replaceChild(IHTMLDOMNode* newChild, IHTMLDOMNode* oldChild, IHTMLDOMNode** node)
        {
            return ((delegate* unmanaged<IHTMLDOMNode3*, IHTMLDOMNode*, IHTMLDOMNode*, IHTMLDOMNode**, int>)(lpVtbl[20]))((IHTMLDOMNode3*)Unsafe.AsPointer(ref this), newChild, oldChild, node);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int isSameNode(IHTMLDOMNode3* otherNode, [NativeTypeName("VARIANT_BOOL *")] short* isSame)
        {
            return ((delegate* unmanaged<IHTMLDOMNode3*, IHTMLDOMNode3*, short*, int>)(lpVtbl[21]))((IHTMLDOMNode3*)Unsafe.AsPointer(ref this), otherNode, isSame);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("HRESULT")]
        public int compareDocumentPosition(IHTMLDOMNode* otherNode, [NativeTypeName("USHORT *")] ushort* flags)
        {
            return ((delegate* unmanaged<IHTMLDOMNode3*, IHTMLDOMNode*, ushort*, int>)(lpVtbl[22]))((IHTMLDOMNode3*)Unsafe.AsPointer(ref this), otherNode, flags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        [return: NativeTypeName("HRESULT")]
        public int isSupported([NativeTypeName("BSTR")] ushort* feature, VARIANT version, [NativeTypeName("VARIANT_BOOL *")] short* pfisSupported)
        {
            return ((delegate* unmanaged<IHTMLDOMNode3*, ushort*, VARIANT, short*, int>)(lpVtbl[23]))((IHTMLDOMNode3*)Unsafe.AsPointer(ref this), feature, version, pfisSupported);
        }
    }
}