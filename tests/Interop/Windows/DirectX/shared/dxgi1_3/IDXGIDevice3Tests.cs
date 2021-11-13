// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi1_3.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.DirectX.DirectX;

namespace TerraFX.Interop.DirectX.UnitTests
{
    /// <summary>Provides validation of the <see cref="IDXGIDevice3" /> struct.</summary>
    [SupportedOSPlatform("windows8.1")]
    public static unsafe partial class IDXGIDevice3Tests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IDXGIDevice3" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IDXGIDevice3).GUID, Is.EqualTo(IID_IDXGIDevice3));
        }

        /// <summary>Validates that the <see cref="IDXGIDevice3" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IDXGIDevice3>(), Is.EqualTo(sizeof(IDXGIDevice3)));
        }

        /// <summary>Validates that the <see cref="IDXGIDevice3" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IDXGIDevice3).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IDXGIDevice3" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IDXGIDevice3), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IDXGIDevice3), Is.EqualTo(4));
            }
        }
    }
}