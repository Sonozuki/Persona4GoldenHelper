using Microsoft.AspNetCore.Mvc;
using Persona4GoldenHelper.Data;
using Persona4GoldenHelper.Data.Models;
using Persona4GoldenHelper.Models;
using System.Collections.Generic;
using System.Linq;

namespace Persona4GoldenHelper.Controllers
{
    /// <summary>Provides web UI for shadow views.</summary>
    [Route("Shadows/")]
    public class ShadowController : Controller
    {
        /*********
        ** Fields
        *********/
        /// <summary>Provides basic data apis.</summary>
        private readonly IApp AppService;

        /// <summary>Provides shadow apis.</summary>
        private readonly IShadow ShadowService;


        /*********
        ** Public Methods
        *********/
        /****
        ** Constructor
        *****/
        /// <summary>Construct an instance.</summary>
        /// <param name="appService">Provides basic data apis.</param>
        /// <param name="shadowService">Provides shadow apis.</param>
        public ShadowController(IApp appService, IShadow shadowService)
        {
            AppService = appService;
            ShadowService = shadowService;
        }

        /****
        ** Web UI
        *****/
        /// <summary>Render the shadow listing UI.</summary>
        public IActionResult Index()
        {
            ViewBag.Title = "Shadows";
            ViewBag.HaveSearchBar = true;

            var model = new ShadowListingViewModel()
            {
                Shadows = ShadowService.GetAll()
            };

            return View(model);
        }

        /// <summary>Render the shadow UI.</summary>
        /// <param name="shadowName">The name of the shadow to render.</param>
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
