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

            // For this act section, we can realise that we are going to obtain one int value from this operation, and will need to operands. This allows us to infere that this Substract method signature 
            // Act
            int result = 0;
            //result = engine.Substract();

            // Assert
            Assert.AreEqual(result, expectedResult);
        }
    }
}