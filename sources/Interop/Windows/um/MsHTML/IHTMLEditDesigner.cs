// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3050F662-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IHTMLEditDesigner : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IHTMLEditDesigner
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLEditDesigner*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLEditDesigner*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLEditDesigner*, uint>)(lpVtbl[1]))((IHTMLEditDesigner*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLEditDesigner*, uint>)(lpVtbl[2]))((IHTMLEditDesigner*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int PreHandleEvent([NativeTypeName("DISPID")] int inEvtDispId, IHTMLEventObj* pIEventObj)
        {
            return ((delegate* unmanaged<IHTMLEditDesigner*, int, IHTMLEventObj*, int>)(lpVtbl[3]))((IHTMLEditDesigner*)Unsafe.AsPointer(ref this), inEvtDispId, pIEventObj);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int PostHandleEvent([NativeTypeName("DISPID")] int inEvtDispId, IHTMLEventObj* pIEventObj)
        {
            return ((delegate* unmanaged<IHTMLEditDesigner*, int, IHTMLEventObj*, int>)(lpVtbl[4]))((IHTMLEditDesigner*)Unsafe.AsPointer(ref this), inEvtDispId, pIEventObj);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int TranslateAcceleratorW([NativeTypeName("DISPID")] int inEvtDispId, IHTMLEventObj* pIEventObj)
        {
            return ((delegate* unmanaged<IHTMLEditDesigner*, int, IHTMLEventObj*, int>)(lpVtbl[5]))((IHTMLEditDesigner*)Unsafe.AsPointer(ref this), inEvtDispId, pIEventObj);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int PostEditorEventNotify([NativeTypeName("DISPID")] int inEvtDispId, IHTMLEventObj* pIEventObj)
        {
            return ((delegate* unmanaged<IHTMLEditDesigner*, int, IHTMLEventObj*, int>)(lpVtbl[6]))((IHTMLEditDesigner*)Unsafe.AsPointer(ref this), inEvtDispId, pIEventObj);
        }
    }
}