using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Persona4GoldenHelper.Data;
using Persona4GoldenHelper.Data.Data;
using Persona4GoldenHelper.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Persona4GoldenHelper.Service
{
    public class SkillService : ISkill
    {
        private readonly ApplicationDbContext Context;
        private readonly ILogger<SkillService> Logger;

        public SkillService(ApplicationDbContext context, ILogger<SkillService> logger)
        {
            Context = context;
            Logger = logger;
        }

        public List<Skill> GetAll()
        {
            try
            {
                Logger.LogInformation("GetAll was called");

                return Context.Skills
                    .Include(skill => skill.Personas)
                    .ToList();
            }
            catch (Exception ex)
            {
                Logger.LogError($"GetAll failed: {ex}");
                return null;
            }
        }

        public List<Skill> GetByPersona(Persona persona)
        {
            try
            {
                Logger.LogInformation("GetByPersona was called");

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
                Logger.LogError($"GetByPersona failed: {ex}");
                return null;
            }
        }
    }
}
