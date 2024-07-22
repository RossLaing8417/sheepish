using Microsoft.AspNetCore.Mvc;
using Sheepish.DataAccess.Services;

namespace Sheepish.Web.Controllers
{
    public class ScenarioController : Controller
    {
        private readonly ISheepishDataService service;

        public ScenarioController(ISheepishDataService service)
        {
            this.service = service;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var data = service.GetScenarios();

            return View();
        }
    }
}
