// Copyright (c) 2014 Jonathan Magnan (http://jonathanmagnan.com).
// All rights reserved (http://jonathanmagnan.com/extension-methods-library).
// Licensed under MIT License (MIT) (http://zextensionmethods.codeplex.com/license).

using System.IO;

namespace Z.ExtensionMethods
{
    public static partial class StringExtension
    {
        /// <summary>
        ///     A string extension method that converts the @this to a directory information.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>@this as a DirectoryInfo.</returns>
        /// <example>
        ///     <code>
        ///           using System;
        ///           using System.IO;
        ///           using Microsoft.VisualStudio.TestTools.UnitTesting;
        ///           using Z.ExtensionMethods;
        ///           
        ///           namespace ExtensionMethods.Examples
        ///           {
        ///               [TestClass]
        ///               public class System_String_ToDirectoryInfo
        ///               {
        ///                   [TestMethod]
        ///                   public void ToDirectoryInfo()
        ///                   {
        ///                       // Type
        ///                       string @this = AppDomain.CurrentDomain.BaseDirectory;
        ///           
        ///                       // Examples
        ///                       DirectoryInfo value = @this.ToDirectoryInfo(); // return a DirectoryInfo from the specified path.
        ///           
        ///                       // Unit Test
        ///                       Assert.AreEqual(@this, value.FullName);
        ///                   }
        ///               }
        ///           }
        ///     </code>
        /// </example>
        public static DirectoryInfo ToDirectoryInfo(this string @this)
        {
            return new DirectoryInfo(@this);
        }
    }
}