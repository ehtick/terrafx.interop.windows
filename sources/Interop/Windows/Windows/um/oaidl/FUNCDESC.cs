// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct FUNCDESC
    {
        [NativeTypeName("MEMBERID")]
        public int memid;

        [NativeTypeName("SCODE *")]
        public int* lprgscode;

        public ELEMDESC* lprgelemdescParam;

        public FUNCKIND funckind;

        public INVOKEKIND invkind;

        public CALLCONV callconv;

        public short cParams;

        public short cParamsOpt;

        public short oVft;

        public short cScodes;

        public ELEMDESC elemdescFunc;

        [NativeTypeName("WORD")]
        public ushort wFuncFlags;
    }
}