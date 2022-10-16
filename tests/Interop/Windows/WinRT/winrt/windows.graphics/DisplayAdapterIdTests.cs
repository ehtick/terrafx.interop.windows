// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref="DisplayAdapterId" /> struct.</summary>
public static unsafe partial class DisplayAdapterIdTests
{
    /// <summary>Validates that the <see cref="DisplayAdapterId" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DisplayAdapterId>(), Is.EqualTo(sizeof(DisplayAdapterId)));
    }

    /// <summary>Validates that the <see cref="DisplayAdapterId" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DisplayAdapterId).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="DisplayAdapterId" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DisplayAdapterId), Is.EqualTo(8));
    }
}
