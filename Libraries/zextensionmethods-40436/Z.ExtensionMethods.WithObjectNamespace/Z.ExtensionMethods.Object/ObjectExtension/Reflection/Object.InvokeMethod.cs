// Copyright (c) 2014 Jonathan Magnan (http://jonathanmagnan.com).
// All rights reserved (http://jonathanmagnan.com/extension-methods-library).
// Licensed under MIT License (MIT) (http://zextensionmethods.codeplex.com/license).

using System;
using System.Linq;
using System.Reflection;

namespace Z.ExtensionMethods.Object
{
    public static partial class ObjectExtension
    {
        /// <summary>
        ///     An object extension method that executes the method on a different thread, and waits for the result.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="obj">The obj to act on.</param>
        /// <param name="methodName">Name of the method.</param>
        /// <param name="parameters">Options for controlling the operation.</param>
        /// <returns>An object.</returns>
        public static object InvokeMethod<T>(this T obj, string methodName, params object[] parameters)
        {
            Type type = obj.GetType();
            MethodInfo method = type.GetMethod(methodName, parameters.Select(o => o.GetType()).ToArray());

            return method.Invoke(obj, parameters);
        }

        /// <summary>
        ///     An object extension method that executes the method on a different thread, and waits for the result.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="obj">The obj to act on.</param>
        /// <param name="methodName">Name of the method.</param>
        /// <param name="parameters">Options for controlling the operation.</param>
        /// <returns>A T.</returns>
        public static T InvokeMethod<T>(this object obj, string methodName, params object[] parameters)
        {
            Type type = obj.GetType();
            MethodInfo method = type.GetMethod(methodName, parameters.Select(o => o.GetType()).ToArray());

            object value = method.Invoke(obj, parameters);
            return (value is T ? (T) value : default(T));
        }
    }
}