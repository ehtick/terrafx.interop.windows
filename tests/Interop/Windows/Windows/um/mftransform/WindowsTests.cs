// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mftransform.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using static TerraFX.Interop.Windows.Windows;

namespace TerraFX.Interop.Windows.UnitTests
{
    /// <summary>Provides validation of the <see cref="Windows" /> class.</summary>
    public static unsafe partial class WindowsTests
    {
        /// <summary>Validates that the value of the <see cref="MEDeviceStreamCreated" /> property is correct.</summary>
        [Test]
        public static void MEDeviceStreamCreatedTest()
        {
            Assert.That(MEDeviceStreamCreated, Is.EqualTo(new Guid(0x0252a1cf, 0x3540, 0x43b4, 0x91, 0x64, 0xd7, 0x2e, 0xb4, 0x05, 0xfa, 0x40)));
        }

        /// <summary>Validates that the value of the <see cref="MFPKEY_CLSID" /> property is correct.</summary>
        [Test]
        public static void MFPKEY_CLSIDTest()
        {
            Assert.That(MFPKEY_CLSID.fmtid, Is.EqualTo(new Guid(0xc57a84c0, 0x1a80, 0x40a3, 0x97, 0xb5, 0x92, 0x72, 0xa4, 0x3, 0xc8, 0xae)));
            Assert.That(MFPKEY_CLSID.pid, Is.EqualTo(0x01));
        }

        /// <summary>Validates that the value of the <see cref="MFPKEY_CATEGORY" /> property is correct.</summary>
        [Test]
        public static void MFPKEY_CATEGORYTest()
        {
            Assert.That(MFPKEY_CATEGORY.fmtid, Is.EqualTo(new Guid(0xc57a84c0, 0x1a80, 0x40a3, 0x97, 0xb5, 0x92, 0x72, 0xa4, 0x3, 0xc8, 0xae)));
            Assert.That(MFPKEY_CATEGORY.pid, Is.EqualTo(0x02));
        }

        /// <summary>Validates that the value of the <see cref="MFPKEY_EXATTRIBUTE_SUPPORTED" /> property is correct.</summary>
        [Test]
        public static void MFPKEY_EXATTRIBUTE_SUPPORTEDTest()
        {
            Assert.That(MFPKEY_EXATTRIBUTE_SUPPORTED.fmtid, Is.EqualTo(new Guid(0x456fe843, 0x3c87, 0x40c0, 0x94, 0x9d, 0x14, 0x9, 0xc9, 0x7d, 0xab, 0x2c)));
            Assert.That(MFPKEY_EXATTRIBUTE_SUPPORTED.pid, Is.EqualTo(0x01));
        }

        /// <summary>Validates that the value of the <see cref="MFPKEY_MULTICHANNEL_CHANNEL_MASK" /> property is correct.</summary>
        [Test]
        public static void MFPKEY_MULTICHANNEL_CHANNEL_MASKTest()
        {
            Assert.That(MFPKEY_MULTICHANNEL_CHANNEL_MASK.fmtid, Is.EqualTo(new Guid(0x58bdaf8c, 0x3224, 0x4692, 0x86, 0xd0, 0x44, 0xd6, 0x5c, 0x5b, 0xf8, 0x2b)));
            Assert.That(MFPKEY_MULTICHANNEL_CHANNEL_MASK.pid, Is.EqualTo(0x01));
        }

        /// <summary>Validates that the value of the <see cref="MF_SA_D3D_AWARE" /> property is correct.</summary>
        [Test]
        public static void MF_SA_D3D_AWARETest()
        {
            Assert.That(MF_SA_D3D_AWARE, Is.EqualTo(new Guid(0xeaa35c29, 0x775e, 0x488e, 0x9b, 0x61, 0xb3, 0x28, 0x3e, 0x49, 0x58, 0x3b)));
        }

        /// <summary>Validates that the value of the <see cref="MF_SA_REQUIRED_SAMPLE_COUNT" /> property is correct.</summary>
        [Test]
        public static void MF_SA_REQUIRED_SAMPLE_COUNTTest()
        {
            Assert.That(MF_SA_REQUIRED_SAMPLE_COUNT, Is.EqualTo(new Guid(0x18802c61, 0x324b, 0x4952, 0xab, 0xd0, 0x17, 0x6f, 0xf5, 0xc6, 0x96, 0xff)));
        }

