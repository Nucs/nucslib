// Copyright (c) 2014 Jonathan Magnan (http://jonathanmagnan.com).
// All rights reserved (http://jonathanmagnan.com/extension-methods-library).
// Licensed under MIT License (MIT) (http://zextensionmethods.codeplex.com/license).


public static partial class ObjectExtension
{
    /// <summary>
    ///     A T extension method that query if '@this' is not null.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <returns>true if not null, false if not.</returns>
    /// <example>
    ///     <code>
    ///           using Microsoft.VisualStudio.TestTools.UnitTesting;
    ///           using Z.ExtensionMethods.Object;
    ///           
    ///           namespace ExtensionMethods.Examples
    ///           {
    ///               [TestClass]
    ///               public class System_Object_IsNotNull
    ///               {
    ///                   [TestMethod]
    ///                   public void IsNotNull()
    ///                   {
    ///                       // Type
    ///                       object @thisNull = null;
    ///                       var @thisNotNull = new object();
    ///           
    ///                       // Examples
    ///                       bool value1 = @thisNull.IsNotNull(); // return false;
    ///                       bool value2 = @thisNotNull.IsNotNull(); // return true;
    ///           
    ///                       // Unit Test
    ///                       Assert.IsFalse(value1);
    ///                       Assert.IsTrue(value2);
    ///                   }
    ///               }
    ///           }
    ///     </code>
    /// </example>
    public static bool IsNotNull<T>(this T @this) where T : class
    {
        return @this != null;
    }
}