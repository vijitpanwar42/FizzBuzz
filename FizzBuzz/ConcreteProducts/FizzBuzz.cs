using FizzBuzzApp.Constants;

namespace FizzBuzzApp.ConcreteProducts
{
    public class FizzBuzz : IFizzBuzzResult
    {
        public string GetResult(int number)
        {
            return $"{number}-{FizzBuzzConstants.FizzBuzz}";
        }
    }
}
