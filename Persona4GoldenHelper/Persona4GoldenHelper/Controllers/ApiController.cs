using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Persona4GoldenHelper.Data;
using System;

namespace Persona4GoldenHelper.Controllers
{
    public class ApiController : Controller
    {
        private readonly IPersona PersonaService;
        private readonly IFusion FusionService;
        private readonly ILogger<ApiController> Logger;

        public ApiController(IPersona personaService, IFusion fusionService, ILogger<ApiController> logger)
        {
            PersonaService = personaService;
            FusionService = fusionService;
            Logger = logger;
        }

        public IActionResult GetAllPersonas()
        {
            try
            {
                Logger.LogInformation("GetAllPersonas was called");

                var personas = PersonaService.GetAll();
                return Ok(personas);
            }
            catch (Exception ex)
            {
                Logger.LogError($"GetAllPersonas failed: {ex}");
                return BadRequest("GetAllPersonas failed");
            }
        }

        public IActionResult GetAllArcanas()
        {
            try
            {
                Logger.LogInformation("GetAllArcanas was called");

                var arcanas = FusionService.GetAllArcanas();
                return Ok(arcanas);
            }
            catch (Exception ex)
            {
                Logger.LogError($"GetAllArcanas failed: {ex}");
                return BadRequest("GetAllPersonas failed");
            }
        }

        public IActionResult GetAllArcana2FusionResults()
        {
            try
            {
                Logger.LogInformation("GetAllArcana2FusionResults was called");

                var arcana2FusionResults = FusionService.GetAllArcana2FusionResults();
                return Ok(arcana2FusionResults);
            }
            catch (Exception ex)
            {
                Logger.LogError($"GetAllArcana2FusionResults failed: {ex}");
                return BadRequest("GetAllArcana2FusionResults failed");
            }
        }

        public IActionResult GetAllArcana3FusionResults()
        {
            try
            {
                Logger.LogInformation("GetAllArcana3FusionResults was called");

                var arcana3FusionResults = FusionService.GetAllArcana3FusionResults();
                return Ok(arcana3FusionResults);
            }
            catch (Exception ex)
            {
                Logger.LogError($"GetAllArcana3FusionResults failed: {ex}");
                return BadRequest("GetAllArcana3FusionResults failed");
            }
        }

        public IActionResult GetAllSpecialFusionResults()
        {
            try
            {
                Logger.LogInformation("GetAllSpecialFusionResults was called");

                var specialFusionResults = FusionService.GetAllSpecialFusionResults();
                return Ok(specialFusionResults);
            }
            catch (Exception ex)
            {
                Logger.LogError($"GetAllSpecialFusionResults failed: {ex}");
                return BadRequest("GetAllSpecialFusionResults failed");
            }
        }
    }
}