        /// <summary>Validates that the value of the <see cref="MFT_END_STREAMING_AWARE" /> property is correct.</summary>
        [Test]
        public static void MFT_END_STREAMING_AWARETest()
        {
            Assert.That(MFT_END_STREAMING_AWARE, Is.EqualTo(new Guid(0x70fbc845, 0xb07e, 0x4089, 0xb0, 0x64, 0x39, 0x9d, 0xc6, 0x11, 0xf, 0x29)));
        }

        /// <summary>Validates that the value of the <see cref="MF_SA_AUDIO_ENDPOINT_AWARE" /> property is correct.</summary>
        [Test]
        public static void MF_SA_AUDIO_ENDPOINT_AWARETest()
        {
            Assert.That(MF_SA_AUDIO_ENDPOINT_AWARE, Is.EqualTo(new Guid(0xc0381701, 0x805c, 0x42b2, 0xac, 0x8d, 0xe2, 0xb4, 0xbf, 0x21, 0xf4, 0xf8)));
        }

        /// <summary>Validates that the value of the <see cref="MFT_AUDIO_DECODER_AUDIO_ENDPOINT_ID" /> property is correct.</summary>
        [Test]
        public static void MFT_AUDIO_DECODER_AUDIO_ENDPOINT_IDTest()
        {
            Assert.That(MFT_AUDIO_DECODER_AUDIO_ENDPOINT_ID, Is.EqualTo(new Guid(0xc7ccdd6e, 0x5398, 0x4695, 0x8b, 0xe7, 0x51, 0xb3, 0xe9, 0x51, 0x11, 0xbd)));
        }

        /// <summary>Validates that the value of the <see cref="MFT_AUDIO_DECODER_SPATIAL_METADATA_CLIENT" /> property is correct.</summary>
        [Test]
        public static void MFT_AUDIO_DECODER_SPATIAL_METADATA_CLIENTTest()
        {
            Assert.That(MFT_AUDIO_DECODER_SPATIAL_METADATA_CLIENT, Is.EqualTo(new Guid(0x5987df4, 0x1270, 0x4999, 0x92, 0x5f, 0x8e, 0x93, 0x9a, 0x7c, 0xa, 0xf7)));
        }

        /// <summary>Validates that the value of the <see cref="MF_DMFT_FRAME_BUFFER_INFO" /> property is correct.</summary>
        [Test]
        public static void MF_DMFT_FRAME_BUFFER_INFOTest()
        {
            Assert.That(MF_DMFT_FRAME_BUFFER_INFO, Is.EqualTo(new Guid(0x396CE1C9, 0x67A9, 0x454C, 0x87, 0x97, 0x95, 0xA4, 0x57, 0x99, 0xD8, 0x04)));
        }

        /// <summary>Validates that the value of the <see cref="MF_SA_REQUIRED_SAMPLE_COUNT_PROGRESSIVE" /> property is correct.</summary>
        [Test]
        public static void MF_SA_REQUIRED_SAMPLE_COUNT_PROGRESSIVETest()
        {
            Assert.That(MF_SA_REQUIRED_SAMPLE_COUNT_PROGRESSIVE, Is.EqualTo(new Guid(0xb172d58e, 0xfa77, 0x4e48, 0x8d, 0x2a, 0x1d, 0xf2, 0xd8, 0x50, 0xea, 0xc2)));
        }

        /// <summary>Validates that the value of the <see cref="MF_SA_MINIMUM_OUTPUT_SAMPLE_COUNT" /> property is correct.</summary>
        [Test]
        public static void MF_SA_MINIMUM_OUTPUT_SAMPLE_COUNTTest()
        {
            Assert.That(MF_SA_MINIMUM_OUTPUT_SAMPLE_COUNT, Is.EqualTo(new Guid(0x851745d5, 0xc3d6, 0x476d, 0x95, 0x27, 0x49, 0x8e, 0xf2, 0xd1, 0xd, 0x18)));
        }

