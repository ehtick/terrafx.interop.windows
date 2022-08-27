// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct SHELLEXECUTEINFOW
{
    public static uint SizeOf
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return (uint)(sizeof(SHELLEXECUTEINFO32W));
            }
            else
            {
                return (uint)(sizeof(SHELLEXECUTEINFO64W));
            }
        }
    }

    [FieldOffset(0)]
    public SHELLEXECUTEINFO32W _value32;

    [FieldOffset(0)]
    public SHELLEXECUTEINFO64W _value64;

    [NativeTypeName("DWORD")]
    [UnscopedRef]
    public ref uint cbSize
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.cbSize;
            }
            else
            {
                return ref _value64.cbSize;
            }
        }
    }

    [NativeTypeName("ULONG")]
    [UnscopedRef]
    public ref uint fMask
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.fMask;
            }
            else
            {
                return ref _value64.fMask;
            }
        }
    }

    [UnscopedRef]
    public ref HWND hwnd
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.hwnd;
            }
            else
            {
                return ref _value64.hwnd;
            }
        }
    }

    [NativeTypeName("LPCWSTR")]
    [UnscopedRef]
    public ref ushort* lpVerb
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.lpVerb;
            }
            else
            {
                return ref _value64.lpVerb;
            }
        }
    }

    [NativeTypeName("LPCWSTR")]
    [UnscopedRef]
    public ref ushort* lpFile
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.lpFile;
            }
            else
            {
                return ref _value64.lpFile;
            }
        }
    }

    [NativeTypeName("LPCWSTR")]
    [UnscopedRef]
    public ref ushort* lpParameters
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.lpParameters;
            }
            else
            {
                return ref _value64.lpParameters;
            }
        }
    }

    [NativeTypeName("LPCWSTR")]
    [UnscopedRef]
    public ref ushort* lpDirectory
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.lpDirectory;
            }
            else
            {
                return ref _value64.lpDirectory;
            }
        }
    }

    [UnscopedRef]
    public ref int nShow
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.nShow;
            }
            else
            {
                return ref _value64.nShow;
            }
        }
    }

    [UnscopedRef]
    public ref HINSTANCE hInstApp
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.hInstApp;
            }
            else
            {
                return ref _value64.hInstApp;
            }
        }
    }

    [UnscopedRef]
    public ref void* lpIDList
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.lpIDList;
            }
            else
            {
                return ref _value64.lpIDList;
            }
        }
    }

    [NativeTypeName("LPCWSTR")]
    [UnscopedRef]
    public ref ushort* lpClass
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.lpClass;
            }
            else
            {
                return ref _value64.lpClass;
            }
        }
    }

    [UnscopedRef]
    public ref HKEY hkeyClass
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.hkeyClass;
            }
            else
            {
                return ref _value64.hkeyClass;
            }
        }
    }

    [NativeTypeName("DWORD")]
    [UnscopedRef]
    public ref uint dwHotKey
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.dwHotKey;
            }
            else
            {
                return ref _value64.dwHotKey;
            }
        }
    }

    [UnscopedRef]
    public ref HANDLE hProcess
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.hProcess;
            }
            else
            {
                return ref _value64.hProcess;
            }
        }
    }

    [UnscopedRef]
    public ref HANDLE hIcon
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.hIcon;
            }
            else
            {
                return ref _value64.hIcon;
            }
        }
    }

    [UnscopedRef]
    public ref HANDLE hMonitor
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.hMonitor;
            }
            else
            {
                return ref _value64.hMonitor;
            }
        }
    }
}
