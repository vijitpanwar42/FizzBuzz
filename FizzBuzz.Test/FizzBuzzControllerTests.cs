using FizzBuzz.Controllers;
using FizzBuzz.Services;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace FizzBuzz.Test
{
    public class FizzBuzzControllerTests
    {

        private Mock<IFizzBuzzService> _fizzbuzzService;
        private int[] arr;
        private Dictionary<int, string> dict;
        [SetUp]
        public void Setup()
        {
            _fizzbuzzService = new Mock<IFizzBuzzService>();
            arr = new int[2];
            arr[0] = 1;
            arr[1] = 2;
            dict = new Dictionary<int, string>();
            dict.Add(5, "Fizz");
        }

        [Test]
        public void PrintFizzBuzzTest()
        {
            //Act
            _fizzbuzzService.Setup(a => a.PrintFizzBuzz(arr)).Returns(dict);

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
            var fizzBuzzService = new FizzBuzzService();
            var result = fizzBuzzService.PrintFizzBuzz(arr);
            Assert.IsTrue(result.Count == 2);

        }
    }
}