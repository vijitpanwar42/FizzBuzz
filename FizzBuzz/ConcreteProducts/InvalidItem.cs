using FizzBuzzApp.Constants;

namespace FizzBuzzApp.ConcreteProducts
{
    public class InvalidItem : IFizzBuzzResult
    {
        public string GetResult(int number)
        {
            return $"{number}-{FizzBuzzConstants.InvalidItem}";
        }
    }
}
