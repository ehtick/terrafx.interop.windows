// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct WS_STRUCT_DESCRIPTION
    {
        [NativeTypeName("ULONG")]
        public uint size;

        [NativeTypeName("ULONG")]
        public uint alignment;

        public WS_FIELD_DESCRIPTION** fields;

        [NativeTypeName("ULONG")]
        public uint fieldCount;

        public WS_XML_STRING* typeLocalName;

        public WS_XML_STRING* typeNs;

        public WS_STRUCT_DESCRIPTION* parentType;

        public WS_STRUCT_DESCRIPTION** subTypes;

        [NativeTypeName("ULONG")]
        public uint subTypeCount;

        [NativeTypeName("ULONG")]
        public uint structOptions;
    }
}
