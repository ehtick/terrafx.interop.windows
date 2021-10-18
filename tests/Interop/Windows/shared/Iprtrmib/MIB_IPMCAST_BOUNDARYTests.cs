// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/Iprtrmib.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="MIB_IPMCAST_BOUNDARY" /> struct.</summary>
    public static unsafe partial class MIB_IPMCAST_BOUNDARYTests
    {
        /// <summary>Validates that the <see cref="MIB_IPMCAST_BOUNDARY" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<MIB_IPMCAST_BOUNDARY>(), Is.EqualTo(sizeof(MIB_IPMCAST_BOUNDARY)));
        }

        /// <summary>Validates that the <see cref="MIB_IPMCAST_BOUNDARY" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(MIB_IPMCAST_BOUNDARY).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="MIB_IPMCAST_BOUNDARY" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(MIB_IPMCAST_BOUNDARY), Is.EqualTo(16));
        }
    }
}
