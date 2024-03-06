using FizzBuzz.Constants;
using System.Linq;
using System.Text.RegularExpressions;

namespace FizzBuzz.Services
{
    public class CalculateFizzBuzzService : ICalculateFizzBuzzService
    {
        public List<string> CalculateFizzBuzz(List<string> list)
        {
            List<string> result = new List<string>();
            int i;
            if (list.Count > 0)
            {
                foreach (string item in list)
                {
                    if (int.TryParse(item, out i))
                    {
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
                            result.Add(i + "-" + FizzBuzzConstants.Dividedby3);

                            result.Add(i + "-" + FizzBuzzConstants.Dividedby5);
                        }
                    }
                    else
                    {
                        result.Add(item + "-" + FizzBuzzConstants.InvalidItem);
                    }
                }
            }
            return result;
        }
    }
}
