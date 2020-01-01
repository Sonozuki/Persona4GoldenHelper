using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Persona4GoldenHelper.Data;
using Persona4GoldenHelper.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Persona4GoldenHelper.Service
{
    public class ShadowService : IShadow
    {
        private readonly ApplicationDbContext Context;
        private readonly ILogger<ShadowService> Logger;

        public ShadowService(ApplicationDbContext context, ILogger<ShadowService> logger)
        {
            Context = context;
            Logger = logger;
        }

        public List<Shadow> GetAll()
        {
            try
            {
                Logger.LogInformation("GetAll was called");

                return Context.Shadows
                    .Include(shadow => shadow.Stats)
                    .Include(shadow => shadow.Elements)
                    .ToList();
            }
            catch (Exception ex)
            {
                Logger.LogError($"GetAll failed: {ex}");
                return null;
            }
        }

        public List<Shadow> GetByName(string shadowName)
        {
            try
            {
                Logger.LogInformation("GetByName was called");

                return Context.Shadows
                    .Where(shadow => shadow.Name.ToLower() == shadowName.ToLower())
                    .Include(shadow => shadow.Stats)
                    .Include(shadow => shadow.Elements)
                    .Include(shadow => shadow.Skills)
                    .ToList();
            }
            catch (Exception ex)
            {
                Logger.LogError($"GetByName failed: {ex}");
                return null;
            }
        }
    }
}
