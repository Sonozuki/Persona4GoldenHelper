﻿using Microsoft.AspNetCore.Mvc;
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
            ViewBag.Title = "Index";

            var model = new SourceListingViewModel()
            {
                Sources = AppService.GetAllSources()
            };

            return View(model);
        }

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
    }
}
