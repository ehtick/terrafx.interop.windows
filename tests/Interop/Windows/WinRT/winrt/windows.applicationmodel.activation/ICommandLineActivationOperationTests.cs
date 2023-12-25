// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.activation.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref="ICommandLineActivationOperation" /> struct.</summary>
public static unsafe partial class ICommandLineActivationOperationTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="ICommandLineActivationOperation" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(ICommandLineActivationOperation).GUID, Is.EqualTo(IID_ICommandLineActivationOperation));
    }
}
