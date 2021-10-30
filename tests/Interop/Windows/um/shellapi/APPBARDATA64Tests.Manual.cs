// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="APPBARDATA64" /> struct.</summary>
    public static unsafe partial class APPBARDATA64Tests
    {
        /// <summary>Validates that the <see cref="APPBARDATA64" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<APPBARDATA64>(), Is.EqualTo(sizeof(APPBARDATA64)));
        }

        /// <summary>Validates that the <see cref="APPBARDATA64" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(APPBARDATA64).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="APPBARDATA64" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(APPBARDATA64), Is.EqualTo(48));
            }
            else
            {
                Assert.That(sizeof(APPBARDATA64), Is.EqualTo(36));
            }
        }
    }
}
