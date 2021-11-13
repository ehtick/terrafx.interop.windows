// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("CE17C09B-4EFA-44D5-A4C9-59D9585AB0CD")]
    [NativeTypeName("struct ISpeechDataKey : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct ISpeechDataKey : ISpeechDataKey.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISpeechDataKey*, Guid*, void**, int>)(lpVtbl[0]))((ISpeechDataKey*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISpeechDataKey*, uint>)(lpVtbl[1]))((ISpeechDataKey*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISpeechDataKey*, uint>)(lpVtbl[2]))((ISpeechDataKey*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount(uint* pctinfo)
        {
            return ((delegate* unmanaged<ISpeechDataKey*, uint*, int>)(lpVtbl[3]))((ISpeechDataKey*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<ISpeechDataKey*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISpeechDataKey*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<ISpeechDataKey*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISpeechDataKey*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return ((delegate* unmanaged<ISpeechDataKey*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISpeechDataKey*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT SetBinaryValue([NativeTypeName("const BSTR")] ushort* ValueName, VARIANT Value)
        {
            return ((delegate* unmanaged<ISpeechDataKey*, ushort*, VARIANT, int>)(lpVtbl[7]))((ISpeechDataKey*)Unsafe.AsPointer(ref this), ValueName, Value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetBinaryValue([NativeTypeName("const BSTR")] ushort* ValueName, VARIANT* Value)
        {
            return ((delegate* unmanaged<ISpeechDataKey*, ushort*, VARIANT*, int>)(lpVtbl[8]))((ISpeechDataKey*)Unsafe.AsPointer(ref this), ValueName, Value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT SetStringValue([NativeTypeName("const BSTR")] ushort* ValueName, [NativeTypeName("const BSTR")] ushort* Value)
        {
            return ((delegate* unmanaged<ISpeechDataKey*, ushort*, ushort*, int>)(lpVtbl[9]))((ISpeechDataKey*)Unsafe.AsPointer(ref this), ValueName, Value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT GetStringValue([NativeTypeName("const BSTR")] ushort* ValueName, [NativeTypeName("BSTR *")] ushort** Value)
        {
            return ((delegate* unmanaged<ISpeechDataKey*, ushort*, ushort**, int>)(lpVtbl[10]))((ISpeechDataKey*)Unsafe.AsPointer(ref this), ValueName, Value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT SetLongValue([NativeTypeName("const BSTR")] ushort* ValueName, [NativeTypeName("long")] int Value)
        {
            return ((delegate* unmanaged<ISpeechDataKey*, ushort*, int, int>)(lpVtbl[11]))((ISpeechDataKey*)Unsafe.AsPointer(ref this), ValueName, Value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT GetLongValue([NativeTypeName("const BSTR")] ushort* ValueName, [NativeTypeName("long *")] int* Value)
        {
            return ((delegate* unmanaged<ISpeechDataKey*, ushort*, int*, int>)(lpVtbl[12]))((ISpeechDataKey*)Unsafe.AsPointer(ref this), ValueName, Value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT OpenKey([NativeTypeName("const BSTR")] ushort* SubKeyName, ISpeechDataKey** SubKey)
        {
            return ((delegate* unmanaged<ISpeechDataKey*, ushort*, ISpeechDataKey**, int>)(lpVtbl[13]))((ISpeechDataKey*)Unsafe.AsPointer(ref this), SubKeyName, SubKey);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT CreateKey([NativeTypeName("const BSTR")] ushort* SubKeyName, ISpeechDataKey** SubKey)
        {
            return ((delegate* unmanaged<ISpeechDataKey*, ushort*, ISpeechDataKey**, int>)(lpVtbl[14]))((ISpeechDataKey*)Unsafe.AsPointer(ref this), SubKeyName, SubKey);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT DeleteKey([NativeTypeName("const BSTR")] ushort* SubKeyName)
        {
            return ((delegate* unmanaged<ISpeechDataKey*, ushort*, int>)(lpVtbl[15]))((ISpeechDataKey*)Unsafe.AsPointer(ref this), SubKeyName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT DeleteValue([NativeTypeName("const BSTR")] ushort* ValueName)
        {
            return ((delegate* unmanaged<ISpeechDataKey*, ushort*, int>)(lpVtbl[16]))((ISpeechDataKey*)Unsafe.AsPointer(ref this), ValueName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT EnumKeys([NativeTypeName("long")] int Index, [NativeTypeName("BSTR *")] ushort** SubKeyName)
        {
            return ((delegate* unmanaged<ISpeechDataKey*, int, ushort**, int>)(lpVtbl[17]))((ISpeechDataKey*)Unsafe.AsPointer(ref this), Index, SubKeyName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT EnumValues([NativeTypeName("long")] int Index, [NativeTypeName("BSTR *")] ushort** ValueName)
        {
            return ((delegate* unmanaged<ISpeechDataKey*, int, ushort**, int>)(lpVtbl[18]))((ISpeechDataKey*)Unsafe.AsPointer(ref this), Index, ValueName);
        }

        public interface Interface : IDispatch.Interface
        {
            [VtblIndex(7)]
            HRESULT SetBinaryValue([NativeTypeName("const BSTR")] ushort* ValueName, VARIANT Value);

            [VtblIndex(8)]
            HRESULT GetBinaryValue([NativeTypeName("const BSTR")] ushort* ValueName, VARIANT* Value);

            [VtblIndex(9)]
            HRESULT SetStringValue([NativeTypeName("const BSTR")] ushort* ValueName, [NativeTypeName("const BSTR")] ushort* Value);

            [VtblIndex(10)]
            HRESULT GetStringValue([NativeTypeName("const BSTR")] ushort* ValueName, [NativeTypeName("BSTR *")] ushort** Value);

            [VtblIndex(11)]
            HRESULT SetLongValue([NativeTypeName("const BSTR")] ushort* ValueName, [NativeTypeName("long")] int Value);

            [VtblIndex(12)]
            HRESULT GetLongValue([NativeTypeName("const BSTR")] ushort* ValueName, [NativeTypeName("long *")] int* Value);

            [VtblIndex(13)]
            HRESULT OpenKey([NativeTypeName("const BSTR")] ushort* SubKeyName, ISpeechDataKey** SubKey);

            [VtblIndex(14)]
            HRESULT CreateKey([NativeTypeName("const BSTR")] ushort* SubKeyName, ISpeechDataKey** SubKey);

            [VtblIndex(15)]
            HRESULT DeleteKey([NativeTypeName("const BSTR")] ushort* SubKeyName);

            [VtblIndex(16)]
            HRESULT DeleteValue([NativeTypeName("const BSTR")] ushort* ValueName);

            [VtblIndex(17)]
            HRESULT EnumKeys([NativeTypeName("long")] int Index, [NativeTypeName("BSTR *")] ushort** SubKeyName);

            [VtblIndex(18)]
            HRESULT EnumValues([NativeTypeName("long")] int Index, [NativeTypeName("BSTR *")] ushort** ValueName);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechDataKey*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechDataKey*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechDataKey*, uint> Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechDataKey*, uint*, int> GetTypeInfoCount;

            [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechDataKey*, uint, uint, ITypeInfo**, int> GetTypeInfo;

            [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechDataKey*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

            [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechDataKey*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;

            [NativeTypeName("HRESULT (const BSTR, VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechDataKey*, ushort*, VARIANT, int> SetBinaryValue;

            [NativeTypeName("HRESULT (const BSTR, VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechDataKey*, ushort*, VARIANT*, int> GetBinaryValue;

            [NativeTypeName("HRESULT (const BSTR, const BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechDataKey*, ushort*, ushort*, int> SetStringValue;

            [NativeTypeName("HRESULT (const BSTR, BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechDataKey*, ushort*, ushort**, int> GetStringValue;

            [NativeTypeName("HRESULT (const BSTR, long) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechDataKey*, ushort*, int, int> SetLongValue;

            [NativeTypeName("HRESULT (const BSTR, long *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechDataKey*, ushort*, int*, int> GetLongValue;

            [NativeTypeName("HRESULT (const BSTR, ISpeechDataKey **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechDataKey*, ushort*, ISpeechDataKey**, int> OpenKey;

            [NativeTypeName("HRESULT (const BSTR, ISpeechDataKey **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechDataKey*, ushort*, ISpeechDataKey**, int> CreateKey;

            [NativeTypeName("HRESULT (const BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechDataKey*, ushort*, int> DeleteKey;

            [NativeTypeName("HRESULT (const BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechDataKey*, ushort*, int> DeleteValue;

            [NativeTypeName("HRESULT (long, BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechDataKey*, int, ushort**, int> EnumKeys;

            [NativeTypeName("HRESULT (long, BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechDataKey*, int, ushort**, int> EnumValues;
        }
    }
}