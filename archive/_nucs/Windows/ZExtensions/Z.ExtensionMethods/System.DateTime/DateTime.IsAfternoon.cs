// Copyright (c) 2014 Jonathan Magnan (http://jonathanmagnan.com).
// All rights reserved (http://jonathanmagnan.com/extension-methods-library).
// Licensed under MIT License (MIT) (http://zextensionmethods.codeplex.com/license).

using System;

public static partial class DateTimeExtension
{
    /// <summary>
    ///     A DateTime extension method that query if '@this' is afternoon.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>true if afternoon, false if not.</returns>
    public static bool IsAfternoon(this DateTime @this)
    {
        return @this.TimeOfDay >= new DateTime(2000, 1, 1, 12, 0, 0).TimeOfDay;
    }
}