// Copyright (c) 2014 Jonathan Magnan (http://jonathanmagnan.com).
// All rights reserved (http://jonathanmagnan.com/extension-methods-library).
// Licensed under MIT License (MIT) (http://zextensionmethods.codeplex.com/license).

using System;
using System.Globalization;

namespace Z.ExtensionMethods
{
    public static partial class CharExtension
    {
        /// <summary>
        ///     Converts the value of a specified Unicode character to its lowercase equivalent using specified culture-
        ///     specific formatting information.
        /// </summary>
        /// <param name="c">The Unicode character to convert.</param>
        /// <param name="culture">An object that supplies culture-specific casing rules.</param>
        /// <returns>
        ///     The lowercase equivalent of , modified according to , or the unchanged value of , if  is already lowercase or
        ///     not alphabetic.
        /// </returns>
        public static Char ToLower(this Char c, CultureInfo culture)
        {
            return Char.ToLower(c, culture);
        }

        /// <summary>
        ///     Converts the value of a Unicode character to its lowercase equivalent.
        /// </summary>
        /// <param name="c">The Unicode character to convert.</param>
        /// <returns>
        ///     The lowercase equivalent of , or the unchanged value of , if  is already lowercase or not alphabetic.
        /// </returns>
        public static Char ToLower(this Char c)
        {
            return Char.ToLower(c);
        }
    }
}