// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='CRYPT_PKCS12_PBE_PARAMS.xml' path='doc/member[@name="CRYPT_PKCS12_PBE_PARAMS"]/*' />
public partial struct CRYPT_PKCS12_PBE_PARAMS
{
    /// <include file='CRYPT_PKCS12_PBE_PARAMS.xml' path='doc/member[@name="CRYPT_PKCS12_PBE_PARAMS.iIterations"]/*' />
    public int iIterations;

    /// <include file='CRYPT_PKCS12_PBE_PARAMS.xml' path='doc/member[@name="CRYPT_PKCS12_PBE_PARAMS.cbSalt"]/*' />
    [NativeTypeName("ULONG")]
    public uint cbSalt;
}
