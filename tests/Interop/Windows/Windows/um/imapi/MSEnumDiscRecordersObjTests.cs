// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.CLSID;

namespace TerraFX.Interop.Windows.UnitTests
{
    /// <summary>Provides validation of the <see cref="MSEnumDiscRecordersObj" /> struct.</summary>
    public static unsafe partial class MSEnumDiscRecordersObjTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="MSEnumDiscRecordersObj" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(MSEnumDiscRecordersObj).GUID, Is.EqualTo(CLSID_MSEnumDiscRecordersObj));
        }

        /// <summary>Validates that the <see cref="MSEnumDiscRecordersObj" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<MSEnumDiscRecordersObj>(), Is.EqualTo(sizeof(MSEnumDiscRecordersObj)));
        }

        /// <summary>Validates that the <see cref="MSEnumDiscRecordersObj" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(MSEnumDiscRecordersObj).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="MSEnumDiscRecordersObj" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(MSEnumDiscRecordersObj), Is.EqualTo(1));
        }
    }
}
