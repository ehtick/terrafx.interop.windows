// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.Windows;

namespace TerraFX.Interop.Windows.UnitTests
{
    /// <summary>Provides validation of the <see cref="IMFFinalizableMediaSink" /> struct.</summary>
    public static unsafe partial class IMFFinalizableMediaSinkTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IMFFinalizableMediaSink" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IMFFinalizableMediaSink).GUID, Is.EqualTo(IID_IMFFinalizableMediaSink));
        }

        /// <summary>Validates that the <see cref="IMFFinalizableMediaSink" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IMFFinalizableMediaSink>(), Is.EqualTo(sizeof(IMFFinalizableMediaSink)));
        }

        /// <summary>Validates that the <see cref="IMFFinalizableMediaSink" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IMFFinalizableMediaSink).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IMFFinalizableMediaSink" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IMFFinalizableMediaSink), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IMFFinalizableMediaSink), Is.EqualTo(4));
            }
        }
    }
}