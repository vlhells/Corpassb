using Microsoft.AspNetCore.Mvc;

namespace Corpassb.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
