using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Z.ExtensionMethods;

namespace ExtensionMethods.Examples
{
    [TestClass]
    public class System_Drawing_Image_Scale
    {
        [TestMethod]
        public void Scale()
        {
            // Type
            var @this = new Bitmap(1, 1);

            // Examples
            Image value1 = @this.Scale(2); // return an Image(2, 2);
            Image value2 = @this.Scale(2, 2); // return an Image(2, 2);

            // Unit Test
            Assert.AreEqual(2, value1.Width);
            Assert.AreEqual(2, value1.Height);
            Assert.AreEqual(2, value2.Width);
            Assert.AreEqual(2, value2.Height);
        }
    }
}