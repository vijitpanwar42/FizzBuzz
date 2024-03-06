using FizzBuzz.Controllers;
using FizzBuzz.Services;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace FizzBuzz.Test
{
    public class FizzBuzzControllerTests
    {

        private Mock<ICalculateFizzBuzzService> _fizzbuzzService;
        string[] arr = { "1", "2"};
        private Dictionary<int, string> dict;
        [SetUp]
        public void Setup()
        {
            _fizzbuzzService = new Mock<ICalculateFizzBuzzService>();
            dict = new Dictionary<int, string>();
            dict.Add(5, "Fizz");
        }

        [Test]
        public void PrintFizzBuzzTest()
        {
            //Act
            _fizzbuzzService.Setup(a => a.CalculateFizzBuzz(arr)).Returns(dict);

            //Arrange
            var fizzBuzzController = new FizzBuzzController(_fizzbuzzService.Object);
            var result = fizzBuzzController.PrintFizzBuzz(arr) as OkObjectResult;

            //Assert
            Assert.IsTrue(result.StatusCode == 200);
            Assert.IsNotNull(result);

        }

        [Test]
        public void TestPrintFizzBuzzService()
        {
            var fizzBuzzService = new CalculateFizzBuzzService();
            var result = fizzBuzzService.CalculateFizzBuzz(arr);
            Assert.IsTrue(result.Count == 2);

        }
    }
}