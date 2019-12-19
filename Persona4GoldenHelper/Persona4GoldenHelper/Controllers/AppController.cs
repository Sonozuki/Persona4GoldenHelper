using Microsoft.AspNetCore.Mvc;

namespace Persona4GoldenHelper.Controllers
{
    public class AppController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
