// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.Windows;

namespace TerraFX.Interop.Windows.UnitTests
{
    /// <summary>Provides validation of the <see cref="HTMLInputFileElement" /> struct.</summary>
    public static unsafe partial class HTMLInputFileElementTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="HTMLInputFileElement" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(HTMLInputFileElement).GUID, Is.EqualTo(IID_HTMLInputFileElement));
        }

        /// <summary>Validates that the <see cref="HTMLInputFileElement" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<HTMLInputFileElement>(), Is.EqualTo(sizeof(HTMLInputFileElement)));
        }

        /// <summary>Validates that the <see cref="HTMLInputFileElement" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(HTMLInputFileElement).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="HTMLInputFileElement" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(HTMLInputFileElement), Is.EqualTo(1));
        }
    }
}