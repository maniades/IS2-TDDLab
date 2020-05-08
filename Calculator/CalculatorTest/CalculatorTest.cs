using Calculator;
using NUnit.Framework;

namespace CalculatorTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SumaTestOk()
        {
            int value1 = 3;
            int value2 = 5;
            int expectedResult = 8;

            CalcEngine engine = new CalcEngine();

            int result = engine.Sum(value1, value2);

            Assert.AreEqual(result, expectedResult);
        }
    }
}