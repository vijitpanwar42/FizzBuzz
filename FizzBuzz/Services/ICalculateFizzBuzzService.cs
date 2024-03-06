namespace FizzBuzz.Services
{
    public interface ICalculateFizzBuzzService
    {
        Dictionary<int,string> CalculateFizzBuzz(string[] arr);
    }
}
