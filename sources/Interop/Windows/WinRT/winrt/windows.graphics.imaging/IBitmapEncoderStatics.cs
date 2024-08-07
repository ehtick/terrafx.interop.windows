// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.imaging.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IBitmapEncoderStatics.xml' path='doc/member[@name="IBitmapEncoderStatics"]/*' />
[Guid("A74356A7-A4E4-4EB9-8E40-564DE7E1CCB2")]
[NativeTypeName("struct IBitmapEncoderStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBitmapEncoderStatics : IBitmapEncoderStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBitmapEncoderStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapEncoderStatics*, Guid*, void**, int>)(lpVtbl[0]))((IBitmapEncoderStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapEncoderStatics*, uint>)(lpVtbl[1]))((IBitmapEncoderStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapEncoderStatics*, uint>)(lpVtbl[2]))((IBitmapEncoderStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapEncoderStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IBitmapEncoderStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapEncoderStatics*, HSTRING*, int>)(lpVtbl[4]))((IBitmapEncoderStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapEncoderStatics*, TrustLevel*, int>)(lpVtbl[5]))((IBitmapEncoderStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IBitmapEncoderStatics.xml' path='doc/member[@name="IBitmapEncoderStatics.get_BmpEncoderId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_BmpEncoderId(Guid* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapEncoderStatics*, Guid*, int>)(lpVtbl[6]))((IBitmapEncoderStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBitmapEncoderStatics.xml' path='doc/member[@name="IBitmapEncoderStatics.get_JpegEncoderId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_JpegEncoderId(Guid* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapEncoderStatics*, Guid*, int>)(lpVtbl[7]))((IBitmapEncoderStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBitmapEncoderStatics.xml' path='doc/member[@name="IBitmapEncoderStatics.get_PngEncoderId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_PngEncoderId(Guid* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapEncoderStatics*, Guid*, int>)(lpVtbl[8]))((IBitmapEncoderStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBitmapEncoderStatics.xml' path='doc/member[@name="IBitmapEncoderStatics.get_TiffEncoderId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_TiffEncoderId(Guid* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapEncoderStatics*, Guid*, int>)(lpVtbl[9]))((IBitmapEncoderStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBitmapEncoderStatics.xml' path='doc/member[@name="IBitmapEncoderStatics.get_GifEncoderId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_GifEncoderId(Guid* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapEncoderStatics*, Guid*, int>)(lpVtbl[10]))((IBitmapEncoderStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBitmapEncoderStatics.xml' path='doc/member[@name="IBitmapEncoderStatics.get_JpegXREncoderId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_JpegXREncoderId(Guid* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapEncoderStatics*, Guid*, int>)(lpVtbl[11]))((IBitmapEncoderStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBitmapEncoderStatics.xml' path='doc/member[@name="IBitmapEncoderStatics.GetEncoderInformationEnumerator"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetEncoderInformationEnumerator([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CGraphics__CImaging__CBitmapCodecInformation_t **")] IVectorView<Pointer<IBitmapCodecInformation>>** encoderInformationEnumerator)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapEncoderStatics*, IVectorView<Pointer<IBitmapCodecInformation>>**, int>)(lpVtbl[12]))((IBitmapEncoderStatics*)Unsafe.AsPointer(ref this), encoderInformationEnumerator);
    }

    /// <include file='IBitmapEncoderStatics.xml' path='doc/member[@name="IBitmapEncoderStatics.CreateAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT CreateAsync(Guid encoderId, [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")] IRandomAccessStream* stream, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CImaging__CBitmapEncoder_t **")] IAsyncOperation<Pointer<IBitmapEncoder>>** asyncInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapEncoderStatics*, Guid, IRandomAccessStream*, IAsyncOperation<Pointer<IBitmapEncoder>>**, int>)(lpVtbl[13]))((IBitmapEncoderStatics*)Unsafe.AsPointer(ref this), encoderId, stream, asyncInfo);
    }

    /// <include file='IBitmapEncoderStatics.xml' path='doc/member[@name="IBitmapEncoderStatics.CreateWithEncodingOptionsAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT CreateWithEncodingOptionsAsync(Guid encoderId, [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")] IRandomAccessStream* stream, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1___FIKeyValuePair_2_HSTRING_Windows__CGraphics__CImaging__CBitmapTypedValue_t *")] IIterable<Pointer<IKeyValuePair<HSTRING, Pointer<IBitmapTypedValue>>>>* encodingOptions, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CImaging__CBitmapEncoder_t **")] IAsyncOperation<Pointer<IBitmapEncoder>>** asyncInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapEncoderStatics*, Guid, IRandomAccessStream*, IIterable<Pointer<IKeyValuePair<HSTRING, Pointer<IBitmapTypedValue>>>>*, IAsyncOperation<Pointer<IBitmapEncoder>>**, int>)(lpVtbl[14]))((IBitmapEncoderStatics*)Unsafe.AsPointer(ref this), encoderId, stream, encodingOptions, asyncInfo);
    }

    /// <include file='IBitmapEncoderStatics.xml' path='doc/member[@name="IBitmapEncoderStatics.CreateForTranscodingAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT CreateForTranscodingAsync([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")] IRandomAccessStream* stream, [NativeTypeName("ABI::Windows::Graphics::Imaging::IBitmapDecoder *")] IBitmapDecoder* bitmapDecoder, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CImaging__CBitmapEncoder_t **")] IAsyncOperation<Pointer<IBitmapEncoder>>** asyncInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapEncoderStatics*, IRandomAccessStream*, IBitmapDecoder*, IAsyncOperation<Pointer<IBitmapEncoder>>**, int>)(lpVtbl[15]))((IBitmapEncoderStatics*)Unsafe.AsPointer(ref this), stream, bitmapDecoder, asyncInfo);
    }

    /// <include file='IBitmapEncoderStatics.xml' path='doc/member[@name="IBitmapEncoderStatics.CreateForInPlacePropertyEncodingAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT CreateForInPlacePropertyEncodingAsync([NativeTypeName("ABI::Windows::Graphics::Imaging::IBitmapDecoder *")] IBitmapDecoder* bitmapDecoder, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CImaging__CBitmapEncoder_t **")] IAsyncOperation<Pointer<IBitmapEncoder>>** asyncInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<IBitmapEncoderStatics*, IBitmapDecoder*, IAsyncOperation<Pointer<IBitmapEncoder>>**, int>)(lpVtbl[16]))((IBitmapEncoderStatics*)Unsafe.AsPointer(ref this), bitmapDecoder, asyncInfo);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_BmpEncoderId(Guid* value);

        [VtblIndex(7)]
        HRESULT get_JpegEncoderId(Guid* value);

        [VtblIndex(8)]
        HRESULT get_PngEncoderId(Guid* value);

        [VtblIndex(9)]
        HRESULT get_TiffEncoderId(Guid* value);

        [VtblIndex(10)]
        HRESULT get_GifEncoderId(Guid* value);

        [VtblIndex(11)]
        HRESULT get_JpegXREncoderId(Guid* value);

        [VtblIndex(12)]
        HRESULT GetEncoderInformationEnumerator([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CGraphics__CImaging__CBitmapCodecInformation_t **")] IVectorView<Pointer<IBitmapCodecInformation>>** encoderInformationEnumerator);

        [VtblIndex(13)]
        HRESULT CreateAsync(Guid encoderId, [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")] IRandomAccessStream* stream, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CImaging__CBitmapEncoder_t **")] IAsyncOperation<Pointer<IBitmapEncoder>>** asyncInfo);

        [VtblIndex(14)]
        HRESULT CreateWithEncodingOptionsAsync(Guid encoderId, [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")] IRandomAccessStream* stream, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1___FIKeyValuePair_2_HSTRING_Windows__CGraphics__CImaging__CBitmapTypedValue_t *")] IIterable<Pointer<IKeyValuePair<HSTRING, Pointer<IBitmapTypedValue>>>>* encodingOptions, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CImaging__CBitmapEncoder_t **")] IAsyncOperation<Pointer<IBitmapEncoder>>** asyncInfo);

        [VtblIndex(15)]
        HRESULT CreateForTranscodingAsync([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")] IRandomAccessStream* stream, [NativeTypeName("ABI::Windows::Graphics::Imaging::IBitmapDecoder *")] IBitmapDecoder* bitmapDecoder, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CImaging__CBitmapEncoder_t **")] IAsyncOperation<Pointer<IBitmapEncoder>>** asyncInfo);

        [VtblIndex(16)]
        HRESULT CreateForInPlacePropertyEncodingAsync([NativeTypeName("ABI::Windows::Graphics::Imaging::IBitmapDecoder *")] IBitmapDecoder* bitmapDecoder, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CImaging__CBitmapEncoder_t **")] IAsyncOperation<Pointer<IBitmapEncoder>>** asyncInfo);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, Guid**, int> GetIids;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> GetRuntimeClassName;

        [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TrustLevel*, int> GetTrustLevel;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> get_BmpEncoderId;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> get_JpegEncoderId;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> get_PngEncoderId;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> get_TiffEncoderId;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> get_GifEncoderId;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> get_JpegXREncoderId;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CGraphics__CImaging__CBitmapCodecInformation_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<Pointer<IBitmapCodecInformation>>**, int> GetEncoderInformationEnumerator;

        [NativeTypeName("HRESULT (GUID, ABI::Windows::Storage::Streams::IRandomAccessStream *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CImaging__CBitmapEncoder_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid, IRandomAccessStream*, IAsyncOperation<Pointer<IBitmapEncoder>>**, int> CreateAsync;

        [NativeTypeName("HRESULT (GUID, ABI::Windows::Storage::Streams::IRandomAccessStream *, ABI::Windows::Foundation::Collections::__FIIterable_1___FIKeyValuePair_2_HSTRING_Windows__CGraphics__CImaging__CBitmapTypedValue_t *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CImaging__CBitmapEncoder_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid, IRandomAccessStream*, IIterable<Pointer<IKeyValuePair<HSTRING, Pointer<IBitmapTypedValue>>>>*, IAsyncOperation<Pointer<IBitmapEncoder>>**, int> CreateWithEncodingOptionsAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStream *, ABI::Windows::Graphics::Imaging::IBitmapDecoder *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CImaging__CBitmapEncoder_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRandomAccessStream*, IBitmapDecoder*, IAsyncOperation<Pointer<IBitmapEncoder>>**, int> CreateForTranscodingAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Imaging::IBitmapDecoder *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CImaging__CBitmapEncoder_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBitmapDecoder*, IAsyncOperation<Pointer<IBitmapEncoder>>**, int> CreateForInPlacePropertyEncodingAsync;
    }
}
