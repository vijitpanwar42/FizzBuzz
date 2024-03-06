using System.Text.RegularExpressions;

namespace FizzBuzz.Services
{
    public class CalculateFizzBuzzService : ICalculateFizzBuzzService
    {
        public Dictionary<int, string> CalculateFizzBuzz(string[] arrString)
        {
            Dictionary<int,string> result = new Dictionary<int, string>();

            int[] arr = arrString.Select(s => int.Parse(s)).ToArray();
            

            for (int i = 0; i <= arr.Length - 1; i++)
            {
                if (arr[i] % 3 == 0 && arr[i] % 5 == 0)
                {
                    result.Add(arr[i], "FizzBuzz");
                }
                else if (arr[i] % 3 == 0)
                {
                    result.Add(arr[i], "Fizz");
                }
                else if (arr[i] % 5 == 0)
                {
                    result.Add(arr[i], "Buzz");
                }
                else
                {
                    result.Add(arr[i], "Divided " + arr[i].ToString() + " by 3 " + "Divided " + arr[i].ToString() + " by 5");
                }
            }
            return result;
        }
    }
}
