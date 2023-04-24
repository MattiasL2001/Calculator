namespace CalculatorTesting

{
    [TestClass]
    public class CalculatorTests
    {
        public CalculatorTests()
        {
            //Calculator.Calculator calculator = new Calculator.Calculator();
        }

        [TestMethod]
        public void Test_Math_Add_Method()
        {
            Assert.AreEqual(10, Calculator.Math.Calculate(5, 5, '+'));
        }

        [TestMethod]
        public void Test_Math_Subtract_Method()
        {
            Assert.AreEqual(10, Calculator.Math.Calculate(15, 5, '-'));
        }
    }
}
