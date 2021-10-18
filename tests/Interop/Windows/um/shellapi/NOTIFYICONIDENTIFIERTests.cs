// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="NOTIFYICONIDENTIFIER" /> struct.</summary>
    public static unsafe partial class NOTIFYICONIDENTIFIERTests
    {
        /// <summary>Validates that the <see cref="NOTIFYICONIDENTIFIER" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<NOTIFYICONIDENTIFIER>(), Is.EqualTo(sizeof(NOTIFYICONIDENTIFIER)));
        }

        /// <summary>Validates that the <see cref="NOTIFYICONIDENTIFIER" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(NOTIFYICONIDENTIFIER).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="NOTIFYICONIDENTIFIER" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(NOTIFYICONIDENTIFIER), Is.EqualTo(32));
            }
            else
            {
                Assert.That(sizeof(NOTIFYICONIDENTIFIER), Is.EqualTo(28));
            }
        }
    }
}
