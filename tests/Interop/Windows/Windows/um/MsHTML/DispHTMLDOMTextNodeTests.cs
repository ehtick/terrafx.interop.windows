// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests
{
    /// <summary>Provides validation of the <see cref="DispHTMLDOMTextNode" /> struct.</summary>
    public static unsafe partial class DispHTMLDOMTextNodeTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="DispHTMLDOMTextNode" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(DispHTMLDOMTextNode).GUID, Is.EqualTo(IID_DispHTMLDOMTextNode));
        }

        /// <summary>Validates that the <see cref="DispHTMLDOMTextNode" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<DispHTMLDOMTextNode>(), Is.EqualTo(sizeof(DispHTMLDOMTextNode)));
        }

        /// <summary>Validates that the <see cref="DispHTMLDOMTextNode" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(DispHTMLDOMTextNode).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="DispHTMLDOMTextNode" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(DispHTMLDOMTextNode), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(DispHTMLDOMTextNode), Is.EqualTo(4));
            }
        }
    }
}
