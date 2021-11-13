// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests
{
    /// <summary>Provides validation of the <see cref="OCSP_SIGNATURE_INFO" /> struct.</summary>
    public static unsafe partial class OCSP_SIGNATURE_INFOTests
    {
        /// <summary>Validates that the <see cref="OCSP_SIGNATURE_INFO" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<OCSP_SIGNATURE_INFO>(), Is.EqualTo(sizeof(OCSP_SIGNATURE_INFO)));
        }

        /// <summary>Validates that the <see cref="OCSP_SIGNATURE_INFO" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(OCSP_SIGNATURE_INFO).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="OCSP_SIGNATURE_INFO" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(OCSP_SIGNATURE_INFO), Is.EqualTo(64));
            }
            else
            {
                Assert.That(sizeof(OCSP_SIGNATURE_INFO), Is.EqualTo(32));
            }
        }
    }
}