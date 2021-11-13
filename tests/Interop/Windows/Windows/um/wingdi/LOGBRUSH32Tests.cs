// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests
{
    /// <summary>Provides validation of the <see cref="LOGBRUSH32" /> struct.</summary>
    public static unsafe partial class LOGBRUSH32Tests
    {
        /// <summary>Validates that the <see cref="LOGBRUSH32" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<LOGBRUSH32>(), Is.EqualTo(sizeof(LOGBRUSH32)));
        }

        /// <summary>Validates that the <see cref="LOGBRUSH32" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(LOGBRUSH32).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="LOGBRUSH32" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(LOGBRUSH32), Is.EqualTo(12));
        }
    }
}