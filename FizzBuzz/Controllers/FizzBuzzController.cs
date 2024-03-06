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
        public ActionResult PrintFizzBuzz(List<string> list)
        {
                var result = _fizzBuzzService.CalculateFizzBuzz(list);
                return Ok(result);
            
        }
    }
}
