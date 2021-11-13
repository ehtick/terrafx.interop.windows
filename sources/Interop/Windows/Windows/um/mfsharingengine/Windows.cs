// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfsharingengine.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    public static partial class Windows
    {
        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_MEDIA_SHARING_ENGINE_DEVICE_NAME
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD1, 0x05, 0x1E, 0x77,
                    0x2F, 0x86,
                    0x99, 0x42,
                    0x95,
                    0xAC,
                    0xAE,
                    0x81,
                    0xFD,
                    0x14,
                    0xF3,
                    0xE7
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MF_MEDIA_SHARING_ENGINE_DEVICE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x8A, 0xC5, 0x61, 0xB4,
                    0x08, 0x7A,
                    0x98, 0x4B,
                    0x99,
                    0xA8,
                    0x70,
                    0xFD,
                    0x5F,
                    0x3B,
                    0xAD,
                    0xFD
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_MEDIA_SHARING_ENGINE_INITIAL_SEEK_TIME
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF5, 0x97, 0x34, 0x6F,
                    0x28, 0xD5,
                    0x4F, 0x4A,
                    0x8D,
                    0xD7,
                    0xDB,
                    0x36,
                    0x65,
                    0x7E,
                    0xC4,
                    0xC9
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_SHUTDOWN_RENDERER_ON_ENGINE_SHUTDOWN
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x4D, 0xD9, 0x12, 0xC1,
                    0x9C, 0x6B,
                    0xF8, 0x48,
                    0xB6,
                    0xF9,
                    0x79,
                    0x50,
                    0xFF,
                    0x9A,
                    0xB7,
                    0x1E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_PREFERRED_SOURCE_URI
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x88, 0x54, 0xC8, 0x5F,
                    0x6A, 0x43,
                    0xB8, 0x4D,
                    0x90,
                    0xAF,
                    0x4D,
                    0xB4,
                    0x02,
                    0xAE,
                    0x5C,
                    0x57
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_SHARING_ENGINE_SHAREDRENDERER
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA0, 0x46, 0xA4, 0xEF,
                    0xE7, 0x73,
                    0x4E, 0x40,
                    0x8A,
                    0xE2,
                    0xFE,
                    0xF6,
                    0x0A,
                    0xF5,
                    0xA3,
                    0x2B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MF_SHARING_ENGINE_CALLBACK
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x95, 0x1E, 0xDC, 0x57,
                    0x52, 0xD2,
                    0xFA, 0x43,
                    0x9B,
                    0xBC,
                    0x18,
                    0x00,
                    0x70,
                    0xEE,
                    0xFE,
                    0x6D
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid CLSID_MFMediaSharingEngineClassFactory
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xFB, 0x07, 0xE3, 0xF8,
                    0x45, 0x6D,
                    0xD3, 0x4A,
                    0x99,
                    0x93,
                    0x66,
                    0xCD,
                    0x5A,
                    0x52,
                    0x96,
                    0x59
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid CLSID_MFImageSharingEngineClassFactory
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x39, 0x33, 0x2C, 0xB2,
                    0xF3, 0x87,
                    0x59, 0x40,
                    0xA0,
                    0xC5,
                    0x03,
                    0x7A,
                    0xA9,
                    0x70,
                    0x7E,
                    0xAF
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid CLSID_PlayToSourceClassFactory
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x9A, 0x53, 0x17, 0xDA,
                    0xC3, 0x3D,
                    0xC1, 0x42,
                    0xA7,
                    0x49,
                    0xA1,
                    0x83,
                    0xB5,
                    0x1F,
                    0x08,
                    0x5E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid GUID_PlayToService
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x9D, 0xFF, 0xA8, 0xF6,
                    0x14, 0x9E,
                    0xC9, 0x41,
                    0xBF,
                    0x0F,
                    0x12,
                    0x0A,
                    0x2B,
                    0x3C,
                    0xE1,
                    0x20
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid GUID_NativeDeviceService
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x3C, 0xE5, 0x71, 0xEF,
                    0xF4, 0x52,
                    0xC5, 0x43,
                    0xB8,
                    0x6A,
                    0xAD,
                    0x6C,
                    0xB2,
                    0x16,
                    0xA6,
                    0x1E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFSharingEngineClassFactory
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x92, 0x1F, 0xA6, 0x2B,
                    0x05, 0x83,
                    0x3B, 0x41,
                    0x97,
                    0x33,
                    0xFA,
                    0xF1,
                    0x5F,
                    0x25,
                    0x93,
                    0x84
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFMediaSharingEngine
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xBF, 0xE1, 0x3C, 0x8D,
                    0x67, 0x23,
                    0xE0, 0x40,
                    0x9E,
                    0xEE,
                    0x40,
                    0xD3,
                    0x77,
                    0xCC,
                    0x1B,
                    0x46
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFMediaSharingEngineClassFactory
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC4, 0x2B, 0x4D, 0x52,
                    0xB1, 0xB2,
                    0xE5, 0x4F,
                    0x8F,
                    0xAC,
                    0xFA,
                    0x4E,
                    0x45,
                    0x12,
                    0xB4,
                    0xE0
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFImageSharingEngine
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x8E, 0xAE, 0xA0, 0xCF,
                    0x1C, 0x7E,
                    0xD2, 0x44,
                    0xAE,
                    0x68,
                    0xFC,
                    0x4C,
                    0x14,
                    0x8A,
                    0x63,
                    0x54
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFImageSharingEngineClassFactory
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x27, 0x57, 0xC5, 0x1F,
                    0xFB, 0xA7,
                    0xC8, 0x4F,
                    0x83,
                    0xAE,
                    0x8A,
                    0xF0,
                    0x24,
                    0x99,
                    0x0A,
                    0xF1
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IPlayToControl
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xEB, 0x74, 0x75, 0x60,
                    0xB6, 0xF4,
                    0xC1, 0x45,
                    0xB0,
                    0x8C,
                    0xCB,
                    0x71,
                    0x51,
                    0x22,
                    0x90,
                    0x1D
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IPlayToControlWithCapabilities
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x0F, 0xD8, 0x9D, 0xAA,
                    0x0A, 0xC5,
                    0x20, 0x42,
                    0x91,
                    0xC1,
                    0x33,
                    0x22,
                    0x87,
                    0xF8,
                    0x2A,
                    0x34
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IPlayToSourceClassFactory
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA3, 0x32, 0x2B, 0x84,
                    0x9B, 0x9B,
                    0x1C, 0x4D,
                    0xB3,
                    0xF3,
                    0x49,
                    0x19,
                    0x32,
                    0x48,
                    0xA5,
                    0x54
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }
    }
}