
// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop.Gdiplus;

[NativeTypeName("struct GpTexture : GpBrush")]
[NativeInheritance("GpBrush")]
public partial struct GpTexture : GpTexture.Interface
{
    public interface Interface : GpBrush.Interface
    {
    }
}
