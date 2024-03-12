using FizzBuzzApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace FizzBuzzApp.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class FizzBuzzController : Controller
    {

        private readonly IFizzBuzzCalculator _fizzBuzzService;

        public FizzBuzzController(IFizzBuzzCalculator fizzBuzzService)
        {
            _fizzBuzzService = fizzBuzzService;
        }


        [HttpPost]
        public ActionResult CalculateFizzBuzz(List<string> list)
        {
              var result = _fizzBuzzService.CalculateFizzBuzz(list);
              return Ok(result);
        }
    }
}
