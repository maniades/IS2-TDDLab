using Calculator;
using NUnit.Framework;
using System;

namespace CalculatorTest
{
    [TestFixture]
    public class CalculatorSquareRootTests
    {
        CalcEngine engine;
        double precission = 0.00001;

        // This attribute allows this part of the test to be ran before each test takes place, initializing the class to test in this case
        [SetUp]
        public void Setup()
        {
            engine = new CalcEngine();
        }

        // We are doing some happy patch tests here
        [Test]
        public void SqrtTestOk1()
        {
            // Arrange
            int value1 = 16;
            double expectedResult = 4;

            // Act
            double result = engine.SquareRoot(value1);

            // Assert
            Assert.LessOrEqual(result - expectedResult, precission);
        }

        // We are doing some happy patch tests here
        [Test]
        public void SqrtTestOk2()
        {
            // Arrange
            int value1 = 64;
            double expectedResult = 8;

            // Act
            double result = engine.SquareRoot(value1);

            // Assert
            Assert.LessOrEqual(result - expectedResult, precission);
        }

        // We are doing some happy patch tests here
        [Test]
        public void SqrtTestOk3()
        {
            // Arrange
            int value1 = 8;
            double expectedResult = 2.8284271247;

            // Act
            double result = engine.SquareRoot(value1);

            // Assert
            Assert.LessOrEqual(result - expectedResult, precission);
        }

        // We are doing some happy patch tests here
        [Test]
        public void SqrtTestOk4()
        {
            // Arrange
            int value1 = 16;
            double expectedResult = 4;

            // Act
            double result = engine.SquareRoot(value1);

            // Assert
            Assert.LessOrEqual(result - expectedResult, precission);
        }

        // We are doing some happy patch tests here
        [Test]
        public void SqrtTestOk5()
        {
            // Arrange
            int value1 = 543;
            double expectedResult = 23.302360395462087179361609805681;

            // Act
            double result = engine.SquareRoot(value1);

            // Assert
            Assert.LessOrEqual(result - expectedResult, precission);
        }

        // For division, we are doing another test that will throw an exception
        [Test]
        public void SqrtTestException1()
        {
            // Arrange
            int value1 = -4;

            // Act & assert
            Assert.Throws<ArgumentException>(() => engine.SquareRoot(value1));
        }
    }
}