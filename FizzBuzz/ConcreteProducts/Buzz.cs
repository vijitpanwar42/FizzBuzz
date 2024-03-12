using FizzBuzzApp.Constants;

namespace FizzBuzzApp.ConcreteProducts
{
    public class Buzz : IFizzBuzzResult
    {
        public string GetResult(int number)
        {
            return $"{number}-{FizzBuzzConstants.Buzz}";
        }
    }
}
