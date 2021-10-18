// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="TrayBandSiteService" /> struct.</summary>
    public static unsafe partial class TrayBandSiteServiceTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="TrayBandSiteService" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(TrayBandSiteService).GUID, Is.EqualTo(IID_TrayBandSiteService));
        }

        /// <summary>Validates that the <see cref="TrayBandSiteService" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<TrayBandSiteService>(), Is.EqualTo(sizeof(TrayBandSiteService)));
        }

        /// <summary>Validates that the <see cref="TrayBandSiteService" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(TrayBandSiteService).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="TrayBandSiteService" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(TrayBandSiteService), Is.EqualTo(1));
        }
    }
}