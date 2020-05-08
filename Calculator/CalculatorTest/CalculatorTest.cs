using Calculator;
using NUnit.Framework;

namespace CalculatorTest
{
    public class Tests
    {
        CalcEngine engine;

        [SetUp]
        public void Setup()
        {
            engine = new CalcEngine();
        }

        [Test]
        public void SumaTestOk1()
        {
            // Arrange
            int value1 = 3;
            int value2 = 5;
            int expectedResult = 8;

            // Act
            int result = engine.Sum(value1, value2);

            // Asset
            Assert.AreEqual(result, expectedResult);
        }

        [Test]
        public void SumaTestOk2()
        {
            // Arrange
            int value1 = -3;
            int value2 = 5;
            int expectedResult = 2;

            // Act
            int result = engine.Sum(value1, value2);

            // Asset
            Assert.AreEqual(result, expectedResult);
        }

        [Test]
        public void SumaTestOk3()
        {
            // Arrange
            int value1 = -6;
            int value2 = 2;
            int expectedResult = -4;

            // Act
            int result = engine.Sum(value1, value2);

            // Asset
            Assert.AreEqual(result, expectedResult);
        }
    }
}