using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace CalculatorTests
{

    [TestClass]
    public class MathTests
    {
        [TestMethod]
        public void TestPlusMethod()
        {
            Assert.AreEqual(5, 5);
        }
    }
}