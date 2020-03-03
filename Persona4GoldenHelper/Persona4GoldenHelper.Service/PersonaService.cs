using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Persona4GoldenHelper.Data;
using Persona4GoldenHelper.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Persona4GoldenHelper.Service
{
    public class PersonaService : IPersona
    {
        /*********
        ** Fields 
        *********/
        /// <summary>The database context.</summary>
        private readonly ApplicationDbContext Context;

        /// <summary>Provides access to log to the console.</summary>
        private readonly ILogger<PersonaService> Logger;


        /*********
        ** Public Methods 
        *********/
        /// <summary>Construct an instance.</summary>
        /// <param name="context">The database context.</param>
        /// <param name="logger">Provides access to log to the console.</param>
        public PersonaService(ApplicationDbContext context, ILogger<PersonaService> logger)
        {
            Context = context;
            Logger = logger;
        }

        /// <summary>Get all the persona data.</summary>
        /// <returns>All persona data.</returns>
        public List<Persona> GetAll()
        {
            try
            {
                Logger.LogInformation("GetAll was called");

                return Context.Personas
                    .Include(persona => persona.Stats)
                    .Include(persona => persona.Elements)
                    .ToList();
            }
            catch (Exception ex)
            {
                Logger.LogError($"GetAll failed: {ex}");
                return null;
            }
        }

        /// <summary>Get persona data by name.</summary>
        /// <param name="name">The persona's name.</param>
        /// <returns>The persona data.</returns>
        public Persona GetByName(string personaName)
        {
            try
            {
                Logger.LogInformation("GetByName was called");

                return Context.Personas
                    .Where(persona => persona.Name.ToLower() == personaName.ToLower())
                    .Include(persona => persona.Stats)
                    .Include(persona => persona.Elements)
                    .Include(persona => persona.Skills)
                    .FirstOrDefault();
            }
            catch (Exception ex)
            {
                Logger.LogError($"GetByName failed: {ex}");
                return null;
            }
        }
    }
}
