// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref="IDXGIDevice1" /> struct.</summary>
public static unsafe partial class IDXGIDevice1Tests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IDXGIDevice1" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IDXGIDevice1).GUID, Is.EqualTo(IID_IDXGIDevice1));
    }
}
