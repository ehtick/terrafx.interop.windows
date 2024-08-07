// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='MF_TIMED_TEXT_BOUTEN_POSITION.xml' path='doc/member[@name="MF_TIMED_TEXT_BOUTEN_POSITION"]/*' />
public enum MF_TIMED_TEXT_BOUTEN_POSITION
{
    /// <include file='MF_TIMED_TEXT_BOUTEN_POSITION.xml' path='doc/member[@name="MF_TIMED_TEXT_BOUTEN_POSITION.MF_TIMED_TEXT_BOUTEN_POSITION_BEFORE"]/*' />
    MF_TIMED_TEXT_BOUTEN_POSITION_BEFORE = 0,

    /// <include file='MF_TIMED_TEXT_BOUTEN_POSITION.xml' path='doc/member[@name="MF_TIMED_TEXT_BOUTEN_POSITION.MF_TIMED_TEXT_BOUTEN_POSITION_AFTER"]/*' />
    MF_TIMED_TEXT_BOUTEN_POSITION_AFTER = 1,

    /// <include file='MF_TIMED_TEXT_BOUTEN_POSITION.xml' path='doc/member[@name="MF_TIMED_TEXT_BOUTEN_POSITION.MF_TIMED_TEXT_BOUTEN_POSITION_OUTSIDE"]/*' />
    MF_TIMED_TEXT_BOUTEN_POSITION_OUTSIDE = 2,
}
