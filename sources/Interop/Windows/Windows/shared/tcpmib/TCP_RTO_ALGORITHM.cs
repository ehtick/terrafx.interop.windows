// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/tcpmib.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public enum TCP_RTO_ALGORITHM
    {
        TcpRtoAlgorithmOther = 1,
        TcpRtoAlgorithmConstant,
        TcpRtoAlgorithmRsre,
        TcpRtoAlgorithmVanj,
        MIB_TCP_RTO_OTHER = 1,
        MIB_TCP_RTO_CONSTANT = 2,
        MIB_TCP_RTO_RSRE = 3,
        MIB_TCP_RTO_VANJ = 4,
    }
}