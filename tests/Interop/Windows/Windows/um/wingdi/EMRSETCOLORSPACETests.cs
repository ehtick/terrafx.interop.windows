// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests
{
    /// <summary>Provides validation of the <see cref="EMRSETCOLORSPACE" /> struct.</summary>
    public static unsafe partial class EMRSETCOLORSPACETests
    {
        /// <summary>Validates that the <see cref="EMRSETCOLORSPACE" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<EMRSETCOLORSPACE>(), Is.EqualTo(sizeof(EMRSETCOLORSPACE)));
        }

        /// <summary>Validates that the <see cref="EMRSETCOLORSPACE" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(EMRSETCOLORSPACE).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="EMRSETCOLORSPACE" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(EMRSETCOLORSPACE), Is.EqualTo(12));
        }
    }
}