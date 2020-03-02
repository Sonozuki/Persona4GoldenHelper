using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Persona4GoldenHelper.Data;
using System;

namespace Persona4GoldenHelper.Controllers
{
    [Route("Api/[action]")]
    public class ApiController : Controller
    {
        private readonly IApp AppService;
        private readonly IPersona PersonaService;
        private readonly IShadow ShadowService;
        private readonly IFusion FusionService;
        private readonly ILogger<ApiController> Logger;

        public ApiController(IApp appService, IPersona personaService, IShadow shadowService, IFusion fusionService, ILogger<ApiController> logger)
        {
            AppService = appService;
            PersonaService = personaService;
            ShadowService = shadowService;
            FusionService = fusionService;
            Logger = logger;
        }

        public IActionResult GetAllBooks()
        {
            try
            {
                Logger.LogInformation("GetAllBooks was called");

                var books = AppService.GetAllBooks();
                if (books != null)
                {
                    return Ok(books);
                }
                else
                {
                    return StatusCode(500);
                }
            }
            catch (Exception ex)
            {
                Logger.LogError($"GetAllBooks failed: {ex}");
                return StatusCode(500);
            }
        }

        public IActionResult GetBookOrder()
        {
            try
            {
                Logger.LogInformation("GetBookOrder was called");

                var bookOrder = AppService.GetBookOrder();
                if (bookOrder != null)
                {
                    return Ok(bookOrder);
                }
                else
                {
                    return StatusCode(500);
                }
            }
            catch (Exception ex)
            {
                Logger.LogError($"GetBookOrder failed: {ex}");
                return StatusCode(500);
            }
        }

        public IActionResult GetAllExamAnswers()
        {
            try
            {
                Logger.LogInformation("GetAllExamAnswers was called");

                var examAnswers = AppService.GetAllExamAnswers();
                if (examAnswers != null)
                {
                    return Ok(examAnswers);
                }
                else
                {
                    return StatusCode(500);
                }
            }
            catch (Exception ex)
            {
                Logger.LogError($"GetAllExamAnswers failed: {ex}");
                return StatusCode(500);
            }
        }

        public IActionResult GetAllPlants()
        {
            try
            {
                Logger.LogInformation("GetAllPlants was called");

                var plants = AppService.GetAllPlants();
                if (plants != null)
                {
                    return Ok(plants);
                }
                else
                {
                    return StatusCode(500);
                }
            }
            catch (Exception ex)
            {
                Logger.LogError($"GetAllPlants failed: {ex}");
                return StatusCode(500);
            }
        }

        public IActionResult GetSkillsByPersonaName(string name)
        {
            try
            {
                Logger.LogInformation("GetSkillsByPersona was called");

                if (name == null)
                {
                    return StatusCode(406);
                }

                var skills = AppService.GetSkillsByPersonaName(name);
                if (skills != null)
                {
                    return Ok(skills);
                }
                else
                {
                    return NoContent();
                }
            }
            catch (Exception ex)
            {
                Logger.LogError($"GetSkillsByPersona failed: {ex}");
                return StatusCode(500);
            }
        }

        public IActionResult GetSkillsByShadowName(string name, string type)
        {
            try
            {
                Logger.LogInformation("GetSkillsByShadow was called");

                if (name == null || type == null)
                {
                    return StatusCode(406);
                }

                var skills = AppService.GetSkillsByShadowName(name, type);
                if (skills != null)
                {
                    return Ok(skills);
                }
                else
                {
                    return NoContent();
                }
            }
            catch (Exception ex)
            {
                Logger.LogError($"GetSkillsByShadow failed: {ex}");
                return StatusCode(500);
            }
        }

        public IActionResult GetAllQuests()
        {
            try
            {
                Logger.LogInformation("GetAllQuests was called");

                var quests = AppService.GetAllQuests();
                if (quests != null)
                {
                    return Ok(quests);
                }
                else
                {
                    return StatusCode(500);
                }
            }
            catch (Exception ex)
            {
                Logger.LogError($"GetAllQuests failed: {ex}");
                return StatusCode(500);
            }
        }

        public IActionResult GetAllSkillCards()
        {
            try
            {
                Logger.LogInformation("GetAllSkillCards was called");

                var skillCards = AppService.GetAllSkillCards();
                if (skillCards != null)
                {
                    return Ok(skillCards);
                }
                else
                {
                    return StatusCode(500);
                }
            }
            catch (Exception ex)
            {
                Logger.LogError($"GetAllSkillCards failed: {ex}");
                return StatusCode(500);
            }
        }

        public IActionResult GetAllSkillCardLocations()
        {
            try
            {
                Logger.LogInformation("GetAllSkillCardLocations was called");

                var skillCardLocations = AppService.GetAllSkillCardLocations();
                if (skillCardLocations != null)
                {
                    return Ok(skillCardLocations);
                }
                else
                {
                    return StatusCode(500);
                }
            }
            catch (Exception ex)
            {
                Logger.LogError($"GetAllSkillCardLocations failed: {ex}");
                return StatusCode(500);
            }
        }

        public IActionResult GetAllLunches()
        {
            try
            {
                Logger.LogInformation("GetAllLunches was called");

                var lunches = AppService.GetAllLunches();
                if (lunches != null)
                {
                    return Ok(lunches);
                }
                else
                {
                    return StatusCode(500);
                }
            }
            catch (Exception ex)
            {
                Logger.LogError($"GetAllLunches failed: {ex}");
                return StatusCode(500);
            }
        }

