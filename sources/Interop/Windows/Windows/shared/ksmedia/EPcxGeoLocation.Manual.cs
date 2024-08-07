// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ksmedia.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public enum EPcxGeoLocation
{
    eGeoLocRear = 0x1,
    eGeoLocFront,
    eGeoLocLeft,
    eGeoLocRight,
    eGeoLocTop,
    eGeoLocBottom,
    eGeoLocRearPanel,
    eGeoLocRiser,
    eGeoLocInsideMobileLid,
    eGeoLocDrivebay,
    eGeoLocHDMI,
    eGeoLocOutsideMobileLid,
    eGeoLocATAPI,
    eGeoLocNotApplicable,
    eGeoLocReserved6,
    EPcxGeoLocation_enum_count,
}
