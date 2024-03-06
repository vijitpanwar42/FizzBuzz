using FizzBuzz.Constants;
using System.Linq;
using System.Text.RegularExpressions;

namespace FizzBuzz.Services
{
    public class CalculateFizzBuzzService : ICalculateFizzBuzzService
    {
        public List<string> CalculateFizzBuzz(string[] arr)
        {
            List<string> result = new List<string>();

            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[j].Any(char.IsDigit))
                {
                    int i = int.Parse(arr[j]);
                    if (i % 3 == 0 && i % 5 == 0)
                    {
                        result.Add(i + "-" + FizzBuzzConstants.FizzBuzz);
                    }
                    else if (i % 3 == 0)
                    {
                        result.Add(i + "-" + FizzBuzzConstants.Fizz);
                    }
                    else if (i % 5 == 0)
                    {
                        result.Add(i + "-" + FizzBuzzConstants.Buzz);
                    }
                    else
                    {
                        result.Add(i + "-" + FizzBuzzConstants.Dividedby3+ " " + FizzBuzzConstants.Dividedby5);
                    }
                }
                else
                {
                    result.Add(arr[j] + "-" + FizzBuzzConstants.InvalidItem);
                }
            }

            return result;
        }
    }
}
