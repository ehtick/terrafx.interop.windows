// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="TBBUTTON32" /> struct.</summary>
public static unsafe partial class TBBUTTON32Tests
{
    /// <summary>Validates that the <see cref="TBBUTTON32" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<TBBUTTON32>(), Is.EqualTo(sizeof(TBBUTTON32)));
    }

    /// <summary>Validates that the <see cref="TBBUTTON32" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(TBBUTTON32).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="TBBUTTON32" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(TBBUTTON32), Is.EqualTo(32));
        }
        else
        {
            Assert.That(sizeof(TBBUTTON32), Is.EqualTo(20));
        }
    }
}
