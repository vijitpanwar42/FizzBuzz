namespace FizzBuzz.Services
{
    public class FizzBuzzService : IFizzBuzzService
    {
        public Dictionary<int, string> PrintFizzBuzz(int[] arr)
        {
            Dictionary<int,string> result = new Dictionary<int, string>();

            for (int i = 0; i <= arr.Length - 1; i++)
            {
                if (arr[i] % 3 == 0 && arr[i] % 5 == 0)
                {
                    result.Add(arr[i],"FizzBuzz");
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
                    result.Add(arr[i],"Divided " + arr[i].ToString() + " by 3 " + "Divided " + arr[i].ToString() + " by 5");
                }
            }
            return result;
        }
    }
}
