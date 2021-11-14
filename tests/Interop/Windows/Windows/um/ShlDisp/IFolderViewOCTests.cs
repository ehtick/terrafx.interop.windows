// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlDisp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests
{
    /// <summary>Provides validation of the <see cref="IFolderViewOC" /> struct.</summary>
    public static unsafe partial class IFolderViewOCTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IFolderViewOC" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IFolderViewOC).GUID, Is.EqualTo(IID_IFolderViewOC));
        }

        /// <summary>Validates that the <see cref="IFolderViewOC" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IFolderViewOC>(), Is.EqualTo(sizeof(IFolderViewOC)));
        }

        /// <summary>Validates that the <see cref="IFolderViewOC" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IFolderViewOC).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IFolderViewOC" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IFolderViewOC), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IFolderViewOC), Is.EqualTo(4));
            }
        }
    }
}
