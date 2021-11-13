// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xmllite.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public enum DtdProcessing
    {
        DtdProcessing_Prohibit = 0,
        DtdProcessing_Parse = (DtdProcessing_Prohibit + 1),
        _DtdProcessing_Last = DtdProcessing_Parse,
    }
}