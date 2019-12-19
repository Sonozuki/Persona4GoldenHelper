using Microsoft.AspNetCore.Mvc;
using Persona4GoldenHelper.Data;
using Persona4GoldenHelper.Models;

namespace Persona4GoldenHelper.Controllers
{
    [Route("ExamAnswers")]
    public class ExamAnswerController : Controller
    {
        private readonly IAnswer AnswerService;

        public ExamAnswerController(IAnswer answerService)
        {
            AnswerService = answerService;
        }

        [HttpGet]
        public IActionResult Index()
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
