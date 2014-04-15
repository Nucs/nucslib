// Copyright (c) 2014 Jonathan Magnan (http://jonathanmagnan.com).
// All rights reserved (http://jonathanmagnan.com/extension-methods-library).
// Licensed under MIT License (MIT) (http://zextensionmethods.codeplex.com/license).

using System.Data.Common;

public static partial class DbCommandExtension
{
    /// <summary>
    ///     A DbCommand extension method that executes the scalar to operation.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <returns>A T.</returns>
    /// <example>
    ///     <code>
    ///           using System.Data.SqlClient;
    ///           using Microsoft.VisualStudio.TestTools.UnitTesting;
    ///           using Z.ExtensionMethods;
    ///           
    ///           namespace ExtensionMethods.Examples
    ///           {
    ///               [TestClass]
    ///               public class System_Data_Common_DbCommand_ExecuteScalarTo
    ///               {
    ///                   [TestMethod]
    ///                   public void ExecuteScalarTo()
    ///                   {
    ///                       const string sql = @&quot;SELECT 1 As IntColumn&quot;;
    ///           
    ///                       // Examples
    ///                       using (var conn = new SqlConnection(My.Config.ConnectionString.UnitTest.ConnectionString))
    ///                       {
    ///                           using (SqlCommand @this = conn.CreateCommand())
    ///                           {
    ///                               conn.Open();
    ///                               @this.CommandText = sql;
    ///                               var result = @this.ExecuteScalarTo&lt;int&gt;();
    ///           
    ///                               // UnitTest
    ///                               Assert.AreEqual(1, result);
    ///                           }
    ///                       }
    ///                   }
    ///               }
    ///           }
    ///     </code>
    /// </example>
    public static T ExecuteScalarTo<T>(this DbCommand @this)
    {
        return @this.ExecuteScalar().To<T>();
    }
}