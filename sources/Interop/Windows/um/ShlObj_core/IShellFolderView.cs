// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("37A378C0-F82D-11CE-AE65-08002B2E1262")]
    [NativeTypeName("struct IShellFolderView : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IShellFolderView
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IShellFolderView*, Guid*, void**, int>)(lpVtbl[0]))((IShellFolderView*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IShellFolderView*, uint>)(lpVtbl[1]))((IShellFolderView*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IShellFolderView*, uint>)(lpVtbl[2]))((IShellFolderView*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int Rearrange([NativeTypeName("LPARAM")] nint lParamSort)
        {
            return ((delegate* unmanaged<IShellFolderView*, nint, int>)(lpVtbl[3]))((IShellFolderView*)Unsafe.AsPointer(ref this), lParamSort);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetArrangeParam([NativeTypeName("LPARAM *")] nint* plParamSort)
        {
            return ((delegate* unmanaged<IShellFolderView*, nint*, int>)(lpVtbl[4]))((IShellFolderView*)Unsafe.AsPointer(ref this), plParamSort);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int ArrangeGrid()
        {
            return ((delegate* unmanaged<IShellFolderView*, int>)(lpVtbl[5]))((IShellFolderView*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int AutoArrange()
        {
            return ((delegate* unmanaged<IShellFolderView*, int>)(lpVtbl[6]))((IShellFolderView*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int GetAutoArrange()
        {
            return ((delegate* unmanaged<IShellFolderView*, int>)(lpVtbl[7]))((IShellFolderView*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int AddObject([NativeTypeName("LPITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("UINT *")] uint* puItem)
        {
            return ((delegate* unmanaged<IShellFolderView*, ITEMIDLIST*, uint*, int>)(lpVtbl[8]))((IShellFolderView*)Unsafe.AsPointer(ref this), pidl, puItem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int GetObjectW([NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidl, [NativeTypeName("UINT")] uint uItem)
        {
            return ((delegate* unmanaged<IShellFolderView*, ITEMIDLIST**, uint, int>)(lpVtbl[9]))((IShellFolderView*)Unsafe.AsPointer(ref this), ppidl, uItem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int RemoveObject([NativeTypeName("LPITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("UINT *")] uint* puItem)
        {
            return ((delegate* unmanaged<IShellFolderView*, ITEMIDLIST*, uint*, int>)(lpVtbl[10]))((IShellFolderView*)Unsafe.AsPointer(ref this), pidl, puItem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int GetObjectCount([NativeTypeName("UINT *")] uint* puCount)
        {
            return ((delegate* unmanaged<IShellFolderView*, uint*, int>)(lpVtbl[11]))((IShellFolderView*)Unsafe.AsPointer(ref this), puCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int SetObjectCount([NativeTypeName("UINT")] uint uCount, [NativeTypeName("UINT")] uint dwFlags)
        {
            return ((delegate* unmanaged<IShellFolderView*, uint, uint, int>)(lpVtbl[12]))((IShellFolderView*)Unsafe.AsPointer(ref this), uCount, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int UpdateObject([NativeTypeName("LPITEMIDLIST")] ITEMIDLIST* pidlOld, [NativeTypeName("LPITEMIDLIST")] ITEMIDLIST* pidlNew, [NativeTypeName("UINT *")] uint* puItem)
        {
            return ((delegate* unmanaged<IShellFolderView*, ITEMIDLIST*, ITEMIDLIST*, uint*, int>)(lpVtbl[13]))((IShellFolderView*)Unsafe.AsPointer(ref this), pidlOld, pidlNew, puItem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int RefreshObject([NativeTypeName("LPITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("UINT *")] uint* puItem)
        {
            return ((delegate* unmanaged<IShellFolderView*, ITEMIDLIST*, uint*, int>)(lpVtbl[14]))((IShellFolderView*)Unsafe.AsPointer(ref this), pidl, puItem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int SetRedraw([NativeTypeName("BOOL")] int bRedraw)
        {
            return ((delegate* unmanaged<IShellFolderView*, int, int>)(lpVtbl[15]))((IShellFolderView*)Unsafe.AsPointer(ref this), bRedraw);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int GetSelectedCount([NativeTypeName("UINT *")] uint* puSelected)
        {
            return ((delegate* unmanaged<IShellFolderView*, uint*, int>)(lpVtbl[16]))((IShellFolderView*)Unsafe.AsPointer(ref this), puSelected);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int GetSelectedObjects([NativeTypeName("LPCITEMIDLIST **")] ITEMIDLIST*** pppidl, [NativeTypeName("UINT *")] uint* puItems)
        {
            return ((delegate* unmanaged<IShellFolderView*, ITEMIDLIST***, uint*, int>)(lpVtbl[17]))((IShellFolderView*)Unsafe.AsPointer(ref this), pppidl, puItems);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int IsDropOnSource(IDropTarget* pDropTarget)
        {
            return ((delegate* unmanaged<IShellFolderView*, IDropTarget*, int>)(lpVtbl[18]))((IShellFolderView*)Unsafe.AsPointer(ref this), pDropTarget);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int GetDragPoint(POINT* ppt)
        {
            return ((delegate* unmanaged<IShellFolderView*, POINT*, int>)(lpVtbl[19]))((IShellFolderView*)Unsafe.AsPointer(ref this), ppt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int GetDropPoint(POINT* ppt)
        {
            return ((delegate* unmanaged<IShellFolderView*, POINT*, int>)(lpVtbl[20]))((IShellFolderView*)Unsafe.AsPointer(ref this), ppt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int MoveIcons(IDataObject* pDataObject)
        {
            return ((delegate* unmanaged<IShellFolderView*, IDataObject*, int>)(lpVtbl[21]))((IShellFolderView*)Unsafe.AsPointer(ref this), pDataObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("HRESULT")]
        public int SetItemPos([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, POINT* ppt)
        {
            return ((delegate* unmanaged<IShellFolderView*, ITEMIDLIST*, POINT*, int>)(lpVtbl[22]))((IShellFolderView*)Unsafe.AsPointer(ref this), pidl, ppt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        [return: NativeTypeName("HRESULT")]
        public int IsBkDropTarget(IDropTarget* pDropTarget)
        {
            return ((delegate* unmanaged<IShellFolderView*, IDropTarget*, int>)(lpVtbl[23]))((IShellFolderView*)Unsafe.AsPointer(ref this), pDropTarget);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        [return: NativeTypeName("HRESULT")]
        public int SetClipboard([NativeTypeName("BOOL")] int bMove)
        {
            return ((delegate* unmanaged<IShellFolderView*, int, int>)(lpVtbl[24]))((IShellFolderView*)Unsafe.AsPointer(ref this), bMove);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        [return: NativeTypeName("HRESULT")]
        public int SetPoints(IDataObject* pDataObject)
        {
            return ((delegate* unmanaged<IShellFolderView*, IDataObject*, int>)(lpVtbl[25]))((IShellFolderView*)Unsafe.AsPointer(ref this), pDataObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        [return: NativeTypeName("HRESULT")]
        public int GetItemSpacing(ITEMSPACING* pSpacing)
        {
            return ((delegate* unmanaged<IShellFolderView*, ITEMSPACING*, int>)(lpVtbl[26]))((IShellFolderView*)Unsafe.AsPointer(ref this), pSpacing);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        [return: NativeTypeName("HRESULT")]
        public int SetCallback(IShellFolderViewCB* pNewCB, IShellFolderViewCB** ppOldCB)
        {
            return ((delegate* unmanaged<IShellFolderView*, IShellFolderViewCB*, IShellFolderViewCB**, int>)(lpVtbl[27]))((IShellFolderView*)Unsafe.AsPointer(ref this), pNewCB, ppOldCB);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        [return: NativeTypeName("HRESULT")]
        public int Select([NativeTypeName("UINT")] uint dwFlags)
        {
            return ((delegate* unmanaged<IShellFolderView*, uint, int>)(lpVtbl[28]))((IShellFolderView*)Unsafe.AsPointer(ref this), dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        [return: NativeTypeName("HRESULT")]
        public int QuerySupport([NativeTypeName("UINT *")] uint* pdwSupport)
        {
            return ((delegate* unmanaged<IShellFolderView*, uint*, int>)(lpVtbl[29]))((IShellFolderView*)Unsafe.AsPointer(ref this), pdwSupport);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        [return: NativeTypeName("HRESULT")]
        public int SetAutomationObject(IDispatch* pdisp)
        {
            return ((delegate* unmanaged<IShellFolderView*, IDispatch*, int>)(lpVtbl[30]))((IShellFolderView*)Unsafe.AsPointer(ref this), pdisp);
        }
    }
}