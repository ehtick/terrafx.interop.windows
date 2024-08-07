// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='FILE_ID_TYPE.xml' path='doc/member[@name="FILE_ID_TYPE"]/*' />
public enum FILE_ID_TYPE
{
    /// <include file='FILE_ID_TYPE.xml' path='doc/member[@name="FILE_ID_TYPE.FileIdType"]/*' />
    FileIdType,

    /// <include file='FILE_ID_TYPE.xml' path='doc/member[@name="FILE_ID_TYPE.ObjectIdType"]/*' />
    ObjectIdType,

    /// <include file='FILE_ID_TYPE.xml' path='doc/member[@name="FILE_ID_TYPE.ExtendedFileIdType"]/*' />
    ExtendedFileIdType,

    /// <include file='FILE_ID_TYPE.xml' path='doc/member[@name="FILE_ID_TYPE.MaximumFileIdType"]/*' />
    MaximumFileIdType,
}