        /// <summary>Validates that the value of the <see cref="MF_SA_MINIMUM_OUTPUT_SAMPLE_COUNT_PROGRESSIVE" /> property is correct.</summary>
        [Test]
        public static void MF_SA_MINIMUM_OUTPUT_SAMPLE_COUNT_PROGRESSIVETest()
        {
            Assert.That(MF_SA_MINIMUM_OUTPUT_SAMPLE_COUNT_PROGRESSIVE, Is.EqualTo(new Guid(0xf5523a5, 0x1cb2, 0x47c5, 0xa5, 0x50, 0x2e, 0xeb, 0x84, 0xb4, 0xd1, 0x4a)));
        }

        /// <summary>Validates that the value of the <see cref="MFT_SUPPORT_3DVIDEO" /> property is correct.</summary>
        [Test]
        public static void MFT_SUPPORT_3DVIDEOTest()
        {
            Assert.That(MFT_SUPPORT_3DVIDEO, Is.EqualTo(new Guid(0x93f81b1, 0x4f2e, 0x4631, 0x81, 0x68, 0x79, 0x34, 0x3, 0x2a, 0x1, 0xd3)));
        }

        /// <summary>Validates that the value of the <see cref="MF_ENABLE_3DVIDEO_OUTPUT" /> property is correct.</summary>
        [Test]
        public static void MF_ENABLE_3DVIDEO_OUTPUTTest()
        {
            Assert.That(MF_ENABLE_3DVIDEO_OUTPUT, Is.EqualTo(new Guid(0xbdad7bca, 0xe5f, 0x4b10, 0xab, 0x16, 0x26, 0xde, 0x38, 0x1b, 0x62, 0x93)));
        }

        /// <summary>Validates that the value of the <see cref="MF_SA_D3D11_BINDFLAGS" /> property is correct.</summary>
        [Test]
        public static void MF_SA_D3D11_BINDFLAGSTest()
        {
            Assert.That(MF_SA_D3D11_BINDFLAGS, Is.EqualTo(new Guid(0xeacf97ad, 0x065c, 0x4408, 0xbe, 0xe3, 0xfd, 0xcb, 0xfd, 0x12, 0x8b, 0xe2)));
        }

        /// <summary>Validates that the value of the <see cref="MF_SA_D3D11_USAGE" /> property is correct.</summary>
        [Test]
        public static void MF_SA_D3D11_USAGETest()
        {
            Assert.That(MF_SA_D3D11_USAGE, Is.EqualTo(new Guid(0xe85fe442, 0x2ca3, 0x486e, 0xa9, 0xc7, 0x10, 0x9d, 0xda, 0x60, 0x98, 0x80)));
        }

        /// <summary>Validates that the value of the <see cref="MF_SA_D3D11_AWARE" /> property is correct.</summary>
        [Test]
        public static void MF_SA_D3D11_AWARETest()
        {
            Assert.That(MF_SA_D3D11_AWARE, Is.EqualTo(new Guid(0x206b4fc8, 0xfcf9, 0x4c51, 0xaf, 0xe3, 0x97, 0x64, 0x36, 0x9e, 0x33, 0xa0)));
        }

        /// <summary>Validates that the value of the <see cref="MF_SA_D3D11_SHARED" /> property is correct.</summary>
        [Test]
        public static void MF_SA_D3D11_SHAREDTest()
        {
            Assert.That(MF_SA_D3D11_SHARED, Is.EqualTo(new Guid(0x7b8f32c3, 0x6d96, 0x4b89, 0x92, 0x3, 0xdd, 0x38, 0xb6, 0x14, 0x14, 0xf3)));
        }

        /// <summary>Validates that the value of the <see cref="MF_SA_D3D11_SHARED_WITHOUT_MUTEX" /> property is correct.</summary>
        [Test]
        public static void MF_SA_D3D11_SHARED_WITHOUT_MUTEXTest()
        {
            Assert.That(MF_SA_D3D11_SHARED_WITHOUT_MUTEX, Is.EqualTo(new Guid(0x39dbd44d, 0x2e44, 0x4931, 0xa4, 0xc8, 0x35, 0x2d, 0x3d, 0xc4, 0x21, 0x15)));
        }

