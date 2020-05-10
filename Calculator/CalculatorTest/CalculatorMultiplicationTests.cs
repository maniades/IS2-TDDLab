using Calculator;
using NUnit.Framework;

namespace CalculatorTest
{
    [TestFixture]
    public class CalculatorMultiplicationTests
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
        public void MultiplicationTestOk1()
        {
            // Arrange
            int value1 = 4;
            int value2 = 2;
            int expectedResult = 8;

            // Act
            int result = 0;
            //int result = engine.Multiplication(value1, value2);

            // Assert
            Assert.AreEqual(result, expectedResult);
        }

        // We are doing some happy patch tests here
        [Test]
        public void MultiplicationTestOk2()
        {
            // Arrange
            int value1 = 0;
            int value2 = 5;
            int expectedResult = 0;

            // Act
            int result = 0;
            //int result = engine.Multiplication(value1, value2);

            // Assert
            Assert.AreEqual(result, expectedResult);
        }

        // We are doing some happy patch tests here
        [Test]
        public void MultiplicationTestOk3()
        {
            // Arrange
            int value1 = -6;
            int value2 = 2;
            int expectedResult = -12;

            // Act
            int result = 0;
            //int result = engine.Multiplication(value1, value2);

            // Assert
            Assert.AreEqual(result, expectedResult);
        }
    }
}