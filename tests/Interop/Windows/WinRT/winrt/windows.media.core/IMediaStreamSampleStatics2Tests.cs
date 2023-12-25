// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref="IMediaStreamSampleStatics2" /> struct.</summary>
public static unsafe partial class IMediaStreamSampleStatics2Tests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IMediaStreamSampleStatics2" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IMediaStreamSampleStatics2).GUID, Is.EqualTo(IID_IMediaStreamSampleStatics2));
    }
}
