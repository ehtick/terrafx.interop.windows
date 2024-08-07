// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MSAAText.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class TS
{
    [NativeTypeName("#define TS_STRF_START ( 0 )")]
    public const int TS_STRF_START = (0);

    [NativeTypeName("#define TS_STRF_MID ( 1 )")]
    public const int TS_STRF_MID = (1);

    [NativeTypeName("#define TS_STRF_END ( 2 )")]
    public const int TS_STRF_END = (2);
}
