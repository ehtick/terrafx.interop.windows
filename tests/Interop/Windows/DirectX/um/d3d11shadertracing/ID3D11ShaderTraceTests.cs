// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11shadertracing.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref="ID3D11ShaderTrace" /> struct.</summary>
[SupportedOSPlatform("windows6.2")]
public static unsafe partial class ID3D11ShaderTraceTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="ID3D11ShaderTrace" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(ID3D11ShaderTrace).GUID, Is.EqualTo(IID_ID3D11ShaderTrace));
    }

    /// <summary>Validates that the <see cref="ID3D11ShaderTrace" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ID3D11ShaderTrace>(), Is.EqualTo(sizeof(ID3D11ShaderTrace)));
    }

    /// <summary>Validates that the <see cref="ID3D11ShaderTrace" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ID3D11ShaderTrace).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="ID3D11ShaderTrace" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ID3D11ShaderTrace), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ID3D11ShaderTrace), Is.EqualTo(4));
        }
    }
}
