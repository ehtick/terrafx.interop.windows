// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="SP_REGISTER_CONTROL_STATUS32W" /> struct.</summary>
public static unsafe partial class SP_REGISTER_CONTROL_STATUS32WTests
{
    /// <summary>Validates that the <see cref="SP_REGISTER_CONTROL_STATUS32W" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SP_REGISTER_CONTROL_STATUS32W>(), Is.EqualTo(sizeof(SP_REGISTER_CONTROL_STATUS32W)));
    }

    /// <summary>Validates that the <see cref="SP_REGISTER_CONTROL_STATUS32W" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SP_REGISTER_CONTROL_STATUS32W).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="SP_REGISTER_CONTROL_STATUS32W" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(SP_REGISTER_CONTROL_STATUS32W), Is.EqualTo(20));
        }
        else
        {
            Assert.That(sizeof(SP_REGISTER_CONTROL_STATUS32W), Is.EqualTo(16));
        }
    }
}
