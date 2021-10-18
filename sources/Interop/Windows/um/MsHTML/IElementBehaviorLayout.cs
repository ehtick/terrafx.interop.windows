// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3050F6BA-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IElementBehaviorLayout : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IElementBehaviorLayout
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IElementBehaviorLayout*, Guid*, void**, int>)(lpVtbl[0]))((IElementBehaviorLayout*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IElementBehaviorLayout*, uint>)(lpVtbl[1]))((IElementBehaviorLayout*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IElementBehaviorLayout*, uint>)(lpVtbl[2]))((IElementBehaviorLayout*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetSize([NativeTypeName("LONG")] int dwFlags, SIZE sizeContent, POINT* pptTranslateBy, POINT* pptTopLeft, SIZE* psizeProposed)
        {
            return ((delegate* unmanaged<IElementBehaviorLayout*, int, SIZE, POINT*, POINT*, SIZE*, int>)(lpVtbl[3]))((IElementBehaviorLayout*)Unsafe.AsPointer(ref this), dwFlags, sizeContent, pptTranslateBy, pptTopLeft, psizeProposed);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetLayoutInfo([NativeTypeName("LONG *")] int* plLayoutInfo)
        {
            return ((delegate* unmanaged<IElementBehaviorLayout*, int*, int>)(lpVtbl[4]))((IElementBehaviorLayout*)Unsafe.AsPointer(ref this), plLayoutInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetPosition([NativeTypeName("LONG")] int lFlags, POINT* pptTopLeft)
        {
            return ((delegate* unmanaged<IElementBehaviorLayout*, int, POINT*, int>)(lpVtbl[5]))((IElementBehaviorLayout*)Unsafe.AsPointer(ref this), lFlags, pptTopLeft);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int MapSize(SIZE* psizeIn, RECT* prcOut)
        {
            return ((delegate* unmanaged<IElementBehaviorLayout*, SIZE*, RECT*, int>)(lpVtbl[6]))((IElementBehaviorLayout*)Unsafe.AsPointer(ref this), psizeIn, prcOut);
        }
    }
}