using Microsoft.AspNetCore.Mvc;
using Persona4GoldenHelper.Data;
using Persona4GoldenHelper.Models;
using Persona4GoldenHelper.Service;

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

            var model = new BookViewModel();
            model.Books = BookService.GetAll();
            model.BookOrder = BookService.GetOrder();

            return View(model);
        }
    }
}
