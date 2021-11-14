// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests
{
    /// <summary>Provides validation of the <see cref="ISyncMgrSyncItem" /> struct.</summary>
    public static unsafe partial class ISyncMgrSyncItemTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="ISyncMgrSyncItem" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(ISyncMgrSyncItem).GUID, Is.EqualTo(IID_ISyncMgrSyncItem));
        }

        /// <summary>Validates that the <see cref="ISyncMgrSyncItem" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<ISyncMgrSyncItem>(), Is.EqualTo(sizeof(ISyncMgrSyncItem)));
        }

        /// <summary>Validates that the <see cref="ISyncMgrSyncItem" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(ISyncMgrSyncItem).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="ISyncMgrSyncItem" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(ISyncMgrSyncItem), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(ISyncMgrSyncItem), Is.EqualTo(4));
            }
        }
    }
}
