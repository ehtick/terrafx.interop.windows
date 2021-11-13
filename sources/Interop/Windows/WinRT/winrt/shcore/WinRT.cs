// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/shcore.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.WinRT
{
    public static unsafe partial class WinRT
    {
        [DllImport("shcore", ExactSpelling = true)]
        public static extern HRESULT CreateRandomAccessStreamOnFile([NativeTypeName("PCWSTR")] ushort* filePath, [NativeTypeName("DWORD")] uint accessMode, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

        [DllImport("shcore", ExactSpelling = true)]
        public static extern HRESULT CreateRandomAccessStreamOverStream(IStream* stream, BSOS_OPTIONS options, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

        [DllImport("shcore", ExactSpelling = true)]
        public static extern HRESULT CreateStreamOverRandomAccessStream(IUnknown* randomAccessStream, [NativeTypeName("const IID &")] Guid* riid, void** ppv);
    }
}