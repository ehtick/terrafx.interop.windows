// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="DispSVGPathSegLinetoVerticalRel" /> struct.</summary>
    public static unsafe partial class DispSVGPathSegLinetoVerticalRelTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="DispSVGPathSegLinetoVerticalRel" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(DispSVGPathSegLinetoVerticalRel).GUID, Is.EqualTo(IID_DispSVGPathSegLinetoVerticalRel));
        }

        /// <summary>Validates that the <see cref="DispSVGPathSegLinetoVerticalRel" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<DispSVGPathSegLinetoVerticalRel>(), Is.EqualTo(sizeof(DispSVGPathSegLinetoVerticalRel)));
        }

        /// <summary>Validates that the <see cref="DispSVGPathSegLinetoVerticalRel" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(DispSVGPathSegLinetoVerticalRel).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="DispSVGPathSegLinetoVerticalRel" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(DispSVGPathSegLinetoVerticalRel), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(DispSVGPathSegLinetoVerticalRel), Is.EqualTo(4));
            }
        }
    }
}