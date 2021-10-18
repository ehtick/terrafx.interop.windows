// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IHTMLSpanElement" /> struct.</summary>
    public static unsafe partial class IHTMLSpanElementTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IHTMLSpanElement" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IHTMLSpanElement).GUID, Is.EqualTo(IID_IHTMLSpanElement));
        }

        /// <summary>Validates that the <see cref="IHTMLSpanElement" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IHTMLSpanElement>(), Is.EqualTo(sizeof(IHTMLSpanElement)));
        }

        /// <summary>Validates that the <see cref="IHTMLSpanElement" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IHTMLSpanElement).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IHTMLSpanElement" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IHTMLSpanElement), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IHTMLSpanElement), Is.EqualTo(4));
            }
        }
    }
}
