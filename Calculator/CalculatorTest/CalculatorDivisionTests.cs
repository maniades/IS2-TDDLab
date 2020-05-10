using Calculator;
using NUnit.Framework;
using System;

namespace CalculatorTest
{
    [TestFixture]
    public class CalculatorDivisionTests
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
        public void DivisionTestOk1()
        {
            // Arrange
            int value1 = 4;
            int value2 = 2;
            int expectedResult = 2;

            // Act
            int result = 0;
            //int result = engine.Division(value1, value2);

            // Assert
            Assert.AreEqual(result, expectedResult);
        }

        // We are doing some happy patch tests here
        [Test]
        public void DivisionTestOk2()
        {
            // Arrange
            int value1 = 0;
            int value2 = 5;
            int expectedResult = 0;

            // Act
            int result = -10; // Juat to make to test fail
            //int result = engine.Division(value1, value2);

            // Assert
            Assert.AreEqual(result, expectedResult);
        }

        // We are doing some happy patch tests here
        [Test]
        public void DivisionTestOk3()
        {
            // Arrange
            int value1 = -6;
            int value2 = 2;
            int expectedResult = -3;

            // Act
            int result = 0;
            //int result = engine.Division(value1, value2);

            // Assert
            Assert.AreEqual(result, expectedResult);
        }

        // We are doing some happy patch tests here
        [Test]
        public void DivisionTestOk4()
        {
            // Arrange
            int value1 = 7;
            int value2 = 2;
            double expectedResult = 3.5;

            // Act
            double result = 0;
            //int result = engine.Division(value1, value2);

            // Assert
            Assert.AreEqual(result, expectedResult);
        }

        // For division, we are doing another test that will throw an exception
        [Test]
        public void DivisionException1()
        {
            // Arrange
            int value1 = 10;
            int value2 = 0;

            // Act & assert
            Assert.Throws<DivideByZeroException>(() => engine.Division());
        }
    }
}