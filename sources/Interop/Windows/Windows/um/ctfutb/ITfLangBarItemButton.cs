// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ctfutb.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("28C7F1D0-DE25-11D2-AFDD-00105A2799B5")]
    [NativeTypeName("struct ITfLangBarItemButton : ITfLangBarItem")]
    [NativeInheritance("ITfLangBarItem")]
    public unsafe partial struct ITfLangBarItemButton : ITfLangBarItemButton.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfLangBarItemButton*, Guid*, void**, int>)(lpVtbl[0]))((ITfLangBarItemButton*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfLangBarItemButton*, uint>)(lpVtbl[1]))((ITfLangBarItemButton*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfLangBarItemButton*, uint>)(lpVtbl[2]))((ITfLangBarItemButton*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetInfo(TF_LANGBARITEMINFO* pInfo)
        {
            return ((delegate* unmanaged<ITfLangBarItemButton*, TF_LANGBARITEMINFO*, int>)(lpVtbl[3]))((ITfLangBarItemButton*)Unsafe.AsPointer(ref this), pInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetStatus([NativeTypeName("DWORD *")] uint* pdwStatus)
        {
            return ((delegate* unmanaged<ITfLangBarItemButton*, uint*, int>)(lpVtbl[4]))((ITfLangBarItemButton*)Unsafe.AsPointer(ref this), pdwStatus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT Show(BOOL fShow)
        {
            return ((delegate* unmanaged<ITfLangBarItemButton*, BOOL, int>)(lpVtbl[5]))((ITfLangBarItemButton*)Unsafe.AsPointer(ref this), fShow);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetTooltipString([NativeTypeName("BSTR *")] ushort** pbstrToolTip)
        {
            return ((delegate* unmanaged<ITfLangBarItemButton*, ushort**, int>)(lpVtbl[6]))((ITfLangBarItemButton*)Unsafe.AsPointer(ref this), pbstrToolTip);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT OnClick(TfLBIClick click, POINT pt, [NativeTypeName("const RECT *")] RECT* prcArea)
        {
            return ((delegate* unmanaged<ITfLangBarItemButton*, TfLBIClick, POINT, RECT*, int>)(lpVtbl[7]))((ITfLangBarItemButton*)Unsafe.AsPointer(ref this), click, pt, prcArea);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT InitMenu(ITfMenu* pMenu)
        {
            return ((delegate* unmanaged<ITfLangBarItemButton*, ITfMenu*, int>)(lpVtbl[8]))((ITfLangBarItemButton*)Unsafe.AsPointer(ref this), pMenu);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT OnMenuSelect(uint wID)
        {
            return ((delegate* unmanaged<ITfLangBarItemButton*, uint, int>)(lpVtbl[9]))((ITfLangBarItemButton*)Unsafe.AsPointer(ref this), wID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT GetIcon(HICON* phIcon)
        {
            return ((delegate* unmanaged<ITfLangBarItemButton*, HICON*, int>)(lpVtbl[10]))((ITfLangBarItemButton*)Unsafe.AsPointer(ref this), phIcon);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT GetText([NativeTypeName("BSTR *")] ushort** pbstrText)
        {
            return ((delegate* unmanaged<ITfLangBarItemButton*, ushort**, int>)(lpVtbl[11]))((ITfLangBarItemButton*)Unsafe.AsPointer(ref this), pbstrText);
        }

        public interface Interface : ITfLangBarItem.Interface
        {
            [VtblIndex(7)]
            HRESULT OnClick(TfLBIClick click, POINT pt, [NativeTypeName("const RECT *")] RECT* prcArea);

            [VtblIndex(8)]
            HRESULT InitMenu(ITfMenu* pMenu);

            [VtblIndex(9)]
            HRESULT OnMenuSelect(uint wID);

            [VtblIndex(10)]
            HRESULT GetIcon(HICON* phIcon);

            [VtblIndex(11)]
            HRESULT GetText([NativeTypeName("BSTR *")] ushort** pbstrText);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfLangBarItemButton*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ITfLangBarItemButton*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ITfLangBarItemButton*, uint> Release;

            [NativeTypeName("HRESULT (TF_LANGBARITEMINFO *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfLangBarItemButton*, TF_LANGBARITEMINFO*, int> GetInfo;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfLangBarItemButton*, uint*, int> GetStatus;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfLangBarItemButton*, BOOL, int> Show;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfLangBarItemButton*, ushort**, int> GetTooltipString;

            [NativeTypeName("HRESULT (TfLBIClick, POINT, const RECT *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfLangBarItemButton*, TfLBIClick, POINT, RECT*, int> OnClick;

            [NativeTypeName("HRESULT (ITfMenu *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfLangBarItemButton*, ITfMenu*, int> InitMenu;

            [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfLangBarItemButton*, uint, int> OnMenuSelect;

            [NativeTypeName("HRESULT (HICON *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfLangBarItemButton*, HICON*, int> GetIcon;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfLangBarItemButton*, ushort**, int> GetText;
        }
    }
}