// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlDisp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D8F015C0-C278-11CE-A49E-444553540000")]
    [NativeTypeName("struct IShellDispatch : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IShellDispatch
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IShellDispatch*, Guid*, void**, int>)(lpVtbl[0]))((IShellDispatch*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IShellDispatch*, uint>)(lpVtbl[1]))((IShellDispatch*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IShellDispatch*, uint>)(lpVtbl[2]))((IShellDispatch*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IShellDispatch*, uint*, int>)(lpVtbl[3]))((IShellDispatch*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IShellDispatch*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IShellDispatch*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IShellDispatch*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IShellDispatch*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IShellDispatch*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IShellDispatch*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int get_Application(IDispatch** ppid)
        {
            return ((delegate* unmanaged<IShellDispatch*, IDispatch**, int>)(lpVtbl[7]))((IShellDispatch*)Unsafe.AsPointer(ref this), ppid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int get_Parent(IDispatch** ppid)
        {
            return ((delegate* unmanaged<IShellDispatch*, IDispatch**, int>)(lpVtbl[8]))((IShellDispatch*)Unsafe.AsPointer(ref this), ppid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int NameSpace(VARIANT vDir, Folder** ppsdf)
        {
            return ((delegate* unmanaged<IShellDispatch*, VARIANT, Folder**, int>)(lpVtbl[9]))((IShellDispatch*)Unsafe.AsPointer(ref this), vDir, ppsdf);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int BrowseForFolder([NativeTypeName("long")] int Hwnd, [NativeTypeName("BSTR")] ushort* Title, [NativeTypeName("long")] int Options, VARIANT RootFolder, Folder** ppsdf)
        {
            return ((delegate* unmanaged<IShellDispatch*, int, ushort*, int, VARIANT, Folder**, int>)(lpVtbl[10]))((IShellDispatch*)Unsafe.AsPointer(ref this), Hwnd, Title, Options, RootFolder, ppsdf);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int Windows(IDispatch** ppid)
        {
            return ((delegate* unmanaged<IShellDispatch*, IDispatch**, int>)(lpVtbl[11]))((IShellDispatch*)Unsafe.AsPointer(ref this), ppid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int Open(VARIANT vDir)
        {
            return ((delegate* unmanaged<IShellDispatch*, VARIANT, int>)(lpVtbl[12]))((IShellDispatch*)Unsafe.AsPointer(ref this), vDir);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int Explore(VARIANT vDir)
        {
            return ((delegate* unmanaged<IShellDispatch*, VARIANT, int>)(lpVtbl[13]))((IShellDispatch*)Unsafe.AsPointer(ref this), vDir);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int MinimizeAll()
        {
            return ((delegate* unmanaged<IShellDispatch*, int>)(lpVtbl[14]))((IShellDispatch*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int UndoMinimizeALL()
        {
            return ((delegate* unmanaged<IShellDispatch*, int>)(lpVtbl[15]))((IShellDispatch*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int FileRun()
        {
            return ((delegate* unmanaged<IShellDispatch*, int>)(lpVtbl[16]))((IShellDispatch*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int CascadeWindows()
        {
            return ((delegate* unmanaged<IShellDispatch*, int>)(lpVtbl[17]))((IShellDispatch*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int TileVertically()
        {
            return ((delegate* unmanaged<IShellDispatch*, int>)(lpVtbl[18]))((IShellDispatch*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int TileHorizontally()
        {
            return ((delegate* unmanaged<IShellDispatch*, int>)(lpVtbl[19]))((IShellDispatch*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int ShutdownWindows()
        {
            return ((delegate* unmanaged<IShellDispatch*, int>)(lpVtbl[20]))((IShellDispatch*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int Suspend()
        {
            return ((delegate* unmanaged<IShellDispatch*, int>)(lpVtbl[21]))((IShellDispatch*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("HRESULT")]
        public int EjectPC()
        {
            return ((delegate* unmanaged<IShellDispatch*, int>)(lpVtbl[22]))((IShellDispatch*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        [return: NativeTypeName("HRESULT")]
        public int SetTime()
        {
            return ((delegate* unmanaged<IShellDispatch*, int>)(lpVtbl[23]))((IShellDispatch*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        [return: NativeTypeName("HRESULT")]
        public int TrayProperties()
        {
            return ((delegate* unmanaged<IShellDispatch*, int>)(lpVtbl[24]))((IShellDispatch*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        [return: NativeTypeName("HRESULT")]
        public int Help()
        {
            return ((delegate* unmanaged<IShellDispatch*, int>)(lpVtbl[25]))((IShellDispatch*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        [return: NativeTypeName("HRESULT")]
        public int FindFiles()
        {
            return ((delegate* unmanaged<IShellDispatch*, int>)(lpVtbl[26]))((IShellDispatch*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        [return: NativeTypeName("HRESULT")]
        public int FindComputer()
        {
            return ((delegate* unmanaged<IShellDispatch*, int>)(lpVtbl[27]))((IShellDispatch*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        [return: NativeTypeName("HRESULT")]
        public int RefreshMenu()
        {
            return ((delegate* unmanaged<IShellDispatch*, int>)(lpVtbl[28]))((IShellDispatch*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        [return: NativeTypeName("HRESULT")]
        public int ControlPanelItem([NativeTypeName("BSTR")] ushort* bstrDir)
        {
            return ((delegate* unmanaged<IShellDispatch*, ushort*, int>)(lpVtbl[29]))((IShellDispatch*)Unsafe.AsPointer(ref this), bstrDir);
        }
    }
}