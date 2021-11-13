// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.Windows;

namespace TerraFX.Interop.Windows.UnitTests
{
    /// <summary>Provides validation of the <see cref="HTMLScreen" /> struct.</summary>
    public static unsafe partial class HTMLScreenTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="HTMLScreen" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(HTMLScreen).GUID, Is.EqualTo(IID_HTMLScreen));
        }

        /// <summary>Validates that the <see cref="HTMLScreen" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<HTMLScreen>(), Is.EqualTo(sizeof(HTMLScreen)));
        }

        /// <summary>Validates that the <see cref="HTMLScreen" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(HTMLScreen).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="HTMLScreen" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(HTMLScreen), Is.EqualTo(1));
        }
    }
}