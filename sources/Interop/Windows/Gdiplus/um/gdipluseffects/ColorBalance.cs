// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdipluseffects.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Interop.Windows;

namespace TerraFX.Interop.Gdiplus;

/// <include file='ColorBalance.xml' path='doc/member[@name="ColorBalance"]/*' />
[NativeTypeName("struct ColorBalance : Gdiplus::Effect")]
[NativeInheritance("Effect")]
public unsafe partial struct ColorBalance
{
    public Effect Base;

    public readonly int GetAuxDataSize()
    {
        return Base.GetAuxDataSize();
    }

    public readonly void* GetAuxData()
    {
        return Base.GetAuxData();
    }

    public void UseAuxData([NativeTypeName("const BOOL")] BOOL useAuxDataFlag)
    {
        Base.UseAuxData(useAuxDataFlag);
    }

    [return: NativeTypeName("Gdiplus::Status")]
    public readonly GpStatus GetParameterSize(uint* size)
    {
        return Base.GetParameterSize(size);
    }

    [return: NativeTypeName("Gdiplus::Status")]
    public readonly GpStatus SetParameters([NativeTypeName("const void *")] void* @params, [NativeTypeName("const UINT")] uint size)
    {
        return Base.SetParameters(@params, size);
    }

    [return: NativeTypeName("Gdiplus::Status")]
    public readonly GpStatus GetParameters(uint* size, void* @params)
    {
        return Base.GetParameters(size, @params);
    }

    [return: NativeTypeName("Gdiplus::Status")]
    public readonly GpStatus SetParameters([NativeTypeName("const ColorBalanceParams *")] ColorBalanceParams* parameters)
    {
        uint size = 12;

        return Base.SetParameters(unchecked((void*)(parameters)), size);
    }

    [return: NativeTypeName("Gdiplus::Status")]
    public readonly GpStatus GetParameters(uint* size, [NativeTypeName("Gdiplus::ColorBalanceParams *")] ColorBalanceParams* parameters)
    {
        return Base.GetParameters(size, unchecked((void*)(parameters)));
    }
}
