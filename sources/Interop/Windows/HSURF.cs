// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HSURF : IEquatable<HSURF>
    {
        public readonly nint Value;

        public HSURF(nint value)
        {
            Value = value;
        }

        public static HSURF INVALID_HANDLE_VALUE => new HSURF(-1);

        public static HSURF NULL => new HSURF(0);

        public static bool operator ==(HSURF left, HSURF right) => left.Value == right.Value;

        public static bool operator !=(HSURF left, HSURF right) => left.Value != right.Value;

        public static explicit operator HSURF(void* value) => new HSURF((nint)(value));

        public static implicit operator void*(HSURF value) => (void*)(value.Value);

        public static explicit operator HSURF(HANDLE value) => new HSURF(value);

        public static implicit operator HANDLE(HSURF value) => new HSURF(value);

        public static explicit operator HSURF(byte value) => new HSURF((nint)(value));

        public static implicit operator byte(HSURF value) => (byte)(value.Value);

        public static explicit operator HSURF(short value) => new HSURF((nint)(value));

        public static implicit operator short(HSURF value) => (short)(value.Value);

        public static explicit operator HSURF(int value) => new HSURF((nint)(value));

        public static implicit operator int(HSURF value) => (int)(value.Value);

        public static explicit operator HSURF(long value) => new HSURF((nint)(value));

        public static explicit operator long(HSURF value) => (long)(value.Value);

        public static explicit operator HSURF(nint value) => new HSURF((nint)(value));

        public static implicit operator nint(HSURF value) => (nint)(value.Value);

        public static explicit operator HSURF(sbyte value) => new HSURF((nint)(value));

        public static implicit operator sbyte(HSURF value) => (sbyte)(value.Value);

        public static explicit operator HSURF(ushort value) => new HSURF((nint)(value));

        public static implicit operator ushort(HSURF value) => (ushort)(value.Value);

        public static explicit operator HSURF(uint value) => new HSURF((nint)(value));

        public static implicit operator uint(HSURF value) => (uint)(value.Value);

        public static explicit operator HSURF(ulong value) => new HSURF((nint)(value));

        public static explicit operator ulong(HSURF value) => (ulong)(value.Value);

        public static explicit operator HSURF(nuint value) => new HSURF((nint)(value));

        public static explicit operator nuint(HSURF value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is HSURF other) && Equals(other);

        public bool Equals(HSURF other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
