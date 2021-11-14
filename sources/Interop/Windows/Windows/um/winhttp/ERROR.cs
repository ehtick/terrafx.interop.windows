// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public static partial class ERROR
    {
        [NativeTypeName("#define ERROR_WINHTTP_OUT_OF_HANDLES (WINHTTP_ERROR_BASE + 1)")]
        public const int ERROR_WINHTTP_OUT_OF_HANDLES = (12000 + 1);

        [NativeTypeName("#define ERROR_WINHTTP_TIMEOUT (WINHTTP_ERROR_BASE + 2)")]
        public const int ERROR_WINHTTP_TIMEOUT = (12000 + 2);

        [NativeTypeName("#define ERROR_WINHTTP_INTERNAL_ERROR (WINHTTP_ERROR_BASE + 4)")]
        public const int ERROR_WINHTTP_INTERNAL_ERROR = (12000 + 4);

        [NativeTypeName("#define ERROR_WINHTTP_INVALID_URL (WINHTTP_ERROR_BASE + 5)")]
        public const int ERROR_WINHTTP_INVALID_URL = (12000 + 5);

        [NativeTypeName("#define ERROR_WINHTTP_UNRECOGNIZED_SCHEME (WINHTTP_ERROR_BASE + 6)")]
        public const int ERROR_WINHTTP_UNRECOGNIZED_SCHEME = (12000 + 6);

        [NativeTypeName("#define ERROR_WINHTTP_NAME_NOT_RESOLVED (WINHTTP_ERROR_BASE + 7)")]
        public const int ERROR_WINHTTP_NAME_NOT_RESOLVED = (12000 + 7);

        [NativeTypeName("#define ERROR_WINHTTP_INVALID_OPTION (WINHTTP_ERROR_BASE + 9)")]
        public const int ERROR_WINHTTP_INVALID_OPTION = (12000 + 9);

        [NativeTypeName("#define ERROR_WINHTTP_OPTION_NOT_SETTABLE (WINHTTP_ERROR_BASE + 11)")]
        public const int ERROR_WINHTTP_OPTION_NOT_SETTABLE = (12000 + 11);

        [NativeTypeName("#define ERROR_WINHTTP_SHUTDOWN (WINHTTP_ERROR_BASE + 12)")]
        public const int ERROR_WINHTTP_SHUTDOWN = (12000 + 12);

        [NativeTypeName("#define ERROR_WINHTTP_LOGIN_FAILURE (WINHTTP_ERROR_BASE + 15)")]
        public const int ERROR_WINHTTP_LOGIN_FAILURE = (12000 + 15);

        [NativeTypeName("#define ERROR_WINHTTP_OPERATION_CANCELLED (WINHTTP_ERROR_BASE + 17)")]
        public const int ERROR_WINHTTP_OPERATION_CANCELLED = (12000 + 17);

        [NativeTypeName("#define ERROR_WINHTTP_INCORRECT_HANDLE_TYPE (WINHTTP_ERROR_BASE + 18)")]
        public const int ERROR_WINHTTP_INCORRECT_HANDLE_TYPE = (12000 + 18);

        [NativeTypeName("#define ERROR_WINHTTP_INCORRECT_HANDLE_STATE (WINHTTP_ERROR_BASE + 19)")]
        public const int ERROR_WINHTTP_INCORRECT_HANDLE_STATE = (12000 + 19);

        [NativeTypeName("#define ERROR_WINHTTP_CANNOT_CONNECT (WINHTTP_ERROR_BASE + 29)")]
        public const int ERROR_WINHTTP_CANNOT_CONNECT = (12000 + 29);

        [NativeTypeName("#define ERROR_WINHTTP_CONNECTION_ERROR (WINHTTP_ERROR_BASE + 30)")]
        public const int ERROR_WINHTTP_CONNECTION_ERROR = (12000 + 30);

        [NativeTypeName("#define ERROR_WINHTTP_RESEND_REQUEST (WINHTTP_ERROR_BASE + 32)")]
        public const int ERROR_WINHTTP_RESEND_REQUEST = (12000 + 32);

        [NativeTypeName("#define ERROR_WINHTTP_CLIENT_AUTH_CERT_NEEDED (WINHTTP_ERROR_BASE + 44)")]
        public const int ERROR_WINHTTP_CLIENT_AUTH_CERT_NEEDED = (12000 + 44);

        [NativeTypeName("#define ERROR_WINHTTP_CANNOT_CALL_BEFORE_OPEN (WINHTTP_ERROR_BASE + 100)")]
        public const int ERROR_WINHTTP_CANNOT_CALL_BEFORE_OPEN = (12000 + 100);

        [NativeTypeName("#define ERROR_WINHTTP_CANNOT_CALL_BEFORE_SEND (WINHTTP_ERROR_BASE + 101)")]
        public const int ERROR_WINHTTP_CANNOT_CALL_BEFORE_SEND = (12000 + 101);

        [NativeTypeName("#define ERROR_WINHTTP_CANNOT_CALL_AFTER_SEND (WINHTTP_ERROR_BASE + 102)")]
        public const int ERROR_WINHTTP_CANNOT_CALL_AFTER_SEND = (12000 + 102);

        [NativeTypeName("#define ERROR_WINHTTP_CANNOT_CALL_AFTER_OPEN (WINHTTP_ERROR_BASE + 103)")]
        public const int ERROR_WINHTTP_CANNOT_CALL_AFTER_OPEN = (12000 + 103);

        [NativeTypeName("#define ERROR_WINHTTP_HEADER_NOT_FOUND (WINHTTP_ERROR_BASE + 150)")]
        public const int ERROR_WINHTTP_HEADER_NOT_FOUND = (12000 + 150);

        [NativeTypeName("#define ERROR_WINHTTP_INVALID_SERVER_RESPONSE (WINHTTP_ERROR_BASE + 152)")]
        public const int ERROR_WINHTTP_INVALID_SERVER_RESPONSE = (12000 + 152);

        [NativeTypeName("#define ERROR_WINHTTP_INVALID_HEADER (WINHTTP_ERROR_BASE + 153)")]
        public const int ERROR_WINHTTP_INVALID_HEADER = (12000 + 153);

        [NativeTypeName("#define ERROR_WINHTTP_INVALID_QUERY_REQUEST (WINHTTP_ERROR_BASE + 154)")]
        public const int ERROR_WINHTTP_INVALID_QUERY_REQUEST = (12000 + 154);

        [NativeTypeName("#define ERROR_WINHTTP_HEADER_ALREADY_EXISTS (WINHTTP_ERROR_BASE + 155)")]
        public const int ERROR_WINHTTP_HEADER_ALREADY_EXISTS = (12000 + 155);

        [NativeTypeName("#define ERROR_WINHTTP_REDIRECT_FAILED (WINHTTP_ERROR_BASE + 156)")]
        public const int ERROR_WINHTTP_REDIRECT_FAILED = (12000 + 156);

        [NativeTypeName("#define ERROR_WINHTTP_AUTO_PROXY_SERVICE_ERROR (WINHTTP_ERROR_BASE + 178)")]
        public const int ERROR_WINHTTP_AUTO_PROXY_SERVICE_ERROR = (12000 + 178);

        [NativeTypeName("#define ERROR_WINHTTP_BAD_AUTO_PROXY_SCRIPT (WINHTTP_ERROR_BASE + 166)")]
        public const int ERROR_WINHTTP_BAD_AUTO_PROXY_SCRIPT = (12000 + 166);

        [NativeTypeName("#define ERROR_WINHTTP_UNABLE_TO_DOWNLOAD_SCRIPT (WINHTTP_ERROR_BASE + 167)")]
        public const int ERROR_WINHTTP_UNABLE_TO_DOWNLOAD_SCRIPT = (12000 + 167);

        [NativeTypeName("#define ERROR_WINHTTP_UNHANDLED_SCRIPT_TYPE (WINHTTP_ERROR_BASE + 176)")]
        public const int ERROR_WINHTTP_UNHANDLED_SCRIPT_TYPE = (12000 + 176);

        [NativeTypeName("#define ERROR_WINHTTP_SCRIPT_EXECUTION_ERROR (WINHTTP_ERROR_BASE + 177)")]
        public const int ERROR_WINHTTP_SCRIPT_EXECUTION_ERROR = (12000 + 177);

        [NativeTypeName("#define ERROR_WINHTTP_NOT_INITIALIZED (WINHTTP_ERROR_BASE + 172)")]
        public const int ERROR_WINHTTP_NOT_INITIALIZED = (12000 + 172);

        [NativeTypeName("#define ERROR_WINHTTP_SECURE_FAILURE (WINHTTP_ERROR_BASE + 175)")]
        public const int ERROR_WINHTTP_SECURE_FAILURE = (12000 + 175);

        [NativeTypeName("#define ERROR_WINHTTP_SECURE_CERT_DATE_INVALID (WINHTTP_ERROR_BASE + 37)")]
        public const int ERROR_WINHTTP_SECURE_CERT_DATE_INVALID = (12000 + 37);

        [NativeTypeName("#define ERROR_WINHTTP_SECURE_CERT_CN_INVALID (WINHTTP_ERROR_BASE + 38)")]
        public const int ERROR_WINHTTP_SECURE_CERT_CN_INVALID = (12000 + 38);

        [NativeTypeName("#define ERROR_WINHTTP_SECURE_INVALID_CA (WINHTTP_ERROR_BASE + 45)")]
        public const int ERROR_WINHTTP_SECURE_INVALID_CA = (12000 + 45);

        [NativeTypeName("#define ERROR_WINHTTP_SECURE_CERT_REV_FAILED (WINHTTP_ERROR_BASE + 57)")]
        public const int ERROR_WINHTTP_SECURE_CERT_REV_FAILED = (12000 + 57);

        [NativeTypeName("#define ERROR_WINHTTP_SECURE_CHANNEL_ERROR (WINHTTP_ERROR_BASE + 157)")]
        public const int ERROR_WINHTTP_SECURE_CHANNEL_ERROR = (12000 + 157);

        [NativeTypeName("#define ERROR_WINHTTP_SECURE_INVALID_CERT (WINHTTP_ERROR_BASE + 169)")]
        public const int ERROR_WINHTTP_SECURE_INVALID_CERT = (12000 + 169);

        [NativeTypeName("#define ERROR_WINHTTP_SECURE_CERT_REVOKED (WINHTTP_ERROR_BASE + 170)")]
        public const int ERROR_WINHTTP_SECURE_CERT_REVOKED = (12000 + 170);

        [NativeTypeName("#define ERROR_WINHTTP_SECURE_CERT_WRONG_USAGE (WINHTTP_ERROR_BASE + 179)")]
        public const int ERROR_WINHTTP_SECURE_CERT_WRONG_USAGE = (12000 + 179);

        [NativeTypeName("#define ERROR_WINHTTP_AUTODETECTION_FAILED (WINHTTP_ERROR_BASE + 180)")]
        public const int ERROR_WINHTTP_AUTODETECTION_FAILED = (12000 + 180);

        [NativeTypeName("#define ERROR_WINHTTP_HEADER_COUNT_EXCEEDED (WINHTTP_ERROR_BASE + 181)")]
        public const int ERROR_WINHTTP_HEADER_COUNT_EXCEEDED = (12000 + 181);

        [NativeTypeName("#define ERROR_WINHTTP_HEADER_SIZE_OVERFLOW (WINHTTP_ERROR_BASE + 182)")]
        public const int ERROR_WINHTTP_HEADER_SIZE_OVERFLOW = (12000 + 182);

        [NativeTypeName("#define ERROR_WINHTTP_CHUNKED_ENCODING_HEADER_SIZE_OVERFLOW (WINHTTP_ERROR_BASE + 183)")]
        public const int ERROR_WINHTTP_CHUNKED_ENCODING_HEADER_SIZE_OVERFLOW = (12000 + 183);

        [NativeTypeName("#define ERROR_WINHTTP_RESPONSE_DRAIN_OVERFLOW (WINHTTP_ERROR_BASE + 184)")]
        public const int ERROR_WINHTTP_RESPONSE_DRAIN_OVERFLOW = (12000 + 184);

        [NativeTypeName("#define ERROR_WINHTTP_CLIENT_CERT_NO_PRIVATE_KEY (WINHTTP_ERROR_BASE + 185)")]
        public const int ERROR_WINHTTP_CLIENT_CERT_NO_PRIVATE_KEY = (12000 + 185);

        [NativeTypeName("#define ERROR_WINHTTP_CLIENT_CERT_NO_ACCESS_PRIVATE_KEY (WINHTTP_ERROR_BASE + 186)")]
        public const int ERROR_WINHTTP_CLIENT_CERT_NO_ACCESS_PRIVATE_KEY = (12000 + 186);

        [NativeTypeName("#define ERROR_WINHTTP_CLIENT_AUTH_CERT_NEEDED_PROXY (WINHTTP_ERROR_BASE + 187)")]
        public const int ERROR_WINHTTP_CLIENT_AUTH_CERT_NEEDED_PROXY = (12000 + 187);

        [NativeTypeName("#define ERROR_WINHTTP_SECURE_FAILURE_PROXY (WINHTTP_ERROR_BASE + 188)")]
        public const int ERROR_WINHTTP_SECURE_FAILURE_PROXY = (12000 + 188);

        [NativeTypeName("#define ERROR_WINHTTP_RESERVED_189 (WINHTTP_ERROR_BASE + 189)")]
        public const int ERROR_WINHTTP_RESERVED_189 = (12000 + 189);

        [NativeTypeName("#define ERROR_WINHTTP_HTTP_PROTOCOL_MISMATCH (WINHTTP_ERROR_BASE + 190)")]
        public const int ERROR_WINHTTP_HTTP_PROTOCOL_MISMATCH = (12000 + 190);

        [NativeTypeName("#define ERROR_WINHTTP_GLOBAL_CALLBACK_FAILED (WINHTTP_ERROR_BASE + 191)")]
        public const int ERROR_WINHTTP_GLOBAL_CALLBACK_FAILED = (12000 + 191);

        [NativeTypeName("#define ERROR_WINHTTP_FEATURE_DISABLED (WINHTTP_ERROR_BASE + 192)")]
        public const int ERROR_WINHTTP_FEATURE_DISABLED = (12000 + 192);
    }
}
