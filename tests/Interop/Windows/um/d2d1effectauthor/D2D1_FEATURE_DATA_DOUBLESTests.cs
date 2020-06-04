// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effectauthor.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="D2D1_FEATURE_DATA_DOUBLES" /> struct.</summary>
    public static unsafe class D2D1_FEATURE_DATA_DOUBLESTests
    {
        /// <summary>Validates that the <see cref="D2D1_FEATURE_DATA_DOUBLES" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<D2D1_FEATURE_DATA_DOUBLES>(), Is.EqualTo(sizeof(D2D1_FEATURE_DATA_DOUBLES)));
        }

        /// <summary>Validates that the <see cref="D2D1_FEATURE_DATA_DOUBLES" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(D2D1_FEATURE_DATA_DOUBLES).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="D2D1_FEATURE_DATA_DOUBLES" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(D2D1_FEATURE_DATA_DOUBLES), Is.EqualTo(4));
        }
    }
}