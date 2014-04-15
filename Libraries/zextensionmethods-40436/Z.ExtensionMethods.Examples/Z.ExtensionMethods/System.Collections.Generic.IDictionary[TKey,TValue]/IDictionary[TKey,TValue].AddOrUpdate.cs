using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Z.ExtensionMethods;

namespace ExtensionMethods.Examples
{
    [TestClass]
    public class System_Collections_Generic_IDictionary_TKey_TValue_AddOrUpdate
    {
        [TestMethod]
        public void AddOrUpdate()
        {
            // Type
            var @this = new Dictionary<string, string>();

            // Examples
            string value1 = @this.AddOrUpdate("Fizz", "Buzz"); // return "Buzz";
            string value2 = @this.AddOrUpdate("Fizz", "Buzz2"); // return "Buzz2";

            // Unit Test
            Assert.AreEqual("Buzz", value1);
            Assert.AreEqual("Buzz2", value2);
        }
    }
}