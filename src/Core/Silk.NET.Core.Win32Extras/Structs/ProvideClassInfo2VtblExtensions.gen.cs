// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras;

public unsafe static class ProvideClassInfo2VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IProvideClassInfo2> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IProvideClassInfo2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IProvideClassInfo2> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IProvideClassInfo2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IProvideClassInfo2> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IProvideClassInfo2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IProvideClassInfo2> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IProvideClassInfo2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IProvideClassInfo2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IProvideClassInfo2*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IProvideClassInfo2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IProvideClassInfo2*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetClassInfoA(this ComPtr<IProvideClassInfo2> thisVtbl, ITypeInfo** ppTI)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IProvideClassInfo2*, ITypeInfo**, int>)@this->LpVtbl[3])(@this, ppTI);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetClassInfoA(this ComPtr<IProvideClassInfo2> thisVtbl, ref ITypeInfo* ppTI)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ITypeInfo** ppTIPtr = &ppTI)
        {
            ret = ((delegate* unmanaged[Cdecl]<IProvideClassInfo2*, ITypeInfo**, int>)@this->LpVtbl[3])(@this, ppTIPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGUID(this ComPtr<IProvideClassInfo2> thisVtbl, uint dwGuidKind, Guid* pGUID)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IProvideClassInfo2*, uint, Guid*, int>)@this->LpVtbl[4])(@this, dwGuidKind, pGUID);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetGUID(this ComPtr<IProvideClassInfo2> thisVtbl, uint dwGuidKind, ref Guid pGUID)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pGUIDPtr = &pGUID)
        {
            ret = ((delegate* unmanaged[Cdecl]<IProvideClassInfo2*, uint, Guid*, int>)@this->LpVtbl[4])(@this, dwGuidKind, pGUIDPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IProvideClassInfo2> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IProvideClassInfo2> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IProvideClassInfo2> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int GetClassInfoA<TI0>(this ComPtr<IProvideClassInfo2> thisVtbl, ref ComPtr<TI0> ppTI) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetClassInfoA((ITypeInfo**) ppTI.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int GetGUID(this ComPtr<IProvideClassInfo2> thisVtbl, uint dwGuidKind, Span<Guid> pGUID)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGUID(dwGuidKind, ref pGUID.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IProvideClassInfo2> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
