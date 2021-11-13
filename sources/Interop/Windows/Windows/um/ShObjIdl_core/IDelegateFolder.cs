// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("ADD8BA80-002B-11D0-8F0F-00C04FD7D062")]
    [NativeTypeName("struct IDelegateFolder : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDelegateFolder : IDelegateFolder.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDelegateFolder*, Guid*, void**, int>)(lpVtbl[0]))((IDelegateFolder*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDelegateFolder*, uint>)(lpVtbl[1]))((IDelegateFolder*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDelegateFolder*, uint>)(lpVtbl[2]))((IDelegateFolder*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetItemAlloc(IMalloc* pmalloc)
        {
            return ((delegate* unmanaged<IDelegateFolder*, IMalloc*, int>)(lpVtbl[3]))((IDelegateFolder*)Unsafe.AsPointer(ref this), pmalloc);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT SetItemAlloc(IMalloc* pmalloc);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDelegateFolder*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDelegateFolder*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDelegateFolder*, uint> Release;

            [NativeTypeName("HRESULT (IMalloc *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDelegateFolder*, IMalloc*, int> SetItemAlloc;
        }
    }
}