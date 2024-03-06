using FizzBuzz.Services;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Text.RegularExpressions;

namespace FizzBuzz.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class FizzBuzzController : Controller
    {

        private readonly ICalculateFizzBuzzService _fizzBuzzService;

        public FizzBuzzController(ICalculateFizzBuzzService fizzBuzzService)
        {
            _fizzBuzzService = fizzBuzzService;
        }


        [HttpPost]
        public ActionResult PrintFizzBuzz(string[] arr)
        {
            bool allints = arr.All(x => Regex.IsMatch(x, @"^[0-9]*$"));

            if (allints)
            {
                var result = _fizzBuzzService.CalculateFizzBuzz(arr);
                return Ok(result);
            }
            else
            {
                return BadRequest("Invalid Item.");
            }

        }
    }
}
