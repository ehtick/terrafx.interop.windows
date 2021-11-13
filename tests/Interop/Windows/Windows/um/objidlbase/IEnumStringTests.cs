// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.Windows;

namespace TerraFX.Interop.Windows.UnitTests
{
    /// <summary>Provides validation of the <see cref="IEnumString" /> struct.</summary>
    public static unsafe partial class IEnumStringTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IEnumString" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IEnumString).GUID, Is.EqualTo(IID_IEnumString));
        }

        /// <summary>Validates that the <see cref="IEnumString" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IEnumString>(), Is.EqualTo(sizeof(IEnumString)));
        }

        /// <summary>Validates that the <see cref="IEnumString" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IEnumString).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IEnumString" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IEnumString), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IEnumString), Is.EqualTo(4));
            }
        }
    }
}