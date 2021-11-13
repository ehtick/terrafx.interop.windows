// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.Windows;

namespace TerraFX.Interop.Windows.UnitTests
{
    /// <summary>Provides validation of the <see cref="IMFSensorTransformFactory" /> struct.</summary>
    [SupportedOSPlatform("windows10.0.15063.0")]
    public static unsafe partial class IMFSensorTransformFactoryTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IMFSensorTransformFactory" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IMFSensorTransformFactory).GUID, Is.EqualTo(IID_IMFSensorTransformFactory));
        }

        /// <summary>Validates that the <see cref="IMFSensorTransformFactory" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IMFSensorTransformFactory>(), Is.EqualTo(sizeof(IMFSensorTransformFactory)));
        }

        /// <summary>Validates that the <see cref="IMFSensorTransformFactory" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IMFSensorTransformFactory).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IMFSensorTransformFactory" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IMFSensorTransformFactory), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IMFSensorTransformFactory), Is.EqualTo(4));
            }
        }
    }
}