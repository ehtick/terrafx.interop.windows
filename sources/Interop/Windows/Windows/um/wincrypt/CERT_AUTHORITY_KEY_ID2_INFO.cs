// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public partial struct CERT_AUTHORITY_KEY_ID2_INFO
    {
        public CRYPT_DATA_BLOB KeyId;

        public CERT_ALT_NAME_INFO AuthorityCertIssuer;

        [NativeTypeName("CRYPT_INTEGER_BLOB")]
        public CRYPT_DATA_BLOB AuthorityCertSerialNumber;
    }
}