// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shimgdata.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("9BE8ED5C-EDAB-4D75-90F3-BD5BDBB21C82")]
    [NativeTypeName("struct IShellImageDataFactory : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IShellImageDataFactory : IShellImageDataFactory.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IShellImageDataFactory*, Guid*, void**, int>)(lpVtbl[0]))((IShellImageDataFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IShellImageDataFactory*, uint>)(lpVtbl[1]))((IShellImageDataFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IShellImageDataFactory*, uint>)(lpVtbl[2]))((IShellImageDataFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT CreateIShellImageData(IShellImageData** ppshimg)
        {
            return ((delegate* unmanaged<IShellImageDataFactory*, IShellImageData**, int>)(lpVtbl[3]))((IShellImageDataFactory*)Unsafe.AsPointer(ref this), ppshimg);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT CreateImageFromFile([NativeTypeName("LPCWSTR")] ushort* pszPath, IShellImageData** ppshimg)
        {
            return ((delegate* unmanaged<IShellImageDataFactory*, ushort*, IShellImageData**, int>)(lpVtbl[4]))((IShellImageDataFactory*)Unsafe.AsPointer(ref this), pszPath, ppshimg);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT CreateImageFromStream(IStream* pStream, IShellImageData** ppshimg)
        {
            return ((delegate* unmanaged<IShellImageDataFactory*, IStream*, IShellImageData**, int>)(lpVtbl[5]))((IShellImageDataFactory*)Unsafe.AsPointer(ref this), pStream, ppshimg);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetDataFormatFromPath([NativeTypeName("LPCWSTR")] ushort* pszPath, Guid* pDataFormat)
        {
            return ((delegate* unmanaged<IShellImageDataFactory*, ushort*, Guid*, int>)(lpVtbl[6]))((IShellImageDataFactory*)Unsafe.AsPointer(ref this), pszPath, pDataFormat);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT CreateIShellImageData(IShellImageData** ppshimg);

            [VtblIndex(4)]
            HRESULT CreateImageFromFile([NativeTypeName("LPCWSTR")] ushort* pszPath, IShellImageData** ppshimg);

            [VtblIndex(5)]
            HRESULT CreateImageFromStream(IStream* pStream, IShellImageData** ppshimg);

            [VtblIndex(6)]
            HRESULT GetDataFormatFromPath([NativeTypeName("LPCWSTR")] ushort* pszPath, Guid* pDataFormat);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellImageDataFactory*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IShellImageDataFactory*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IShellImageDataFactory*, uint> Release;

            [NativeTypeName("HRESULT (IShellImageData **) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellImageDataFactory*, IShellImageData**, int> CreateIShellImageData;

            [NativeTypeName("HRESULT (LPCWSTR, IShellImageData **) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellImageDataFactory*, ushort*, IShellImageData**, int> CreateImageFromFile;

            [NativeTypeName("HRESULT (IStream *, IShellImageData **) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellImageDataFactory*, IStream*, IShellImageData**, int> CreateImageFromStream;

            [NativeTypeName("HRESULT (LPCWSTR, GUID *) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellImageDataFactory*, ushort*, Guid*, int> GetDataFormatFromPath;
        }
    }
}