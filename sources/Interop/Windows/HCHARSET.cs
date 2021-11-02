// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HCHARSET : IEquatable<HCHARSET>
    {
        public readonly nint Value;

        public HCHARSET(nint value)
        {
            Value = value;
        }

        public static HCHARSET INVALID_HANDLE_VALUE => new HCHARSET(-1);

        public static HCHARSET NULL => new HCHARSET(0);

        public static bool operator ==(HCHARSET left, HCHARSET right) => left.Value == right.Value;

        public static bool operator !=(HCHARSET left, HCHARSET right) => left.Value != right.Value;

        public static explicit operator HCHARSET(void* value) => new HCHARSET((nint)(value));

        public static implicit operator void*(HCHARSET value) => (void*)(value.Value);

        public static explicit operator HCHARSET(HANDLE value) => new HCHARSET(value);

        public static implicit operator HANDLE(HCHARSET value) => new HCHARSET(value);

        public static explicit operator HCHARSET(byte value) => new HCHARSET((nint)(value));

        public static implicit operator byte(HCHARSET value) => (byte)(value.Value);

        public static explicit operator HCHARSET(short value) => new HCHARSET((nint)(value));

        public static implicit operator short(HCHARSET value) => (short)(value.Value);

        public static explicit operator HCHARSET(int value) => new HCHARSET((nint)(value));

        public static implicit operator int(HCHARSET value) => (int)(value.Value);

        public static explicit operator HCHARSET(long value) => new HCHARSET((nint)(value));

        public static explicit operator long(HCHARSET value) => (long)(value.Value);

        public static explicit operator HCHARSET(nint value) => new HCHARSET((nint)(value));

        public static implicit operator nint(HCHARSET value) => (nint)(value.Value);

        public static explicit operator HCHARSET(sbyte value) => new HCHARSET((nint)(value));

        public static implicit operator sbyte(HCHARSET value) => (sbyte)(value.Value);

        public static explicit operator HCHARSET(ushort value) => new HCHARSET((nint)(value));

        public static implicit operator ushort(HCHARSET value) => (ushort)(value.Value);

        public static explicit operator HCHARSET(uint value) => new HCHARSET((nint)(value));

        public static implicit operator uint(HCHARSET value) => (uint)(value.Value);

        public static explicit operator HCHARSET(ulong value) => new HCHARSET((nint)(value));

        public static explicit operator ulong(HCHARSET value) => (ulong)(value.Value);

        public static explicit operator HCHARSET(nuint value) => new HCHARSET((nint)(value));

        public static explicit operator nuint(HCHARSET value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is HCHARSET other) && Equals(other);

        public bool Equals(HCHARSET other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
