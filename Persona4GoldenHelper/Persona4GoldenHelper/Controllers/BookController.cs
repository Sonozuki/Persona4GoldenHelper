using Microsoft.AspNetCore.Mvc;
using Persona4GoldenHelper.Data;

namespace Persona4GoldenHelper.Controllers
{
    [Route("Books")]
    public class BookController : Controller
    {
        private readonly IBook BookService;

        public BookController(IBook bookService)
        {
            BookService = bookService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Title = "Books";
            return View();
        }
    }
}
