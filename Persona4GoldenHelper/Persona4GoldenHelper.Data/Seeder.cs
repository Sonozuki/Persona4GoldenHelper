using System.Linq;
using Persona4GoldenHelper.Data.Data;
using Persona4GoldenHelper.Data.Data.Calculator;

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

            if (!Context.Accessories.Any())
            {
                foreach (var accessory in AccessoryData.Accessories)
                {
                    Context.Accessories.Add(accessory);
                    Context.SaveChanges();
                }
            }

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

            if (!Context.Lunches.Any())
            {
                foreach (var lunch in LunchData.Lunches)
                {
                    Context.Lunches.Add(lunch);
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

            if (!Context.Shadows.Any())
            {
                foreach (var shadow in ShadowData.Shadows)
                {
                    Context.Shadows.Add(shadow);
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

            if (!Context.SkillCardLocations.Any())
            {
                foreach (var skillCardLocation in SkillCardData.SkillCardLocations)
                {
                    Context.SkillCardLocations.Add(skillCardLocation);
                    Context.SaveChanges();
                }
            }

            if (!Context.Weapons.Any())
            {
                foreach (var weapon in WeaponData.Weapons)
                {
                    Context.Weapons.Add(weapon);
                    Context.SaveChanges();
                }
            }

            if (!Context.ArcanaFusionResults.Any())
            {
                foreach (var fusionResult in ArcanaFusionResultData.ArcanaFusions)
                {
                    Context.ArcanaFusionResults.Add(fusionResult);
                    Context.SaveChanges();
                }
            }

            if (!Context.SpecialFusionResults.Any())
            {
                foreach (var fusionResult in SpecialFusionResultData.SpecialFusions)
                {
                    Context.SpecialFusionResults.Add(fusionResult);
                    Context.SaveChanges();
                }
            }

            if (!Context.ArcanaRanks.Any())
            {
                foreach (var arcana in ArcanaRankData.Arcanas)
                {
                    Context.ArcanaRanks.Add(arcana);
                    Context.SaveChanges();
                }
            }
        }
    }
}
