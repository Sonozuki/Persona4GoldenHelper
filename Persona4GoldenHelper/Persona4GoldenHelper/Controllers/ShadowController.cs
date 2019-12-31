using Microsoft.AspNetCore.Mvc;
using Persona4GoldenHelper.Data;
using Persona4GoldenHelper.Models;

namespace Persona4GoldenHelper.Controllers
{
    [Route("Shadows/")]
    public class ShadowController : Controller
    {
        private readonly IShadow ShadowService;

        public ShadowController(IShadow shadowService)
        {
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
    }
}
