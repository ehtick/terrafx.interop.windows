// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.speechrecognition.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISpeechRecognitionGrammarFileConstraintFactory.xml' path='doc/member[@name="ISpeechRecognitionGrammarFileConstraintFactory"]/*' />
[Guid("3DA770EB-C479-4C27-9F19-89974EF392D1")]
[NativeTypeName("struct ISpeechRecognitionGrammarFileConstraintFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISpeechRecognitionGrammarFileConstraintFactory : ISpeechRecognitionGrammarFileConstraintFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpeechRecognitionGrammarFileConstraintFactory));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognitionGrammarFileConstraintFactory*, Guid*, void**, int>)(lpVtbl[0]))((ISpeechRecognitionGrammarFileConstraintFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognitionGrammarFileConstraintFactory*, uint>)(lpVtbl[1]))((ISpeechRecognitionGrammarFileConstraintFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognitionGrammarFileConstraintFactory*, uint>)(lpVtbl[2]))((ISpeechRecognitionGrammarFileConstraintFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognitionGrammarFileConstraintFactory*, uint*, Guid**, int>)(lpVtbl[3]))((ISpeechRecognitionGrammarFileConstraintFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognitionGrammarFileConstraintFactory*, HSTRING*, int>)(lpVtbl[4]))((ISpeechRecognitionGrammarFileConstraintFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognitionGrammarFileConstraintFactory*, TrustLevel*, int>)(lpVtbl[5]))((ISpeechRecognitionGrammarFileConstraintFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISpeechRecognitionGrammarFileConstraintFactory.xml' path='doc/member[@name="ISpeechRecognitionGrammarFileConstraintFactory.Create"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Create([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, [NativeTypeName("ABI::Windows::Media::SpeechRecognition::ISpeechRecognitionGrammarFileConstraint **")] ISpeechRecognitionGrammarFileConstraint** constraint)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognitionGrammarFileConstraintFactory*, IStorageFile*, ISpeechRecognitionGrammarFileConstraint**, int>)(lpVtbl[6]))((ISpeechRecognitionGrammarFileConstraintFactory*)Unsafe.AsPointer(ref this), file, constraint);
    }

    /// <include file='ISpeechRecognitionGrammarFileConstraintFactory.xml' path='doc/member[@name="ISpeechRecognitionGrammarFileConstraintFactory.CreateWithTag"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateWithTag([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, HSTRING tag, [NativeTypeName("ABI::Windows::Media::SpeechRecognition::ISpeechRecognitionGrammarFileConstraint **")] ISpeechRecognitionGrammarFileConstraint** constraint)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognitionGrammarFileConstraintFactory*, IStorageFile*, HSTRING, ISpeechRecognitionGrammarFileConstraint**, int>)(lpVtbl[7]))((ISpeechRecognitionGrammarFileConstraintFactory*)Unsafe.AsPointer(ref this), file, tag, constraint);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Create([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, [NativeTypeName("ABI::Windows::Media::SpeechRecognition::ISpeechRecognitionGrammarFileConstraint **")] ISpeechRecognitionGrammarFileConstraint** constraint);

        [VtblIndex(7)]
        HRESULT CreateWithTag([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, HSTRING tag, [NativeTypeName("ABI::Windows::Media::SpeechRecognition::ISpeechRecognitionGrammarFileConstraint **")] ISpeechRecognitionGrammarFileConstraint** constraint);
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

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFile *, ABI::Windows::Media::SpeechRecognition::ISpeechRecognitionGrammarFileConstraint **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFile*, ISpeechRecognitionGrammarFileConstraint**, int> Create;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFile *, HSTRING, ABI::Windows::Media::SpeechRecognition::ISpeechRecognitionGrammarFileConstraint **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFile*, HSTRING, ISpeechRecognitionGrammarFileConstraint**, int> CreateWithTag;
    }
}
