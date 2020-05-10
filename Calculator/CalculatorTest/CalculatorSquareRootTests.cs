using Calculator;
using NUnit.Framework;
using System;

namespace CalculatorTest
{
    [TestFixture]
    public class CalculatorSquareRootTests
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
        public void SqrtTestOk1()
        {
            // Arrange
            int value1 = 16;
            double expectedResult = 4;

            // Act
            double result = 0;
            //double result = engine.SquareRoot(value1);

            // Assert
            Assert.AreEqual(result, expectedResult);
        }

        // We are doing some happy patch tests here
        [Test]
        public void SqrtTestOk2()
        {
            // Arrange
            int value1 = 64;
            double expectedResult = 8;

            // Act
            double result = 0;
            //double result = engine.SquareRoot(value1);

            // Assert
            Assert.AreEqual(result, expectedResult);
        }

        // We are doing some happy patch tests here
        [Test]
        public void SqrtTestOk3()
        {
            // Arrange
            int value1 = 8;
            double expectedResult = 2.8284271247;

            // Act
            double result = 0;
            //double result = engine.SquareRoot(value1);

            // Assert
            Assert.AreEqual(result, expectedResult);
        }

        // We are doing some happy patch tests here
        [Test]
        public void SqrtTestOk4()
        {
            // Arrange
            int value1 = -16;
            double expectedResult = 3.5;

            // Act
            double result = 0;
            //double result = engine.SquareRoot(value1);

            // Assert
            Assert.AreEqual(result, expectedResult);
        }

        // For division, we are doing another test that will throw an exception
        [Test]
        public void SqrtTestException1()
        {
            // Arrange
            int value1 = -4;

            // Act & assert
            Assert.Throws<Exception>(() => engine.SquareRoot());
        }
    }
}