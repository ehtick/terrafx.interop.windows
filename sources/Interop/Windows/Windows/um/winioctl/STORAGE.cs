// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public static partial class STORAGE
    {
        [NativeTypeName("#define STORAGE_DEVICE_FLAGS_RANDOM_DEVICEGUID_REASON_CONFLICT 0x1")]
        public const int STORAGE_DEVICE_FLAGS_RANDOM_DEVICEGUID_REASON_CONFLICT = 0x1;

        [NativeTypeName("#define STORAGE_DEVICE_FLAGS_RANDOM_DEVICEGUID_REASON_NOHWID 0x2")]
        public const int STORAGE_DEVICE_FLAGS_RANDOM_DEVICEGUID_REASON_NOHWID = 0x2;

        [NativeTypeName("#define STORAGE_DEVICE_FLAGS_PAGE_83_DEVICEGUID 0x4")]
        public const int STORAGE_DEVICE_FLAGS_PAGE_83_DEVICEGUID = 0x4;

        [NativeTypeName("#define STORAGE_FAILURE_PREDICTION_CONFIG_V1 1")]
        public const int STORAGE_FAILURE_PREDICTION_CONFIG_V1 = 1;

        [NativeTypeName("#define STORAGE_ADDRESS_TYPE_BTL8 0")]
        public const int STORAGE_ADDRESS_TYPE_BTL8 = 0;

        [NativeTypeName("#define STORAGE_RPMB_DESCRIPTOR_VERSION_1 1")]
        public const int STORAGE_RPMB_DESCRIPTOR_VERSION_1 = 1;

        [NativeTypeName("#define STORAGE_RPMB_MINIMUM_RELIABLE_WRITE_SIZE 512")]
        public const int STORAGE_RPMB_MINIMUM_RELIABLE_WRITE_SIZE = 512;

        [NativeTypeName("#define STORAGE_CRYPTO_CAPABILITY_VERSION_1 1")]
        public const int STORAGE_CRYPTO_CAPABILITY_VERSION_1 = 1;

        [NativeTypeName("#define STORAGE_CRYPTO_DESCRIPTOR_VERSION_1 1")]
        public const int STORAGE_CRYPTO_DESCRIPTOR_VERSION_1 = 1;

        [NativeTypeName("#define STORAGE_TIER_NAME_LENGTH (256)")]
        public const int STORAGE_TIER_NAME_LENGTH = (256);

        [NativeTypeName("#define STORAGE_TIER_DESCRIPTION_LENGTH (512)")]
        public const int STORAGE_TIER_DESCRIPTION_LENGTH = (512);

        [NativeTypeName("#define STORAGE_TIER_FLAG_NO_SEEK_PENALTY (0x00020000)")]
        public const int STORAGE_TIER_FLAG_NO_SEEK_PENALTY = (0x00020000);

        [NativeTypeName("#define STORAGE_TIER_FLAG_WRITE_BACK_CACHE (0x00200000)")]
        public const int STORAGE_TIER_FLAG_WRITE_BACK_CACHE = (0x00200000);

        [NativeTypeName("#define STORAGE_TIER_FLAG_READ_CACHE (0x00400000)")]
        public const int STORAGE_TIER_FLAG_READ_CACHE = (0x00400000);

        [NativeTypeName("#define STORAGE_TIER_FLAG_PARITY (0x00800000)")]
        public const int STORAGE_TIER_FLAG_PARITY = (0x00800000);

        [NativeTypeName("#define STORAGE_TIER_FLAG_SMR (0x01000000)")]
        public const int STORAGE_TIER_FLAG_SMR = (0x01000000);

        [NativeTypeName("#define STORAGE_TEMPERATURE_VALUE_NOT_REPORTED 0x8000")]
        public const int STORAGE_TEMPERATURE_VALUE_NOT_REPORTED = 0x8000;

        [NativeTypeName("#define STORAGE_TEMPERATURE_THRESHOLD_FLAG_ADAPTER_REQUEST 0x0001")]
        public const int STORAGE_TEMPERATURE_THRESHOLD_FLAG_ADAPTER_REQUEST = 0x0001;

        [NativeTypeName("#define STORAGE_COMPONENT_ROLE_CACHE 0x00000001")]
        public const int STORAGE_COMPONENT_ROLE_CACHE = 0x00000001;

        [NativeTypeName("#define STORAGE_COMPONENT_ROLE_TIERING 0x00000002")]
        public const int STORAGE_COMPONENT_ROLE_TIERING = 0x00000002;

        [NativeTypeName("#define STORAGE_COMPONENT_ROLE_DATA 0x00000004")]
        public const int STORAGE_COMPONENT_ROLE_DATA = 0x00000004;

        [NativeTypeName("#define STORAGE_ATTRIBUTE_BYTE_ADDRESSABLE_IO 0x01")]
        public const int STORAGE_ATTRIBUTE_BYTE_ADDRESSABLE_IO = 0x01;

        [NativeTypeName("#define STORAGE_ATTRIBUTE_BLOCK_IO 0x02")]
        public const int STORAGE_ATTRIBUTE_BLOCK_IO = 0x02;

        [NativeTypeName("#define STORAGE_ATTRIBUTE_DYNAMIC_PERSISTENCE 0x04")]
        public const int STORAGE_ATTRIBUTE_DYNAMIC_PERSISTENCE = 0x04;

        [NativeTypeName("#define STORAGE_ATTRIBUTE_VOLATILE 0x08")]
        public const int STORAGE_ATTRIBUTE_VOLATILE = 0x08;

        [NativeTypeName("#define STORAGE_ATTRIBUTE_ASYNC_EVENT_NOTIFICATION 0x10")]
        public const int STORAGE_ATTRIBUTE_ASYNC_EVENT_NOTIFICATION = 0x10;

        [NativeTypeName("#define STORAGE_ATTRIBUTE_PERF_SIZE_INDEPENDENT 0x20")]
        public const int STORAGE_ATTRIBUTE_PERF_SIZE_INDEPENDENT = 0x20;

        [NativeTypeName("#define STORAGE_DEVICE_MAX_OPERATIONAL_STATUS 16")]
        public const int STORAGE_DEVICE_MAX_OPERATIONAL_STATUS = 16;

        [NativeTypeName("#define STORAGE_ADAPTER_SERIAL_NUMBER_V1_MAX_LENGTH (128)")]
        public const int STORAGE_ADAPTER_SERIAL_NUMBER_V1_MAX_LENGTH = (128);

        [NativeTypeName("#define STORAGE_ADAPTER_SERIAL_NUMBER_V1_VERSION (sizeof(STORAGE_ADAPTER_SERIAL_NUMBER))")]
        public const uint STORAGE_ADAPTER_SERIAL_NUMBER_V1_VERSION = (264);

        [NativeTypeName("#define STORAGE_ADAPTER_SERIAL_NUMBER_V1_SIZE (sizeof(STORAGE_ADAPTER_SERIAL_NUMBER))")]
        public const uint STORAGE_ADAPTER_SERIAL_NUMBER_V1_SIZE = (264);

        [NativeTypeName("#define STORAGE_DEVICE_NUMA_NODE_UNKNOWN MAXDWORD")]
        public const uint STORAGE_DEVICE_NUMA_NODE_UNKNOWN = 0xffffffff;

        [NativeTypeName("#define STORAGE_OFFLOAD_MAX_TOKEN_LENGTH 512")]
        public const int STORAGE_OFFLOAD_MAX_TOKEN_LENGTH = 512;

        [NativeTypeName("#define STORAGE_OFFLOAD_TOKEN_ID_LENGTH 0x1F8")]
        public const int STORAGE_OFFLOAD_TOKEN_ID_LENGTH = 0x1F8;

        [NativeTypeName("#define STORAGE_OFFLOAD_TOKEN_TYPE_ZERO_DATA 0xFFFF0001")]
        public const uint STORAGE_OFFLOAD_TOKEN_TYPE_ZERO_DATA = 0xFFFF0001;

        [NativeTypeName("#define STORAGE_OFFLOAD_READ_RANGE_TRUNCATED 0x00000001")]
        public const int STORAGE_OFFLOAD_READ_RANGE_TRUNCATED = 0x00000001;

        [NativeTypeName("#define STORAGE_OFFLOAD_WRITE_RANGE_TRUNCATED 0x0001")]
        public const int STORAGE_OFFLOAD_WRITE_RANGE_TRUNCATED = 0x0001;

        [NativeTypeName("#define STORAGE_OFFLOAD_TOKEN_INVALID 0x0002")]
        public const int STORAGE_OFFLOAD_TOKEN_INVALID = 0x0002;

        [NativeTypeName("#define STORAGE_PRIORITY_HINT_SUPPORTED 0x0001")]
        public const int STORAGE_PRIORITY_HINT_SUPPORTED = 0x0001;

        [NativeTypeName("#define STORAGE_DIAGNOSTIC_FLAG_ADAPTER_REQUEST 0x00000001")]
        public const int STORAGE_DIAGNOSTIC_FLAG_ADAPTER_REQUEST = 0x00000001;

        [NativeTypeName("#define STORAGE_CRASH_TELEMETRY_REGKEY L\"\\\\Registry\\\\Machine\\\\System\\\\CurrentControlSet\\\\Control\\\\CrashControl\\\\StorageTelemetry\"")]
        public const string STORAGE_CRASH_TELEMETRY_REGKEY = "\\Registry\\Machine\\System\\CurrentControlSet\\Control\\CrashControl\\StorageTelemetry";

        [NativeTypeName("#define STORAGE_DEVICE_TELEMETRY_REGKEY L\"\\\\Registry\\\\Machine\\\\System\\\\CurrentControlSet\\\\Control\\\\Storage\\\\StorageTelemetry\"")]
        public const string STORAGE_DEVICE_TELEMETRY_REGKEY = "\\Registry\\Machine\\System\\CurrentControlSet\\Control\\Storage\\StorageTelemetry";

        [NativeTypeName("#define STORAGE_IDLE_POWERUP_REASON_VERSION_V1 1")]
        public const int STORAGE_IDLE_POWERUP_REASON_VERSION_V1 = 1;

        [NativeTypeName("#define STORAGE_DEVICE_POWER_CAP_VERSION_V1 1")]
        public const int STORAGE_DEVICE_POWER_CAP_VERSION_V1 = 1;

        [NativeTypeName("#define STORAGE_EVENT_NOTIFICATION_VERSION_V1 1")]
        public const int STORAGE_EVENT_NOTIFICATION_VERSION_V1 = 1;

        [NativeTypeName("#define STORAGE_EVENT_MEDIA_STATUS 0x0000000000000001")]
        public const int STORAGE_EVENT_MEDIA_STATUS = 0x0000000000000001;

        [NativeTypeName("#define STORAGE_EVENT_DEVICE_STATUS 0x0000000000000002")]
        public const int STORAGE_EVENT_DEVICE_STATUS = 0x0000000000000002;

        [NativeTypeName("#define STORAGE_EVENT_DEVICE_OPERATION 0x0000000000000004")]
        public const int STORAGE_EVENT_DEVICE_OPERATION = 0x0000000000000004;

        [NativeTypeName("#define STORAGE_EVENT_ALL (STORAGE_EVENT_MEDIA_STATUS | STORAGE_EVENT_DEVICE_STATUS | STORAGE_EVENT_DEVICE_OPERATION)")]
        public const int STORAGE_EVENT_ALL = (0x0000000000000001 | 0x0000000000000002 | 0x0000000000000004);

        [NativeTypeName("#define STORAGE_COUNTERS_VERSION_V1 sizeof(STORAGE_COUNTERS)")]
        public const uint STORAGE_COUNTERS_VERSION_V1 = 32;

        [NativeTypeName("#define STORAGE_HW_FIRMWARE_REQUEST_FLAG_CONTROLLER 0x00000001")]
        public const int STORAGE_HW_FIRMWARE_REQUEST_FLAG_CONTROLLER = 0x00000001;

        [NativeTypeName("#define STORAGE_HW_FIRMWARE_REQUEST_FLAG_LAST_SEGMENT 0x00000002")]
        public const int STORAGE_HW_FIRMWARE_REQUEST_FLAG_LAST_SEGMENT = 0x00000002;

        [NativeTypeName("#define STORAGE_HW_FIRMWARE_REQUEST_FLAG_FIRST_SEGMENT 0x00000004")]
        public const int STORAGE_HW_FIRMWARE_REQUEST_FLAG_FIRST_SEGMENT = 0x00000004;

        [NativeTypeName("#define STORAGE_HW_FIRMWARE_REQUEST_FLAG_SWITCH_TO_EXISTING_FIRMWARE 0x80000000")]
        public const uint STORAGE_HW_FIRMWARE_REQUEST_FLAG_SWITCH_TO_EXISTING_FIRMWARE = 0x80000000;

        [NativeTypeName("#define STORAGE_HW_FIRMWARE_INVALID_SLOT 0xFF")]
        public const int STORAGE_HW_FIRMWARE_INVALID_SLOT = 0xFF;

        [NativeTypeName("#define STORAGE_HW_FIRMWARE_REVISION_LENGTH 16")]
        public const int STORAGE_HW_FIRMWARE_REVISION_LENGTH = 16;

        [NativeTypeName("#define STORAGE_PROTOCOL_STRUCTURE_VERSION 0x1")]
        public const int STORAGE_PROTOCOL_STRUCTURE_VERSION = 0x1;

        [NativeTypeName("#define STORAGE_PROTOCOL_COMMAND_FLAG_ADAPTER_REQUEST 0x80000000")]
        public const uint STORAGE_PROTOCOL_COMMAND_FLAG_ADAPTER_REQUEST = 0x80000000;

        [NativeTypeName("#define STORAGE_PROTOCOL_STATUS_PENDING 0x0")]
        public const int STORAGE_PROTOCOL_STATUS_PENDING = 0x0;

        [NativeTypeName("#define STORAGE_PROTOCOL_STATUS_SUCCESS 0x1")]
        public const int STORAGE_PROTOCOL_STATUS_SUCCESS = 0x1;

        [NativeTypeName("#define STORAGE_PROTOCOL_STATUS_ERROR 0x2")]
        public const int STORAGE_PROTOCOL_STATUS_ERROR = 0x2;

        [NativeTypeName("#define STORAGE_PROTOCOL_STATUS_INVALID_REQUEST 0x3")]
        public const int STORAGE_PROTOCOL_STATUS_INVALID_REQUEST = 0x3;

        [NativeTypeName("#define STORAGE_PROTOCOL_STATUS_NO_DEVICE 0x4")]
        public const int STORAGE_PROTOCOL_STATUS_NO_DEVICE = 0x4;

        [NativeTypeName("#define STORAGE_PROTOCOL_STATUS_BUSY 0x5")]
        public const int STORAGE_PROTOCOL_STATUS_BUSY = 0x5;

        [NativeTypeName("#define STORAGE_PROTOCOL_STATUS_DATA_OVERRUN 0x6")]
        public const int STORAGE_PROTOCOL_STATUS_DATA_OVERRUN = 0x6;

        [NativeTypeName("#define STORAGE_PROTOCOL_STATUS_INSUFFICIENT_RESOURCES 0x7")]
        public const int STORAGE_PROTOCOL_STATUS_INSUFFICIENT_RESOURCES = 0x7;

        [NativeTypeName("#define STORAGE_PROTOCOL_STATUS_THROTTLED_REQUEST 0x8")]
        public const int STORAGE_PROTOCOL_STATUS_THROTTLED_REQUEST = 0x8;

        [NativeTypeName("#define STORAGE_PROTOCOL_STATUS_NOT_SUPPORTED 0xFF")]
        public const int STORAGE_PROTOCOL_STATUS_NOT_SUPPORTED = 0xFF;

        [NativeTypeName("#define STORAGE_PROTOCOL_COMMAND_LENGTH_NVME 0x40")]
        public const int STORAGE_PROTOCOL_COMMAND_LENGTH_NVME = 0x40;

        [NativeTypeName("#define STORAGE_PROTOCOL_SPECIFIC_NVME_ADMIN_COMMAND 0x01")]
        public const int STORAGE_PROTOCOL_SPECIFIC_NVME_ADMIN_COMMAND = 0x01;

        [NativeTypeName("#define STORAGE_PROTOCOL_SPECIFIC_NVME_NVM_COMMAND 0x02")]
        public const int STORAGE_PROTOCOL_SPECIFIC_NVME_NVM_COMMAND = 0x02;
    }
}
