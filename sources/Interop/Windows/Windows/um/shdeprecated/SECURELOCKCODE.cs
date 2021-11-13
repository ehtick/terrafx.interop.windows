// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shdeprecated.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public enum SECURELOCKCODE
    {
        SECURELOCK_NOCHANGE = -1,
        SECURELOCK_SET_UNSECURE = 0,
        SECURELOCK_SET_MIXED = (SECURELOCK_SET_UNSECURE + 1),
        SECURELOCK_SET_SECUREUNKNOWNBIT = (SECURELOCK_SET_MIXED + 1),
        SECURELOCK_SET_SECURE40BIT = (SECURELOCK_SET_SECUREUNKNOWNBIT + 1),
        SECURELOCK_SET_SECURE56BIT = (SECURELOCK_SET_SECURE40BIT + 1),
        SECURELOCK_SET_FORTEZZA = (SECURELOCK_SET_SECURE56BIT + 1),
        SECURELOCK_SET_SECURE128BIT = (SECURELOCK_SET_FORTEZZA + 1),
        SECURELOCK_FIRSTSUGGEST = (SECURELOCK_SET_SECURE128BIT + 1),
        SECURELOCK_SUGGEST_UNSECURE = SECURELOCK_FIRSTSUGGEST,
        SECURELOCK_SUGGEST_MIXED = (SECURELOCK_SUGGEST_UNSECURE + 1),
        SECURELOCK_SUGGEST_SECUREUNKNOWNBIT = (SECURELOCK_SUGGEST_MIXED + 1),
        SECURELOCK_SUGGEST_SECURE40BIT = (SECURELOCK_SUGGEST_SECUREUNKNOWNBIT + 1),
        SECURELOCK_SUGGEST_SECURE56BIT = (SECURELOCK_SUGGEST_SECURE40BIT + 1),
        SECURELOCK_SUGGEST_FORTEZZA = (SECURELOCK_SUGGEST_SECURE56BIT + 1),
        SECURELOCK_SUGGEST_SECURE128BIT = (SECURELOCK_SUGGEST_FORTEZZA + 1),
    }
}