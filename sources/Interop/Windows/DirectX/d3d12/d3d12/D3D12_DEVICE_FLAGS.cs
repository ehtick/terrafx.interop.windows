// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_DEVICE_FLAGS.xml' path='doc/member[@name="D3D12_DEVICE_FLAGS"]/*' />
[Flags]
public enum D3D12_DEVICE_FLAGS
{
    /// <include file='D3D12_DEVICE_FLAGS.xml' path='doc/member[@name="D3D12_DEVICE_FLAGS.D3D12_DEVICE_FLAG_NONE"]/*' />
    D3D12_DEVICE_FLAG_NONE = 0,

    /// <include file='D3D12_DEVICE_FLAGS.xml' path='doc/member[@name="D3D12_DEVICE_FLAGS.D3D12_DEVICE_FLAG_DEBUG_LAYER_ENABLED"]/*' />
    D3D12_DEVICE_FLAG_DEBUG_LAYER_ENABLED = 0x1,

    /// <include file='D3D12_DEVICE_FLAGS.xml' path='doc/member[@name="D3D12_DEVICE_FLAGS.D3D12_DEVICE_FLAG_GPU_BASED_VALIDATION_ENABLED"]/*' />
    D3D12_DEVICE_FLAG_GPU_BASED_VALIDATION_ENABLED = 0x2,

    /// <include file='D3D12_DEVICE_FLAGS.xml' path='doc/member[@name="D3D12_DEVICE_FLAGS.D3D12_DEVICE_FLAG_SYNCHRONIZED_COMMAND_QUEUE_VALIDATION_DISABLED"]/*' />
    D3D12_DEVICE_FLAG_SYNCHRONIZED_COMMAND_QUEUE_VALIDATION_DISABLED = 0x4,

    /// <include file='D3D12_DEVICE_FLAGS.xml' path='doc/member[@name="D3D12_DEVICE_FLAGS.D3D12_DEVICE_FLAG_DRED_AUTO_BREADCRUMBS_ENABLED"]/*' />
    D3D12_DEVICE_FLAG_DRED_AUTO_BREADCRUMBS_ENABLED = 0x8,

    /// <include file='D3D12_DEVICE_FLAGS.xml' path='doc/member[@name="D3D12_DEVICE_FLAGS.D3D12_DEVICE_FLAG_DRED_PAGE_FAULT_REPORTING_ENABLED"]/*' />
    D3D12_DEVICE_FLAG_DRED_PAGE_FAULT_REPORTING_ENABLED = 0x10,

    /// <include file='D3D12_DEVICE_FLAGS.xml' path='doc/member[@name="D3D12_DEVICE_FLAGS.D3D12_DEVICE_FLAG_DRED_WATSON_REPORTING_ENABLED"]/*' />
    D3D12_DEVICE_FLAG_DRED_WATSON_REPORTING_ENABLED = 0x20,

    /// <include file='D3D12_DEVICE_FLAGS.xml' path='doc/member[@name="D3D12_DEVICE_FLAGS.D3D12_DEVICE_FLAG_DRED_BREADCRUMB_CONTEXT_ENABLED"]/*' />
    D3D12_DEVICE_FLAG_DRED_BREADCRUMB_CONTEXT_ENABLED = 0x40,

    /// <include file='D3D12_DEVICE_FLAGS.xml' path='doc/member[@name="D3D12_DEVICE_FLAGS.D3D12_DEVICE_FLAG_DRED_USE_MARKERS_ONLY_BREADCRUMBS"]/*' />
    D3D12_DEVICE_FLAG_DRED_USE_MARKERS_ONLY_BREADCRUMBS = 0x80,

    /// <include file='D3D12_DEVICE_FLAGS.xml' path='doc/member[@name="D3D12_DEVICE_FLAGS.D3D12_DEVICE_FLAG_SHADER_INSTRUMENTATION_ENABLED"]/*' />
    D3D12_DEVICE_FLAG_SHADER_INSTRUMENTATION_ENABLED = 0x100,

    /// <include file='D3D12_DEVICE_FLAGS.xml' path='doc/member[@name="D3D12_DEVICE_FLAGS.D3D12_DEVICE_FLAG_AUTO_DEBUG_NAME_ENABLED"]/*' />
    D3D12_DEVICE_FLAG_AUTO_DEBUG_NAME_ENABLED = 0x200,

    /// <include file='D3D12_DEVICE_FLAGS.xml' path='doc/member[@name="D3D12_DEVICE_FLAGS.D3D12_DEVICE_FLAG_FORCE_LEGACY_STATE_VALIDATION"]/*' />
    D3D12_DEVICE_FLAG_FORCE_LEGACY_STATE_VALIDATION = 0x400,
}