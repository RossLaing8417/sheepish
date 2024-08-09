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
            return View(new ScenarioViewModel().SetDefaults());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var scenario = service.GetScenario(id);
            return View(new ScenarioViewModel(scenario));
        }

        [HttpGet]
        public IActionResult View(int id)
        {
            var scenario = service.GetScenario(id);
            return View(new ScenarioViewModel(scenario));
        }

        [HttpPost]
        public IActionResult Add(ScenarioViewModel viewmodel)
        {
            service.AddScenario(viewmodel.ToEntity());
            return RedirectToAction("List", "Scenario");
        }

        [HttpPost]
        public IActionResult Edit(ScenarioViewModel viewmodel)
        {
            var scenario = service.GetScenario(viewmodel.Id);
            viewmodel.SetEntityProperties(scenario);
            service.UpdateScenario(scenario);
            return RedirectToAction("List", "Scenario");
        }

        [HttpPost]
        public IActionResult Delete(ScenarioViewModel viewmodel)
        {
            service.DeleteScenario(viewmodel.Id);
            return RedirectToAction("List", "Scenario");
        }

        [HttpPost]
        public IActionResult Complete(int id)
        {
            service.CompleteScenario(id);
            return RedirectToAction("View", "Scenario", new { id = id });
        }

        [HttpGet]
        public JsonResult DailyRecords(int id)
        {
            var records = service.GetDailyRecords(id);
            return Json(records.ConvertAll<DailyRecordViewModel>(
                item => new DailyRecordViewModel(item)
            ));
        }
    }
}
