// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WbemCli.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public enum WBEMSTATUS
    {
        WBEM_NO_ERROR = 0,
        WBEM_S_NO_ERROR = 0,
        WBEM_S_SAME = 0,
        WBEM_S_FALSE = 1,
        WBEM_S_ALREADY_EXISTS = 0x40001,
        WBEM_S_RESET_TO_DEFAULT = 0x40002,
        WBEM_S_DIFFERENT = 0x40003,
        WBEM_S_TIMEDOUT = 0x40004,
        WBEM_S_NO_MORE_DATA = 0x40005,
        WBEM_S_OPERATION_CANCELLED = 0x40006,
        WBEM_S_PENDING = 0x40007,
        WBEM_S_DUPLICATE_OBJECTS = 0x40008,
        WBEM_S_ACCESS_DENIED = 0x40009,
        WBEM_S_PARTIAL_RESULTS = 0x40010,
        WBEM_S_SOURCE_NOT_AVAILABLE = 0x40017,
        WBEM_E_FAILED = unchecked((int)(0x80041001)),
        WBEM_E_NOT_FOUND = unchecked((int)(0x80041002)),
        WBEM_E_ACCESS_DENIED = unchecked((int)(0x80041003)),
        WBEM_E_PROVIDER_FAILURE = unchecked((int)(0x80041004)),
        WBEM_E_TYPE_MISMATCH = unchecked((int)(0x80041005)),
        WBEM_E_OUT_OF_MEMORY = unchecked((int)(0x80041006)),
        WBEM_E_INVALID_CONTEXT = unchecked((int)(0x80041007)),
        WBEM_E_INVALID_PARAMETER = unchecked((int)(0x80041008)),
        WBEM_E_NOT_AVAILABLE = unchecked((int)(0x80041009)),
        WBEM_E_CRITICAL_ERROR = unchecked((int)(0x8004100a)),
        WBEM_E_INVALID_STREAM = unchecked((int)(0x8004100b)),
        WBEM_E_NOT_SUPPORTED = unchecked((int)(0x8004100c)),
        WBEM_E_INVALID_SUPERCLASS = unchecked((int)(0x8004100d)),
        WBEM_E_INVALID_NAMESPACE = unchecked((int)(0x8004100e)),
        WBEM_E_INVALID_OBJECT = unchecked((int)(0x8004100f)),
        WBEM_E_INVALID_CLASS = unchecked((int)(0x80041010)),
        WBEM_E_PROVIDER_NOT_FOUND = unchecked((int)(0x80041011)),
        WBEM_E_INVALID_PROVIDER_REGISTRATION = unchecked((int)(0x80041012)),
        WBEM_E_PROVIDER_LOAD_FAILURE = unchecked((int)(0x80041013)),
        WBEM_E_INITIALIZATION_FAILURE = unchecked((int)(0x80041014)),
        WBEM_E_TRANSPORT_FAILURE = unchecked((int)(0x80041015)),
        WBEM_E_INVALID_OPERATION = unchecked((int)(0x80041016)),
        WBEM_E_INVALID_QUERY = unchecked((int)(0x80041017)),
        WBEM_E_INVALID_QUERY_TYPE = unchecked((int)(0x80041018)),
        WBEM_E_ALREADY_EXISTS = unchecked((int)(0x80041019)),
        WBEM_E_OVERRIDE_NOT_ALLOWED = unchecked((int)(0x8004101a)),
        WBEM_E_PROPAGATED_QUALIFIER = unchecked((int)(0x8004101b)),
        WBEM_E_PROPAGATED_PROPERTY = unchecked((int)(0x8004101c)),
        WBEM_E_UNEXPECTED = unchecked((int)(0x8004101d)),
        WBEM_E_ILLEGAL_OPERATION = unchecked((int)(0x8004101e)),
        WBEM_E_CANNOT_BE_KEY = unchecked((int)(0x8004101f)),
        WBEM_E_INCOMPLETE_CLASS = unchecked((int)(0x80041020)),
        WBEM_E_INVALID_SYNTAX = unchecked((int)(0x80041021)),
        WBEM_E_NONDECORATED_OBJECT = unchecked((int)(0x80041022)),
        WBEM_E_READ_ONLY = unchecked((int)(0x80041023)),
        WBEM_E_PROVIDER_NOT_CAPABLE = unchecked((int)(0x80041024)),
        WBEM_E_CLASS_HAS_CHILDREN = unchecked((int)(0x80041025)),
        WBEM_E_CLASS_HAS_INSTANCES = unchecked((int)(0x80041026)),
        WBEM_E_QUERY_NOT_IMPLEMENTED = unchecked((int)(0x80041027)),
        WBEM_E_ILLEGAL_NULL = unchecked((int)(0x80041028)),
        WBEM_E_INVALID_QUALIFIER_TYPE = unchecked((int)(0x80041029)),
        WBEM_E_INVALID_PROPERTY_TYPE = unchecked((int)(0x8004102a)),
        WBEM_E_VALUE_OUT_OF_RANGE = unchecked((int)(0x8004102b)),
        WBEM_E_CANNOT_BE_SINGLETON = unchecked((int)(0x8004102c)),
        WBEM_E_INVALID_CIM_TYPE = unchecked((int)(0x8004102d)),
        WBEM_E_INVALID_METHOD = unchecked((int)(0x8004102e)),
        WBEM_E_INVALID_METHOD_PARAMETERS = unchecked((int)(0x8004102f)),
        WBEM_E_SYSTEM_PROPERTY = unchecked((int)(0x80041030)),
        WBEM_E_INVALID_PROPERTY = unchecked((int)(0x80041031)),
        WBEM_E_CALL_CANCELLED = unchecked((int)(0x80041032)),
        WBEM_E_SHUTTING_DOWN = unchecked((int)(0x80041033)),
        WBEM_E_PROPAGATED_METHOD = unchecked((int)(0x80041034)),
        WBEM_E_UNSUPPORTED_PARAMETER = unchecked((int)(0x80041035)),
        WBEM_E_MISSING_PARAMETER_ID = unchecked((int)(0x80041036)),
        WBEM_E_INVALID_PARAMETER_ID = unchecked((int)(0x80041037)),
        WBEM_E_NONCONSECUTIVE_PARAMETER_IDS = unchecked((int)(0x80041038)),
        WBEM_E_PARAMETER_ID_ON_RETVAL = unchecked((int)(0x80041039)),
        WBEM_E_INVALID_OBJECT_PATH = unchecked((int)(0x8004103a)),
        WBEM_E_OUT_OF_DISK_SPACE = unchecked((int)(0x8004103b)),
        WBEM_E_BUFFER_TOO_SMALL = unchecked((int)(0x8004103c)),
        WBEM_E_UNSUPPORTED_PUT_EXTENSION = unchecked((int)(0x8004103d)),
        WBEM_E_UNKNOWN_OBJECT_TYPE = unchecked((int)(0x8004103e)),
        WBEM_E_UNKNOWN_PACKET_TYPE = unchecked((int)(0x8004103f)),
        WBEM_E_MARSHAL_VERSION_MISMATCH = unchecked((int)(0x80041040)),
        WBEM_E_MARSHAL_INVALID_SIGNATURE = unchecked((int)(0x80041041)),
        WBEM_E_INVALID_QUALIFIER = unchecked((int)(0x80041042)),
        WBEM_E_INVALID_DUPLICATE_PARAMETER = unchecked((int)(0x80041043)),
        WBEM_E_TOO_MUCH_DATA = unchecked((int)(0x80041044)),
        WBEM_E_SERVER_TOO_BUSY = unchecked((int)(0x80041045)),
        WBEM_E_INVALID_FLAVOR = unchecked((int)(0x80041046)),
        WBEM_E_CIRCULAR_REFERENCE = unchecked((int)(0x80041047)),
        WBEM_E_UNSUPPORTED_CLASS_UPDATE = unchecked((int)(0x80041048)),
        WBEM_E_CANNOT_CHANGE_KEY_INHERITANCE = unchecked((int)(0x80041049)),
        WBEM_E_CANNOT_CHANGE_INDEX_INHERITANCE = unchecked((int)(0x80041050)),
        WBEM_E_TOO_MANY_PROPERTIES = unchecked((int)(0x80041051)),
        WBEM_E_UPDATE_TYPE_MISMATCH = unchecked((int)(0x80041052)),
        WBEM_E_UPDATE_OVERRIDE_NOT_ALLOWED = unchecked((int)(0x80041053)),
        WBEM_E_UPDATE_PROPAGATED_METHOD = unchecked((int)(0x80041054)),
        WBEM_E_METHOD_NOT_IMPLEMENTED = unchecked((int)(0x80041055)),
        WBEM_E_METHOD_DISABLED = unchecked((int)(0x80041056)),
        WBEM_E_REFRESHER_BUSY = unchecked((int)(0x80041057)),
        WBEM_E_UNPARSABLE_QUERY = unchecked((int)(0x80041058)),
        WBEM_E_NOT_EVENT_CLASS = unchecked((int)(0x80041059)),
        WBEM_E_MISSING_GROUP_WITHIN = unchecked((int)(0x8004105a)),
        WBEM_E_MISSING_AGGREGATION_LIST = unchecked((int)(0x8004105b)),
        WBEM_E_PROPERTY_NOT_AN_OBJECT = unchecked((int)(0x8004105c)),
        WBEM_E_AGGREGATING_BY_OBJECT = unchecked((int)(0x8004105d)),
        WBEM_E_UNINTERPRETABLE_PROVIDER_QUERY = unchecked((int)(0x8004105f)),
        WBEM_E_BACKUP_RESTORE_WINMGMT_RUNNING = unchecked((int)(0x80041060)),
        WBEM_E_QUEUE_OVERFLOW = unchecked((int)(0x80041061)),
        WBEM_E_PRIVILEGE_NOT_HELD = unchecked((int)(0x80041062)),
        WBEM_E_INVALID_OPERATOR = unchecked((int)(0x80041063)),
        WBEM_E_LOCAL_CREDENTIALS = unchecked((int)(0x80041064)),
        WBEM_E_CANNOT_BE_ABSTRACT = unchecked((int)(0x80041065)),
        WBEM_E_AMENDED_OBJECT = unchecked((int)(0x80041066)),
        WBEM_E_CLIENT_TOO_SLOW = unchecked((int)(0x80041067)),
        WBEM_E_NULL_SECURITY_DESCRIPTOR = unchecked((int)(0x80041068)),
        WBEM_E_TIMED_OUT = unchecked((int)(0x80041069)),
        WBEM_E_INVALID_ASSOCIATION = unchecked((int)(0x8004106a)),
        WBEM_E_AMBIGUOUS_OPERATION = unchecked((int)(0x8004106b)),
        WBEM_E_QUOTA_VIOLATION = unchecked((int)(0x8004106c)),
        WBEM_E_RESERVED_001 = unchecked((int)(0x8004106d)),
        WBEM_E_RESERVED_002 = unchecked((int)(0x8004106e)),
        WBEM_E_UNSUPPORTED_LOCALE = unchecked((int)(0x8004106f)),
        WBEM_E_HANDLE_OUT_OF_DATE = unchecked((int)(0x80041070)),
        WBEM_E_CONNECTION_FAILED = unchecked((int)(0x80041071)),
        WBEM_E_INVALID_HANDLE_REQUEST = unchecked((int)(0x80041072)),
        WBEM_E_PROPERTY_NAME_TOO_WIDE = unchecked((int)(0x80041073)),
        WBEM_E_CLASS_NAME_TOO_WIDE = unchecked((int)(0x80041074)),
        WBEM_E_METHOD_NAME_TOO_WIDE = unchecked((int)(0x80041075)),
        WBEM_E_QUALIFIER_NAME_TOO_WIDE = unchecked((int)(0x80041076)),
        WBEM_E_RERUN_COMMAND = unchecked((int)(0x80041077)),
        WBEM_E_DATABASE_VER_MISMATCH = unchecked((int)(0x80041078)),
        WBEM_E_VETO_DELETE = unchecked((int)(0x80041079)),
        WBEM_E_VETO_PUT = unchecked((int)(0x8004107a)),
        WBEM_E_INVALID_LOCALE = unchecked((int)(0x80041080)),
        WBEM_E_PROVIDER_SUSPENDED = unchecked((int)(0x80041081)),
        WBEM_E_SYNCHRONIZATION_REQUIRED = unchecked((int)(0x80041082)),
        WBEM_E_NO_SCHEMA = unchecked((int)(0x80041083)),
        WBEM_E_PROVIDER_ALREADY_REGISTERED = unchecked((int)(0x80041084)),
        WBEM_E_PROVIDER_NOT_REGISTERED = unchecked((int)(0x80041085)),
        WBEM_E_FATAL_TRANSPORT_ERROR = unchecked((int)(0x80041086)),
        WBEM_E_ENCRYPTED_CONNECTION_REQUIRED = unchecked((int)(0x80041087)),
        WBEM_E_PROVIDER_TIMED_OUT = unchecked((int)(0x80041088)),
        WBEM_E_NO_KEY = unchecked((int)(0x80041089)),
        WBEM_E_PROVIDER_DISABLED = unchecked((int)(0x8004108a)),
        WBEMESS_E_REGISTRATION_TOO_BROAD = unchecked((int)(0x80042001)),
        WBEMESS_E_REGISTRATION_TOO_PRECISE = unchecked((int)(0x80042002)),
        WBEMESS_E_AUTHZ_NOT_PRIVILEGED = unchecked((int)(0x80042003)),
        WBEMMOF_E_EXPECTED_QUALIFIER_NAME = unchecked((int)(0x80044001)),
        WBEMMOF_E_EXPECTED_SEMI = unchecked((int)(0x80044002)),
        WBEMMOF_E_EXPECTED_OPEN_BRACE = unchecked((int)(0x80044003)),
        WBEMMOF_E_EXPECTED_CLOSE_BRACE = unchecked((int)(0x80044004)),
        WBEMMOF_E_EXPECTED_CLOSE_BRACKET = unchecked((int)(0x80044005)),
        WBEMMOF_E_EXPECTED_CLOSE_PAREN = unchecked((int)(0x80044006)),
        WBEMMOF_E_ILLEGAL_CONSTANT_VALUE = unchecked((int)(0x80044007)),
        WBEMMOF_E_EXPECTED_TYPE_IDENTIFIER = unchecked((int)(0x80044008)),
        WBEMMOF_E_EXPECTED_OPEN_PAREN = unchecked((int)(0x80044009)),
        WBEMMOF_E_UNRECOGNIZED_TOKEN = unchecked((int)(0x8004400a)),
        WBEMMOF_E_UNRECOGNIZED_TYPE = unchecked((int)(0x8004400b)),
        WBEMMOF_E_EXPECTED_PROPERTY_NAME = unchecked((int)(0x8004400c)),
        WBEMMOF_E_TYPEDEF_NOT_SUPPORTED = unchecked((int)(0x8004400d)),
        WBEMMOF_E_UNEXPECTED_ALIAS = unchecked((int)(0x8004400e)),
        WBEMMOF_E_UNEXPECTED_ARRAY_INIT = unchecked((int)(0x8004400f)),
        WBEMMOF_E_INVALID_AMENDMENT_SYNTAX = unchecked((int)(0x80044010)),
        WBEMMOF_E_INVALID_DUPLICATE_AMENDMENT = unchecked((int)(0x80044011)),
        WBEMMOF_E_INVALID_PRAGMA = unchecked((int)(0x80044012)),
        WBEMMOF_E_INVALID_NAMESPACE_SYNTAX = unchecked((int)(0x80044013)),
        WBEMMOF_E_EXPECTED_CLASS_NAME = unchecked((int)(0x80044014)),
        WBEMMOF_E_TYPE_MISMATCH = unchecked((int)(0x80044015)),
        WBEMMOF_E_EXPECTED_ALIAS_NAME = unchecked((int)(0x80044016)),
        WBEMMOF_E_INVALID_CLASS_DECLARATION = unchecked((int)(0x80044017)),
        WBEMMOF_E_INVALID_INSTANCE_DECLARATION = unchecked((int)(0x80044018)),
        WBEMMOF_E_EXPECTED_DOLLAR = unchecked((int)(0x80044019)),
        WBEMMOF_E_CIMTYPE_QUALIFIER = unchecked((int)(0x8004401a)),
        WBEMMOF_E_DUPLICATE_PROPERTY = unchecked((int)(0x8004401b)),
        WBEMMOF_E_INVALID_NAMESPACE_SPECIFICATION = unchecked((int)(0x8004401c)),
        WBEMMOF_E_OUT_OF_RANGE = unchecked((int)(0x8004401d)),
        WBEMMOF_E_INVALID_FILE = unchecked((int)(0x8004401e)),
        WBEMMOF_E_ALIASES_IN_EMBEDDED = unchecked((int)(0x8004401f)),
        WBEMMOF_E_NULL_ARRAY_ELEM = unchecked((int)(0x80044020)),
        WBEMMOF_E_DUPLICATE_QUALIFIER = unchecked((int)(0x80044021)),
        WBEMMOF_E_EXPECTED_FLAVOR_TYPE = unchecked((int)(0x80044022)),
        WBEMMOF_E_INCOMPATIBLE_FLAVOR_TYPES = unchecked((int)(0x80044023)),
        WBEMMOF_E_MULTIPLE_ALIASES = unchecked((int)(0x80044024)),
        WBEMMOF_E_INCOMPATIBLE_FLAVOR_TYPES2 = unchecked((int)(0x80044025)),
        WBEMMOF_E_NO_ARRAYS_RETURNED = unchecked((int)(0x80044026)),
        WBEMMOF_E_MUST_BE_IN_OR_OUT = unchecked((int)(0x80044027)),
        WBEMMOF_E_INVALID_FLAGS_SYNTAX = unchecked((int)(0x80044028)),
        WBEMMOF_E_EXPECTED_BRACE_OR_BAD_TYPE = unchecked((int)(0x80044029)),
        WBEMMOF_E_UNSUPPORTED_CIMV22_QUAL_VALUE = unchecked((int)(0x8004402a)),
        WBEMMOF_E_UNSUPPORTED_CIMV22_DATA_TYPE = unchecked((int)(0x8004402b)),
        WBEMMOF_E_INVALID_DELETEINSTANCE_SYNTAX = unchecked((int)(0x8004402c)),
        WBEMMOF_E_INVALID_QUALIFIER_SYNTAX = unchecked((int)(0x8004402d)),
        WBEMMOF_E_QUALIFIER_USED_OUTSIDE_SCOPE = unchecked((int)(0x8004402e)),
        WBEMMOF_E_ERROR_CREATING_TEMP_FILE = unchecked((int)(0x8004402f)),
        WBEMMOF_E_ERROR_INVALID_INCLUDE_FILE = unchecked((int)(0x80044030)),
        WBEMMOF_E_INVALID_DELETECLASS_SYNTAX = unchecked((int)(0x80044031)),
    }
}