        /// <summary>Validates that the value of the <see cref="MF_SA_D3D11_ALLOW_DYNAMIC_YUV_TEXTURE" /> property is correct.</summary>
        [Test]
        public static void MF_SA_D3D11_ALLOW_DYNAMIC_YUV_TEXTURETest()
        {
            Assert.That(MF_SA_D3D11_ALLOW_DYNAMIC_YUV_TEXTURE, Is.EqualTo(new Guid(0xce06d49f, 0x613, 0x4b9d, 0x86, 0xa6, 0xd8, 0xc4, 0xf9, 0xc1, 0x0, 0x75)));
        }

        /// <summary>Validates that the value of the <see cref="MF_SA_D3D11_HW_PROTECTED" /> property is correct.</summary>
        [Test]
        public static void MF_SA_D3D11_HW_PROTECTEDTest()
        {
            Assert.That(MF_SA_D3D11_HW_PROTECTED, Is.EqualTo(new Guid(0x3a8ba9d9, 0x92ca, 0x4307, 0xa3, 0x91, 0x69, 0x99, 0xdb, 0xf3, 0xb6, 0xce)));
        }

        /// <summary>Validates that the value of the <see cref="MF_SA_BUFFERS_PER_SAMPLE" /> property is correct.</summary>
        [Test]
        public static void MF_SA_BUFFERS_PER_SAMPLETest()
        {
            Assert.That(MF_SA_BUFFERS_PER_SAMPLE, Is.EqualTo(new Guid(0x873c5171, 0x1e3d, 0x4e25, 0x98, 0x8d, 0xb4, 0x33, 0xce, 0x04, 0x19, 0x83)));
        }

        /// <summary>Validates that the value of the <see cref="MFT_DECODER_EXPOSE_OUTPUT_TYPES_IN_NATIVE_ORDER" /> property is correct.</summary>
        [Test]
        public static void MFT_DECODER_EXPOSE_OUTPUT_TYPES_IN_NATIVE_ORDERTest()
        {
            Assert.That(MFT_DECODER_EXPOSE_OUTPUT_TYPES_IN_NATIVE_ORDER, Is.EqualTo(new Guid(0xef80833f, 0xf8fa, 0x44d9, 0x80, 0xd8, 0x41, 0xed, 0x62, 0x32, 0x67, 0xc)));
        }

        /// <summary>Validates that the value of the <see cref="MFT_DECODER_QUALITY_MANAGEMENT_CUSTOM_CONTROL" /> property is correct.</summary>
        [Test]
        public static void MFT_DECODER_QUALITY_MANAGEMENT_CUSTOM_CONTROLTest()
        {
            Assert.That(MFT_DECODER_QUALITY_MANAGEMENT_CUSTOM_CONTROL, Is.EqualTo(new Guid(0xa24e30d7, 0xde25, 0x4558, 0xbb, 0xfb, 0x71, 0x7, 0xa, 0x2d, 0x33, 0x2e)));
        }

        /// <summary>Validates that the value of the <see cref="MFT_DECODER_QUALITY_MANAGEMENT_RECOVERY_WITHOUT_ARTIFACTS" /> property is correct.</summary>
        [Test]
        public static void MFT_DECODER_QUALITY_MANAGEMENT_RECOVERY_WITHOUT_ARTIFACTSTest()
        {
            Assert.That(MFT_DECODER_QUALITY_MANAGEMENT_RECOVERY_WITHOUT_ARTIFACTS, Is.EqualTo(new Guid(0xd8980deb, 0xa48, 0x425f, 0x86, 0x23, 0x61, 0x1d, 0xb4, 0x1d, 0x38, 0x10)));
        }

        /// <summary>Validates that the value of the <see cref="MFT_REMUX_MARK_I_PICTURE_AS_CLEAN_POINT" /> property is correct.</summary>
        [Test]
        public static void MFT_REMUX_MARK_I_PICTURE_AS_CLEAN_POINTTest()
        {
            Assert.That(MFT_REMUX_MARK_I_PICTURE_AS_CLEAN_POINT, Is.EqualTo(new Guid(0x364e8f85, 0x3f2e, 0x436c, 0xb2, 0xa2, 0x44, 0x40, 0xa0, 0x12, 0xa9, 0xe8)));
        }

