using Microsoft.AspNetCore.Mvc;
using Sheepish.DataAccess.Services;
using Sheepish.Web.Models;

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
        public IActionResult List()
        {
            var data = service.GetScenarios();

            return View(data.ConvertAll<ScenarioViewModel>(
                item => new ScenarioViewModel(item)
            ));
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpGet]
        public IActionResult View(Guid id)
        {
            var scenario = service.GetScenario(id);

            return View(new ScenarioViewModel(scenario));
        }
    }
}
