using Persona4GoldenHelper.Data.Models;
using System.Collections.Generic;

namespace Persona4GoldenHelper.Data
{
    /// <summary>Provides basic data apis.</summary>
    public interface IApp
    {
        /// <summary>Get all the book data.</summary>
        /// <returns>All book data.</returns>
        List<Book> GetAllBooks();

        /// <summary>Get the order the books are rendered in the player inventory.</summary>
        /// <returns>The books order.</returns>
        List<BookOrder> GetBookOrder();

        /// <summary>Get all the exam answers data.</summary>
        /// <returns>All exam answers data.</returns>
        List<Answer> GetAllExamAnswers();

        /// <summary>Get all skill data.</summary>
        /// <returns>All skill data.</returns>
        List<Skill> GetAllSkills();

        /// <summary>Get all the skills by persona name.</summary>
        /// <param name="name">The name of the persona to get skills.</param>
        /// <returns>The skills the persona has by default.</returns>
        List<Skill> GetSkillsByPersonaName(string name);

        /// <summary>Get all the skills by shadow name and type</summary>
        /// <param name="name">The name of shadow to get skills.</param>
        /// <param name="type">The type of shadow to get skills.</param>
        /// <returns>The skills the shadow has.</returns>
        List<Skill> GetSkillsByShadowName(string name, string shadowType);

        /// <summary>Get all the quest data.</summary>
        /// <returns>All quest data.</returns>
        List<Quest> GetAllQuests();

        /// <summary>Get all the skill card data.</summary>
        /// <returns>All skill card data.</returns>
        List<SkillCard> GetAllSkillCards();

        /// <summary>Get all the skill card locations data.</summary>
        /// <returns>All skill card locations data.</returns>
        List<SkillCardLocation> GetAllSkillCardLocations();

        /// <summary>Get all the lunch data.</summary>
        /// <returns>All lunch data.</returns>
        List<Lunch> GetAllLunches();

        /// <summary>Get all the accessory data.</summary>
        /// <returns>All accessory data.</returns>
        List<Accessory> GetAllAccessories();

        /// <summary>Get all the armor data.</summary>
        /// <returns>All armor data.</returns>
        List<Armor> GetAllArmor();

        /// <summary>Get all the weapon data.</summary>
        /// <returns>All weapon data.</returns>
        List<Weapon> GetAllWeapons();

        /// <summary>Get all the plant data.</summary>
        /// <returns>All plant data.</returns>
        List<Plant> GetAllPlants();
    }
}
