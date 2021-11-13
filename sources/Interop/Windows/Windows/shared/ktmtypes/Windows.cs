// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ktmtypes.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public static partial class Windows
    {
        [NativeTypeName("#define TRANSACTION_MANAGER_VOLATILE 0x00000001")]
        public const int TRANSACTION_MANAGER_VOLATILE = 0x00000001;

        [NativeTypeName("#define TRANSACTION_MANAGER_COMMIT_DEFAULT 0x00000000")]
        public const int TRANSACTION_MANAGER_COMMIT_DEFAULT = 0x00000000;

        [NativeTypeName("#define TRANSACTION_MANAGER_COMMIT_SYSTEM_VOLUME 0x00000002")]
        public const int TRANSACTION_MANAGER_COMMIT_SYSTEM_VOLUME = 0x00000002;

        [NativeTypeName("#define TRANSACTION_MANAGER_COMMIT_SYSTEM_HIVES 0x00000004")]
        public const int TRANSACTION_MANAGER_COMMIT_SYSTEM_HIVES = 0x00000004;

        [NativeTypeName("#define TRANSACTION_MANAGER_COMMIT_LOWEST 0x00000008")]
        public const int TRANSACTION_MANAGER_COMMIT_LOWEST = 0x00000008;

        [NativeTypeName("#define TRANSACTION_MANAGER_CORRUPT_FOR_RECOVERY 0x00000010")]
        public const int TRANSACTION_MANAGER_CORRUPT_FOR_RECOVERY = 0x00000010;

        [NativeTypeName("#define TRANSACTION_MANAGER_CORRUPT_FOR_PROGRESS 0x00000020")]
        public const int TRANSACTION_MANAGER_CORRUPT_FOR_PROGRESS = 0x00000020;

        [NativeTypeName("#define TRANSACTION_MANAGER_MAXIMUM_OPTION 0x0000003F")]
        public const int TRANSACTION_MANAGER_MAXIMUM_OPTION = 0x0000003F;

        [NativeTypeName("#define TRANSACTION_DO_NOT_PROMOTE 0x00000001")]
        public const int TRANSACTION_DO_NOT_PROMOTE = 0x00000001;

        [NativeTypeName("#define TRANSACTION_MAXIMUM_OPTION 0x00000001")]
        public const int TRANSACTION_MAXIMUM_OPTION = 0x00000001;

        [NativeTypeName("#define RESOURCE_MANAGER_VOLATILE 0x00000001")]
        public const int RESOURCE_MANAGER_VOLATILE = 0x00000001;

        [NativeTypeName("#define RESOURCE_MANAGER_COMMUNICATION 0x00000002")]
        public const int RESOURCE_MANAGER_COMMUNICATION = 0x00000002;

        [NativeTypeName("#define RESOURCE_MANAGER_MAXIMUM_OPTION 0x00000003")]
        public const int RESOURCE_MANAGER_MAXIMUM_OPTION = 0x00000003;

        [NativeTypeName("#define CRM_PROTOCOL_EXPLICIT_MARSHAL_ONLY 0x00000001")]
        public const int CRM_PROTOCOL_EXPLICIT_MARSHAL_ONLY = 0x00000001;

        [NativeTypeName("#define CRM_PROTOCOL_DYNAMIC_MARSHAL_INFO 0x00000002")]
        public const int CRM_PROTOCOL_DYNAMIC_MARSHAL_INFO = 0x00000002;

        [NativeTypeName("#define CRM_PROTOCOL_MAXIMUM_OPTION 0x00000003")]
        public const int CRM_PROTOCOL_MAXIMUM_OPTION = 0x00000003;

        [NativeTypeName("#define ENLISTMENT_SUPERIOR 0x00000001")]
        public const int ENLISTMENT_SUPERIOR = 0x00000001;

        [NativeTypeName("#define ENLISTMENT_MAXIMUM_OPTION 0x00000001")]
        public const int ENLISTMENT_MAXIMUM_OPTION = 0x00000001;

        [NativeTypeName("#define TRANSACTION_NOTIFY_MASK 0x3FFFFFFF")]
        public const int TRANSACTION_NOTIFY_MASK = 0x3FFFFFFF;

        [NativeTypeName("#define TRANSACTION_NOTIFY_PREPREPARE 0x00000001")]
        public const int TRANSACTION_NOTIFY_PREPREPARE = 0x00000001;

        [NativeTypeName("#define TRANSACTION_NOTIFY_PREPARE 0x00000002")]
        public const int TRANSACTION_NOTIFY_PREPARE = 0x00000002;

        [NativeTypeName("#define TRANSACTION_NOTIFY_COMMIT 0x00000004")]
        public const int TRANSACTION_NOTIFY_COMMIT = 0x00000004;

        [NativeTypeName("#define TRANSACTION_NOTIFY_ROLLBACK 0x00000008")]
        public const int TRANSACTION_NOTIFY_ROLLBACK = 0x00000008;

        [NativeTypeName("#define TRANSACTION_NOTIFY_PREPREPARE_COMPLETE 0x00000010")]
        public const int TRANSACTION_NOTIFY_PREPREPARE_COMPLETE = 0x00000010;

        [NativeTypeName("#define TRANSACTION_NOTIFY_PREPARE_COMPLETE 0x00000020")]
        public const int TRANSACTION_NOTIFY_PREPARE_COMPLETE = 0x00000020;

        [NativeTypeName("#define TRANSACTION_NOTIFY_COMMIT_COMPLETE 0x00000040")]
        public const int TRANSACTION_NOTIFY_COMMIT_COMPLETE = 0x00000040;

        [NativeTypeName("#define TRANSACTION_NOTIFY_ROLLBACK_COMPLETE 0x00000080")]
        public const int TRANSACTION_NOTIFY_ROLLBACK_COMPLETE = 0x00000080;

        [NativeTypeName("#define TRANSACTION_NOTIFY_RECOVER 0x00000100")]
        public const int TRANSACTION_NOTIFY_RECOVER = 0x00000100;

        [NativeTypeName("#define TRANSACTION_NOTIFY_SINGLE_PHASE_COMMIT 0x00000200")]
        public const int TRANSACTION_NOTIFY_SINGLE_PHASE_COMMIT = 0x00000200;

        [NativeTypeName("#define TRANSACTION_NOTIFY_DELEGATE_COMMIT 0x00000400")]
        public const int TRANSACTION_NOTIFY_DELEGATE_COMMIT = 0x00000400;

        [NativeTypeName("#define TRANSACTION_NOTIFY_RECOVER_QUERY 0x00000800")]
        public const int TRANSACTION_NOTIFY_RECOVER_QUERY = 0x00000800;

        [NativeTypeName("#define TRANSACTION_NOTIFY_ENLIST_PREPREPARE 0x00001000")]
        public const int TRANSACTION_NOTIFY_ENLIST_PREPREPARE = 0x00001000;

        [NativeTypeName("#define TRANSACTION_NOTIFY_LAST_RECOVER 0x00002000")]
        public const int TRANSACTION_NOTIFY_LAST_RECOVER = 0x00002000;

        [NativeTypeName("#define TRANSACTION_NOTIFY_INDOUBT 0x00004000")]
        public const int TRANSACTION_NOTIFY_INDOUBT = 0x00004000;

        [NativeTypeName("#define TRANSACTION_NOTIFY_PROPAGATE_PULL 0x00008000")]
        public const int TRANSACTION_NOTIFY_PROPAGATE_PULL = 0x00008000;

        [NativeTypeName("#define TRANSACTION_NOTIFY_PROPAGATE_PUSH 0x00010000")]
        public const int TRANSACTION_NOTIFY_PROPAGATE_PUSH = 0x00010000;

        [NativeTypeName("#define TRANSACTION_NOTIFY_MARSHAL 0x00020000")]
        public const int TRANSACTION_NOTIFY_MARSHAL = 0x00020000;

        [NativeTypeName("#define TRANSACTION_NOTIFY_ENLIST_MASK 0x00040000")]
        public const int TRANSACTION_NOTIFY_ENLIST_MASK = 0x00040000;

        [NativeTypeName("#define TRANSACTION_NOTIFY_RM_DISCONNECTED 0x01000000")]
        public const int TRANSACTION_NOTIFY_RM_DISCONNECTED = 0x01000000;

        [NativeTypeName("#define TRANSACTION_NOTIFY_TM_ONLINE 0x02000000")]
        public const int TRANSACTION_NOTIFY_TM_ONLINE = 0x02000000;

        [NativeTypeName("#define TRANSACTION_NOTIFY_COMMIT_REQUEST 0x04000000")]
        public const int TRANSACTION_NOTIFY_COMMIT_REQUEST = 0x04000000;

        [NativeTypeName("#define TRANSACTION_NOTIFY_PROMOTE 0x08000000")]
        public const int TRANSACTION_NOTIFY_PROMOTE = 0x08000000;

        [NativeTypeName("#define TRANSACTION_NOTIFY_PROMOTE_NEW 0x10000000")]
        public const int TRANSACTION_NOTIFY_PROMOTE_NEW = 0x10000000;

        [NativeTypeName("#define TRANSACTION_NOTIFY_REQUEST_OUTCOME 0x20000000")]
        public const int TRANSACTION_NOTIFY_REQUEST_OUTCOME = 0x20000000;

        [NativeTypeName("#define TRANSACTION_NOTIFY_COMMIT_FINALIZE 0x40000000")]
        public const int TRANSACTION_NOTIFY_COMMIT_FINALIZE = 0x40000000;

        [NativeTypeName("#define TRANSACTIONMANAGER_OBJECT_PATH L\"\\\\TransactionManager\\\\\"")]
        public const string TRANSACTIONMANAGER_OBJECT_PATH = "\\TransactionManager\\";

        [NativeTypeName("#define TRANSACTION_OBJECT_PATH L\"\\\\Transaction\\\\\"")]
        public const string TRANSACTION_OBJECT_PATH = "\\Transaction\\";

        [NativeTypeName("#define ENLISTMENT_OBJECT_PATH L\"\\\\Enlistment\\\\\"")]
        public const string ENLISTMENT_OBJECT_PATH = "\\Enlistment\\";

        [NativeTypeName("#define RESOURCE_MANAGER_OBJECT_PATH L\"\\\\ResourceManager\\\\\"")]
        public const string RESOURCE_MANAGER_OBJECT_PATH = "\\ResourceManager\\";

        [NativeTypeName("#define TRANSACTIONMANAGER_OBJECT_NAME_LENGTH_IN_BYTES (sizeof(TRANSACTIONMANAGER_OBJECT_PATH)+(38*sizeof(WCHAR)))")]
        public const uint TRANSACTIONMANAGER_OBJECT_NAME_LENGTH_IN_BYTES = (42 + (38 * 2));

        [NativeTypeName("#define TRANSACTION_OBJECT_NAME_LENGTH_IN_BYTES (sizeof(TRANSACTION_OBJECT_PATH)+(38*sizeof(WCHAR)))")]
        public const uint TRANSACTION_OBJECT_NAME_LENGTH_IN_BYTES = (28 + (38 * 2));

        [NativeTypeName("#define ENLISTMENT_OBJECT_NAME_LENGTH_IN_BYTES (sizeof(ENLISTMENT_OBJECT_PATH)+(38*sizeof(WCHAR)))")]
        public const uint ENLISTMENT_OBJECT_NAME_LENGTH_IN_BYTES = (26 + (38 * 2));

        [NativeTypeName("#define RESOURCE_MANAGER_OBJECT_NAME_LENGTH_IN_BYTES (sizeof(RESOURCE_MANAGER_OBJECT_PATH)+(38*sizeof(WCHAR)))")]
        public const uint RESOURCE_MANAGER_OBJECT_NAME_LENGTH_IN_BYTES = (36 + (38 * 2));

        [NativeTypeName("#define TRANSACTION_NOTIFICATION_TM_ONLINE_FLAG_IS_CLUSTERED 0x1")]
        public const int TRANSACTION_NOTIFICATION_TM_ONLINE_FLAG_IS_CLUSTERED = 0x1;

        [NativeTypeName("#define KTM_MARSHAL_BLOB_VERSION_MAJOR 1")]
        public const int KTM_MARSHAL_BLOB_VERSION_MAJOR = 1;

        [NativeTypeName("#define KTM_MARSHAL_BLOB_VERSION_MINOR 1")]
        public const int KTM_MARSHAL_BLOB_VERSION_MINOR = 1;

        [NativeTypeName("#define MAX_TRANSACTION_DESCRIPTION_LENGTH 64")]
        public const int MAX_TRANSACTION_DESCRIPTION_LENGTH = 64;

        [NativeTypeName("#define MAX_RESOURCEMANAGER_DESCRIPTION_LENGTH 64")]
        public const int MAX_RESOURCEMANAGER_DESCRIPTION_LENGTH = 64;
    }
}