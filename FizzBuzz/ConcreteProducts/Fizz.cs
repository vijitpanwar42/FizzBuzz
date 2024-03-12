using FizzBuzzApp.Constants;

namespace FizzBuzzApp.ConcreteProducts
{
    public class Fizz : IFizzBuzzResult
    {
        public string GetResult(int number)
        {
            return $"{number}-{FizzBuzzConstants.Fizz}";
        }
    }
}
