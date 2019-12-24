using Microsoft.Extensions.Logging;
using Persona4GoldenHelper.Data;
using Persona4GoldenHelper.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Persona4GoldenHelper.Service
{
    public class SkillCardService : ISkillCard
    {
        private ApplicationDbContext Context;
        private ILogger<SkillCardService> Logger;

        public SkillCardService(ApplicationDbContext context, ILogger<SkillCardService> logger)
        {
            Context = context;
            Logger = logger;
        }

        public List<SkillCard> GetAll()
        {
            try
            {
                Logger.LogInformation("GetAll was called");

                return Context.SkillCards
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
