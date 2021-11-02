// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HFONT : IEquatable<HFONT>
    {
        public readonly nint Value;

        public HFONT(nint value)
        {
            Value = value;
        }

        public static HFONT INVALID_HANDLE_VALUE => new HFONT(-1);

        public static HFONT NULL => new HFONT(0);

        public static bool operator ==(HFONT left, HFONT right) => left.Value == right.Value;

        public static bool operator !=(HFONT left, HFONT right) => left.Value != right.Value;

        public static explicit operator HFONT(void* value) => new HFONT((nint)(value));

        public static implicit operator void*(HFONT value) => (void*)(value.Value);

        public static explicit operator HFONT(HANDLE value) => new HFONT(value);

        public static implicit operator HANDLE(HFONT value) => new HFONT(value);

        public static explicit operator HFONT(byte value) => new HFONT((nint)(value));

        public static implicit operator byte(HFONT value) => (byte)(value.Value);

        public static explicit operator HFONT(short value) => new HFONT((nint)(value));

        public static implicit operator short(HFONT value) => (short)(value.Value);

        public static explicit operator HFONT(int value) => new HFONT((nint)(value));

        public static implicit operator int(HFONT value) => (int)(value.Value);

        public static explicit operator HFONT(long value) => new HFONT((nint)(value));

        public static explicit operator long(HFONT value) => (long)(value.Value);

        public static explicit operator HFONT(nint value) => new HFONT((nint)(value));

        public static implicit operator nint(HFONT value) => (nint)(value.Value);

        public static explicit operator HFONT(sbyte value) => new HFONT((nint)(value));

        public static implicit operator sbyte(HFONT value) => (sbyte)(value.Value);

        public static explicit operator HFONT(ushort value) => new HFONT((nint)(value));

        public static implicit operator ushort(HFONT value) => (ushort)(value.Value);

        public static explicit operator HFONT(uint value) => new HFONT((nint)(value));

        public static implicit operator uint(HFONT value) => (uint)(value.Value);

        public static explicit operator HFONT(ulong value) => new HFONT((nint)(value));

        public static explicit operator ulong(HFONT value) => (ulong)(value.Value);

        public static explicit operator HFONT(nuint value) => new HFONT((nint)(value));

        public static explicit operator nuint(HFONT value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is HFONT other) && Equals(other);

        public bool Equals(HFONT other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
