// Copyright (c) 2014 Jonathan Magnan (http://jonathanmagnan.com).
// All rights reserved (http://jonathanmagnan.com/extension-methods-library).
// Licensed under MIT License (MIT) (http://zextensionmethods.codeplex.com/license).

using System;

namespace Z.ExtensionMethods
{
    public static partial class DateTimeExtension
    {
        /// <summary>
        ///     A DateTime extension method that return a DateTime of the last day of the year with the time set to
        ///     "23:59:59:999". The last moment of the last day of the year.  Use "DateTime2" column type in sql to keep the
        ///     precision.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>A DateTime of the last day of the year with the time set to "23:59:59:999".</returns>
        public static DateTime EndOfYear(this DateTime @this)
        {
            return new DateTime(@this.Year, 1, 1).AddYears(1).Subtract(new TimeSpan(0, 0, 0, 0, 1));
        }
    }
}