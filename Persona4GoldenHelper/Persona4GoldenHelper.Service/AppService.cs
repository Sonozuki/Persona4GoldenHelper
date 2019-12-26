using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Persona4GoldenHelper.Data;
using Persona4GoldenHelper.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Persona4GoldenHelper.Service
{
    public class AppService : IApp
    {
        private readonly ApplicationDbContext Context;
        private readonly ILogger<AppService> Logger;

        public AppService(ApplicationDbContext context, ILogger<AppService> logger)
        {
            Context = context;
            Logger = logger;
        }

        public List<Book> GetAllBooks()
        {
            try
            {
                Logger.LogInformation("GetAllBooks was called");

                return Context.Books.ToList();
            }
            catch (Exception ex)
            {
                Logger.LogError($"GetAllBooks failed: {ex}");
                return null;
            }
        }

        public List<BookOrder> GetBookOrder()
        {
            try
            {
                Logger.LogInformation("GetBookOrder was called");

                return Context.BookOrder.ToList();
            }
            catch (Exception ex)
            {
                Logger.LogError($"GetBookOrder failed {ex}");
                return null;
            }
        }

        public List<Answer> GetAllExamAnswers()
        {
                try
                {
                    Logger.LogInformation("GetAllExamAnswers was called");

                    return Context.ExamAnswers
                        .ToList();
                }
                catch (Exception ex)
                {
                    Logger.LogError($"GetAllExamAnswers failed: {ex}");
                    return null;
                }
        }

        public List<Skill> GetAllSkills()
        {
            try
            {
                Logger.LogInformation("GetAllSkills was called");

                return Context.Skills
                    .Include(skill => skill.Personas)
                    .ToList();
            }
            catch (Exception ex)
            {
                Logger.LogError($"GetAllSkills failed: {ex}");
                return null;
            }
        }

        public List<Skill> GetSkillsByPersona(Persona persona)
        {
            try
            {
                Logger.LogInformation("GetSkillsByPersona was called");

                // the reason this was done and a direct linq return wasn't used is to keep the current order of skills
                List<string> skillNames = new List<string>();
                foreach (PersonaSkill skillStripped in persona.Skills)
                {
                    skillNames.Add(skillStripped.Name);
                }

                List<Skill> fullSkills = new List<Skill>();
                foreach (string skillName in skillNames)
                {
                    fullSkills.Add(Context.Skills
                        .Where(skill => skill.Name == skillName)
                        .FirstOrDefault());
                }

                return fullSkills;
            }
            catch (Exception ex)
            {
                Logger.LogError($"GetSkillsByPersona failed: {ex}");
                return null;
            }
        }

        public List<Quest> GetAllQuests()
        {
            try
            {
                Logger.LogInformation("GetAllQuests was called");

                return Context.Quests
                    .ToList();
            }
            catch (Exception ex)
            {
                Logger.LogError($"GetAllQuests failed: {ex}");
                return null;
            }
        }

        public List<SkillCard> GetAllSkillCards()
        {
            try
            {
                Logger.LogInformation("GetAllSkillCards was called");

                return Context.SkillCards
                    .ToList();
            }
            catch (Exception ex)
            {
                Logger.LogError($"GetAllSkillCards failed: {ex}");
                return null;
            }
        }

        public List<SkillCardLocation> GetAllSkillCardLocations()
        {
            try
            {
                Logger.LogInformation("GetSkillCardLocations was called");

                return Context.SkillCardLocations
                    .ToList();
            }
            catch (Exception ex)
            {
                Logger.LogError($"GetSkillCardLocations failed: {ex}");
                return null;
            }
        }

        public List<Lunch> GetAllLunches()
        {
            try
            {
                Logger.LogInformation("GetAllLunches was called");

                return Context.Lunches
                    .ToList();
            }
            catch (Exception ex)
            {
                Logger.LogError($"GetAllLunches failed: {ex}");
                return null;
            }
        }
    }
}
