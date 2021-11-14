// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX.UnitTests
{
    /// <summary>Provides validation of the <see cref="ID3D12VideoDecodeCommandList2" /> struct.</summary>
    [SupportedOSPlatform("windows10.0.19041.0")]
    public static unsafe partial class ID3D12VideoDecodeCommandList2Tests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="ID3D12VideoDecodeCommandList2" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(ID3D12VideoDecodeCommandList2).GUID, Is.EqualTo(IID_ID3D12VideoDecodeCommandList2));
        }

        /// <summary>Validates that the <see cref="ID3D12VideoDecodeCommandList2" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<ID3D12VideoDecodeCommandList2>(), Is.EqualTo(sizeof(ID3D12VideoDecodeCommandList2)));
        }

        /// <summary>Validates that the <see cref="ID3D12VideoDecodeCommandList2" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(ID3D12VideoDecodeCommandList2).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="ID3D12VideoDecodeCommandList2" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(ID3D12VideoDecodeCommandList2), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(ID3D12VideoDecodeCommandList2), Is.EqualTo(4));
            }
        }
    }
}
