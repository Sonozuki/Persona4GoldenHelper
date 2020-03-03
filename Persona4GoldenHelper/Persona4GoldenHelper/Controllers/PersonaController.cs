using Microsoft.AspNetCore.Mvc;
using Persona4GoldenHelper.Data;
using Persona4GoldenHelper.Data.Models;
using Persona4GoldenHelper.Models;

namespace Persona4GoldenHelper.Controllers
{
    /// <summary>Provides a web UI for all persona views.</summary>
    [Route("Personas/")]
    public class PersonaController : Controller
    {
        /*********
        ** Fields
        *********/
        /// <summary>Provides access to persona apis.</summary>
        private readonly IPersona PersonaService;

        /// <summary>Provides access to basic data apis.</summary>
        private readonly IApp AppService;


        /*********
        ** Public Methods
        *********/
        /****
        ** Constructor
        *****/
        public PersonaController(IPersona personaService, IApp appService)
        {
            PersonaService = personaService;
            AppService = appService;
        }

        /****
        ** Web UI
        *****/
        /// <summary>Render the persona listing UI.</summary>
        public IActionResult Index()
        {
            ViewBag.Title = "Personas";
            ViewBag.HaveSearchBar = true;

            var model = new PersonaListingViewModel
            {
                Personas = PersonaService.GetAll()
            };

            return View(model);
        }

        /// <summary>Render the persona UI.</summary>
        /// <param name="personaName">The name of the persona to render.</param>
        [Route("{personaName}")]
        public IActionResult Persona(string personaName)
        {
            ViewBag.Title = personaName;
            ViewBag.PersonaName = personaName;

            Persona persona = PersonaService.GetByName(personaName);
            if (persona != null)
            {
                var model = new PersonaViewModel
                {
                    Persona = persona,
                    Skills = AppService.GetSkillsByPersonaName(personaName)
                };

                return View("Persona", model);
            }

            return View("ErrorNoPersona");
        }
    }
}
