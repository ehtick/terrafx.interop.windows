// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdiplustypes.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Gdiplus;

public partial struct GpSizeF
{
    public static GpSizeF operator +(in GpSizeF self, in GpSizeF sz)
    {
        return new GpSizeF(
            self.Width + sz.Width,
            self.Height + sz.Height
        );
    }

    public static GpSizeF operator -(in GpSizeF self, in GpSizeF sz)
    {
        return new GpSizeF(
            self.Width - sz.Width,
            self.Height - sz.Height
        );
    }
}
