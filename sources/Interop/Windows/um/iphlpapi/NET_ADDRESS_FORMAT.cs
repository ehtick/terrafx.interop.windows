// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/iphlpapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum NET_ADDRESS_FORMAT
    {
        NET_ADDRESS_FORMAT_UNSPECIFIED = 0,
        NET_ADDRESS_DNS_NAME,
        NET_ADDRESS_IPV4,
        NET_ADDRESS_IPV6,
    }
}