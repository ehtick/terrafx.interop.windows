// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("6AF6E03F-D664-4EF4-9626-F7E0ED36755E")]
    [NativeTypeName("struct ISearchBoxInfo : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ISearchBoxInfo
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISearchBoxInfo*, Guid*, void**, int>)(lpVtbl[0]))((ISearchBoxInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISearchBoxInfo*, uint>)(lpVtbl[1]))((ISearchBoxInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISearchBoxInfo*, uint>)(lpVtbl[2]))((ISearchBoxInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetCondition([NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<ISearchBoxInfo*, Guid*, void**, int>)(lpVtbl[3]))((ISearchBoxInfo*)Unsafe.AsPointer(ref this), riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetText([NativeTypeName("LPWSTR *")] ushort** ppsz)
        {
            return ((delegate* unmanaged<ISearchBoxInfo*, ushort**, int>)(lpVtbl[4]))((ISearchBoxInfo*)Unsafe.AsPointer(ref this), ppsz);
        }
    }
}