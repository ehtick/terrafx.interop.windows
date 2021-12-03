// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="LSA_FOREST_TRUST_BINARY_DATA" /> struct.</summary>
public static unsafe partial class LSA_FOREST_TRUST_BINARY_DATATests
{
    /// <summary>Validates that the <see cref="LSA_FOREST_TRUST_BINARY_DATA" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<LSA_FOREST_TRUST_BINARY_DATA>(), Is.EqualTo(sizeof(LSA_FOREST_TRUST_BINARY_DATA)));
    }

    /// <summary>Validates that the <see cref="LSA_FOREST_TRUST_BINARY_DATA" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(LSA_FOREST_TRUST_BINARY_DATA).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="LSA_FOREST_TRUST_BINARY_DATA" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(LSA_FOREST_TRUST_BINARY_DATA), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(LSA_FOREST_TRUST_BINARY_DATA), Is.EqualTo(8));
        }
    }
}