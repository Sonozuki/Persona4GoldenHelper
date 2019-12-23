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
    public class PersonaService : IPersona
    {
        private readonly ApplicationDbContext Context;
        private readonly ILogger<PersonaService> Logger;

        public PersonaService(ApplicationDbContext context, ILogger<PersonaService> logger)
        {
            Context = context;
            Logger = logger;
        }

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
