using Microsoft.AspNetCore.Mvc;
using Persona4GoldenHelper.Data;
using Persona4GoldenHelper.Models;

namespace Persona4GoldenHelper.Controllers
{
    public class AppController : Controller
    {
        private readonly IApp AppService;

        public AppController(IApp appService)
        {
            AppService = appService;
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
                Books = AppService.GetAllBooks(),
                BookOrder = AppService.GetBookOrder()
            };

            return View(model);
        }

        public IActionResult ExamAnswers()
        {
            ViewBag.Title = "Exam Answers";

            var model = new ExamAnswerListingViewModel
            {
                Answers = AppService.GetAllExamAnswers()
            };

            return View(model);
        }

        public IActionResult Skills()
        {
            ViewBag.Title = "Skills";

            var model = new SkillListingViewModel
            {
                Skills = AppService.GetAllSkills()
            };

            return View(model);
        }

        public IActionResult Quests()
        {
            ViewBag.Title = "Quests";

            var model = new QuestListingViewModel
            {
                Quests = AppService.GetAllQuests()
            };

            return View(model);
        }

        public IActionResult SkillCards()
        {
            ViewBag.Title = "Skill Cards";

            var model = new SkillCardListingViewModel
            { 
                SkillCards = AppService.GetAllSkillCards()
            };

            return View(model);
        }
    }
}
