using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreApiWithMiddleware.Controllers
{
    [Route("/api/v1/messages")]
    public class MessageController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> GetMessage([FromQuery(Name = "name")] string name)
        {
            Console.WriteLine("GetMessage run!");
            return Ok($"Here's your message, {name}!");
        }
    }
}
