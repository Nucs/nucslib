// Copyright (c) 2014 Jonathan Magnan (http://jonathanmagnan.com).
// All rights reserved (http://jonathanmagnan.com/extension-methods-library).
// Licensed under MIT License (MIT) (http://zextensionmethods.codeplex.com/license).

using System;

public static partial class ObjectExtension
{
    /// <summary>
    ///     An object extension method that converts the @this to an u int 16.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>@this as an ushort.</returns>
    public static ushort ToUInt16(this object @this)
    {
        return Convert.ToUInt16(@this);
    }
}