// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public enum WICRawRotationCapabilities
    {
        WICRawRotationCapabilityNotSupported = 0,
        WICRawRotationCapabilityGetSupported = 0x1,
        WICRawRotationCapabilityNinetyDegreesSupported = 0x2,
        WICRawRotationCapabilityFullySupported = 0x3,
        WICRAWROTATIONCAPABILITIES_FORCE_DWORD = 0x7fffffff,
    }
}