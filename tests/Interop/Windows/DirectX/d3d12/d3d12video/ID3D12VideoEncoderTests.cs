// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref="ID3D12VideoEncoder" /> struct.</summary>
[SupportedOSPlatform("windows10.0.22000.0")]
public static unsafe partial class ID3D12VideoEncoderTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="ID3D12VideoEncoder" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(ID3D12VideoEncoder).GUID, Is.EqualTo(IID_ID3D12VideoEncoder));
    }
}
