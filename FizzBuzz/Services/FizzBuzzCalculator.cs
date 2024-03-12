using FizzBuzzApp.ConcreteFactories;
using FizzBuzzApp.ConcreteProducts;
using FizzBuzzApp.Constants;
using System.Linq;
using System.Text.RegularExpressions;

namespace FizzBuzzApp.Services
{
    public class FizzBuzzCalculator : IFizzBuzzCalculator
    {
        private readonly IFizzBuzzFactory _factory;

        public FizzBuzzCalculator(IFizzBuzzFactory factory)
        {
            _factory = factory;
        }
        public List<string> CalculateFizzBuzz(List<string> list)
        {
            List<string> result = new List<string>();

            foreach (string item in list)
            {
                if (int.TryParse(item, out int i))
                {
                    IFizzBuzzResult fizzBuzzResult = _factory.CreateFizzBuzzResult(i);
                    result.Add(fizzBuzzResult.GetResult(i));
                }
                else
                {
                    result.Add($"{item}-{FizzBuzzConstants.InvalidItem}");
                }
            }

            return result;
        }
    }
}
