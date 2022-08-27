// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/directmanipulation.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop.DirectX;

/// <include file='DIRECTMANIPULATION_INTERACTION_TYPE.xml' path='doc/member[@name="DIRECTMANIPULATION_INTERACTION_TYPE"]/*' />
[SupportedOSPlatform("windows6.3")]
public enum DIRECTMANIPULATION_INTERACTION_TYPE
{
    /// <include file='DIRECTMANIPULATION_INTERACTION_TYPE.xml' path='doc/member[@name="DIRECTMANIPULATION_INTERACTION_TYPE.DIRECTMANIPULATION_INTERACTION_BEGIN"]/*' />
    DIRECTMANIPULATION_INTERACTION_BEGIN = 0,

    /// <include file='DIRECTMANIPULATION_INTERACTION_TYPE.xml' path='doc/member[@name="DIRECTMANIPULATION_INTERACTION_TYPE.DIRECTMANIPULATION_INTERACTION_TYPE_MANIPULATION"]/*' />
    DIRECTMANIPULATION_INTERACTION_TYPE_MANIPULATION = 1,

    /// <include file='DIRECTMANIPULATION_INTERACTION_TYPE.xml' path='doc/member[@name="DIRECTMANIPULATION_INTERACTION_TYPE.DIRECTMANIPULATION_INTERACTION_TYPE_GESTURE_TAP"]/*' />
    DIRECTMANIPULATION_INTERACTION_TYPE_GESTURE_TAP = 2,

    /// <include file='DIRECTMANIPULATION_INTERACTION_TYPE.xml' path='doc/member[@name="DIRECTMANIPULATION_INTERACTION_TYPE.DIRECTMANIPULATION_INTERACTION_TYPE_GESTURE_HOLD"]/*' />
    DIRECTMANIPULATION_INTERACTION_TYPE_GESTURE_HOLD = 3,

    /// <include file='DIRECTMANIPULATION_INTERACTION_TYPE.xml' path='doc/member[@name="DIRECTMANIPULATION_INTERACTION_TYPE.DIRECTMANIPULATION_INTERACTION_TYPE_GESTURE_CROSS_SLIDE"]/*' />
    DIRECTMANIPULATION_INTERACTION_TYPE_GESTURE_CROSS_SLIDE = 4,

    /// <include file='DIRECTMANIPULATION_INTERACTION_TYPE.xml' path='doc/member[@name="DIRECTMANIPULATION_INTERACTION_TYPE.DIRECTMANIPULATION_INTERACTION_TYPE_GESTURE_PINCH_ZOOM"]/*' />
    DIRECTMANIPULATION_INTERACTION_TYPE_GESTURE_PINCH_ZOOM = 5,

    /// <include file='DIRECTMANIPULATION_INTERACTION_TYPE.xml' path='doc/member[@name="DIRECTMANIPULATION_INTERACTION_TYPE.DIRECTMANIPULATION_INTERACTION_END"]/*' />
    DIRECTMANIPULATION_INTERACTION_END = 100,
}
