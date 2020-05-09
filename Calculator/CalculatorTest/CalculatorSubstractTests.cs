using Calculator;
using NUnit.Framework;

namespace CalculatorTest
{
    [TestFixture]
    public class CalculatorSubstractTests
    {
        CalcEngine engine;

        // This attribute allows this part of the test to be ran before each test takes place, initializing the class to test in this case
        [SetUp]
        public void Setup()
        {
            engine = new CalcEngine();
        }

        // We are doing some happy patch tests here
        [Test]
        public void SubstractTestOk1()
        {
            // Arrange
            int value1 = 5;
            int value2 = 2;
            int expectedResult = 3;

            // Act
            int result = engine.Substract(value1, value2);

            // Assert
            Assert.AreEqual(result, expectedResult);
        }

        // We are doing some happy patch tests here
        [Test]
        public void SubstractTestOk2()
        {
            // Arrange
            int value1 = 0;
            int value2 = 5;
            int expectedResult = -5;

            // Act
            int result = engine.Substract(value1, value2);

            // Assert
            Assert.AreEqual(result, expectedResult);
        }

        // We are doing some happy patch tests here
        [Test]
        public void SubstractTestOk3()
        {
            // Arrange
            int value1 = -6;
            int value2 = -3;
            int expectedResult = -3;

            // Act
            int result = engine.Substract(value1, value2);

            // Assert
            Assert.AreEqual(result, expectedResult);
        }
    }
}