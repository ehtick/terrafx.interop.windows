// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='ENCLAVE_INIT_INFO_VBS_BASIC.xml' path='doc/member[@name="ENCLAVE_INIT_INFO_VBS_BASIC"]/*' />
public partial struct ENCLAVE_INIT_INFO_VBS_BASIC
{
    /// <include file='ENCLAVE_INIT_INFO_VBS_BASIC.xml' path='doc/member[@name="ENCLAVE_INIT_INFO_VBS_BASIC.FamilyId"]/*' />
    [NativeTypeName("BYTE[16]")]
    public _FamilyId_e__FixedBuffer FamilyId;

    /// <include file='ENCLAVE_INIT_INFO_VBS_BASIC.xml' path='doc/member[@name="ENCLAVE_INIT_INFO_VBS_BASIC.ImageId"]/*' />
    [NativeTypeName("BYTE[16]")]
    public _ImageId_e__FixedBuffer ImageId;

    /// <include file='ENCLAVE_INIT_INFO_VBS_BASIC.xml' path='doc/member[@name="ENCLAVE_INIT_INFO_VBS_BASIC.EnclaveSize"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong EnclaveSize;

    /// <include file='ENCLAVE_INIT_INFO_VBS_BASIC.xml' path='doc/member[@name="ENCLAVE_INIT_INFO_VBS_BASIC.EnclaveSvn"]/*' />
    [NativeTypeName("DWORD")]
    public uint EnclaveSvn;

    /// <include file='ENCLAVE_INIT_INFO_VBS_BASIC.xml' path='doc/member[@name="ENCLAVE_INIT_INFO_VBS_BASIC.Reserved"]/*' />
    [NativeTypeName("DWORD")]
    public uint Reserved;

    /// <include file='ENCLAVE_INIT_INFO_VBS_BASIC.xml' path='doc/member[@name="ENCLAVE_INIT_INFO_VBS_BASIC.Anonymous"]/*' />
    [NativeTypeName("__AnonymousRecord_winnt_L14766_C5")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.SignatureInfoHandle"]/*' />
    [UnscopedRef]
    public ref HANDLE SignatureInfoHandle
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.SignatureInfoHandle;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Unused"]/*' />
    [UnscopedRef]
    public ref ulong Unused
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Unused;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.SignatureInfoHandle"]/*' />
        [FieldOffset(0)]
        public HANDLE SignatureInfoHandle;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Unused"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("ULONGLONG")]
        public ulong Unused;
    }

    /// <include file='_FamilyId_e__FixedBuffer.xml' path='doc/member[@name="_FamilyId_e__FixedBuffer"]/*' />
    [InlineArray(16)]
    public partial struct _FamilyId_e__FixedBuffer
    {
        public byte e0;
    }

    /// <include file='_ImageId_e__FixedBuffer.xml' path='doc/member[@name="_ImageId_e__FixedBuffer"]/*' />
    [InlineArray(16)]
    public partial struct _ImageId_e__FixedBuffer
    {
        public byte e0;
    }
}
