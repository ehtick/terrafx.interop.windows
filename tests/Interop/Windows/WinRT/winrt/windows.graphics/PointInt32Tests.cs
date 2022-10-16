// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref="PointInt32" /> struct.</summary>
public static unsafe partial class PointInt32Tests
{
    /// <summary>Validates that the <see cref="PointInt32" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<PointInt32>(), Is.EqualTo(sizeof(PointInt32)));
    }

    /// <summary>Validates that the <see cref="PointInt32" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(PointInt32).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="PointInt32" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(PointInt32), Is.EqualTo(8));
    }
}
