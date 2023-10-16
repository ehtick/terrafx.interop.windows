// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref="IDirectInput7W" /> struct.</summary>
public static unsafe partial class IDirectInput7WTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IDirectInput7W" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IDirectInput7W).GUID, Is.EqualTo(IID_IDirectInput7W));
    }
}
