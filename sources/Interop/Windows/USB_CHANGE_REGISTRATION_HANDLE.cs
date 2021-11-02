// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct USB_CHANGE_REGISTRATION_HANDLE : IEquatable<USB_CHANGE_REGISTRATION_HANDLE>
    {
        public readonly nint Value;

        public USB_CHANGE_REGISTRATION_HANDLE(nint value)
        {
            Value = value;
        }

        public static USB_CHANGE_REGISTRATION_HANDLE INVALID_HANDLE_VALUE => new USB_CHANGE_REGISTRATION_HANDLE(-1);

        public static USB_CHANGE_REGISTRATION_HANDLE NULL => new USB_CHANGE_REGISTRATION_HANDLE(0);

        public static bool operator ==(USB_CHANGE_REGISTRATION_HANDLE left, USB_CHANGE_REGISTRATION_HANDLE right) => left.Value == right.Value;

        public static bool operator !=(USB_CHANGE_REGISTRATION_HANDLE left, USB_CHANGE_REGISTRATION_HANDLE right) => left.Value != right.Value;

        public static explicit operator USB_CHANGE_REGISTRATION_HANDLE(void* value) => new USB_CHANGE_REGISTRATION_HANDLE((nint)(value));

        public static implicit operator void*(USB_CHANGE_REGISTRATION_HANDLE value) => (void*)(value.Value);

        public static explicit operator USB_CHANGE_REGISTRATION_HANDLE(HANDLE value) => new USB_CHANGE_REGISTRATION_HANDLE(value);

        public static implicit operator HANDLE(USB_CHANGE_REGISTRATION_HANDLE value) => new USB_CHANGE_REGISTRATION_HANDLE(value);

        public static explicit operator USB_CHANGE_REGISTRATION_HANDLE(byte value) => new USB_CHANGE_REGISTRATION_HANDLE((nint)(value));

        public static implicit operator byte(USB_CHANGE_REGISTRATION_HANDLE value) => (byte)(value.Value);

        public static explicit operator USB_CHANGE_REGISTRATION_HANDLE(short value) => new USB_CHANGE_REGISTRATION_HANDLE((nint)(value));

        public static implicit operator short(USB_CHANGE_REGISTRATION_HANDLE value) => (short)(value.Value);

        public static explicit operator USB_CHANGE_REGISTRATION_HANDLE(int value) => new USB_CHANGE_REGISTRATION_HANDLE((nint)(value));

        public static implicit operator int(USB_CHANGE_REGISTRATION_HANDLE value) => (int)(value.Value);

        public static explicit operator USB_CHANGE_REGISTRATION_HANDLE(long value) => new USB_CHANGE_REGISTRATION_HANDLE((nint)(value));

        public static explicit operator long(USB_CHANGE_REGISTRATION_HANDLE value) => (long)(value.Value);

        public static explicit operator USB_CHANGE_REGISTRATION_HANDLE(nint value) => new USB_CHANGE_REGISTRATION_HANDLE((nint)(value));

        public static implicit operator nint(USB_CHANGE_REGISTRATION_HANDLE value) => (nint)(value.Value);

        public static explicit operator USB_CHANGE_REGISTRATION_HANDLE(sbyte value) => new USB_CHANGE_REGISTRATION_HANDLE((nint)(value));

        public static implicit operator sbyte(USB_CHANGE_REGISTRATION_HANDLE value) => (sbyte)(value.Value);

        public static explicit operator USB_CHANGE_REGISTRATION_HANDLE(ushort value) => new USB_CHANGE_REGISTRATION_HANDLE((nint)(value));

        public static implicit operator ushort(USB_CHANGE_REGISTRATION_HANDLE value) => (ushort)(value.Value);

        public static explicit operator USB_CHANGE_REGISTRATION_HANDLE(uint value) => new USB_CHANGE_REGISTRATION_HANDLE((nint)(value));

        public static implicit operator uint(USB_CHANGE_REGISTRATION_HANDLE value) => (uint)(value.Value);

        public static explicit operator USB_CHANGE_REGISTRATION_HANDLE(ulong value) => new USB_CHANGE_REGISTRATION_HANDLE((nint)(value));

        public static explicit operator ulong(USB_CHANGE_REGISTRATION_HANDLE value) => (ulong)(value.Value);

        public static explicit operator USB_CHANGE_REGISTRATION_HANDLE(nuint value) => new USB_CHANGE_REGISTRATION_HANDLE((nint)(value));

        public static explicit operator nuint(USB_CHANGE_REGISTRATION_HANDLE value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is USB_CHANGE_REGISTRATION_HANDLE other) && Equals(other);

        public bool Equals(USB_CHANGE_REGISTRATION_HANDLE other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