        /// <summary>Validates that the value of the <see cref="MFT_DECODER_FINAL_VIDEO_RESOLUTION_HINT" /> property is correct.</summary>
        [Test]
        public static void MFT_DECODER_FINAL_VIDEO_RESOLUTION_HINTTest()
        {
            Assert.That(MFT_DECODER_FINAL_VIDEO_RESOLUTION_HINT, Is.EqualTo(new Guid(0xdc2f8496, 0x15c4, 0x407a, 0xb6, 0xf0, 0x1b, 0x66, 0xab, 0x5f, 0xbf, 0x53)));
        }

        /// <summary>Validates that the value of the <see cref="MFT_ENCODER_SUPPORTS_CONFIG_EVENT" /> property is correct.</summary>
        [Test]
        public static void MFT_ENCODER_SUPPORTS_CONFIG_EVENTTest()
        {
            Assert.That(MFT_ENCODER_SUPPORTS_CONFIG_EVENT, Is.EqualTo(new Guid(0x86a355ae, 0x3a77, 0x4ec4, 0x9f, 0x31, 0x1, 0x14, 0x9a, 0x4e, 0x92, 0xde)));
        }

        /// <summary>Validates that the value of the <see cref="MFT_ENUM_HARDWARE_VENDOR_ID_Attribute" /> property is correct.</summary>
        [Test]
        public static void MFT_ENUM_HARDWARE_VENDOR_ID_AttributeTest()
        {
            Assert.That(MFT_ENUM_HARDWARE_VENDOR_ID_Attribute, Is.EqualTo(new Guid(0x3aecb0cc, 0x35b, 0x4bcc, 0x81, 0x85, 0x2b, 0x8d, 0x55, 0x1e, 0xf3, 0xaf)));
        }

        /// <summary>Validates that the value of the <see cref="MF_TRANSFORM_ASYNC" /> property is correct.</summary>
        [Test]
        public static void MF_TRANSFORM_ASYNCTest()
        {
            Assert.That(MF_TRANSFORM_ASYNC, Is.EqualTo(new Guid(0xf81a699a, 0x649a, 0x497d, 0x8c, 0x73, 0x29, 0xf8, 0xfe, 0xd6, 0xad, 0x7a)));
        }

        /// <summary>Validates that the value of the <see cref="MF_TRANSFORM_ASYNC_UNLOCK" /> property is correct.</summary>
        [Test]
        public static void MF_TRANSFORM_ASYNC_UNLOCKTest()
        {
            Assert.That(MF_TRANSFORM_ASYNC_UNLOCK, Is.EqualTo(new Guid(0xe5666d6b, 0x3422, 0x4eb6, 0xa4, 0x21, 0xda, 0x7d, 0xb1, 0xf8, 0xe2, 0x7)));
        }

        /// <summary>Validates that the value of the <see cref="MF_TRANSFORM_FLAGS_Attribute" /> property is correct.</summary>
        [Test]
        public static void MF_TRANSFORM_FLAGS_AttributeTest()
        {
            Assert.That(MF_TRANSFORM_FLAGS_Attribute, Is.EqualTo(new Guid(0x9359bb7e, 0x6275, 0x46c4, 0xa0, 0x25, 0x1c, 0x1, 0xe4, 0x5f, 0x1a, 0x86)));
        }

        /// <summary>Validates that the value of the <see cref="MF_TRANSFORM_CATEGORY_Attribute" /> property is correct.</summary>
        [Test]
        public static void MF_TRANSFORM_CATEGORY_AttributeTest()
        {
            Assert.That(MF_TRANSFORM_CATEGORY_Attribute, Is.EqualTo(new Guid(0xceabba49, 0x506d, 0x4757, 0xa6, 0xff, 0x66, 0xc1, 0x84, 0x98, 0x7e, 0x4e)));
        }

        /// <summary>Validates that the value of the <see cref="MFT_TRANSFORM_CLSID_Attribute" /> property is correct.</summary>
        [Test]
        public static void MFT_TRANSFORM_CLSID_AttributeTest()
        {
            Assert.That(MFT_TRANSFORM_CLSID_Attribute, Is.EqualTo(new Guid(0x6821c42b, 0x65a4, 0x4e82, 0x99, 0xbc, 0x9a, 0x88, 0x20, 0x5e, 0xcd, 0xc)));
        }

