using Microsoft.AspNetCore.Mvc;
using Persona4GoldenHelper.Data;
using Persona4GoldenHelper.Data.Models;
using Persona4GoldenHelper.Models;

namespace Persona4GoldenHelper.Controllers
{
    [Route("Personas/")]
    public class PersonaController : Controller
    {
        private readonly IPersona PersonaService;
        private readonly IApp AppService;

        public PersonaController(IPersona personaService, IApp appService)
        {
            PersonaService = personaService;
            AppService = appService;
        }

        public IActionResult Index()
        {
            ViewBag.Title = "Personas";

            var model = new PersonaListingViewModel
            {
                Personas = PersonaService.GetAll()
            };

            return View(model);
        }

        [Route("{personaName}")]
        public IActionResult Persona(string personaName)
        {
            ViewBag.Title = personaName;

            Persona persona = PersonaService.GetByName(personaName);
            if (persona != null)
            {
                var model = new PersonaViewModel
                {
                    Persona = persona,
                    Skills = AppService.GetSkillsByPersona(persona)
                };

                return View("Persona", model);
            }

            return View("ErrorNoPersona");
        }
    }
}
