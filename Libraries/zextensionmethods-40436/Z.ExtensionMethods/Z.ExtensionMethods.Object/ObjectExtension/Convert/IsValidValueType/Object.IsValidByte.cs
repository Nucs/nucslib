// Copyright (c) 2014 Jonathan Magnan (http://jonathanmagnan.com).
// All rights reserved (http://jonathanmagnan.com/extension-methods-library).
// Licensed under MIT License (MIT) (http://zextensionmethods.codeplex.com/license).


public static partial class ObjectExtension
{
    /// <summary>
    ///     An object extension method that query if '@this' is valid byte.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>true if valid byte, false if not.</returns>
    public static bool IsValidByte(this object @this)
    {
        if (@this == null)
        {
            return true;
        }

        byte result;
        return byte.TryParse(@this.ToString(), out result);
    }
}