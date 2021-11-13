// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("02997C3B-8E1B-460E-9270-545E0DE9563E")]
    [NativeTypeName("struct IVideoEncoder : IEncoderAPI")]
    [NativeInheritance("IEncoderAPI")]
    public unsafe partial struct IVideoEncoder : IVideoEncoder.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IVideoEncoder*, Guid*, void**, int>)(lpVtbl[0]))((IVideoEncoder*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IVideoEncoder*, uint>)(lpVtbl[1]))((IVideoEncoder*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IVideoEncoder*, uint>)(lpVtbl[2]))((IVideoEncoder*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT IsSupported([NativeTypeName("const GUID *")] Guid* Api)
        {
            return ((delegate* unmanaged<IVideoEncoder*, Guid*, int>)(lpVtbl[3]))((IVideoEncoder*)Unsafe.AsPointer(ref this), Api);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT IsAvailable([NativeTypeName("const GUID *")] Guid* Api)
        {
            return ((delegate* unmanaged<IVideoEncoder*, Guid*, int>)(lpVtbl[4]))((IVideoEncoder*)Unsafe.AsPointer(ref this), Api);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetParameterRange([NativeTypeName("const GUID *")] Guid* Api, VARIANT* ValueMin, VARIANT* ValueMax, VARIANT* SteppingDelta)
        {
            return ((delegate* unmanaged<IVideoEncoder*, Guid*, VARIANT*, VARIANT*, VARIANT*, int>)(lpVtbl[5]))((IVideoEncoder*)Unsafe.AsPointer(ref this), Api, ValueMin, ValueMax, SteppingDelta);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetParameterValues([NativeTypeName("const GUID *")] Guid* Api, VARIANT** Values, [NativeTypeName("ULONG *")] uint* ValuesCount)
        {
            return ((delegate* unmanaged<IVideoEncoder*, Guid*, VARIANT**, uint*, int>)(lpVtbl[6]))((IVideoEncoder*)Unsafe.AsPointer(ref this), Api, Values, ValuesCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetDefaultValue([NativeTypeName("const GUID *")] Guid* Api, VARIANT* Value)
        {
            return ((delegate* unmanaged<IVideoEncoder*, Guid*, VARIANT*, int>)(lpVtbl[7]))((IVideoEncoder*)Unsafe.AsPointer(ref this), Api, Value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetValue([NativeTypeName("const GUID *")] Guid* Api, VARIANT* Value)
        {
            return ((delegate* unmanaged<IVideoEncoder*, Guid*, VARIANT*, int>)(lpVtbl[8]))((IVideoEncoder*)Unsafe.AsPointer(ref this), Api, Value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT SetValue([NativeTypeName("const GUID *")] Guid* Api, VARIANT* Value)
        {
            return ((delegate* unmanaged<IVideoEncoder*, Guid*, VARIANT*, int>)(lpVtbl[9]))((IVideoEncoder*)Unsafe.AsPointer(ref this), Api, Value);
        }

        public interface Interface : IEncoderAPI.Interface
        {
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IVideoEncoder*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IVideoEncoder*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IVideoEncoder*, uint> Release;

            [NativeTypeName("HRESULT (const GUID *) __attribute__((stdcall))")]
            public delegate* unmanaged<IVideoEncoder*, Guid*, int> IsSupported;

            [NativeTypeName("HRESULT (const GUID *) __attribute__((stdcall))")]
            public delegate* unmanaged<IVideoEncoder*, Guid*, int> IsAvailable;

            [NativeTypeName("HRESULT (const GUID *, VARIANT *, VARIANT *, VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IVideoEncoder*, Guid*, VARIANT*, VARIANT*, VARIANT*, int> GetParameterRange;

            [NativeTypeName("HRESULT (const GUID *, VARIANT **, ULONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IVideoEncoder*, Guid*, VARIANT**, uint*, int> GetParameterValues;

            [NativeTypeName("HRESULT (const GUID *, VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IVideoEncoder*, Guid*, VARIANT*, int> GetDefaultValue;

            [NativeTypeName("HRESULT (const GUID *, VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IVideoEncoder*, Guid*, VARIANT*, int> GetValue;

            [NativeTypeName("HRESULT (const GUID *, VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IVideoEncoder*, Guid*, VARIANT*, int> SetValue;
        }
    }
}