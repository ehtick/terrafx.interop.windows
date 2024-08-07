// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.printing.workflow.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='PdlConversionHostBasedProcessingOperations.xml' path='doc/member[@name="PdlConversionHostBasedProcessingOperations"]/*' />
[NativeTypeName("unsigned int")]
public enum PdlConversionHostBasedProcessingOperations : uint
{
    /// <include file='PdlConversionHostBasedProcessingOperations.xml' path='doc/member[@name="PdlConversionHostBasedProcessingOperations.PdlConversionHostBasedProcessingOperations_None"]/*' />
    PdlConversionHostBasedProcessingOperations_None = 0,

    /// <include file='PdlConversionHostBasedProcessingOperations.xml' path='doc/member[@name="PdlConversionHostBasedProcessingOperations.PdlConversionHostBasedProcessingOperations_PageRotation"]/*' />
    PdlConversionHostBasedProcessingOperations_PageRotation = 0x1,

    /// <include file='PdlConversionHostBasedProcessingOperations.xml' path='doc/member[@name="PdlConversionHostBasedProcessingOperations.PdlConversionHostBasedProcessingOperations_PageOrdering"]/*' />
    PdlConversionHostBasedProcessingOperations_PageOrdering = 0x2,

    /// <include file='PdlConversionHostBasedProcessingOperations.xml' path='doc/member[@name="PdlConversionHostBasedProcessingOperations.PdlConversionHostBasedProcessingOperations_Copies"]/*' />
    PdlConversionHostBasedProcessingOperations_Copies = 0x4,

    /// <include file='PdlConversionHostBasedProcessingOperations.xml' path='doc/member[@name="PdlConversionHostBasedProcessingOperations.PdlConversionHostBasedProcessingOperations_BlankPageInsertion"]/*' />
    PdlConversionHostBasedProcessingOperations_BlankPageInsertion = 0x8,

    /// <include file='PdlConversionHostBasedProcessingOperations.xml' path='doc/member[@name="PdlConversionHostBasedProcessingOperations.PdlConversionHostBasedProcessingOperations_All"]/*' />
    PdlConversionHostBasedProcessingOperations_All = 0xffffffff,
}
