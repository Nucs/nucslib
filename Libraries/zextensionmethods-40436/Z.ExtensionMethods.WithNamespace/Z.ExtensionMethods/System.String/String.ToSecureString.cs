// Copyright (c) 2014 Jonathan Magnan (http://jonathanmagnan.com).
// All rights reserved (http://jonathanmagnan.com/extension-methods-library).
// Licensed under MIT License (MIT) (http://zextensionmethods.codeplex.com/license).

using System;
using System.Security;

namespace Z.ExtensionMethods
{
    public static partial class StringExtension
    {
        /// <summary>
        ///     A String extension method that converts the @this to a secure string.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>@this as a SecureString.</returns>
        /// <example>
        ///     <code>
        ///           using System.Security;
        ///           using Microsoft.VisualStudio.TestTools.UnitTesting;
        ///           using Z.ExtensionMethods;
        ///           
        ///           namespace ExtensionMethods.Examples
        ///           {
        ///               [TestClass]
        ///               public class System_String_ToSecureString
        ///               {
        ///                   [TestMethod]
        ///                   public void ToSecureString()
        ///                   {
        ///                       // Type
        ///                       string @this = &quot;FizzBuzz&quot;;
        ///           
        ///                       // Exemples
        ///                       SecureString result = @this.ToSecureString();
        ///                   }
        ///               }
        ///           }
        ///     </code>
        /// </example>
        public static SecureString ToSecureString(this string @this)
        {
            var secureString = new SecureString();
            foreach (Char c in @this)
                secureString.AppendChar(c);

            return secureString;
        }
    }
}