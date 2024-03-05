namespace FizzBuzz.Services
{
    public class FizzBuzzService : IFizzBuzzService
    {
        public string PrintFizzBuzz(int i)
        {
            string res = string.Empty;

            if (i % 3 == 0 && i % 5 == 0)
            {
                res = "FizzBuzz";
            }
            else if (i % 3 == 0)
            {
                res = "Fizz";
            }
            else if (i % 5 == 0)
            {
                res = "Buzz";
            }
            else
            {
                res = "Divided " + i.ToString() + " by 3\n" + "Divided " + i.ToString() + " by 5";
            }
            return res;
        }
    }
}
