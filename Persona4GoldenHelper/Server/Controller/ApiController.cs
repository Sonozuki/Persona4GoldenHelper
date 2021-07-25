using Microsoft.AspNetCore.Mvc;
using Persona4GoldenHelper.Server.Data;
using Persona4GoldenHelper.Shared.Models;
using System.Collections.Generic;

namespace Persona4GoldenHelper.Server.Controller
{
    /// <summary>Provides APIs that exposes all internal data.</summary>
    [ApiController]
    [Route("[controller]/[action]")]
    public class ApiController : ControllerBase
    {
        /*********
        ** Public Methods
        *********/
        /// <summary>Retrieves all persona data.</summary>
        /// <returns>All persona data.</returns>
        [HttpGet]
        public List<Persona> GetAllPersonas() => PersonaData.Personas;

        /// <summary>Retrieves all skill data.</summary>
        /// <returns>All skill data.</returns>
        [HttpGet]
        public List<Skill> GetAllSkills() => SkillData.Skills;

        /// <summary>Retrieves all book data.</summary>
        /// <returns>All books data.</returns>
        [HttpGet]
        public List<Book> GetAllBooks() => BookData.Books;

        /// <summary>Retrieves the book order.</summary>
        /// <returns>The book order.</returns>
        [HttpGet]
        public List<string> GetBookOrder() => BookData.BookOrder;

        /// <summary>Retrieves all weapon data.</summary>
        /// <returns>All weapon data.</returns>
        [HttpGet]
        public List<Weapon> GetAllWeapons() => WeaponData.Weapons;

        /// <summary>Retrieves all armour data.</summary>
        /// <returns>All armour data.</returns>
        [HttpGet]
        public List<Armour> GetAllArmour() => ArmourData.Armour;

        /// <summary>Retrieves all accessory data.</summary>
        /// <returns>All accessory data.</returns>
        [HttpGet]
        public List<Accessory> GetAllAccessories() => AccessoryData.Accessories;

        /// <summary>Retrieves all exam answer data.</summary>
        /// <returns>All exam answer data.</returns>
        [HttpGet]
        public List<ExamAnswer> GetAllExamAnswers() => ExamAnswerData.ExamAnswers;

        /// <summary>Retrieves all plant data.</summary>
        /// <returns>All plant data.</returns>
        [HttpGet]
        public List<Plant> GetAllPlants() => PlantData.Plants;

        /// <summary>Retrieves all quest data.</summary>
        /// <returns>All quest data.</returns>
        [HttpGet]
        public List<Quest> GetAllQuests() => QuestData.Quests;

        /// <summary>Retrieves all shadow data.</summary>
        /// <returns>All shadow data.</returns>
        [HttpGet]
        public List<Shadow> GetAllShadows() => ShadowData.Shadows;

        /// <summary>Retrieves all lunch data.</summary>
        /// <returns>All lunch data.</returns>
        [HttpGet]
        public List<Lunch> GetAllLunches() => LunchData.Lunches;

        /// <summary>Retrieves all skill card location data.</summary>
        /// <returns>All skil card location data.</returns>
        [HttpGet]
        public List<SkillCardLocation> GetAllSkillCardLocations() => SkillCardData.SkillCardLocations;

        /// <summary>Retrieves all skill card data.</summary>
        /// <returns>All skill card data.</returns>
        [HttpGet]
        public List<SkillCard> GetAllSkillCards() => SkillCardData.SkillCards;
    }
}
