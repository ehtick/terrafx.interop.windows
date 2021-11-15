// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public enum IMAGEHLP_SYMBOL_TYPE_INFO
    {
        TI_GET_SYMTAG,
        TI_GET_SYMNAME,
        TI_GET_LENGTH,
        TI_GET_TYPE,
        TI_GET_TYPEID,
        TI_GET_BASETYPE,
        TI_GET_ARRAYINDEXTYPEID,
        TI_FINDCHILDREN,
        TI_GET_DATAKIND,
        TI_GET_ADDRESSOFFSET,
        TI_GET_OFFSET,
        TI_GET_VALUE,
        TI_GET_COUNT,
        TI_GET_CHILDRENCOUNT,
        TI_GET_BITPOSITION,
        TI_GET_VIRTUALBASECLASS,
        TI_GET_VIRTUALTABLESHAPEID,
        TI_GET_VIRTUALBASEPOINTEROFFSET,
        TI_GET_CLASSPARENTID,
        TI_GET_NESTED,
        TI_GET_SYMINDEX,
        TI_GET_LEXICALPARENT,
        TI_GET_ADDRESS,
        TI_GET_THISADJUST,
        TI_GET_UDTKIND,
        TI_IS_EQUIV_TO,
        TI_GET_CALLING_CONVENTION,
        TI_IS_CLOSE_EQUIV_TO,
        TI_GTIEX_REQS_VALID,
        TI_GET_VIRTUALBASEOFFSET,
        TI_GET_VIRTUALBASEDISPINDEX,
        TI_GET_IS_REFERENCE,
        TI_GET_INDIRECTVIRTUALBASECLASS,
        TI_GET_VIRTUALBASETABLETYPE,
        IMAGEHLP_SYMBOL_TYPE_INFO_MAX,
    }
}