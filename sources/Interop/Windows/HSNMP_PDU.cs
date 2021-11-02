// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HSNMP_PDU : IEquatable<HSNMP_PDU>
    {
        public readonly nint Value;

        public HSNMP_PDU(nint value)
        {
            Value = value;
        }

        public static HSNMP_PDU INVALID_HANDLE_VALUE => new HSNMP_PDU(-1);

        public static HSNMP_PDU NULL => new HSNMP_PDU(0);

        public static bool operator ==(HSNMP_PDU left, HSNMP_PDU right) => left.Value == right.Value;

        public static bool operator !=(HSNMP_PDU left, HSNMP_PDU right) => left.Value != right.Value;

        public static explicit operator HSNMP_PDU(void* value) => new HSNMP_PDU((nint)(value));

        public static implicit operator void*(HSNMP_PDU value) => (void*)(value.Value);

        public static explicit operator HSNMP_PDU(HANDLE value) => new HSNMP_PDU(value);

        public static implicit operator HANDLE(HSNMP_PDU value) => new HSNMP_PDU(value);

        public static explicit operator HSNMP_PDU(byte value) => new HSNMP_PDU((nint)(value));

        public static implicit operator byte(HSNMP_PDU value) => (byte)(value.Value);

        public static explicit operator HSNMP_PDU(short value) => new HSNMP_PDU((nint)(value));

        public static implicit operator short(HSNMP_PDU value) => (short)(value.Value);

        public static explicit operator HSNMP_PDU(int value) => new HSNMP_PDU((nint)(value));

        public static implicit operator int(HSNMP_PDU value) => (int)(value.Value);

        public static explicit operator HSNMP_PDU(long value) => new HSNMP_PDU((nint)(value));

        public static explicit operator long(HSNMP_PDU value) => (long)(value.Value);

        public static explicit operator HSNMP_PDU(nint value) => new HSNMP_PDU((nint)(value));

        public static implicit operator nint(HSNMP_PDU value) => (nint)(value.Value);

        public static explicit operator HSNMP_PDU(sbyte value) => new HSNMP_PDU((nint)(value));

        public static implicit operator sbyte(HSNMP_PDU value) => (sbyte)(value.Value);

        public static explicit operator HSNMP_PDU(ushort value) => new HSNMP_PDU((nint)(value));

        public static implicit operator ushort(HSNMP_PDU value) => (ushort)(value.Value);

        public static explicit operator HSNMP_PDU(uint value) => new HSNMP_PDU((nint)(value));

        public static implicit operator uint(HSNMP_PDU value) => (uint)(value.Value);

        public static explicit operator HSNMP_PDU(ulong value) => new HSNMP_PDU((nint)(value));

        public static explicit operator ulong(HSNMP_PDU value) => (ulong)(value.Value);

        public static explicit operator HSNMP_PDU(nuint value) => new HSNMP_PDU((nint)(value));

        public static explicit operator nuint(HSNMP_PDU value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is HSNMP_PDU other) && Equals(other);

        public bool Equals(HSNMP_PDU other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
