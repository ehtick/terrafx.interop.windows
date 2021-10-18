// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ifdef.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum NET_IF_ACCESS_TYPE
    {
        NET_IF_ACCESS_LOOPBACK = 1,
        NET_IF_ACCESS_BROADCAST = 2,
        NET_IF_ACCESS_POINT_TO_POINT = 3,
        NET_IF_ACCESS_POINT_TO_MULTI_POINT = 4,
        NET_IF_ACCESS_MAXIMUM = 5,
    }
}