        /// <summary>Validates that the value of the <see cref="MFT_INPUT_TYPES_Attributes" /> property is correct.</summary>
        [Test]
        public static void MFT_INPUT_TYPES_AttributesTest()
        {
            Assert.That(MFT_INPUT_TYPES_Attributes, Is.EqualTo(new Guid(0x4276c9b1, 0x759d, 0x4bf3, 0x9c, 0xd0, 0xd, 0x72, 0x3d, 0x13, 0x8f, 0x96)));
        }

        /// <summary>Validates that the value of the <see cref="MFT_OUTPUT_TYPES_Attributes" /> property is correct.</summary>
        [Test]
        public static void MFT_OUTPUT_TYPES_AttributesTest()
        {
            Assert.That(MFT_OUTPUT_TYPES_Attributes, Is.EqualTo(new Guid(0x8eae8cf3, 0xa44f, 0x4306, 0xba, 0x5c, 0xbf, 0x5d, 0xda, 0x24, 0x28, 0x18)));
        }

        /// <summary>Validates that the value of the <see cref="MFT_ENUM_HARDWARE_URL_Attribute" /> property is correct.</summary>
        [Test]
        public static void MFT_ENUM_HARDWARE_URL_AttributeTest()
        {
            Assert.That(MFT_ENUM_HARDWARE_URL_Attribute, Is.EqualTo(new Guid(0x2fb866ac, 0xb078, 0x4942, 0xab, 0x6c, 0x0, 0x3d, 0x5, 0xcd, 0xa6, 0x74)));
        }

        /// <summary>Validates that the value of the <see cref="MFT_FRIENDLY_NAME_Attribute" /> property is correct.</summary>
        [Test]
        public static void MFT_FRIENDLY_NAME_AttributeTest()
        {
            Assert.That(MFT_FRIENDLY_NAME_Attribute, Is.EqualTo(new Guid(0x314ffbae, 0x5b41, 0x4c95, 0x9c, 0x19, 0x4e, 0x7d, 0x58, 0x6f, 0xac, 0xe3)));
        }

        /// <summary>Validates that the value of the <see cref="MFT_CONNECTED_STREAM_ATTRIBUTE" /> property is correct.</summary>
        [Test]
        public static void MFT_CONNECTED_STREAM_ATTRIBUTETest()
        {
            Assert.That(MFT_CONNECTED_STREAM_ATTRIBUTE, Is.EqualTo(new Guid(0x71eeb820, 0xa59f, 0x4de2, 0xbc, 0xec, 0x38, 0xdb, 0x1d, 0xd6, 0x11, 0xa4)));
        }

        /// <summary>Validates that the value of the <see cref="MFT_CONNECTED_TO_HW_STREAM" /> property is correct.</summary>
        [Test]
        public static void MFT_CONNECTED_TO_HW_STREAMTest()
        {
            Assert.That(MFT_CONNECTED_TO_HW_STREAM, Is.EqualTo(new Guid(0x34e6e728, 0x6d6, 0x4491, 0xa5, 0x53, 0x47, 0x95, 0x65, 0xd, 0xb9, 0x12)));
        }

        /// <summary>Validates that the value of the <see cref="MFT_PREFERRED_OUTPUTTYPE_Attribute" /> property is correct.</summary>
        [Test]
        public static void MFT_PREFERRED_OUTPUTTYPE_AttributeTest()
        {
            Assert.That(MFT_PREFERRED_OUTPUTTYPE_Attribute, Is.EqualTo(new Guid(0x7e700499, 0x396a, 0x49ee, 0xb1, 0xb4, 0xf6, 0x28, 0x2, 0x1e, 0x8c, 0x9d)));
        }

        /// <summary>Validates that the value of the <see cref="MFT_PROCESS_LOCAL_Attribute" /> property is correct.</summary>
        [Test]
        public static void MFT_PROCESS_LOCAL_AttributeTest()
        {
            Assert.That(MFT_PROCESS_LOCAL_Attribute, Is.EqualTo(new Guid(0x543186e4, 0x4649, 0x4e65, 0xb5, 0x88, 0x4a, 0xa3, 0x52, 0xaf, 0xf3, 0x79)));
        }

