// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct KDHELP
    {
        [NativeTypeName("DWORD")]
        public uint Thread;

        [NativeTypeName("DWORD")]
        public uint ThCallbackStack;

        [NativeTypeName("DWORD")]
        public uint NextCallback;

        [NativeTypeName("DWORD")]
        public uint FramePointer;

        [NativeTypeName("DWORD")]
        public uint KiCallUserMode;

        [NativeTypeName("DWORD")]
        public uint KeUserCallbackDispatcher;

        [NativeTypeName("DWORD")]
        public uint SystemRangeStart;

        [NativeTypeName("DWORD")]
        public uint ThCallbackBStore;

        [NativeTypeName("DWORD")]
        public uint KiUserExceptionDispatcher;

        [NativeTypeName("DWORD")]
        public uint StackBase;

        [NativeTypeName("DWORD")]
        public uint StackLimit;

        [NativeTypeName("DWORD [5]")]
        public fixed uint Reserved[5];
    }
}
