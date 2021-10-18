// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="TVSORTCB" /> struct.</summary>
    public static unsafe partial class TVSORTCBTests
    {
        /// <summary>Validates that the <see cref="TVSORTCB" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<TVSORTCB>(), Is.EqualTo(sizeof(TVSORTCB)));
        }

        /// <summary>Validates that the <see cref="TVSORTCB" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(TVSORTCB).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="TVSORTCB" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(TVSORTCB), Is.EqualTo(24));
            }
            else
            {
                Assert.That(sizeof(TVSORTCB), Is.EqualTo(12));
            }
        }
    }
}