// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='AppCaptureHistoricalBufferLengthUnit.xml' path='doc/member[@name="AppCaptureHistoricalBufferLengthUnit"]/*' />
public enum AppCaptureHistoricalBufferLengthUnit
{
    /// <include file='AppCaptureHistoricalBufferLengthUnit.xml' path='doc/member[@name="AppCaptureHistoricalBufferLengthUnit.AppCaptureHistoricalBufferLengthUnit_Megabytes"]/*' />
    AppCaptureHistoricalBufferLengthUnit_Megabytes = 0,

    /// <include file='AppCaptureHistoricalBufferLengthUnit.xml' path='doc/member[@name="AppCaptureHistoricalBufferLengthUnit.AppCaptureHistoricalBufferLengthUnit_Seconds"]/*' />
    AppCaptureHistoricalBufferLengthUnit_Seconds = 1,
}
