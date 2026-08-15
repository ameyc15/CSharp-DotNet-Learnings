using NUnit.Framework;
using Day43_NUnitTest.Services;
namespace Day43_NUnitTest.Tests

{
    public class CalculatorServiceTests
    {
        private CalculatorService _calculatorService;

        [SetUp]
        public void Setup()
        {
            _calculatorService = new CalculatorService();
        }

        [Test]
        public void AddShouldReturnCorrectSum()
        {
            // arrange
            int a = 2, b = 3;

            // act
            var result = _calculatorService.Add(a, b);

            // assert

            Assert.That(5, Is.EqualTo(result));
        }
    }
}
