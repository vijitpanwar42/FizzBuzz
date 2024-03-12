using FizzBuzzApp.ConcreteFactories;
using FizzBuzzApp.ConcreteProducts;
using FizzBuzzApp.Constants;

namespace FizzBuzzApp.ConcreteFactories
{
    public class FizzBuzzFactory : IFizzBuzzFactory
    {
        public IFizzBuzzResult CreateFizzBuzzResult(int i)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                return new FizzBuzz();
            }
            else if (i % 3 == 0)
            {
                return new Fizz();
            }
            else if (i % 5 == 0)
            {
                return new Buzz();
            }
            else
            {
                return new DividedBy3And5();
            }
        }
    }
}
