using Microsoft.AspNetCore.Mvc;
using Persona4GoldenHelper.Data;
using Persona4GoldenHelper.Models;

namespace Persona4GoldenHelper.Controllers
{
    public class AppController : Controller
    {
        private readonly IBook BookService;
        private readonly IAnswer AnswerService;

        public AppController(IBook bookService, IAnswer answerService)
        {
            BookService = bookService;
            AnswerService = answerService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Books()
        {
            ViewBag.Title = "Books";

            var model = new BookViewModel();
            model.Books = BookService.GetAll();
            model.BookOrder = BookService.GetOrder();

            return View(model);
        }

        public IActionResult ExamAnswers()
        {
            ViewBag.Title = "Exam Answers";

            var model = new ExamAnswerViewModel();
            model.April = AnswerService.GetByMonth("April");
            model.May = AnswerService.GetByMonth("May");
            model.June = AnswerService.GetByMonth("June");
            model.July = AnswerService.GetByMonth("July");
            model.August = AnswerService.GetByMonth("August");
            model.September = AnswerService.GetByMonth("September");
            model.October = AnswerService.GetByMonth("October");
            model.November = AnswerService.GetByMonth("November");
            model.December = AnswerService.GetByMonth("December");
            model.Janurary = AnswerService.GetByMonth("Janurary");
            model.February = AnswerService.GetByMonth("February");

            return View(model);
        }
    }
}
