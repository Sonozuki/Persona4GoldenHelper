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
        List<Skill> GetSkillsByPersona(Persona persona);
        List<Skill> GetSkillsByShadow(Shadow shadow);
        List<Quest> GetAllQuests();
        List<SkillCard> GetAllSkillCards();
        List<SkillCardLocation> GetAllSkillCardLocations();
        List<Lunch> GetAllLunches();
        List<Source> GetAllSources();
        List<Accessory> GetAllAccessories();
        List<Armor> GetAllArmor();
    }
}
