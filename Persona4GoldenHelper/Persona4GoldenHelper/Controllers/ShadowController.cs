using Microsoft.AspNetCore.Mvc;
using Persona4GoldenHelper.Data;
using Persona4GoldenHelper.Data.Models;
using Persona4GoldenHelper.Models;
using System.Collections.Generic;
using System.Linq;

namespace Persona4GoldenHelper.Controllers
{
    [Route("Shadows/")]
    public class ShadowController : Controller
    {
        private readonly IApp AppService;
        private readonly IShadow ShadowService;

        public ShadowController(IApp appService, IShadow shadowService)
        {
            AppService = appService;
            ShadowService = shadowService;
        }

        public IActionResult Index()
        {
            ViewBag.Title = "Shadows";

            var model = new ShadowListingViewModel()
            {
                Shadows = ShadowService.GetAll()
            };

            return View(model);
        }

        [Route("{shadowName}")]
        public IActionResult Shadow(string shadowName)
        {
            ViewBag.Title = shadowName;
            ViewBag.ShadowName = shadowName;

            List<Shadow> shadows = ShadowService.GetByName(shadowName);
            if (shadows != null || !shadows.Any())
            {
                var model = new ShadowViewModel()
                {
                    Shadows = shadows
                };

                foreach (var shadow in model.Shadows)
                {
                    shadow.FullSkills = AppService.GetSkillsByShadowName(shadow.Name, shadow.Type.ToString());
                }

                return View("Shadow" , model);
            }

            return View("ErrorNoShadow");
        }
    }
}
