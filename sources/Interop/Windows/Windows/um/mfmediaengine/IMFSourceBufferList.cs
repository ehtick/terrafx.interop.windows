// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows
{
    [SupportedOSPlatform("windows8.1")]
    [Guid("249981F8-8325-41F3-B80C-3B9E3AAD0CBE")]
    [NativeTypeName("struct IMFSourceBufferList : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFSourceBufferList : IMFSourceBufferList.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFSourceBufferList*, Guid*, void**, int>)(lpVtbl[0]))((IMFSourceBufferList*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFSourceBufferList*, uint>)(lpVtbl[1]))((IMFSourceBufferList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFSourceBufferList*, uint>)(lpVtbl[2]))((IMFSourceBufferList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("DWORD")]
        public uint GetLength()
        {
            return ((delegate* unmanaged<IMFSourceBufferList*, uint>)(lpVtbl[3]))((IMFSourceBufferList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public IMFSourceBuffer* GetSourceBuffer([NativeTypeName("DWORD")] uint index)
        {
            return ((delegate* unmanaged<IMFSourceBufferList*, uint, IMFSourceBuffer*>)(lpVtbl[4]))((IMFSourceBufferList*)Unsafe.AsPointer(ref this), index);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            [return: NativeTypeName("DWORD")]
            uint GetLength();

            [VtblIndex(4)]
            IMFSourceBuffer* GetSourceBuffer([NativeTypeName("DWORD")] uint index);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSourceBufferList*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSourceBufferList*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSourceBufferList*, uint> Release;

            [NativeTypeName("DWORD () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSourceBufferList*, uint> GetLength;

            [NativeTypeName("IMFSourceBuffer *(DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSourceBufferList*, uint, IMFSourceBuffer*> GetSourceBuffer;
        }
    }
}