// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/handleapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows
{
    public static unsafe partial class Windows
    {
        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CloseHandle(HANDLE hObject);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL DuplicateHandle(HANDLE hSourceProcessHandle, HANDLE hSourceHandle, HANDLE hTargetProcessHandle, [NativeTypeName("LPHANDLE")] HANDLE* lpTargetHandle, [NativeTypeName("DWORD")] uint dwDesiredAccess, BOOL bInheritHandle, [NativeTypeName("DWORD")] uint dwOptions);

        [SupportedOSPlatform("windows10.0")]
        [DllImport("kernelbase", ExactSpelling = true)]
        public static extern BOOL CompareObjectHandles(HANDLE hFirstObjectHandle, HANDLE hSecondObjectHandle);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL GetHandleInformation(HANDLE hObject, [NativeTypeName("LPDWORD")] uint* lpdwFlags);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetHandleInformation(HANDLE hObject, [NativeTypeName("DWORD")] uint dwMask, [NativeTypeName("DWORD")] uint dwFlags);
    }
}