using Microsoft.AspNetCore.Mvc;
using Persona4GoldenHelper.Data;
using Persona4GoldenHelper.Models;

namespace Persona4GoldenHelper.Controllers
{
    public class AppController : Controller
    {
        private readonly IBook BookService;
        private readonly IAnswer AnswerService;
        private readonly ISkill SkillService;

        public AppController(IBook bookService, IAnswer answerService, ISkill skillService)
        {
            BookService = bookService;
            AnswerService = answerService;
            SkillService = skillService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Books()
        {
            ViewBag.Title = "Books";

            var model = new BookListingViewModel
            {
                Books = BookService.GetAll(),
                BookOrder = BookService.GetOrder()
            };

            return View(model);
        }

        public IActionResult ExamAnswers()
        {
            ViewBag.Title = "Exam Answers";

            var model = new ExamAnswerListingViewModel
            {
                Answers = AnswerService.GetAll()
            };

            return View(model);
        }

        public IActionResult Skills()
        {
            ViewBag.Title = "Skills";

            var model = new SkillListingViewModel
            {
                Skills = SkillService.GetAll()
            };

            return View(model);
        }
    }
}
