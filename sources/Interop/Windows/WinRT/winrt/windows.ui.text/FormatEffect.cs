// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.text.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='FormatEffect.xml' path='doc/member[@name="FormatEffect"]/*' />
public enum FormatEffect
{
    /// <include file='FormatEffect.xml' path='doc/member[@name="FormatEffect.FormatEffect_Off"]/*' />
    FormatEffect_Off = 0,

    /// <include file='FormatEffect.xml' path='doc/member[@name="FormatEffect.FormatEffect_On"]/*' />
    FormatEffect_On = 1,

    /// <include file='FormatEffect.xml' path='doc/member[@name="FormatEffect.FormatEffect_Toggle"]/*' />
    FormatEffect_Toggle = 2,

    /// <include file='FormatEffect.xml' path='doc/member[@name="FormatEffect.FormatEffect_Undefined"]/*' />
    FormatEffect_Undefined = 3,
}