        public IActionResult GetAllAccessories()
        {
            try
            {
                Logger.LogInformation("GetAllAccessories was called");

                var accessories = AppService.GetAllAccessories();
                if (accessories != null)
                {
                    return Ok(accessories);
                }
                else
                {
                    return StatusCode(500);
                }
            }
            catch (Exception ex)
            {
                Logger.LogError($"GetAllAccessories failed: {ex}");
                return StatusCode(500);
            }
        }

        public IActionResult GetAllArmor()
        {
            try
            {
                Logger.LogInformation("GetAllArmor was called");

                var armor = AppService.GetAllArmor();
                if (armor != null)
                {
                    return Ok(armor);
                }
                else
                {
                    return StatusCode(500);
                }
            }
            catch (Exception ex)
            {
                Logger.LogError($"GetAllArmor failed: {ex}");
                return StatusCode(500);
            }
        }

        public IActionResult GetAllWeapons()
        {
            try
            {
                Logger.LogInformation("GetAllWeapons was called");

                var weapons = AppService.GetAllWeapons();
                if (weapons != null)
                {
                    return Ok(weapons);
                }
                else
                {
                    return StatusCode(500);
                }
            }
            catch (Exception ex)
            {
                Logger.LogError($"GetAllWeapons failed: {ex}");
                return StatusCode(500);
            }
        }

        public IActionResult GetAllPersonas()
        {
            try
            {
                Logger.LogInformation("GetAllPersonas was called");

                var personas = PersonaService.GetAll();
                if (personas != null)
                {
                    return Ok(personas);
                }
                else
                {
                    return StatusCode(500);
                }
            }
            catch (Exception ex)
            {
                Logger.LogError($"GetAllPersonas failed: {ex}");
                return StatusCode(500);
            }
        }

        public IActionResult GetPersonaByName(string name)
        {
            try
            {
                Logger.LogInformation("GetPersonaByName was called");

                if (name == null)
                {
                    return StatusCode(406);
                }

                var persona = PersonaService.GetByName(name);
                if (persona != null)
                {
                    return Ok(persona);
                }
                else
                {
                    return NoContent();
                }
            }
            catch (Exception ex)
            {
                Logger.LogError($"GetPersonaByName failed: {ex}");
                return StatusCode(500);
            }
        }

        public IActionResult GetAllShadows()
        {
            try
            {
                Logger.LogInformation("GetAllShadows was called");

                var shadows = ShadowService.GetAll();
                if (shadows != null)
                {
                    return Ok(shadows);
                }
                else
                {
                    return StatusCode(500);
                }
            }
            catch (Exception ex)
            {
                Logger.LogError($"GetAllShadows failed: {ex}");
                return StatusCode(500);
            }
        }

        public IActionResult GetShadowsByName(string name)
        {
            try
            {
                Logger.LogInformation("GetShadowByName was called");

                if (name == null)
                {
                    return StatusCode(406);
                }

                var shadows = ShadowService.GetByName(name);
                if (shadows != null)
                {
                    return Ok(shadows);
                }
                else
                {
                    return NoContent();
                }
            }
            catch (Exception ex)
            {
                Logger.LogError($"GetShadowsByName failed: {ex}");
                return StatusCode(500);
            }
        }

        public IActionResult GetAllArcanas()
        {
            try
            {
                Logger.LogInformation("GetAllArcanas was called");

                var arcanas = FusionService.GetAllArcanas();
                if (arcanas != null)
                {
                    return Ok(arcanas);
                }
                else
                {
                    return StatusCode(500);
                }
            }
            catch (Exception ex)
            {
                Logger.LogError($"GetAllArcanas failed: {ex}");
                return StatusCode(500);
            }
        }

        public IActionResult GetAllArcana2FusionResults()
        {
            try
            {
                Logger.LogInformation("GetAllArcana2FusionResults was called");

                var arcana2FusionResults = FusionService.GetAllArcana2FusionResults();
                if (arcana2FusionResults != null)
                {
                    return Ok(arcana2FusionResults);
                }
                else
                {
                    return StatusCode(500);
                }
            }
            catch (Exception ex)
            {
                Logger.LogError($"GetAllArcana2FusionResults failed: {ex}");
                return StatusCode(500);
            }
        }

        public IActionResult GetAllArcana3FusionResults()
        {
            try
            {
                Logger.LogInformation("GetAllArcana3FusionResults was called");

                var arcana3FusionResults = FusionService.GetAllArcana3FusionResults();
                if (arcana3FusionResults != null)
                {
                    return Ok(arcana3FusionResults);
                }
                else
                {
                    return StatusCode(500);
                }
            }
            catch (Exception ex)
            {
                Logger.LogError($"GetAllArcana3FusionResults failed: {ex}");
                return StatusCode(500);
            }
        }

        public IActionResult GetAllSpecialFusionResults()
        {
            try
            {
                Logger.LogInformation("GetAllSpecialFusionResults was called");

                var specialFusionResults = FusionService.GetAllSpecialFusionResults();
                if (specialFusionResults != null)
                {
                    return Ok(specialFusionResults);
                }
                else
                {
                    return StatusCode(500);
                }
            }
            catch (Exception ex)
            {
                Logger.LogError($"GetAllSpecialFusionResults failed: {ex}");
                return StatusCode(500);
            }
        }
    }
}
