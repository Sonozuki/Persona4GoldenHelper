using Microsoft.Extensions.Logging;
using Persona4GoldenHelper.Data;
using Persona4GoldenHelper.Data.Context;
using Persona4GoldenHelper.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Persona4GoldenHelper.Service
{
    public class PersonaService : IPersona
    {
        private readonly PersonaContext Context;
        private readonly ILogger<PersonaService> Logger;

        public PersonaService(PersonaContext context, ILogger<PersonaService> logger)
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
