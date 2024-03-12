using FizzBuzzApp.ConcreteProducts;

namespace FizzBuzzApp.ConcreteFactories
{
    public interface IFizzBuzzFactory
    {
        IFizzBuzzResult CreateFizzBuzzResult(int i);

    }
}
