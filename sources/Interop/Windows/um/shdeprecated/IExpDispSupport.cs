// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shdeprecated.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0D7D1D00-6FC0-11D0-A974-00C04FD705A2")]
    [NativeTypeName("struct IExpDispSupport : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IExpDispSupport
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IExpDispSupport*, Guid*, void**, int>)(lpVtbl[0]))((IExpDispSupport*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IExpDispSupport*, uint>)(lpVtbl[1]))((IExpDispSupport*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IExpDispSupport*, uint>)(lpVtbl[2]))((IExpDispSupport*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int FindConnectionPoint([NativeTypeName("const IID &")] Guid* riid, IConnectionPoint** ppccp)
        {
            return ((delegate* unmanaged<IExpDispSupport*, Guid*, IConnectionPoint**, int>)(lpVtbl[3]))((IExpDispSupport*)Unsafe.AsPointer(ref this), riid, ppccp);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int OnTranslateAccelerator(MSG* pMsg, [NativeTypeName("DWORD")] uint grfModifiers)
        {
            return ((delegate* unmanaged<IExpDispSupport*, MSG*, uint, int>)(lpVtbl[4]))((IExpDispSupport*)Unsafe.AsPointer(ref this), pMsg, grfModifiers);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int OnInvoke([NativeTypeName("DISPID")] int dispidMember, [NativeTypeName("const IID &")] Guid* iid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pdispparams, VARIANT* pVarResult, EXCEPINFO* pexcepinfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IExpDispSupport*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[5]))((IExpDispSupport*)Unsafe.AsPointer(ref this), dispidMember, iid, lcid, wFlags, pdispparams, pVarResult, pexcepinfo, puArgErr);
        }
    }
}