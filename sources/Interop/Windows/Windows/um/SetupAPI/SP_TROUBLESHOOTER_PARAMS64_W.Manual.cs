// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

public unsafe partial struct SP_TROUBLESHOOTER_PARAMS64_W
{
    public SP_CLASSINSTALL_HEADER64 ClassInstallHeader;

    [NativeTypeName("WCHAR[260]")]
    public _ChmFile_e__FixedBuffer ChmFile;

    [NativeTypeName("WCHAR[260]")]
    public _HtmlTroubleShooter_e__FixedBuffer HtmlTroubleShooter;

    [InlineArray(260)]
    public partial struct _ChmFile_e__FixedBuffer
    {
        public char e0;
    }

    [InlineArray(260)]
    public partial struct _HtmlTroubleShooter_e__FixedBuffer
    {
        public char e0;
    }
}
