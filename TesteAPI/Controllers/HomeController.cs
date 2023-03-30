using Microsoft.AspNetCore.Mvc;

namespace TesteAPI.Controllers
{
    public class HomeController : Controller
    {
        [Route("home/index")]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

    }
}


