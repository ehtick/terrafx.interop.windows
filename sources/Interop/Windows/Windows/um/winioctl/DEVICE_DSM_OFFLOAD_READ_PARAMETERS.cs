// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

/// <include file='DEVICE_DSM_OFFLOAD_READ_PARAMETERS.xml' path='doc/member[@name="DEVICE_DSM_OFFLOAD_READ_PARAMETERS"]/*' />
[SupportedOSPlatform("windows6.2")]
public partial struct DEVICE_DSM_OFFLOAD_READ_PARAMETERS
{
    /// <include file='DEVICE_DSM_OFFLOAD_READ_PARAMETERS.xml' path='doc/member[@name="DEVICE_DSM_OFFLOAD_READ_PARAMETERS.Flags"]/*' />
    [NativeTypeName("DWORD")]
    public uint Flags;

    /// <include file='DEVICE_DSM_OFFLOAD_READ_PARAMETERS.xml' path='doc/member[@name="DEVICE_DSM_OFFLOAD_READ_PARAMETERS.TimeToLive"]/*' />
    [NativeTypeName("DWORD")]
    public uint TimeToLive;

    /// <include file='DEVICE_DSM_OFFLOAD_READ_PARAMETERS.xml' path='doc/member[@name="DEVICE_DSM_OFFLOAD_READ_PARAMETERS.Reserved"]/*' />
    [NativeTypeName("DWORD[2]")]
    public _Reserved_e__FixedBuffer Reserved;

    /// <include file='_Reserved_e__FixedBuffer.xml' path='doc/member[@name="_Reserved_e__FixedBuffer"]/*' />
    [InlineArray(2)]
    public partial struct _Reserved_e__FixedBuffer
    {
        public uint e0;
    }
}
