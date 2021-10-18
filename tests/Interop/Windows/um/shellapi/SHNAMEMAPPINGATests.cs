// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="SHNAMEMAPPINGA" /> struct.</summary>
    public static unsafe partial class SHNAMEMAPPINGATests
    {
        /// <summary>Validates that the <see cref="SHNAMEMAPPINGA" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<SHNAMEMAPPINGA>(), Is.EqualTo(sizeof(SHNAMEMAPPINGA)));
        }

        /// <summary>Validates that the <see cref="SHNAMEMAPPINGA" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(SHNAMEMAPPINGA).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="SHNAMEMAPPINGA" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(SHNAMEMAPPINGA), Is.EqualTo(24));
            }
            else
            {
                Assert.That(sizeof(SHNAMEMAPPINGA), Is.EqualTo(16));
            }
        }
    }
}
