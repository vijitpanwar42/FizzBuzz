using FizzBuzzApp.Constants;

namespace FizzBuzzApp.ConcreteProducts
{
    public class DividedBy3And5 : IFizzBuzzResult
    {
        public string GetResult(int number)
        {
            return $"{number}-{FizzBuzzConstants.Dividedby3} and {FizzBuzzConstants.Dividedby5}";
        }
    }
}
