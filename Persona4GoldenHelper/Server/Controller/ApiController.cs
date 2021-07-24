using Microsoft.AspNetCore.Mvc;
using Persona4GoldenHelper.Server.Data;
using Persona4GoldenHelper.Shared.Models;
using System.Collections.Generic;

namespace Persona4GoldenHelper.Server.Controller
{
    /// <summary>Provides APIs that exposes all internal data.</summary>
    [ApiController]
    [Route("[controller]/[action]")]
    public class ApiController : ControllerBase
    {
        /*********
        ** Public Methods
        *********/
        /// <summary>Retrieves all persona data.</summary>
        /// <returns>All persona data.</returns>
        [HttpGet]
        public List<Persona> GetAllPersonas() => PersonaData.Personas;

        /// <summary>Retrieves all skill data.</summary>
        /// <returns>All skill data.</returns>
        [HttpGet]
        public List<Skill> GetAllSkills() => SkillData.Skills;
    }
}
