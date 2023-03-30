using Microsoft.AspNetCore.Mvc;

namespace TesteAPI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return File("~/index.html", "text/html");
        }
    }

}
