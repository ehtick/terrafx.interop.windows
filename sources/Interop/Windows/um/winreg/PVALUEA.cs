// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winreg.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct PVALUEA
    {
        [NativeTypeName("LPSTR")]
        public sbyte* pv_valuename;

        public int pv_valuelen;

        [NativeTypeName("LPVOID")]
        public void* pv_value_context;

        [NativeTypeName("DWORD")]
        public uint pv_type;
    }
}