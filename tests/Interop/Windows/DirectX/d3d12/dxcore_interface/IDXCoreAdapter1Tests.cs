// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dxcore_interface.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref="IDXCoreAdapter1" /> struct.</summary>
public static unsafe partial class IDXCoreAdapter1Tests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IDXCoreAdapter1" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IDXCoreAdapter1).GUID, Is.EqualTo(IID_IDXCoreAdapter1));
    }
}
