// Copyright (c) 2014 Jonathan Magnan (http://jonathanmagnan.com).
// All rights reserved (http://jonathanmagnan.com/extension-methods-library).
// Licensed under MIT License (MIT) (http://zextensionmethods.codeplex.com/license).

using System;

public static class ObjectArrayExtension
{
    /// <summary>
    ///     Gets the types of the objects in the specified array.
    /// </summary>
    /// <param name="args">An array of objects whose types to determine.</param>
    /// <returns>An array of  objects representing the types of the corresponding elements in .</returns>
    public static Type[] GetTypeArray(this Object[] args)
    {
        return Type.GetTypeArray(args);
    }
}