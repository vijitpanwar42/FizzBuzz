using FizzBuzz.Controllers;
using FizzBuzz.Services;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace FizzBuzz.Test
{
    public class FizzBuzzControllerTests
    {

        private Mock<IFizzBuzzService> _fizzbuzzService;
        [SetUp]
        public void Setup()
        {
            _fizzbuzzService = new Mock<IFizzBuzzService>();
        }

        [Test]
        public void PrintFizzBuzzTest()
        {
            //Act
            _fizzbuzzService.Setup(a => a.PrintFizzBuzz(15)).Returns("FizzBuzz");

            //Arrange
            var fizzBuzzController = new FizzBuzzController(_fizzbuzzService.Object);
            var result = fizzBuzzController.PrintFizzBuzz(15) as OkObjectResult;

            //Assert
            Assert.IsTrue(result.StatusCode == 200);
            Assert.That(result.Value, Is.EqualTo("FizzBuzz"));

        }
    }
}