// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum styleMsTouchAction
    {
        styleMsTouchActionNotSet = -1,
        styleMsTouchActionNone = 0,
        styleMsTouchActionAuto = 1,
        styleMsTouchActionManipulation = 2,
        styleMsTouchActionDoubleTapZoom = 4,
        styleMsTouchActionPanX = 8,
        styleMsTouchActionPanY = 16,
        styleMsTouchActionPinchZoom = 32,
        styleMsTouchActionCrossSlideX = 64,
        styleMsTouchActionCrossSlideY = 128,
        styleMsTouchAction_Max = 2147483647,
    }
}
