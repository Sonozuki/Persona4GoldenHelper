using Microsoft.AspNetCore.Mvc;
using Persona4GoldenHelper.Data;
using Persona4GoldenHelper.Models;

namespace Persona4GoldenHelper.Controllers
{
    /// <summary>Provides a web UI for all basic data views.</summary>
    public class AppController : Controller
    {
        /*********
        ** Fields
        *********/
        /// <summary>Provides access to basic data apis.</summary>
        private readonly IApp AppService;


        /*********
        ** Fields
        *********/
        /****
        ** Constructor
        ****/
        /// <summary>Construct an instance.</summary>
        /// <param name="appService">Provides access to basic data apis.</param>
        public AppController(IApp appService)
        {
            AppService = appService;
        }

        /****
        ** Web UI
        ****/
        /// <summary>Render the data sources UI.</summary>
        public IActionResult Index()
        {
            ViewBag.Title = "Index";

            return View();
        }

        /// <summary>Render the books UI.</summary>
        public IActionResult Books()
        {
            ViewBag.Title = "Books";
            ViewBag.HaveSearchBar = true;

            var model = new BookListingViewModel
            {
                Books = AppService.GetAllBooks(),
                BookOrder = AppService.GetBookOrder()
            };

            return View(model);
        }

        /// <summary>Renders the exam answers UI.</summary>
        public IActionResult ExamAnswers()
        {
            ViewBag.Title = "Exam Answers";
            ViewBag.HaveSearchBar = true;

            var model = new ExamAnswerListingViewModel
            {
                Answers = AppService.GetAllExamAnswers()
            };

            return View(model);
        }

        /// <summary>Renders the skills UI.</summary>
        public IActionResult Skills()
        {
            ViewBag.Title = "Skills";
            ViewBag.HaveSearchBar = true;

            var model = new SkillListingViewModel
            {
                Skills = AppService.GetAllSkills()
            };

            return View(model);
        }

        /// <summary>Renders the quests UI.</summary>
        public IActionResult Quests()
        {
            ViewBag.Title = "Quests";
            ViewBag.HaveSearchBar = true;

            var model = new QuestListingViewModel
            {
                Quests = AppService.GetAllQuests()
            };

            return View(model);
        }

        /// <summary>Renders the skill card UI.</summary>
        public IActionResult SkillCards()
        {
            ViewBag.Title = "Skill Cards";
            ViewBag.HaveSearchBar = true;

            var model = new SkillCardListingViewModel
            {
                SkillCards = AppService.GetAllSkillCards(),
                SkillCardLocations = AppService.GetAllSkillCardLocations()
            };

            return View(model);
        }

        /// <summary>Renders the lunch UI.</summary>
        public IActionResult Lunches()
        {
            ViewBag.Title = "Lunches";
            ViewBag.HaveSearchBar = true;

            var model = new LunchListingViewModel()
            {
                Lunches = AppService.GetAllLunches()
            };

            return View(model);
        }

        /// <summary>Renders the accessory UI.</summary>
        public IActionResult Accessories()
        {
            ViewBag.Title = "Accessories";
            ViewBag.HaveSearchBar = true;

            var model = new AccessoryListingViewModel()
            {
                Accessories = AppService.GetAllAccessories()
            };

            return View(model);
        }

        /// <summary>Renders the armor UI.</summary>
        public IActionResult Armor()
        {
            ViewBag.Title = "Armor";
            ViewBag.HaveSearchBar = true;

            var model = new ArmorListingViewModel()
            {
                Armor = AppService.GetAllArmor()
            };

            return View(model);
        }

        /// <summary>Renders the weapons UI.</summary>
        public IActionResult Weapons()
        {
            ViewBag.Title = "Weapons";
            ViewBag.HaveSearchBar = true;

            var model = new WeaponListingViewModel()
            {
                Weapons = AppService.GetAllWeapons()
            };

            return View(model);
        }

        /// <summary>Renders the gardening UI.</summary>
        public IActionResult Gardening()
        {
            ViewBag.Title = "Gardening";

            var model = new PlantListingViewModel()
            {
                Plants = AppService.GetAllPlants()
            };

            return View(model);
        }
    }
}
