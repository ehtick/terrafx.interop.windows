// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3DAUTHENTICATEDCHANNEL_QUERYCHANNELTYPE_OUTPUT.xml' path='doc/member[@name="D3DAUTHENTICATEDCHANNEL_QUERYCHANNELTYPE_OUTPUT"]/*' />
public partial struct D3DAUTHENTICATEDCHANNEL_QUERYCHANNELTYPE_OUTPUT
{
    /// <include file='D3DAUTHENTICATEDCHANNEL_QUERYCHANNELTYPE_OUTPUT.xml' path='doc/member[@name="D3DAUTHENTICATEDCHANNEL_QUERYCHANNELTYPE_OUTPUT.Output"]/*' />
    public D3DAUTHENTICATEDCHANNEL_QUERY_OUTPUT Output;

    /// <include file='D3DAUTHENTICATEDCHANNEL_QUERYCHANNELTYPE_OUTPUT.xml' path='doc/member[@name="D3DAUTHENTICATEDCHANNEL_QUERYCHANNELTYPE_OUTPUT.ChannelType"]/*' />
    public D3DAUTHENTICATEDCHANNELTYPE ChannelType;
}
