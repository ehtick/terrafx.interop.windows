// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("829B6CF1-4F3A-4412-AE09-B243EB4C6B58")]
    [NativeTypeName("struct IUIAnimationVariableIntegerChangeHandler2 : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IUIAnimationVariableIntegerChangeHandler2 : IUIAnimationVariableIntegerChangeHandler2.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IUIAnimationVariableIntegerChangeHandler2*, Guid*, void**, int>)(lpVtbl[0]))((IUIAnimationVariableIntegerChangeHandler2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IUIAnimationVariableIntegerChangeHandler2*, uint>)(lpVtbl[1]))((IUIAnimationVariableIntegerChangeHandler2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IUIAnimationVariableIntegerChangeHandler2*, uint>)(lpVtbl[2]))((IUIAnimationVariableIntegerChangeHandler2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT OnIntegerValueChanged(IUIAnimationStoryboard2* storyboard, IUIAnimationVariable2* variable, [NativeTypeName("INT32 *")] int* newValue, [NativeTypeName("INT32 *")] int* previousValue, uint cDimension)
        {
            return ((delegate* unmanaged<IUIAnimationVariableIntegerChangeHandler2*, IUIAnimationStoryboard2*, IUIAnimationVariable2*, int*, int*, uint, int>)(lpVtbl[3]))((IUIAnimationVariableIntegerChangeHandler2*)Unsafe.AsPointer(ref this), storyboard, variable, newValue, previousValue, cDimension);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT OnIntegerValueChanged(IUIAnimationStoryboard2* storyboard, IUIAnimationVariable2* variable, [NativeTypeName("INT32 *")] int* newValue, [NativeTypeName("INT32 *")] int* previousValue, uint cDimension);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IUIAnimationVariableIntegerChangeHandler2*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IUIAnimationVariableIntegerChangeHandler2*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IUIAnimationVariableIntegerChangeHandler2*, uint> Release;

            [NativeTypeName("HRESULT (IUIAnimationStoryboard2 *, IUIAnimationVariable2 *, INT32 *, INT32 *, UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<IUIAnimationVariableIntegerChangeHandler2*, IUIAnimationStoryboard2*, IUIAnimationVariable2*, int*, int*, uint, int> OnIntegerValueChanged;
        }
    }
}