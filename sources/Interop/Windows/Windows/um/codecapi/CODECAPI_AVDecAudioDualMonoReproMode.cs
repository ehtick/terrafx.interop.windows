// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_AVDecAudioDualMonoReproMode.xml' path='doc/member[@name="CODECAPI_AVDecAudioDualMonoReproMode"]/*' />
[Guid("A5106186-CC94-4BC9-8CD9-AA2F61F6807E")]
public unsafe partial struct CODECAPI_AVDecAudioDualMonoReproMode : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_CODECAPI_AVDecAudioDualMonoReproMode));
}
