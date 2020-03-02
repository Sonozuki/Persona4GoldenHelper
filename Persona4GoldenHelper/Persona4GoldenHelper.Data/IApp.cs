using Persona4GoldenHelper.Data.Models;
using System.Collections.Generic;

namespace Persona4GoldenHelper.Data
{
    public interface IApp
    {
        List<Book> GetAllBooks();
        List<BookOrder> GetBookOrder();
        List<Answer> GetAllExamAnswers();
        List<Skill> GetAllSkills();
        List<Skill> GetSkillsByPersonaName(string name);
        List<Skill> GetSkillsByShadowName(string name, string shadowType);
        List<Quest> GetAllQuests();
        List<SkillCard> GetAllSkillCards();
        List<SkillCardLocation> GetAllSkillCardLocations();
        List<Lunch> GetAllLunches();
        List<Accessory> GetAllAccessories();
        List<Armor> GetAllArmor();
        List<Weapon> GetAllWeapons();
        List<Plant> GetAllPlants();
    }
}
