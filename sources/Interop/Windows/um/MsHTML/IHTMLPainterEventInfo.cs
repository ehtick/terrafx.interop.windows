// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3050F6DF-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IHTMLPainterEventInfo : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IHTMLPainterEventInfo
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLPainterEventInfo*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLPainterEventInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLPainterEventInfo*, uint>)(lpVtbl[1]))((IHTMLPainterEventInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLPainterEventInfo*, uint>)(lpVtbl[2]))((IHTMLPainterEventInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetEventInfoFlags([NativeTypeName("long *")] int* plEventInfoFlags)
        {
            return ((delegate* unmanaged<IHTMLPainterEventInfo*, int*, int>)(lpVtbl[3]))((IHTMLPainterEventInfo*)Unsafe.AsPointer(ref this), plEventInfoFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetEventTarget(IHTMLElement** ppElement)
        {
            return ((delegate* unmanaged<IHTMLPainterEventInfo*, IHTMLElement**, int>)(lpVtbl[4]))((IHTMLPainterEventInfo*)Unsafe.AsPointer(ref this), ppElement);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int SetCursor([NativeTypeName("LONG")] int lPartID)
        {
            return ((delegate* unmanaged<IHTMLPainterEventInfo*, int, int>)(lpVtbl[5]))((IHTMLPainterEventInfo*)Unsafe.AsPointer(ref this), lPartID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int StringFromPartID([NativeTypeName("LONG")] int lPartID, [NativeTypeName("BSTR *")] ushort** pbstrPart)
        {
            return ((delegate* unmanaged<IHTMLPainterEventInfo*, int, ushort**, int>)(lpVtbl[6]))((IHTMLPainterEventInfo*)Unsafe.AsPointer(ref this), lPartID, pbstrPart);
        }
    }
}
