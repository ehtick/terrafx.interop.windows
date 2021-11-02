// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HPTPROVIDER : IEquatable<HPTPROVIDER>
    {
        public readonly nint Value;

        public HPTPROVIDER(nint value)
        {
            Value = value;
        }

        public static HPTPROVIDER INVALID_HANDLE_VALUE => new HPTPROVIDER(-1);

        public static HPTPROVIDER NULL => new HPTPROVIDER(0);

        public static bool operator ==(HPTPROVIDER left, HPTPROVIDER right) => left.Value == right.Value;

        public static bool operator !=(HPTPROVIDER left, HPTPROVIDER right) => left.Value != right.Value;

        public static explicit operator HPTPROVIDER(void* value) => new HPTPROVIDER((nint)(value));

        public static implicit operator void*(HPTPROVIDER value) => (void*)(value.Value);

        public static explicit operator HPTPROVIDER(HANDLE value) => new HPTPROVIDER(value);

        public static implicit operator HANDLE(HPTPROVIDER value) => new HPTPROVIDER(value);

        public static explicit operator HPTPROVIDER(byte value) => new HPTPROVIDER((nint)(value));

        public static implicit operator byte(HPTPROVIDER value) => (byte)(value.Value);

        public static explicit operator HPTPROVIDER(short value) => new HPTPROVIDER((nint)(value));

        public static implicit operator short(HPTPROVIDER value) => (short)(value.Value);

        public static explicit operator HPTPROVIDER(int value) => new HPTPROVIDER((nint)(value));

        public static implicit operator int(HPTPROVIDER value) => (int)(value.Value);

        public static explicit operator HPTPROVIDER(long value) => new HPTPROVIDER((nint)(value));

        public static explicit operator long(HPTPROVIDER value) => (long)(value.Value);

        public static explicit operator HPTPROVIDER(nint value) => new HPTPROVIDER((nint)(value));

        public static implicit operator nint(HPTPROVIDER value) => (nint)(value.Value);

        public static explicit operator HPTPROVIDER(sbyte value) => new HPTPROVIDER((nint)(value));

        public static implicit operator sbyte(HPTPROVIDER value) => (sbyte)(value.Value);

        public static explicit operator HPTPROVIDER(ushort value) => new HPTPROVIDER((nint)(value));

        public static implicit operator ushort(HPTPROVIDER value) => (ushort)(value.Value);

        public static explicit operator HPTPROVIDER(uint value) => new HPTPROVIDER((nint)(value));

        public static implicit operator uint(HPTPROVIDER value) => (uint)(value.Value);

        public static explicit operator HPTPROVIDER(ulong value) => new HPTPROVIDER((nint)(value));

        public static explicit operator ulong(HPTPROVIDER value) => (ulong)(value.Value);

        public static explicit operator HPTPROVIDER(nuint value) => new HPTPROVIDER((nint)(value));

        public static explicit operator nuint(HPTPROVIDER value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is HPTPROVIDER other) && Equals(other);

        public bool Equals(HPTPROVIDER other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
