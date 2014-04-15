// Copyright (c) 2014 Jonathan Magnan (http://jonathanmagnan.com).
// All rights reserved (http://jonathanmagnan.com/extension-methods-library).
// Licensed under MIT License (MIT) (http://zextensionmethods.codeplex.com/license).

using System.Collections.Generic;

public static partial class ICollectionExtension
{
    /// <summary>
    ///     An ICollection&lt;T&gt; extension method that query if '@this' contains any value.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="values">A variable-length parameters list containing values.</param>
    /// <returns>true if it succeeds, false if it fails.</returns>
    public static bool ContainsAny<T>(this ICollection<T> @this, params T[] values)
    {
// ReSharper disable LoopCanBeConvertedToQuery
        foreach (T value in values)
// ReSharper restore LoopCanBeConvertedToQuery
        {
            if (@this.Contains(value))
            {
                return true;
            }
        }

        return false;
    }
}