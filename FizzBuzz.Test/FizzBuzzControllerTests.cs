using FizzBuzz.Controllers;
using FizzBuzz.Services;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace FizzBuzz.Test
{
    public class FizzBuzzControllerTests
    {

        private Mock<ICalculateFizzBuzzService> _fizzbuzzService;
        List<string> arr = new List<string>{ "1", "2"};
        private List<string> ls = new List<string>();
        [SetUp]
        public void Setup()
        {
            _fizzbuzzService = new Mock<ICalculateFizzBuzzService>();
            ls.Add("FizzBuzz");
            ls.Add("FiZZ");
            ls.Add("Buzz");
        }

        [Test]
        public void PrintFizzBuzzTest()
        {
            //Act
            _fizzbuzzService.Setup(a => a.CalculateFizzBuzz(arr)).Returns(ls);

            //Arrange
            var fizzBuzzController = new FizzBuzzController(_fizzbuzzService.Object);
            var result = fizzBuzzController.PrintFizzBuzz(arr) as OkObjectResult;

            //Assert
            Assert.IsTrue(result.StatusCode == 200);
            Assert.IsNotNull(result);

        }

        [Test]
        public void TesttoCalculateFizzBuzz()
        {
            List<string> arr = new List<string> {"15"};
            var fizzBuzzService = new CalculateFizzBuzzService();
            var result = fizzBuzzService.CalculateFizzBuzz(arr);
            Assert.IsTrue(result.Contains("15-FizzBuzz"));

        }

        [Test]
        public void TesttoCalculateInValidInput()
        {
            List<string> arr = new List<string> { "A" };
            var fizzBuzzService = new CalculateFizzBuzzService();
            var result = fizzBuzzService.CalculateFizzBuzz(arr);
            Assert.IsTrue(result.Contains("A-Invalid Item"));

        }

        [Test]
        public void TesttoCalculateFizzOnly()
        {
            List<string> arr = new List<string> { "3" };
            var fizzBuzzService = new CalculateFizzBuzzService();
            var result = fizzBuzzService.CalculateFizzBuzz(arr);
            Assert.IsTrue(result.Contains("3-Fizz"));

        }

        [Test]
        public void TesttoCalculateBuzzOnly()
        {
            List<string> arr = new List<string> { "5" };
            var fizzBuzzService = new CalculateFizzBuzzService();
            var result = fizzBuzzService.CalculateFizzBuzz(arr);
            Assert.IsTrue(result.Contains("5-Buzz"));

        }
    }
}