        /// <summary>Validates that the value of the <see cref="MFT_PREFERRED_ENCODER_PROFILE" /> property is correct.</summary>
        [Test]
        public static void MFT_PREFERRED_ENCODER_PROFILETest()
        {
            Assert.That(MFT_PREFERRED_ENCODER_PROFILE, Is.EqualTo(new Guid(0x53004909, 0x1ef5, 0x46d7, 0xa1, 0x8e, 0x5a, 0x75, 0xf8, 0xb5, 0x90, 0x5f)));
        }

        /// <summary>Validates that the value of the <see cref="MFT_HW_TIMESTAMP_WITH_QPC_Attribute" /> property is correct.</summary>
        [Test]
        public static void MFT_HW_TIMESTAMP_WITH_QPC_AttributeTest()
        {
            Assert.That(MFT_HW_TIMESTAMP_WITH_QPC_Attribute, Is.EqualTo(new Guid(0x8d030fb8, 0xcc43, 0x4258, 0xa2, 0x2e, 0x92, 0x10, 0xbe, 0xf8, 0x9b, 0xe4)));
        }

        /// <summary>Validates that the value of the <see cref="MFT_FIELDOFUSE_UNLOCK_Attribute" /> property is correct.</summary>
        [Test]
        public static void MFT_FIELDOFUSE_UNLOCK_AttributeTest()
        {
            Assert.That(MFT_FIELDOFUSE_UNLOCK_Attribute, Is.EqualTo(new Guid(0x8ec2e9fd, 0x9148, 0x410d, 0x83, 0x1e, 0x70, 0x24, 0x39, 0x46, 0x1a, 0x8e)));
        }

        /// <summary>Validates that the value of the <see cref="MFT_CODEC_MERIT_Attribute" /> property is correct.</summary>
        [Test]
        public static void MFT_CODEC_MERIT_AttributeTest()
        {
            Assert.That(MFT_CODEC_MERIT_Attribute, Is.EqualTo(new Guid(0x88a7cb15, 0x7b07, 0x4a34, 0x91, 0x28, 0xe6, 0x4c, 0x67, 0x3, 0xc4, 0xd3)));
        }

        /// <summary>Validates that the value of the <see cref="MFT_ENUM_TRANSCODE_ONLY_ATTRIBUTE" /> property is correct.</summary>
        [Test]
        public static void MFT_ENUM_TRANSCODE_ONLY_ATTRIBUTETest()
        {
            Assert.That(MFT_ENUM_TRANSCODE_ONLY_ATTRIBUTE, Is.EqualTo(new Guid(0x111ea8cd, 0xb62a, 0x4bdb, 0x89, 0xf6, 0x67, 0xff, 0xcd, 0xc2, 0x45, 0x8b)));
        }

        /// <summary>Validates that the value of the <see cref="MFT_AUDIO_DECODER_DEGRADATION_INFO_ATTRIBUTE" /> property is correct.</summary>
        [Test]
        public static void MFT_AUDIO_DECODER_DEGRADATION_INFO_ATTRIBUTETest()
        {
            Assert.That(MFT_AUDIO_DECODER_DEGRADATION_INFO_ATTRIBUTE, Is.EqualTo(new Guid(0x6c3386ad, 0xec20, 0x430d, 0xb2, 0xa5, 0x50, 0x5c, 0x71, 0x78, 0xd9, 0xc4)));
        }

        /// <summary>Validates that the value of the <see cref="MFT_POLICY_SET_AWARE" /> property is correct.</summary>
        [Test]
        public static void MFT_POLICY_SET_AWARETest()
        {
            Assert.That(MFT_POLICY_SET_AWARE, Is.EqualTo(new Guid(0x5a633b19, 0xcc39, 0x4fa8, 0x8c, 0xa5, 0x59, 0x98, 0x1b, 0x7a, 0x0, 0x18)));
        }

        /// <summary>Validates that the value of the <see cref="MFT_USING_HARDWARE_DRM" /> property is correct.</summary>
        [Test]
        public static void MFT_USING_HARDWARE_DRMTest()
        {
            Assert.That(MFT_USING_HARDWARE_DRM, Is.EqualTo(new Guid(0x34faa77d, 0xd79e, 0x4957, 0xb8, 0xce, 0x36, 0x2b, 0x26, 0x84, 0x99, 0x6c)));
        }
    }
}