// Copyright (c) 2014 Jonathan Magnan (http://jonathanmagnan.com).
// All rights reserved (http://jonathanmagnan.com/extension-methods-library).
// Licensed under MIT License (MIT) (http://zextensionmethods.codeplex.com/license).

using System;

namespace Z.ExtensionMethods.Object
{
    public static partial class ObjectExtension
    {
        /// <summary>
        ///     An object extension method that converts this object to a nullable byte or default.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>The given data converted to a byte?</returns>
        public static byte? ToNullableByteOrDefault(this object @this)
        {
            try
            {
                if (@this == null || @this == DBNull.Value)
                {
                    return null;
                }

                return Convert.ToByte(@this);
            }
            catch (Exception)
            {
                return default(byte);
            }
        }

        /// <summary>
        ///     An object extension method that converts this object to a nullable byte or default.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>The given data converted to a byte?</returns>
        public static byte? ToNullableByteOrDefault(this object @this, byte? defaultValue)
        {
            try
            {
                if (@this == null || @this == DBNull.Value)
                {
                    return null;
                }

                return Convert.ToByte(@this);
            }
            catch (Exception)
            {
                return defaultValue;
            }
        }

        /// <summary>
        ///     An object extension method that converts this object to a nullable byte or default.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="defaultValueFactory">The default value factory.</param>
        /// <returns>The given data converted to a byte?</returns>
        public static byte? ToNullableByteOrDefault(this object @this, Func<byte?> defaultValueFactory)
        {
            try
            {
                if (@this == null || @this == DBNull.Value)
                {
                    return null;
                }

                return Convert.ToByte(@this);
            }
            catch (Exception)
            {
                return defaultValueFactory();
            }
        }
    }
}