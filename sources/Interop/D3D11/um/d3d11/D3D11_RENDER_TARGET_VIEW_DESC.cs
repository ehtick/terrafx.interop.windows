// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct D3D11_RENDER_TARGET_VIEW_DESC
    {
        public DXGI_FORMAT Format;

        public D3D11_RTV_DIMENSION ViewDimension;

        [NativeTypeName("D3D11_RENDER_TARGET_VIEW_DESC::(anonymous union at um/d3d11.h:3813:5)")]
        public _Anonymous_e__Union Anonymous;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            public D3D11_BUFFER_RTV Buffer;

            [FieldOffset(0)]
            public D3D11_TEX1D_RTV Texture1D;

            [FieldOffset(0)]
            public D3D11_TEX1D_ARRAY_RTV Texture1DArray;

            [FieldOffset(0)]
            public D3D11_TEX2D_RTV Texture2D;

            [FieldOffset(0)]
            public D3D11_TEX2D_ARRAY_RTV Texture2DArray;

            [FieldOffset(0)]
            public D3D11_TEX2DMS_RTV Texture2DMS;

            [FieldOffset(0)]
            public D3D11_TEX2DMS_ARRAY_RTV Texture2DMSArray;

            [FieldOffset(0)]
            public D3D11_TEX3D_RTV Texture3D;
        }
    }
}