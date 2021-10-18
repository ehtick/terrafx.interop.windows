// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="DRAGINFOW" /> struct.</summary>
    public static unsafe partial class DRAGINFOWTests
    {
        /// <summary>Validates that the <see cref="DRAGINFOW" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<DRAGINFOW>(), Is.EqualTo(sizeof(DRAGINFOW)));
        }

        /// <summary>Validates that the <see cref="DRAGINFOW" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(DRAGINFOW).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="DRAGINFOW" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(DRAGINFOW), Is.EqualTo(28));
            }
            else
            {
                Assert.That(sizeof(DRAGINFOW), Is.EqualTo(24));
            }
        }
    }
}
