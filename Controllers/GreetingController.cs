using Microsoft.AspNetCore.Mvc;

namespace ConsoleApplication
{
    [Route("api/[controller]")]
    public class GreetingController
    {
        [HttpGet]
        public string Get()
        {
            return "Greetings from .NET Core Web API!";
        }
    }
}
