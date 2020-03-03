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
        /*********
        ** Fields 
        *********/
        /// <summary>The database context.</summary>
        private readonly ApplicationDbContext Context;

        /// <summary>Provides access to log to the console.</summary>
        private readonly ILogger<ShadowService> Logger;


        /*********
        ** Public Methods 
        *********/
        /// <summary>Construct an instance.</summary>
        /// <param name="context">The database context.</param>
        /// <param name="logger">Provides access to log to the console.</param>
        public ShadowService(ApplicationDbContext context, ILogger<ShadowService> logger)
        {
            Context = context;
            Logger = logger;
        }

        /// <summary>Get all the shadow data.</summary>
        /// <returns>All shadow data.</returns>
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

        /// <summary>Get shadow data by name.</summary>
        /// <param name="name">The persona's name.</param>
        /// <returns>The data for the shadows that have the name.</returns>
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
