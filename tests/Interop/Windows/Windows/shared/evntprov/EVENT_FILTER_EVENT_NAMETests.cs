// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/evntprov.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="EVENT_FILTER_EVENT_NAME" /> struct.</summary>
public static unsafe partial class EVENT_FILTER_EVENT_NAMETests
{
    /// <summary>Validates that the <see cref="EVENT_FILTER_EVENT_NAME" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<EVENT_FILTER_EVENT_NAME>(), Is.EqualTo(sizeof(EVENT_FILTER_EVENT_NAME)));
    }

    /// <summary>Validates that the <see cref="EVENT_FILTER_EVENT_NAME" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(EVENT_FILTER_EVENT_NAME).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="EVENT_FILTER_EVENT_NAME" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(EVENT_FILTER_EVENT_NAME), Is.EqualTo(24));
    }
}