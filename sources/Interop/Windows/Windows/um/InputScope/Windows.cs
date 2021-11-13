// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/InputScope.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    public static unsafe partial class Windows
    {
        [DllImport("msctf", ExactSpelling = true)]
        public static extern HRESULT SetInputScope(HWND hwnd, InputScope inputscope);

        [DllImport("msctf", ExactSpelling = true)]
        public static extern HRESULT SetInputScopes(HWND hwnd, [NativeTypeName("const InputScope *")] InputScope* pInputScopes, uint cInputScopes, [NativeTypeName("PWSTR *")] ushort** ppszPhraseList, uint cPhrases, [NativeTypeName("PWSTR")] ushort* pszRegExp, [NativeTypeName("PWSTR")] ushort* pszSRGS);

        [DllImport("msctf", ExactSpelling = true)]
        public static extern HRESULT SetInputScopeXML(HWND hwnd, [NativeTypeName("PWSTR")] ushort* pszXML);

        [DllImport("msctf", ExactSpelling = true)]
        public static extern HRESULT SetInputScopes2(HWND hwnd, [NativeTypeName("const InputScope *")] InputScope* pInputScopes, uint cInputScopes, IEnumString* pEnumString, [NativeTypeName("PWSTR")] ushort* pszRegExp, [NativeTypeName("PWSTR")] ushort* pszSRGS);

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ITfInputScope
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xEE, 0xEA, 0xE1, 0xFD,
                    0x24, 0x69,
                    0xDF, 0x4C,
                    0x91,
                    0xE7,
                    0xDA,
                    0x38,
                    0xCF,
                    0xF5,
                    0x55,
                    0x9D
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ITfInputScope2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA0, 0xEA, 0x31, 0x57,
                    0xC2, 0x6B,
                    0x81, 0x46,
                    0xA5,
                    0x32,
                    0x92,
                    0xFB,
                    0xB7,
                    0x4D,
                    0x7C,
                    0x41
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_PROP_INPUTSCOPE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x5A, 0xDD, 0x13, 0x17,
                    0xE7, 0x68,
                    0x5B, 0x4A,
                    0x9A,
                    0xF6,
                    0x59,
                    0x2A,
                    0x59,
                    0x5C,
                    0x77,
                    0x8D
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }
    }
}