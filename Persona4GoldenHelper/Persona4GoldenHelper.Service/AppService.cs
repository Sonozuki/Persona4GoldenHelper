using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Persona4GoldenHelper.Data;
using Persona4GoldenHelper.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Persona4GoldenHelper.Service
{
    /// <summary>Provides basic data apis.</summary>
    public class AppService : IApp
    {
        /*********
        ** Fields 
        *********/
        /// <summary>The database context.</summary>
        private readonly ApplicationDbContext Context;

        /// <summary>Provides access to log to the console.</summary>
        private readonly ILogger<AppService> Logger;

        /// <summary>Provides access to persona apis.</summary>
        private readonly IPersona PersonaService;

        /// <summary>Provides access to shadow apis.</summary>
        private readonly IShadow ShadowService;


        /*********
        ** Public Methods 
        *********/
        /// <summary>Construct an instance.</summary>
        /// <param name="context">The database context.</param>
        /// <param name="logger">Provides access to log to the console.</param>
        /// <param name="personaService">Provides access to persona apis.</param>
        /// <param name="shadowService">Provides access to shadow apis.</param>
        public AppService(ApplicationDbContext context, ILogger<AppService> logger, IPersona personaService, IShadow shadowService)
        {
            Context = context;
            Logger = logger;
            PersonaService = personaService;
            ShadowService = shadowService;
        }

        /// <summary>Get all the book data.</summary>
        /// <returns>All book data.</returns>
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

        /// <summary>Get the order the books are rendered in the player inventory.</summary>
        /// <returns>The books order.</returns>
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

        /// <summary>Get all the exam answers data.</summary>
        /// <returns>All exam answers data.</returns>
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

        /// <summary>Get all skill data.</summary>
        /// <returns>All skill data.</returns>
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

        /// <summary>Get all the skills by persona name.</summary>
        /// <param name="name">The name of the persona to get skills.</param>
        /// <returns>The skills the persona has by default.</returns>
        public List<Skill> GetSkillsByPersonaName(string name)
        {
            try
            {
                Logger.LogInformation("GetSkillsByPersona was called");

                var persona = PersonaService.GetByName(name);
                if (persona == null)
                {
                    return null;
                }

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

        /// <summary>Get all the skills by shadow name and type</summary>
        /// <param name="name">The name of shadow to get skills.</param>
        /// <param name="type">The type of shadow to get skills.</param>
        /// <returns>The skills the shadow has.</returns>
        public List<Skill> GetSkillsByShadowName(string name, string shadowType)
        {
            try
            {
                Logger.LogInformation("GetSkillsByShadow was called");

                var shadows = ShadowService.GetByName(name);
                var shadow = shadows
                    .Where(s => s.Type.ToString().ToLower() == shadowType.ToLower())
                    .FirstOrDefault();

                if (shadow == null)
                {
                    return null;
                }

                List<string> skillNames = new List<string>();
                foreach (ShadowSkill skill in shadow.Skills)
                {
                    skillNames.Add(skill.Name);
                }

                List<Skill> skills = new List<Skill>();
                foreach (string skillName in skillNames)
                {
                    skills.Add(Context.Skills
                        .Where(skill => skill.Name == skillName)
                        .FirstOrDefault());
                }

                return skills;
            }
            catch (Exception ex)
            {
                Logger.LogError($"GetSkillsByShadow failed: {ex}");
                return null;
            }
        }

        /// <summary>Get all the quest data.</summary>
        /// <returns>All quest data.</returns>
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

        /// <summary>Get all the skill card data.</summary>
        /// <returns>All skill card data.</returns>
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

        /// <summary>Get all the skill card locations data.</summary>
        /// <returns>All skill card locations data.</returns>
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

        /// <summary>Get all the lunch data.</summary>
        /// <returns>All lunch data.</returns>
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

        /// <summary>Get all the accessory data.</summary>
        /// <returns>All accessory data.</returns>
        public List<Accessory> GetAllAccessories()
        {
            try
            {
                Logger.LogInformation("GetAllAccessories was called");

                return Context.Accessories
                    .Include(accessory => accessory.Obtained)
                    .ToList();
            }
            catch (Exception ex)
            {
                Logger.LogError($"GetAllAccessories failed: {ex}");
                return null;
            }
        }

        /// <summary>Get all the armor data.</summary>
        /// <returns>All armor data.</returns>
        public List<Armor> GetAllArmor()
        {
            try
            {
                Logger.LogInformation("GetAllArmor was called");

                return Context.Armor
                    .Include(armor => armor.Obtained)
                    .ToList();
            }
            catch (Exception ex)
            {
                Logger.LogError($"GetAllArmor failed: {ex}");
                return null;
            }
        }

        /// <summary>Get all the weapon data.</summary>
        /// <returns>All weapon data.</returns>
        public List<Weapon> GetAllWeapons()
        {
            try
            {
                Logger.LogInformation("GetAllWeapons was called");

                return Context.Weapons
                    .Include(weapon => weapon.Obtained)
                    .ToList();
            }
            catch (Exception ex)
            {
                Logger.LogError($"GetAllWeapons failed: {ex}");
                return null;
            }
        }

        /// <summary>Get all the plant data.</summary>
        /// <returns>All plant data.</returns>
        public List<Plant> GetAllPlants()
        {
            try
            {
                Logger.LogInformation("GetAllPlants was called");

                return Context.Plants
                    .Include(plant => plant.Seed)
                    .Include(plant => plant.Products)
                    .ToList();
            }
            catch (Exception ex)
            {
                Logger.LogError($"GetAllPlants failed: {ex}");
                return null;
            }
        }
    }
}
