// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX
{
    public static unsafe partial class DirectX
    {
        [DllImport("dwrite", ExactSpelling = true)]
        public static extern HRESULT DWriteCreateFactory(DWRITE_FACTORY_TYPE factoryType, [NativeTypeName("const IID &")] Guid* iid, IUnknown** factory);

        [NativeTypeName("#define DWRITE_ALPHA_MAX 255")]
        public const int DWRITE_ALPHA_MAX = 255;

        [NativeTypeName("#define DWRITE_ERR_BASE 0x5000")]
        public const int DWRITE_ERR_BASE = 0x5000;
    }
}
