using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Z.ExtensionMethods.EntityFramework;

namespace Z.ExtensionMethods.EF6.Examples
{
    [TestClass]
    public class Database_SqlExecuteNonQuery
    {
        [TestMethod]
        public void ExecuteNonQuery()
        {
            string sql = "DECLARE @FizzBuzz VARCHAR(MAX) = @Fizz";
            var dict = new Dictionary<string, object> {{"@Fizz", 1}};

            // Examples
            using (var ctx = new EntityFrameworkTestEntities())
            {
                ctx.Database.SqlExecuteNonQuery(sql, dict.ToSqlParameters());
            }
        }
    }
}