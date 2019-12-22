using Microsoft.Extensions.Logging;
using Persona4GoldenHelper.Data;
using Persona4GoldenHelper.Data.Context;
using Persona4GoldenHelper.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Persona4GoldenHelper.Service
{
    public class SkillService : ISkill
    {
        private readonly SkillContext Context;
        private readonly ILogger<SkillService> Logger;

        public SkillService(SkillContext context, ILogger<SkillService> logger)
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
                    .ToList();
            }
            catch (Exception ex)
            {
                Logger.LogError($"GetAll failed: {ex}");
                return null;
            }
        }
    }
}
