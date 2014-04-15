// Copyright (c) 2014 Jonathan Magnan (http://jonathanmagnan.com).
// All rights reserved (http://jonathanmagnan.com/extension-methods-library).
// Licensed under MIT License (MIT) (http://zextensionmethods.codeplex.com/license).

using System;
using System.Globalization;
using System.Reflection;

namespace Z.ExtensionMethods
{
    public static partial class TypeExtension
    {
        /// <summary>
        ///     A Type extension method that creates an instance.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="this">The @this to act on.</param>
        /// <param name="bindingAttr">The binding attribute.</param>
        /// <param name="binder">The binder.</param>
        /// <param name="args">The arguments.</param>
        /// <param name="culture">The culture.</param>
        /// <returns>The new instance.</returns>
        public static T CreateInstance<T>(this Type @this, BindingFlags bindingAttr, Binder binder, System.Object[] args, CultureInfo culture)
        {
            return (T) Activator.CreateInstance(@this, bindingAttr, binder, args, culture);
        }

        /// <summary>
        ///     A Type extension method that creates an instance.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="this">The @this to act on.</param>
        /// <param name="bindingAttr">The binding attribute.</param>
        /// <param name="binder">The binder.</param>
        /// <param name="args">The arguments.</param>
        /// <param name="culture">The culture.</param>
        /// <param name="activationAttributes">The activation attributes.</param>
        /// <returns>The new instance.</returns>
        public static T CreateInstance<T>(this Type @this, BindingFlags bindingAttr, Binder binder, System.Object[] args, CultureInfo culture, System.Object[] activationAttributes)
        {
            return (T) Activator.CreateInstance(@this, bindingAttr, binder, args, culture, activationAttributes);
        }

        /// <summary>
        ///     A Type extension method that creates an instance.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="this">The @this to act on.</param>
        /// <param name="args">The arguments.</param>
        /// <returns>The new instance.</returns>
        public static T CreateInstance<T>(this Type @this, System.Object[] args)
        {
            return (T) Activator.CreateInstance(@this, args);
        }

        /// <summary>
        ///     A Type extension method that creates an instance.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="this">The @this to act on.</param>
        /// <param name="args">The arguments.</param>
        /// <param name="activationAttributes">The activation attributes.</param>
        /// <returns>The new instance.</returns>
        public static T CreateInstance<T>(this Type @this, System.Object[] args, System.Object[] activationAttributes)
        {
            return (T) Activator.CreateInstance(@this, args, activationAttributes);
        }

        /// <summary>
        ///     A Type extension method that creates an instance.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="this">The @this to act on.</param>
        /// <returns>The new instance.</returns>
        public static T CreateInstance<T>(this Type @this)
        {
            return (T) Activator.CreateInstance(@this);
        }

        /// <summary>
        ///     A Type extension method that creates an instance.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="this">The @this to act on.</param>
        /// <param name="nonPublic">true to non public.</param>
        /// <returns>The new instance.</returns>
        public static T CreateInstance<T>(this Type @this, Boolean nonPublic)
        {
            return (T) Activator.CreateInstance(@this, nonPublic);
        }
    }
}