// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("DB2F3ACD-2F86-11D1-8E04-00C04FB9989A")]
    [NativeTypeName("struct AsyncIPipeLong : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct AsyncIPipeLong : AsyncIPipeLong.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<AsyncIPipeLong*, Guid*, void**, int>)(lpVtbl[0]))((AsyncIPipeLong*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<AsyncIPipeLong*, uint>)(lpVtbl[1]))((AsyncIPipeLong*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<AsyncIPipeLong*, uint>)(lpVtbl[2]))((AsyncIPipeLong*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Begin_Pull([NativeTypeName("ULONG")] uint cRequest)
        {
            return ((delegate* unmanaged<AsyncIPipeLong*, uint, int>)(lpVtbl[3]))((AsyncIPipeLong*)Unsafe.AsPointer(ref this), cRequest);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT Finish_Pull([NativeTypeName("LONG *")] int* buf, [NativeTypeName("ULONG *")] uint* pcReturned)
        {
            return ((delegate* unmanaged<AsyncIPipeLong*, int*, uint*, int>)(lpVtbl[4]))((AsyncIPipeLong*)Unsafe.AsPointer(ref this), buf, pcReturned);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT Begin_Push([NativeTypeName("LONG *")] int* buf, [NativeTypeName("ULONG")] uint cSent)
        {
            return ((delegate* unmanaged<AsyncIPipeLong*, int*, uint, int>)(lpVtbl[5]))((AsyncIPipeLong*)Unsafe.AsPointer(ref this), buf, cSent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Finish_Push()
        {
            return ((delegate* unmanaged<AsyncIPipeLong*, int>)(lpVtbl[6]))((AsyncIPipeLong*)Unsafe.AsPointer(ref this));
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT Begin_Pull([NativeTypeName("ULONG")] uint cRequest);

            [VtblIndex(4)]
            HRESULT Finish_Pull([NativeTypeName("LONG *")] int* buf, [NativeTypeName("ULONG *")] uint* pcReturned);

            [VtblIndex(5)]
            HRESULT Begin_Push([NativeTypeName("LONG *")] int* buf, [NativeTypeName("ULONG")] uint cSent);

            [VtblIndex(6)]
            HRESULT Finish_Push();
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<AsyncIPipeLong*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<AsyncIPipeLong*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<AsyncIPipeLong*, uint> Release;

            [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
            public delegate* unmanaged<AsyncIPipeLong*, uint, int> Begin_Pull;

            [NativeTypeName("HRESULT (LONG *, ULONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<AsyncIPipeLong*, int*, uint*, int> Finish_Pull;

            [NativeTypeName("HRESULT (LONG *, ULONG) __attribute__((stdcall))")]
            public delegate* unmanaged<AsyncIPipeLong*, int*, uint, int> Begin_Push;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<AsyncIPipeLong*, int> Finish_Push;
        }
    }
}