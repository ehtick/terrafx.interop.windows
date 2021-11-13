// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/control.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("56A868B8-0AD4-11CE-B03A-0020AF0BA770")]
    [NativeTypeName("struct IDeferredCommand : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDeferredCommand : IDeferredCommand.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDeferredCommand*, Guid*, void**, int>)(lpVtbl[0]))((IDeferredCommand*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDeferredCommand*, uint>)(lpVtbl[1]))((IDeferredCommand*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDeferredCommand*, uint>)(lpVtbl[2]))((IDeferredCommand*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Cancel()
        {
            return ((delegate* unmanaged<IDeferredCommand*, int>)(lpVtbl[3]))((IDeferredCommand*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT Confidence([NativeTypeName("LONG *")] int* pConfidence)
        {
            return ((delegate* unmanaged<IDeferredCommand*, int*, int>)(lpVtbl[4]))((IDeferredCommand*)Unsafe.AsPointer(ref this), pConfidence);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT Postpone([NativeTypeName("REFTIME")] double newtime)
        {
            return ((delegate* unmanaged<IDeferredCommand*, double, int>)(lpVtbl[5]))((IDeferredCommand*)Unsafe.AsPointer(ref this), newtime);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetHResult(HRESULT* phrResult)
        {
            return ((delegate* unmanaged<IDeferredCommand*, HRESULT*, int>)(lpVtbl[6]))((IDeferredCommand*)Unsafe.AsPointer(ref this), phrResult);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT Cancel();

            [VtblIndex(4)]
            HRESULT Confidence([NativeTypeName("LONG *")] int* pConfidence);

            [VtblIndex(5)]
            HRESULT Postpone([NativeTypeName("REFTIME")] double newtime);

            [VtblIndex(6)]
            HRESULT GetHResult(HRESULT* phrResult);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDeferredCommand*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDeferredCommand*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDeferredCommand*, uint> Release;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IDeferredCommand*, int> Cancel;

            [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDeferredCommand*, int*, int> Confidence;

            [NativeTypeName("HRESULT (REFTIME) __attribute__((stdcall))")]
            public delegate* unmanaged<IDeferredCommand*, double, int> Postpone;

            [NativeTypeName("HRESULT (HRESULT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDeferredCommand*, HRESULT*, int> GetHResult;
        }
    }
}