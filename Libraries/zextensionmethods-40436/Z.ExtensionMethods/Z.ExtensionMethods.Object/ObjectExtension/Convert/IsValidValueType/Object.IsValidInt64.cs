// Copyright (c) 2014 Jonathan Magnan (http://jonathanmagnan.com).
// All rights reserved (http://jonathanmagnan.com/extension-methods-library).
// Licensed under MIT License (MIT) (http://zextensionmethods.codeplex.com/license).


public static partial class ObjectExtension
{
    /// <summary>
    ///     An object extension method that query if '@this' is valid long.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>true if valid long, false if not.</returns>
    public static bool IsValidInt64(this object @this)
    {
        if (@this == null)
        {
            return true;
        }

        long result;
        return long.TryParse(@this.ToString(), out result);
    }
}