using FizzBuzz.Services;
using Microsoft.AspNetCore.Mvc;

namespace FizzBuzz.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class FizzBuzzController : Controller
    {

        private readonly IFizzBuzzService _fizzBuzzService;

        public FizzBuzzController(IFizzBuzzService fizzBuzzService)
        {
            _fizzBuzzService = fizzBuzzService;
        }


        [HttpPost]
        public ActionResult PrintFizzBuzz(int[] arr)
        {
            var res = _fizzBuzzService.PrintFizzBuzz(arr);
            return Ok(res);
        }
    }
}
