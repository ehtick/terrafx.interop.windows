// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='SVGAnimatedNumber.xml' path='doc/member[@name="SVGAnimatedNumber"]/*' />
[Guid("30510588-98B5-11CF-BB82-00AA00BDCE0B")]
public unsafe partial struct SVGAnimatedNumber : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_SVGAnimatedNumber));
}
