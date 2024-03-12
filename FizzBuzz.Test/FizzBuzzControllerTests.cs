using FizzBuzzApp.ConcreteFactories;
using FizzBuzzApp.ConcreteProducts;
using FizzBuzzApp.Controllers;
using FizzBuzzApp.Services;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace FizzBuzzApp.Test
{
    public class FizzBuzzControllerTests
    {

        private Mock<IFizzBuzzCalculator> _fizzBuzzCalculator;
        private Mock<IFizzBuzzFactory> _factory;
        private readonly List<string> list = new List<string>();

        [SetUp]
        public void Setup()
        {
            _fizzBuzzCalculator = new Mock<IFizzBuzzCalculator>();
            _factory = new Mock<IFizzBuzzFactory>();
            list.Add("FizzBuzz");
            list.Add("Fizz");
            list.Add("Buzz");
        }

        [Test]
        public void CalculateFizzBuzz_WithValidInput_ShouldReturnOkStatusAndCorrectList()
        {
            // Arrange
            List<string> inputList = new List<string> { "1" };
            _fizzBuzzCalculator.Setup(a => a.CalculateFizzBuzz(inputList)).Returns(list);
            var fizzBuzzController = new FizzBuzzController(_fizzBuzzCalculator.Object);

            // Act
            var result = fizzBuzzController.CalculateFizzBuzz(inputList) as OkObjectResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(200, result.StatusCode);
            CollectionAssert.AreEqual(list, result.Value as List<string>);
        }

        [Test]
        public void CalculateFizzBuzz_WithValidNumbers_ShouldReturnCorrectResults()
        {
            // Arrange
            _factory.Setup(factory => factory.CreateFizzBuzzResult(It.IsAny<int>()))
                       .Returns<int>(number =>
                       {
                           if (number % 3 == 0 && number % 5 == 0)
                               return new FizzBuzz();
                           else if (number % 3 == 0)
                               return new Fizz();
                           else if (number % 5 == 0)
                               return new Buzz();
                           else
                               return new DividedBy3And5();
                       });

            var fizzBuzzCalculator = new FizzBuzzCalculator(_factory.Object);

            // Act
            var result = fizzBuzzCalculator.CalculateFizzBuzz(new List<string> { "3", "5", "15", "7", "11" });

            // Assert
            CollectionAssert.AreEqual(new[] { "3-Fizz", "5-Buzz", "15-FizzBuzz", "7-Divided by 3 and Divided by 5", "11-Divided by 3 and Divided by 5" }, result);
        }

        [Test]
        public void CalculateFizzBuzz_WithInvalidInput_ShouldReturnInvalidItem()
        {
            // Arrange
            var mockFactory = new Mock<IFizzBuzzFactory>();
            var fizzBuzzCalculator = new FizzBuzzCalculator(mockFactory.Object);

            // Act
            var result = fizzBuzzCalculator.CalculateFizzBuzz(new List<string> { "invalid", "12a", "abc" });

            // Assert
            CollectionAssert.AreEqual(new[] { "invalid-Invalid Item", "12a-Invalid Item", "abc-Invalid Item" }, result);
        }

    }
}