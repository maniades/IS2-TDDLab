using Calculator;
using NUnit.Framework;

namespace CalculatorTest
{
    [TestFixture]
    public class CalculatorSumTests
    {
        CalcEngine engine;

        // This attribute allows this part of the test to be ran before each test takes place, initializing the class to test in this case
        [SetUp]
        public void Setup()
        {
            engine = new CalcEngine();
        }

        // We are doing three happy patch tests here
        [Test]
        public void SumaTestOk1()
        {
            // Arrange
            int value1 = 3;
            int value2 = 5;
            int expectedResult = 8;

            // Act
            int result = engine.Sum(value1, value2);

            // Assert
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

            // Assert
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

            // Assert
            Assert.AreEqual(result, expectedResult);
        }


        // There is not a lot more to test here, as a sum function does not do a lot, and does not have a lot of input requirements.
        // Perhaps some out of bounds tests (though testing that would be really testing the compiler, not the program)
    }
}