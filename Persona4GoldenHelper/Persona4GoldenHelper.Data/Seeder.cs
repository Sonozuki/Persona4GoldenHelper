using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Persona4GoldenHelper.Data.Data;

namespace Persona4GoldenHelper.Data
{
    public class Seeder
    {
        private readonly ApplicationDbContext Context;

        public Seeder(ApplicationDbContext context)
        {
            Context = context;
        }

        // Using foreach looks and SaveChanges after each object. This is to preserve the order. Any other methods to add all objects and save at the end but keeping order would be appreciated
        public void Seed()
        {
            Context.Database.EnsureCreated();

            if (!Context.Armor.Any())
            {
                foreach (var armor in ArmorData.Armor)
                {
                    Context.Armor.Add(armor);
                    Context.SaveChanges();
                }
            }

            if (!Context.Books.Any())
            {
                foreach (var book in BookData.Books)
                {
                    Context.Books.Add(book);
                    Context.SaveChanges();
                }
            }

            if (!Context.BookOrder.Any())
            {
                foreach (var bookOrder in BookData.BookOrder)
                {
                    Context.BookOrder.Add(bookOrder);
                    Context.SaveChanges();
                }
            }

            if (!Context.ExamAnswers.Any())
            {
                foreach (var examAnswer in ExamAnswerData.Answers)
                {
                    Context.ExamAnswers.Add(examAnswer);
                    Context.SaveChanges();
                }
            }

            if (!Context.Personas.Any())
            {
                foreach (var persona in PersonaData.Personas)
                {
                    Context.Personas.Add(persona);
                    Context.SaveChanges();
                }
            }

            if (!Context.Plants.Any())
            {
                foreach (var plant in PlantData.Plants)
                {
                    Context.Plants.Add(plant);
                    Context.SaveChanges();
                }
            }

            if (!Context.Quests.Any())
            {
                foreach (var quest in QuestData.Quests)
                {
                    Context.Quests.Add(quest);
                    Context.SaveChanges();
                }
            }

            if (!Context.Skills.Any())
            {
                foreach (var skill in SkillData.Skills)
                {
                    Context.Skills.Add(skill);
                    Context.SaveChanges();
                }
            }

            if (!Context.SkillCards.Any())
            {
                foreach (var skillCard in SkillCardData.SkillCards)
                {
                    Context.SkillCards.Add(skillCard);
                    Context.SaveChanges();
                }
            }
        }
    }
}
