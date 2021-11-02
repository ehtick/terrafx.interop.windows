// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HHOOK : IEquatable<HHOOK>
    {
        public readonly nint Value;

        public HHOOK(nint value)
        {
            Value = value;
        }

        public static HHOOK INVALID_HANDLE_VALUE => new HHOOK(-1);

        public static HHOOK NULL => new HHOOK(0);

        public static bool operator ==(HHOOK left, HHOOK right) => left.Value == right.Value;

        public static bool operator !=(HHOOK left, HHOOK right) => left.Value != right.Value;

        public static explicit operator HHOOK(void* value) => new HHOOK((nint)(value));

        public static implicit operator void*(HHOOK value) => (void*)(value.Value);

        public static explicit operator HHOOK(HANDLE value) => new HHOOK(value);

        public static implicit operator HANDLE(HHOOK value) => new HHOOK(value);

        public static explicit operator HHOOK(byte value) => new HHOOK((nint)(value));

        public static implicit operator byte(HHOOK value) => (byte)(value.Value);

        public static explicit operator HHOOK(short value) => new HHOOK((nint)(value));

        public static implicit operator short(HHOOK value) => (short)(value.Value);

        public static explicit operator HHOOK(int value) => new HHOOK((nint)(value));

        public static implicit operator int(HHOOK value) => (int)(value.Value);

        public static explicit operator HHOOK(long value) => new HHOOK((nint)(value));

        public static explicit operator long(HHOOK value) => (long)(value.Value);

        public static explicit operator HHOOK(nint value) => new HHOOK((nint)(value));

        public static implicit operator nint(HHOOK value) => (nint)(value.Value);

        public static explicit operator HHOOK(sbyte value) => new HHOOK((nint)(value));

        public static implicit operator sbyte(HHOOK value) => (sbyte)(value.Value);

        public static explicit operator HHOOK(ushort value) => new HHOOK((nint)(value));

        public static implicit operator ushort(HHOOK value) => (ushort)(value.Value);

        public static explicit operator HHOOK(uint value) => new HHOOK((nint)(value));

        public static implicit operator uint(HHOOK value) => (uint)(value.Value);

        public static explicit operator HHOOK(ulong value) => new HHOOK((nint)(value));

        public static explicit operator ulong(HHOOK value) => (ulong)(value.Value);

        public static explicit operator HHOOK(nuint value) => new HHOOK((nint)(value));

        public static explicit operator nuint(HHOOK value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is HHOOK other) && Equals(other);

        public bool Equals(HHOOK other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
