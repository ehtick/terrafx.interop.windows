// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlDisp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.Windows;

namespace TerraFX.Interop.Windows.UnitTests
{
    /// <summary>Provides validation of the <see cref="IAutoComplete" /> struct.</summary>
    public static unsafe partial class IAutoCompleteTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IAutoComplete" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IAutoComplete).GUID, Is.EqualTo(IID_IAutoComplete));
        }

        /// <summary>Validates that the <see cref="IAutoComplete" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IAutoComplete>(), Is.EqualTo(sizeof(IAutoComplete)));
        }

        /// <summary>Validates that the <see cref="IAutoComplete" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IAutoComplete).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IAutoComplete" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IAutoComplete), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IAutoComplete), Is.EqualTo(4));
            }
        }
    }
}